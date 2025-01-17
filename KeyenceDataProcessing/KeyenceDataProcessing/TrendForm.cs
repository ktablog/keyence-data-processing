﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using LJV7_DllSampleAll.Datas;
using LJV7_DllSampleAll;

namespace KeyenceDataProcessing
{
    public partial class TrendForm : Form
    {
        #region Field
        private double[] _entrySignal = null;
        private double[] _searchSignal = null;
        private double[] _slopeSignal = null;
        private int[] _slopeSignalRange = null;
        private double[][] _foundSignal = null;
        private int _searchSignalOffset = 0;
        private bool _searchError = true;
        private bool _entryPainting = false;
        Point? _lastEntryPoint = null;
        private double _yValue;
        private double _zValue;
        private double _yValueStart = 0;
        private double _yValuePitch = 0;
        private DateTime _calculateTime;
        private Queue<KeyenceData> _keyenceData = new Queue<KeyenceData>(1024);
        private SimaticCommunication _simaticCommunication = new SimaticCommunication();
        private KeyenceCommunication _keyenceCommunication = new KeyenceCommunication();
        private KeyenceReaderData _keyenceReaderData;
        private SignalProcessor _signalProcessor = new SignalProcessor();
        #endregion


        #region Delegate
        delegate bool ChooseValue(double v1, double v2);
        #endregion


        #region Property
        public int NofDots
        {
            get { return _signalProcessor.NofDots; }
        }
        public double YValueInMm
        {
            get 
            {
                return _yValueStart + _yValue * _yValuePitch;
            }
        }
        public double ZValueInMm
        {
            get
            {
                return _zValue;
            }
        }

        #endregion


        #region Method

        public TrendForm()
        {
            InitializeComponent();
            convolutionChart.ChartAreas[0].AxisX.Minimum = 0;
            convolutionChart.ChartAreas[0].AxisX.Maximum = NofDots;
            convolutionChart.ChartAreas[0].AxisY.Minimum = -25;
            convolutionChart.ChartAreas[0].AxisY.Maximum = 25;

            BuildEntrySignal();
            BuildSearchSignal();
            PlotEntrySeries();
        }


        private void BuildEntrySignal()
        {
            double[] data = new double[NofDots];
            for (int i = 0; i < NofDots; i++)
            {
                data[i] = 0.0;
            }
            _entrySignal = data; 
        }


        private void BuildSearchSignal()
        {
            _searchSignal = _signalProcessor.SearchSignalsList[0];
        }


        private void calcButton_Click(object sender, EventArgs e)
        {
            _calculateTime = DateTime.Now;
            Calc();
            PlotSearchSeries();
            PlotSlopeSeries();
            PlotFoundSeries();
            UpdateView();
            if (!_searchError)
            {
                KeyenceData data = new KeyenceData();
                data.Time = _calculateTime;
                data.Y = _yValue;
                data.Z = _zValue;
                _keyenceData.Enqueue(data);
            }
        }


        private void Plot(String seriesName, double[] yData, int xOffset)
        {
            Series series = convolutionChart.Series.FindByName(seriesName);
            if (series == null)
                return;
            series.Points.Clear();
            if (yData == null)
                return;
            int n = yData.Length;
            double x;
            double y;
            for (int i = 0; i < n; i++)
            {
                x = i + xOffset;
                y = yData[i];
                series.Points.AddXY(x, y);
            }
        }


        private void PlotEntrySeries()
        {
            Plot("EntrySeries", _entrySignal, 0);
        }


        private void PlotSearchSeries()
        {
            //Plot("SearchSeries", _searchError ? null : _searchSignal, _searchSignalOffset);
        }

        private void PlotSlopeSeries()
        {
            /*double[] scaledSignal = null;
            if (_slopeSignal != null)
            {
                int n = _slopeSignal.Length;
                scaledSignal = new double[n];
                for (int i = 0; i < n; i++)
                {
                    scaledSignal[i] = _slopeSignal[i] * 10.0;
                }
            }
            Plot("SlopeSeries", scaledSignal, scaledSignal == null ? 0 : _slopeSignalRange[0]);
             */
        }

