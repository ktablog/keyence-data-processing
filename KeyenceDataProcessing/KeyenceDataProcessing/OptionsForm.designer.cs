namespace KeyenceDataProcessing
{
    partial class OptionsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyencePortTextBox = new System.Windows.Forms.TextBox();
            this.keyenceIpTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keyenceEthernetConnectionRadioButton = new System.Windows.Forms.RadioButton();
            this.keyenceUsbConnectionRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.simaticResultZAddressTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.simaticCounterAddressTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.simaticQualityAddressTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.simaticResultYAddressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.simaticBlockTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.simaticIpTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(104, 320);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ввод";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(194, 320);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 300);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Keyence";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.keyencePortTextBox);
            this.groupBox1.Controls.Add(this.keyenceIpTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.keyenceEthernetConnectionRadioButton);
            this.groupBox1.Controls.Add(this.keyenceUsbConnectionRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Связь";
            // 
            // keyencePortTextBox
            // 
            this.keyencePortTextBox.Location = new System.Drawing.Point(84, 127);
            this.keyencePortTextBox.Name = "keyencePortTextBox";
            this.keyencePortTextBox.Size = new System.Drawing.Size(56, 20);
            this.keyencePortTextBox.TabIndex = 5;
            // 
            // keyenceIpTextBox
            // 
            this.keyenceIpTextBox.Location = new System.Drawing.Point(84, 88);
            this.keyenceIpTextBox.Name = "keyenceIpTextBox";
            this.keyenceIpTextBox.Size = new System.Drawing.Size(123, 20);
            this.keyenceIpTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Порт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // keyenceEthernetConnectionRadioButton
            // 
            this.keyenceEthernetConnectionRadioButton.AutoSize = true;
            this.keyenceEthernetConnectionRadioButton.Location = new System.Drawing.Point(22, 42);
            this.keyenceEthernetConnectionRadioButton.Name = "keyenceEthernetConnectionRadioButton";
            this.keyenceEthernetConnectionRadioButton.Size = new System.Drawing.Size(65, 17);
            this.keyenceEthernetConnectionRadioButton.TabIndex = 1;
            this.keyenceEthernetConnectionRadioButton.TabStop = true;
            this.keyenceEthernetConnectionRadioButton.Text = "Ethernet";
            this.keyenceEthernetConnectionRadioButton.UseVisualStyleBackColor = true;
            this.keyenceEthernetConnectionRadioButton.CheckedChanged += new System.EventHandler(this.keyenceConnectionRadioButton_CheckedChanged);
            // 
            // keyenceUsbConnectionRadioButton
            // 
            this.keyenceUsbConnectionRadioButton.AutoSize = true;
            this.keyenceUsbConnectionRadioButton.Location = new System.Drawing.Point(22, 19);
            this.keyenceUsbConnectionRadioButton.Name = "keyenceUsbConnectionRadioButton";
            this.keyenceUsbConnectionRadioButton.Size = new System.Drawing.Size(47, 17);
            this.keyenceUsbConnectionRadioButton.TabIndex = 0;
            this.keyenceUsbConnectionRadioButton.TabStop = true;
            this.keyenceUsbConnectionRadioButton.Text = "USB";
            this.keyenceUsbConnectionRadioButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.simaticResultZAddressTextBox);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.simaticCounterAddressTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.simaticQualityAddressTextBox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.simaticResultYAddressTextBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.simaticBlockTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.simaticIpTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simatic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Z";
            // 
            // simaticResultZAddressTextBox
            // 
            this.simaticResultZAddressTextBox.Location = new System.Drawing.Point(88, 154);
            this.simaticResultZAddressTextBox.Name = "simaticResultZAddressTextBox";
            this.simaticResultZAddressTextBox.Size = new System.Drawing.Size(123, 20);
            this.simaticResultZAddressTextBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Адрес:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Счетчик";
            // 
            // simaticCounterAddressTextBox
            // 
            this.simaticCounterAddressTextBox.Location = new System.Drawing.Point(88, 238);
            this.simaticCounterAddressTextBox.Name = "simaticCounterAddressTextBox";
            this.simaticCounterAddressTextBox.Size = new System.Drawing.Size(123, 20);
            this.simaticCounterAddressTextBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Адрес:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Качество";
            // 
            // simaticQualityAddressTextBox
            // 
            this.simaticQualityAddressTextBox.Location = new System.Drawing.Point(88, 196);
            this.simaticQualityAddressTextBox.Name = "simaticQualityAddressTextBox";
            this.simaticQualityAddressTextBox.Size = new System.Drawing.Size(123, 20);
            this.simaticQualityAddressTextBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Адрес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y";
            // 
            // simaticResultYAddressTextBox
            // 
            this.simaticResultYAddressTextBox.Location = new System.Drawing.Point(88, 112);
            this.simaticResultYAddressTextBox.Name = "simaticResultYAddressTextBox";
            this.simaticResultYAddressTextBox.Size = new System.Drawing.Size(123, 20);
            this.simaticResultYAddressTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Блок";
            // 
            // simaticBlockTextBox
            // 
            this.simaticBlockTextBox.Location = new System.Drawing.Point(88, 70);
            this.simaticBlockTextBox.Name = "simaticBlockTextBox";
            this.simaticBlockTextBox.Size = new System.Drawing.Size(123, 20);
            this.simaticBlockTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DB:";
            // 
            // simaticIpTextBox
            // 
            this.simaticIpTextBox.Location = new System.Drawing.Point(88, 28);
            this.simaticIpTextBox.Name = "simaticIpTextBox";
            this.simaticIpTextBox.Size = new System.Drawing.Size(123, 20);
            this.simaticIpTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP:";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(281, 353);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.Deactivate += new System.EventHandler(this.OptionsForm_Deactivate);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton keyenceUsbConnectionRadioButton;
        private System.Windows.Forms.RadioButton keyenceEthernetConnectionRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyencePortTextBox;
        private System.Windows.Forms.TextBox keyenceIpTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox simaticBlockTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox simaticIpTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox simaticResultYAddressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox simaticQualityAddressTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox simaticCounterAddressTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox simaticResultZAddressTextBox;
        private System.Windows.Forms.Label label13;
    }
}