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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.convolutionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.calcButton = new System.Windows.Forms.Button();
            this.entryPaintCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yValueLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zValueInMmLbl = new System.Windows.Forms.Label();
            this.yValueInMmLbl = new System.Windows.Forms.Label();
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
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowOffset = 2;
            this.convolutionChart.ChartAreas.Add(chartArea3);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            legend2.Name = "Legend1";
            this.convolutionChart.Legends.Add(legend2);
            this.convolutionChart.Location = new System.Drawing.Point(2, 2);
            this.convolutionChart.Name = "convolutionChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "Legend1";
            series5.LegendText = "Входной сигнал";
            series5.Name = "EntrySeries";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.DarkOrange;
            series6.Legend = "Legend1";
            series6.LegendText = "Образец";
            series6.Name = "SearchSeries";
            this.convolutionChart.Series.Add(series5);
            this.convolutionChart.Series.Add(series6);
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
            this.calcButton.Size = new System.Drawing.Size(133, 33);
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
            this.entryPaintCheckBox.Size = new System.Drawing.Size(133, 32);
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
            // keyenceCheckBox
            // 
            this.keyenceCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.keyenceCheckBox.Location = new System.Drawing.Point(483, 203);
            this.keyenceCheckBox.Name = "keyenceCheckBox";
            this.keyenceCheckBox.Size = new System.Drawing.Size(133, 32);
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
            chartArea4.AxisX.LabelStyle.Format = "HH:mm";
            chartArea4.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.Maximum = 800;
            chartArea4.AxisY.Minimum = 0;
            chartArea4.Name = "ChartArea1";
            chartArea4.ShadowOffset = 2;
            this.timeChart.ChartAreas.Add(chartArea4);
            this.timeChart.Location = new System.Drawing.Point(1, 321);
            this.timeChart.Name = "timeChart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series7.Color = System.Drawing.Color.Blue;
            series7.LegendText = "Входной сигнал";
            series7.Name = "ResultSeries";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Transparent;
            series8.Name = "DummySeries";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.timeChart.Series.Add(series7);
            this.timeChart.Series.Add(series8);
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
            this.optionsButton.Size = new System.Drawing.Size(133, 33);
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
        private System.Windows.Forms.Label yValueInMmLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zValueInMmLbl;
        private System.Windows.Forms.CheckBox keyenceCheckBox;
        private System.Windows.Forms.Timer keyenceTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeChart;
        private System.Windows.Forms.Timer chartUpdateTimer;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.CheckBox simaticCommunicationCheckBox;
        private System.Windows.Forms.Label yValueLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}