        private void PlotFoundSeries()
        {
            Series series = convolutionChart.Series.FindByName("FoundSeries");
            if (series == null)
                return;
            series.Points.Clear();
            double[][] signal = _foundSignal;
            if (signal == null)
                return;
            int n = signal.Length;
            for (int i = 0; i < n; i++)
            {
                series.Points.AddXY(signal[i][0], signal[i][1]);
            }
        }


        private void UpdateView()
        {
            if (_searchError)
            {
                string errorTxt = "?";
                yValueInMmLbl.Text = errorTxt;
                zValueInMmLbl.Text = errorTxt;
            }
            else
            {
                string format = "0.000";
                yValueLbl.Text = _yValue.ToString(format);
                yValueInMmLbl.Text = YValueInMm.ToString(format);
                zValueInMmLbl.Text = ZValueInMm.ToString(format);
            }
        }


        private void convolutionChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (_entryPainting && e.Button == MouseButtons.Left)
            {
                Chart chart = convolutionChart;
                ChartArea area = chart.ChartAreas[0];
                int xLeft = (int)Math.Round(area.AxisX.ValueToPixelPosition(area.AxisX.Minimum));
                int xRight = (int)area.AxisX.ValueToPixelPosition(area.AxisX.Maximum);
                int yTop = (int)area.AxisY.ValueToPixelPosition(area.AxisY.Maximum);
                int yBottom = (int)area.AxisY.ValueToPixelPosition(area.AxisY.Minimum);

                Point currPoint = new Point(e.X, e.Y);

                if (_lastEntryPoint == null)
                {
                    _lastEntryPoint = currPoint;
                }

                int x0, y0;
                int x1, y1;
                if (currPoint.X >= _lastEntryPoint.Value.X)
                {
                    x0 = _lastEntryPoint.Value.X;
                    y0 = _lastEntryPoint.Value.Y;
                    x1 = currPoint.X;
                    y1 = currPoint.Y;
                }
                else
                {
                    x0 = currPoint.X;
                    y0 = currPoint.Y;
                    x1 = _lastEntryPoint.Value.X;
                    y1 = _lastEntryPoint.Value.Y;
                }

                double kX = (double)(xRight - xLeft) / NofDots;
                double kY = (area.AxisY.Maximum - area.AxisY.Minimum)/(yBottom - yTop);
                if (kX < 1.0)
                {
                    int x0Index = (int)((x0 - xLeft) / kX);
                    int x1Index = (int)((x1 - xLeft) / kX);
                    double y;
                    for (int xIndex = x0Index; xIndex <= x1Index; xIndex++)
                    {
                        if (xIndex < 0) continue;
                        if (xIndex >= NofDots) continue;
                        if (x0Index == x1Index)
                        {
                            y = y0;
                        }
                        else
                        {
                            y = (y1 - y0) / (x1Index - x0Index) * (xIndex - x0Index) + y0;
                        }
                        _entrySignal[xIndex] = (yBottom - y)*kY + area.AxisY.Minimum;
                    }
                }
                else
                {
                    // !!! code is absent
                }

                PlotEntrySeries();
                chart.Invalidate();

                _lastEntryPoint = currPoint;
            }
            else
            {
                _lastEntryPoint = null;
            }
        }


