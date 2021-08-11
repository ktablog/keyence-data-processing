using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeyenceDataProcessing
{
    public partial class OptionsForm : Form
    {
        static Point? _lastFormPosition = null;

        public OptionsForm()
        {
            InitializeComponent();
        }


        private void OptionsForm_Load(object sender, EventArgs e)
        {
            if (_lastFormPosition == null)
            {
                CenterToScreen();
            }
            else 
            {
                Location = _lastFormPosition.Value;
            }

            keyenceUsbConnectionRadioButton.Checked = Common.KeyenceConnectionType == KeyenceConnectionType.Usb;
            keyenceEthernetConnectionRadioButton.Checked = Common.KeyenceConnectionType == KeyenceConnectionType.Ethernet;
            keyenceIpTextBox.Text = Common.KeyenceIp;
            keyencePortTextBox.Text = Common.KeyencePort;
            
            simaticIpTextBox.Text = Common.SimaticIp;
            simaticBlockTextBox.Text = Common.SimaticBlock;
            simaticResultYAddressTextBox.Text = Common.SimaticResultYAddress;
            simaticResultZAddressTextBox.Text = Common.SimaticResultZAddress;
            simaticQualityAddressTextBox.Text = Common.SimaticQualityAddress;
            simaticCounterAddressTextBox.Text = Common.SimaticCounterAddress;

            SetKeyenceConnectionTextFieldsState();
        }


        private void OptionsForm_Deactivate(object sender, EventArgs e)
        {
            _lastFormPosition = Location;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            if (keyenceUsbConnectionRadioButton.Checked)
            {
                Common.KeyenceConnectionType = KeyenceConnectionType.Usb;
            }
            if (keyenceEthernetConnectionRadioButton.Checked)
            {
                Common.KeyenceConnectionType = KeyenceConnectionType.Ethernet;
            }

            Common.KeyenceIp = ReadTextBox(keyenceIpTextBox);
            Common.KeyencePort = ReadTextBox(keyencePortTextBox);

            Common.SimaticIp = ReadTextBox(simaticIpTextBox);
            Common.SimaticBlock = ReadTextBox(simaticBlockTextBox);
            Common.SimaticResultYAddress = ReadTextBox(simaticResultYAddressTextBox);
            Common.SimaticResultZAddress = ReadTextBox(simaticResultZAddressTextBox);
            Common.SimaticQualityAddress = ReadTextBox(simaticQualityAddressTextBox);
            Common.SimaticCounterAddress = ReadTextBox(simaticCounterAddressTextBox);

            Common.save();
        }


        private string ReadTextBox(TextBox textBox)
        {
            return textBox.Text.Trim();
        }


        private void keyenceConnectionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetKeyenceConnectionTextFieldsState();
        }


        private void SetKeyenceConnectionTextFieldsState()
        {
            bool enabled = keyenceEthernetConnectionRadioButton.Checked;
            keyenceIpTextBox.Enabled =
            keyencePortTextBox.Enabled = enabled;
        }
    }
}
