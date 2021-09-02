﻿namespace KeyenceDataProcessing
{
    partial class TrendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.convolutionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yValueLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zValueInMmLbl = new System.Windows.Forms.Label();
            this.yValueInMmLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyenceTimer = new System.Windows.Forms.Timer(this.components);
            this.timeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.calcButton = new System.Windows.Forms.Button();
            this.keyenceCommunicationCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsButton = new System.Windows.Forms.Button();
            this.simaticCommunicationCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.entryPaintCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.convolutionChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // convolutionChart
            // 
            this.convolutionChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.convolutionChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.convolutionChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea9.Name = "ChartArea1";
            chartArea9.ShadowOffset = 2;
            this.convolutionChart.ChartAreas.Add(chartArea9);
            legend5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            legend5.Name = "Legend1";
            this.convolutionChart.Legends.Add(legend5);
            this.convolutionChart.Location = new System.Drawing.Point(2, 2);
            this.convolutionChart.Name = "convolutionChart";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Color = System.Drawing.Color.Blue;
            series17.Legend = "Legend1";
            series17.LegendText = "Входной сигнал";
            series17.Name = "EntrySeries";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.DarkOrange;
            series18.Legend = "Legend1";
            series18.LegendText = "Образец";
            series18.Name = "SearchSeries";
            this.convolutionChart.Series.Add(series17);
            this.convolutionChart.Series.Add(series18);
            this.convolutionChart.Size = new System.Drawing.Size(633, 314);
            this.convolutionChart.TabIndex = 1;
            this.convolutionChart.Text = "ConvolutionChart";
            this.convolutionChart.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.convolutionChart_PostPaint);
            this.convolutionChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.convolutionChart_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.yValueLbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.zValueInMmLbl);
            this.panel1.Controls.Add(this.yValueInMmLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(483, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 65);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(106, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(106, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "mm";
            // 
            // yValueLbl
            // 
            this.yValueLbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yValueLbl.Location = new System.Drawing.Point(27, 5);
            this.yValueLbl.Name = "yValueLbl";
            this.yValueLbl.Size = new System.Drawing.Size(79, 17);
            this.yValueLbl.TabIndex = 5;
            this.yValueLbl.Text = "?";
            this.yValueLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y=";
            // 
            // zValueInMmLbl
            // 
            this.zValueInMmLbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zValueInMmLbl.Location = new System.Drawing.Point(30, 41);
            this.zValueInMmLbl.Name = "zValueInMmLbl";
            this.zValueInMmLbl.Size = new System.Drawing.Size(76, 17);
            this.zValueInMmLbl.TabIndex = 3;
            this.zValueInMmLbl.Text = "?";
            this.zValueInMmLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // yValueInMmLbl
            // 
            this.yValueInMmLbl.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yValueInMmLbl.Location = new System.Drawing.Point(30, 23);
            this.yValueInMmLbl.Name = "yValueInMmLbl";
            this.yValueInMmLbl.Size = new System.Drawing.Size(76, 17);
            this.yValueInMmLbl.TabIndex = 2;
            this.yValueInMmLbl.Text = "?";
            this.yValueInMmLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Y=";
            // 
            // keyenceTimer
            // 
            this.keyenceTimer.Interval = 1000;
            this.keyenceTimer.Tick += new System.EventHandler(this.keyenceTimer_Tick);
            // 
            // timeChart
            // 
            this.timeChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.timeChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.timeChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea10.AxisX.LabelStyle.Format = "HH:mm";
            chartArea10.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea10.AxisY.Maximum = 800;
            chartArea10.AxisY.Minimum = 0;
            chartArea10.Name = "ChartArea1";
            chartArea10.ShadowOffset = 2;
            this.timeChart.ChartAreas.Add(chartArea10);
            this.timeChart.Location = new System.Drawing.Point(1, 321);
            this.timeChart.Name = "timeChart";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series19.Color = System.Drawing.Color.Blue;
            series19.LegendText = "Входной сигнал";
            series19.Name = "ResultSeries";
            series19.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series19.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series20.ChartArea = "ChartArea1";
            series20.Color = System.Drawing.Color.Transparent;
            series20.Name = "DummySeries";
            series20.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series20.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.timeChart.Series.Add(series19);
            this.timeChart.Series.Add(series20);
            this.timeChart.Size = new System.Drawing.Size(633, 314);
            this.timeChart.TabIndex = 6;
            this.timeChart.Text = "TimeChart";
            // 
            // chartUpdateTimer
            // 
            this.chartUpdateTimer.Enabled = true;
            this.chartUpdateTimer.Interval = 1000;
            this.chartUpdateTimer.Tick += new System.EventHandler(this.chartUpdateTimer_Tick);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(7, 3);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(120, 33);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Вычислить";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // keyenceCheckBox
            // 
            this.keyenceCommunicationCheckBox.Location = new System.Drawing.Point(7, 104);
            this.keyenceCommunicationCheckBox.Name = "keyenceCheckBox";
            this.keyenceCommunicationCheckBox.Size = new System.Drawing.Size(120, 17);
            this.keyenceCommunicationCheckBox.TabIndex = 5;
            this.keyenceCommunicationCheckBox.Text = "Keyence";
            this.keyenceCommunicationCheckBox.UseVisualStyleBackColor = true;
            this.keyenceCommunicationCheckBox.CheckedChanged += new System.EventHandler(this.keyenceCheckBox_CheckedChanged);
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(7, 42);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(120, 33);
            this.optionsButton.TabIndex = 7;
            this.optionsButton.Text = "Настройки";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // simaticCommunicationCheckBox
            // 
            this.simaticCommunicationCheckBox.AutoSize = true;
            this.simaticCommunicationCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.simaticCommunicationCheckBox.Location = new System.Drawing.Point(7, 127);
            this.simaticCommunicationCheckBox.Name = "simaticCommunicationCheckBox";
            this.simaticCommunicationCheckBox.Size = new System.Drawing.Size(60, 17);
            this.simaticCommunicationCheckBox.TabIndex = 8;
            this.simaticCommunicationCheckBox.Text = "Simatic";
            this.simaticCommunicationCheckBox.UseVisualStyleBackColor = false;
            this.simaticCommunicationCheckBox.CheckedChanged += new System.EventHandler(this.simaticCommunicationCheckBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simaticCommunicationCheckBox);
            this.panel2.Controls.Add(this.calcButton);
            this.panel2.Controls.Add(this.optionsButton);
            this.panel2.Controls.Add(this.entryPaintCheckBox);
            this.panel2.Controls.Add(this.keyenceCommunicationCheckBox);
            this.panel2.Location = new System.Drawing.Point(483, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 151);
            this.panel2.TabIndex = 9;
            // 
            // entryPaintCheckBox
            // 
            this.entryPaintCheckBox.Location = new System.Drawing.Point(7, 81);
            this.entryPaintCheckBox.Name = "entryPaintCheckBox";
            this.entryPaintCheckBox.Size = new System.Drawing.Size(120, 17);
            this.entryPaintCheckBox.TabIndex = 3;
            this.entryPaintCheckBox.Text = "Рисовать";
            this.entryPaintCheckBox.UseVisualStyleBackColor = true;
            this.entryPaintCheckBox.CheckedChanged += new System.EventHandler(this.entryPaintCheckBox_CheckedChanged);
            // 
            // TrendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 636);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.timeChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.convolutionChart);
            this.Name = "TrendForm";
            this.Text = "Поиск корреляции";
            this.Load += new System.EventHandler(this.TrendForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrendForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.convolutionChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart convolutionChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label yValueInMmLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zValueInMmLbl;
        private System.Windows.Forms.Timer keyenceTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeChart;
        private System.Windows.Forms.Timer chartUpdateTimer;
        private System.Windows.Forms.Label yValueLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.CheckBox keyenceCommunicationCheckBox;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.CheckBox simaticCommunicationCheckBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox entryPaintCheckBox;
    }
}