        private void entryPaintCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _entryPainting = (sender as CheckBox).Checked;
        }


        private void Calc()
        {
            SignalProcessorDataIn dataIn = new SignalProcessorDataIn();
            dataIn.entrySignal = _entrySignal;
            SignalProcessorDataOut dataOut = _signalProcessor.Calc(dataIn);
            _searchError = dataOut.searchError;
            _searchSignal = dataOut.searchSignal;
            _searchSignalOffset = dataOut.searchSignalOffset;
            _yValue = dataOut.yValue;
            _zValue = dataOut.zValue;
            _slopeSignal = dataOut.slopeSignal;
            _slopeSignalRange = dataOut.validSignalRange;
            _foundSignal = dataOut.foundSignal;
            SimaticCommunicationData simaticCommunicationData = new SimaticCommunicationData();
            simaticCommunicationData.Quality = !_searchError;
            simaticCommunicationData.ResultY = YValueInMm;
            simaticCommunicationData.ResultZ = ZValueInMm;
            if (isSimaticCommuncationEnabled())
            {
                _simaticCommunication.CommunicationData = simaticCommunicationData;
            }
        }


        private void convolutionChart_PostPaint(object sender, ChartPaintEventArgs e)
        {
            if (!_searchError)
            {
                ChartGraphics cg = e.ChartGraphics;
                Graphics gr = cg.Graphics;

                Chart chart = convolutionChart;
                ChartArea area = chart.ChartAreas[0];
                int xLeft = (int)Math.Round(area.AxisX.ValueToPixelPosition(area.AxisX.Minimum));
                int xRight = (int)area.AxisX.ValueToPixelPosition(area.AxisX.Maximum);
                int yTop = (int)area.AxisY.ValueToPixelPosition(area.AxisY.Maximum);
                int yBottom = (int)area.AxisY.ValueToPixelPosition(area.AxisY.Minimum);
                int xCross = (int)area.AxisX.ValueToPixelPosition(_yValue);
                int yCross = (int)area.AxisY.ValueToPixelPosition(_zValue);

                gr.SetClip(new Rectangle(xLeft, yTop, xRight - xLeft, yBottom - yTop));

                const int crossSize = 32;
                const int crossDotSize = 5;

                Pen pen = Pens.Red;

                gr.DrawLine(pen, xCross, yCross - crossSize / 2, xCross, yCross + crossSize / 2);
                gr.DrawLine(pen, xCross - crossSize / 2, yCross, xCross + crossSize / 2, yCross);

                gr.FillEllipse(Brushes.Red, xCross - crossDotSize/2 - 1, yCross - crossDotSize/2 - 1,
                  crossDotSize, crossDotSize);

                gr.ResetClip();
            }
        }


        private void keyenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isKeyenceCommunicationEnabled())
            {
                RestartKeyenceCommunication();
            }
            else
            {
                StopKeyenceCommunication();
            }
        }

        private void keyenceTimer_Tick(object sender, EventArgs e)
        {
            KeyenceReaderData readerData = KeyenceReadProfile();
            double[] data = null;
            if (readerData != null)
            {
                data = readerData.ProfileData;
                _yValueStart = readerData.YStart * 0.00001;
                _yValuePitch = readerData.YPitch * 0.00001;
            }
            
            if (data != null)
            {
                for (int i = 0; i < _entrySignal.Length; i++)
                {
                    _entrySignal[i] = data[i];
                }
                PlotEntrySeries();
                calcButton.PerformClick();
            }
        }


        private void chartUpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime tm2 = DateTime.Now;
            DateTime tm1 = tm2.AddSeconds(-60 * 10);
            timeChart.ChartAreas[0].AxisX.Minimum = tm1.ToOADate();
            timeChart.ChartAreas[0].AxisX.Maximum = tm2.ToOADate();
            timeChart.Series[0].Points.Clear();
            timeChart.Series[1].Points.Clear();
            timeChart.Series[1].Points.AddXY(tm1, 1);
            timeChart.Series[1].Points.AddXY(tm2, 1);
            foreach(KeyenceData data in _keyenceData) 
            {
                timeChart.Series[0].Points.AddXY(data.Time.ToOADate(), data.Y);
            }
            while (_keyenceData.Count > 0)
            {
                KeyenceData data = _keyenceData.Peek();
                if (data.Time.CompareTo(tm1) < 0)
                    _keyenceData.Dequeue();
                else
                    break;
            }
        }

        private void TrendForm_Load(object sender, EventArgs e)
        {
            Common.Load();
            chartUpdateTimer_Tick(null, null);
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
            if (optionsForm.DialogResult == DialogResult.OK)
            {
                if (isSimaticCommuncationEnabled())
                {
                    RestartSimaticCommunication();
                }
                if (isKeyenceCommunicationEnabled())
                {
                    RestartKeyenceCommunication();
                }
            }
        }

        private void TrendForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopSimaticCommunication();
            StopKeyenceCommunication();
            Common.Save();
        }


        private Nullable<SimaticCommunicationOptions> ConvertToSimaticCommunicationOptions()
        {
            try
            {
                SimaticCommunicationOptions options = new SimaticCommunicationOptions();
                options.Init();

                options.Ip = Common.SimaticIp;
                options.Rack = Common.SimaticRack;
                options.Slot = Common.SimaticSlot;
                options.Block = StrToInt(Common.SimaticBlock);
                options.ResultYAddress = StrToInt(Common.SimaticResultYAddress);
                options.ResultZAddress = StrToInt(Common.SimaticResultZAddress);
                options.QualityAddress = StrToInt(Common.SimaticQualityAddress);
                options.CounterAddress = StrToInt(Common.SimaticCounterAddress);

                return options;
            }
            catch
            {
            }

            return null;
        }


        private int StrToInt(string s)
        {
            return Int32.Parse(s);
        }

        private void simaticCommunicationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isSimaticCommuncationEnabled())
            {
                RestartSimaticCommunication();
            }
            else
            {
                StopSimaticCommunication();
            }
        }


        private void RestartSimaticCommunication()
        {
            Nullable<SimaticCommunicationOptions> communicationOptions = ConvertToSimaticCommunicationOptions();
            if (communicationOptions != null)
            {
                _simaticCommunication.CommunicationOptions = communicationOptions.Value;
                _simaticCommunication.Start();
            }
            else
            {
                StopSimaticCommunication();
            }
        }


        private void StopSimaticCommunication()
        {
            _simaticCommunication.Stop();
        }


        private bool isSimaticCommuncationEnabled()
        {
            return simaticCommunicationCheckBox.Checked;
        }


        private Nullable<KeyenceCommunicationOptions> ConvertToKeyenceCommunicationOptions()
        {
            try
            {
                KeyenceCommunicationOptions options = new KeyenceCommunicationOptions();
                options.Init();

                options.DeviceId = Define.DEVICE_ID;
                options.ConnectionType = Common.KeyenceConnectionType;
                switch (options.ConnectionType)
                {
                    case KeyenceConnectionType.Ethernet:
                        options.EthernetOptions.Ip = Common.KeyenceIp;
                        options.EthernetOptions.Port = StrToInt(Common.KeyenceIp);
                        break;
                }

                return options;
            }
            catch
            {
            }

            return null;
        }


        private void RestartKeyenceCommunication()
        {
            Nullable<KeyenceCommunicationOptions> communicationOptions = ConvertToKeyenceCommunicationOptions();
            if (communicationOptions != null)
            {
                _keyenceCommunication.CommunicationOptions = communicationOptions.Value;
                _keyenceCommunication.ReadSuccessed += OnKeyenceReadSuccessed;
                _keyenceCommunication.ReadFailed += OnKeyenceReadFailed;
                _keyenceCommunication.Start();
                keyenceTimer.Start();
            }
            else
            {
                StopKeyenceCommunication();
            }
        }


        private void StopKeyenceCommunication()
        {
            keyenceTimer.Stop();
            _keyenceCommunication.ReadSuccessed -= OnKeyenceReadSuccessed;
            _keyenceCommunication.ReadFailed -= OnKeyenceReadFailed;
            _keyenceCommunication.Stop();
        }


        private bool isKeyenceCommunicationEnabled()
        {
            return keyenceCommunicationCheckBox.Checked;
        }


        private void OnKeyenceReadSuccessed()
        {
            _keyenceReaderData = _keyenceCommunication.ReaderData;
            Console.Out.WriteLine(_keyenceReaderData == null ? "NULL" : "NOT NULL");
            Console.Out.WriteLine("KEYENCE SUCCESS");
        }

        private void OnKeyenceReadFailed()
        {
            _keyenceReaderData = null;
            Console.Out.WriteLine("KEYENCE FAIL");
        }


        private KeyenceReaderData KeyenceReadProfile()
        {
            KeyenceReaderData readerData = _keyenceReaderData;
            return readerData;
        }

        #endregion


        #region KeyenceData
        class KeyenceData
        {
            private DateTime _time;
            private double _y;
            private double _z;

            public DateTime Time
            {
                get { return _time; }
                set { _time = value; }
            }
            public double Y
            {
                get { return _y; }
                set { _y = value; }
            }
            public double Z
            {
                get { return _z; }
                set { _z = value; }
            }
        }
         #endregion
    }
}
