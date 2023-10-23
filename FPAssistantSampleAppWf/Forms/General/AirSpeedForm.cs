using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FpAssistantCore.GeneralAviation;

namespace FPAssistantSampleAppWf.Forms.General
{
    public partial class AirSpeedForm : Form
    {
        public AirSpeedForm()
        {
            InitializeComponent();
            // Build IAS unit combo with values from FPAssistant
            ComboBoxIasUnit.Items.Insert((int)AirSpeedUnits.Kt, AirSpeedUnits.Kt.ToString());
            ComboBoxIasUnit.Items.Insert((int)AirSpeedUnits.Kph, AirSpeedUnits.Kph.ToString());
            ComboBoxIasUnit.SelectedIndex = (int)AirSpeedUnits.Kt;

            ComboBoxAltitudeUnit.Items.Insert((int)AltitudeUnits.Feet, AltitudeUnits.Feet.ToString());
            ComboBoxAltitudeUnit.Items.Insert((int)AltitudeUnits.Metres, AltitudeUnits.Metres.ToString());
            ComboBoxAltitudeUnit.SelectedIndex = (int)AltitudeUnits.Feet;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AirSpeedForm_Load(object sender, EventArgs e)
        {
            CalculateTas();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTas();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTas();
        }

        private void CalculateTas()
        {
            (bool success, double textBoxIsa) = FpAssistantCore.General.Utilities.ConvertStringToDouble(TextBoxIsa.Text);
            if (!success)
            {
                return;
            }
            (success, double textBoxIas) = FpAssistantCore.General.Utilities.ConvertStringToDouble(TextBoxIas.Text);
            if (!success)
            {
                return;
            }
            (success, double textBoxAltitude) = FpAssistantCore.General.Utilities.ConvertStringToDouble(TextBoxAltitude.Text);
            if (!success)
            {
                return;
            }

            AirSpeed airSpeed = new(textBoxIas, (AirSpeedUnits)ComboBoxIasUnit.SelectedIndex);
            Altitude altitude = new(textBoxAltitude, (AltitudeUnits)ComboBoxAltitudeUnit.SelectedIndex);

            IndicatedAirSpeed ias = new(airSpeed, altitude, textBoxIsa);

            TextBoxTas.Text = ias.TrueAirSpeed.ToString();
            TextBoxK.Text = ias.K.ToString("0.####");

            // Add 10% for Departures
            AirSpeed iasDepartures = airSpeed;
            iasDepartures.Value *= 1.10; // Increase IAS value by 10%
            ias = new(iasDepartures, altitude, textBoxIsa);
            TextBoxTas10pc.Text = ias.TrueAirSpeed.ToString();

        }

        private void LinkLabelApiIndicatedAirSpeed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Program.VisitLink(@"http://api.fpassistant.com/api/FpAssistantCore.GeneralAviation.IndicatedAirSpeed.html");
                LinkLabelApiIndicatedAirSpeed.LinkVisited = true;
            }
            catch (Exception)
            {
                MessageBox.Show(Program.AppCantOpenUrlLink, Program.AppMessageBoxCaption);
            }
        }
    }
}