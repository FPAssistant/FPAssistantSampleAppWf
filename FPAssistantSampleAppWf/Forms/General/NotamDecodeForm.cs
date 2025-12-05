
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FpAssistantCore.General;
using FpAssistantCore.GeneralAviation;

namespace FPAssistantSampleAppWf.Forms.General
{
    public partial class NotamDecodeForm : Form
    {
        public NotamDecodeForm()
        {
            InitializeComponent();

            TextBoxNotamMessage.Text = "Z1234/06 NOTAMR A1212/06\r\nQ)EGTT/QMXLC/IV/NBO/A/111/999/5129N00028W321\r\nA)EGLL\r\nB)0609050500\r\nC)0704300500\r\nE)DUE WIP TWY B SOUTH CLSD BTN 'F' AND 'R'. TWY 'R' CLSD BTN 'A' AND 'B' AND DIVERTED VIA NEW GREEN CL AND BLUE EDGE LGT. CTN ADZ\r\nF)0.0\r\nG)999.99";

        }

        private void ButtonDecodeNotam_Click(object sender, EventArgs e)
        {
            Notam notam = new(TextBoxNotamMessage.Text);

            if (notam.IsIcaoFormat != true)
            {
                MessageBox.Show("Unable to find a valid NOTAM series letter!", "FPAssistant Warning");
            }

            TextBoxSeriesIdentifier.Text= notam.SeriesIdentifier;
            TextBoxSeriesIdentifierLetter.Text = notam.Series.ToString() + "-" + notam.Series.GetDescription();
            TextBoxIcaoNotamType.Text = notam.NotamType.ToString() + "-" + notam.NotamType.GetDescription();
        }
    }
}
