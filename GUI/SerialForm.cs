using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpenHardwareMonitor.GUI
{
    public partial class SerialForm : Form
    {
        public SerialForm(MainForm parent)
        {
            InitializeComponent();

            portBox.Text = parent.Serial.Port;
            this.parent = parent;
        }
        MainForm parent;

        public string Port
        {
            get
            {
                return portBox.Text;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            parent.Serial.Port = portBox.Text;
            Close();
        }
    }
}
