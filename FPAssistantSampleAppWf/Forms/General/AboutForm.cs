using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FpAssistantCore;
using FpAssistantCore.General;

namespace FPAssistantSampleAppWf.Forms.General
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            string sdkVersion = Utilities.GetFPAssistantSDKFileVersion();
            LabelFPAssistantSdkVersion.Text += " " + sdkVersion;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
