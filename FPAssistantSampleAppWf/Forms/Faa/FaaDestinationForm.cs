using FpAssistantCore.General;
using FpAssistantCore.GeneralAviation;
using FpAssistantCore.Geographical;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPAssistantSampleAppWf.Forms.Faa
{
    public partial class FaaDestinationForm : Form
    {
        public FaaDestinationForm()
        {
            InitializeComponent();
            CalculationDestinationCoordinate();
        }

        private void CalculationDestinationCoordinate()
        {
            (bool status, double latitude) = Utilities.ConvertStringToDouble(TextBoxLatitude.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Latitude value in start coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }
            (status, double longitude) = Utilities.ConvertStringToDouble(TextBoxLongitude.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Longitude value in start coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            (status, double bearing) = Utilities.ConvertStringToDouble(TextBoxBearing.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand bearing value!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }
            (status, double distance) = Utilities.ConvertStringToDouble(TextBoxDistance.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand distance value!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            GeoCoordinate start = new(latitude, longitude);
            GeoCoordinateBasic destination = start.GeoCoordinateBasic.WGS84Destination(new CompassBearing(bearing), new LinearDistance(distance, LinearDistanceUnits.Metres));

            TextBoxDestinationLatitude.Text = destination.Latitude.ToString();
            TextBoxDestinationLongitude.Text = destination.Longitude.ToString();
        }

        private void TextBoxLatitude_TextChanged(object sender, EventArgs e)
        {
            CalculationDestinationCoordinate();
        }

        private void TextBoxLongitude_TextChanged(object sender, EventArgs e)
        {
            CalculationDestinationCoordinate();
        }

        private void TextBoxDistance_TextChanged(object sender, EventArgs e)
        {
            CalculationDestinationCoordinate();
        }

        private void TextBoxBearing_TextChanged(object sender, EventArgs e)
        {
            (bool status, double bearing) = Utilities.ConvertStringToDouble(TextBoxBearing.Text);

            if (status)
            {
                CompassBearing compassBearing = new(bearing);
                TextBoxBearing.Text = compassBearing.AsDegrees().ToString();
                CalculationDestinationCoordinate();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LinkLabelWGS84Destination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Program.VisitLink(@"http://api.fpassistant.com/api/FpAssistantCore.Geographical.GeoCoordinateBasic.html#FpAssistantCore_Geographical_GeoCoordinateBasic_WGS84Destination_FpAssistantCore_General_CompassBearing_FpAssistantCore_General_LinearDistance_");
                LinkLabelWGS84Destination.LinkVisited = true;
            }
            catch (Exception)
            {
                MessageBox.Show(Program.AppCantOpenUrlLink, Program.AppMessageBoxCaption);
            }
        }
    }
}
