namespace KeyenceDataProcessing
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.convolutionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calcButton = new System.Windows.Forms.Button();
            this.entryPaintCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zValueLbl = new System.Windows.Forms.Label();
            this.yValueLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyenceCheckBox = new System.Windows.Forms.CheckBox();
            this.keyenceTimer = new System.Windows.Forms.Timer(this.components);
            this.timeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.optionsButton = new System.Windows.Forms.Button();
            this.simaticCommunicationCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.convolutionChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // convolutionChart
            // 
            this.convolutionChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.convolutionChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.convolutionChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.Name = "ChartArea1";
            chartArea5.ShadowOffset = 2;
            this.convolutionChart.ChartAreas.Add(chartArea5);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            legend3.Name = "Legend1";
            this.convolutionChart.Legends.Add(legend3);
            this.convolutionChart.Location = new System.Drawing.Point(2, 2);
            this.convolutionChart.Name = "convolutionChart";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.LegendText = "Входной сигнал";
            series9.Name = "EntrySeries";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.DarkOrange;
            series10.Legend = "Legend1";
            series10.LegendText = "Образец";
            series10.Name = "SearchSeries";
            this.convolutionChart.Series.Add(series9);
            this.convolutionChart.Series.Add(series10);
            this.convolutionChart.Size = new System.Drawing.Size(633, 314);
            this.convolutionChart.TabIndex = 1;
            this.convolutionChart.Text = "ConvolutionChart";
            this.convolutionChart.PostPaint += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ChartPaintEventArgs>(this.convolutionChart_PostPaint);
            this.convolutionChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.convolutionChart_MouseMove);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(483, 164);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(129, 33);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Вычислить";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // entryPaintCheckBox
            // 
            this.entryPaintCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.entryPaintCheckBox.Location = new System.Drawing.Point(483, 126);
            this.entryPaintCheckBox.Name = "entryPaintCheckBox";
            this.entryPaintCheckBox.Size = new System.Drawing.Size(129, 32);
            this.entryPaintCheckBox.TabIndex = 3;
            this.entryPaintCheckBox.Text = "Рисовать";
            this.entryPaintCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.entryPaintCheckBox.UseVisualStyleBackColor = true;
            this.entryPaintCheckBox.CheckedChanged += new System.EventHandler(this.entryPaintCheckBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.zValueLbl);
            this.panel1.Controls.Add(this.yValueLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(483, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 58);
            this.panel1.TabIndex = 4;
            // 
            // zValueLbl
            // 
            this.zValueLbl.AutoSize = true;
            this.zValueLbl.Location = new System.Drawing.Point(47, 33);
            this.zValueLbl.Name = "zValueLbl";
            this.zValueLbl.Size = new System.Drawing.Size(18, 18);
            this.zValueLbl.TabIndex = 3;
            this.zValueLbl.Text = "?";
            // 
            // yValueLbl
            // 
            this.yValueLbl.AutoSize = true;
            this.yValueLbl.Location = new System.Drawing.Point(47, 9);
            this.yValueLbl.Name = "yValueLbl";
            this.yValueLbl.Size = new System.Drawing.Size(18, 18);
            this.yValueLbl.TabIndex = 2;
            this.yValueLbl.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Y =";
            // 
            // keyenceCheckBox
            // 
            this.keyenceCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.keyenceCheckBox.Location = new System.Drawing.Point(483, 203);
            this.keyenceCheckBox.Name = "keyenceCheckBox";
            this.keyenceCheckBox.Size = new System.Drawing.Size(129, 32);
            this.keyenceCheckBox.TabIndex = 5;
            this.keyenceCheckBox.Text = "Keyence";
            this.keyenceCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.keyenceCheckBox.UseVisualStyleBackColor = true;
            this.keyenceCheckBox.CheckedChanged += new System.EventHandler(this.keyenceCheckBox_CheckedChanged);
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
            chartArea6.AxisX.LabelStyle.Format = "HH:mm";
            chartArea6.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea6.AxisY.Maximum = 800;
            chartArea6.AxisY.Minimum = 0;
            chartArea6.Name = "ChartArea1";
            chartArea6.ShadowOffset = 2;
            this.timeChart.ChartAreas.Add(chartArea6);
            this.timeChart.Location = new System.Drawing.Point(1, 321);
            this.timeChart.Name = "timeChart";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series11.Color = System.Drawing.Color.Blue;
            series11.LegendText = "Входной сигнал";
            series11.Name = "ResultSeries";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series11.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.Transparent;
            series12.Name = "DummySeries";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series12.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.timeChart.Series.Add(series11);
            this.timeChart.Series.Add(series12);
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
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(483, 241);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(129, 33);
            this.optionsButton.TabIndex = 7;
            this.optionsButton.Text = "Настройки";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // simaticCommunicationCheckBox
            // 
            this.simaticCommunicationCheckBox.AutoSize = true;
            this.simaticCommunicationCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.simaticCommunicationCheckBox.Location = new System.Drawing.Point(483, 280);
            this.simaticCommunicationCheckBox.Name = "simaticCommunicationCheckBox";
            this.simaticCommunicationCheckBox.Size = new System.Drawing.Size(60, 17);
            this.simaticCommunicationCheckBox.TabIndex = 8;
            this.simaticCommunicationCheckBox.Text = "Simatic";
            this.simaticCommunicationCheckBox.UseVisualStyleBackColor = false;
            this.simaticCommunicationCheckBox.CheckedChanged += new System.EventHandler(this.simaticCommunicationCheckBox_CheckedChanged);
            // 
            // TrendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 636);
            this.Controls.Add(this.simaticCommunicationCheckBox);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.timeChart);
            this.Controls.Add(this.keyenceCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.entryPaintCheckBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.convolutionChart);
            this.Name = "TrendForm";
            this.Text = "Поиск корреляции";
            this.Load += new System.EventHandler(this.TrendForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TrendForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.convolutionChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart convolutionChart;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.CheckBox entryPaintCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label yValueLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zValueLbl;
        private System.Windows.Forms.CheckBox keyenceCheckBox;
        private System.Windows.Forms.Timer keyenceTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeChart;
        private System.Windows.Forms.Timer chartUpdateTimer;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.CheckBox simaticCommunicationCheckBox;
    }
}