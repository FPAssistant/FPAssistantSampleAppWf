using FpAssistantCore.General;
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
using Windows.Devices.Geolocation;

namespace FPAssistantSampleAppWf.Forms.Faa
{
    public partial class FaaDistanceForm : Form
    {
        public FaaDistanceForm()
        {
            InitializeComponent();
            CalculateDistance();
        }

        private void CalculateDistance()
        {
            (bool status, double latitude1) = Utilities.ConvertStringToDouble(TextBoxLatitude1.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Latitude value in first coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }
            (status, double longitude1) = Utilities.ConvertStringToDouble(TextBoxLongitude1.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Longitude value in first coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            (status, double latitude2) = Utilities.ConvertStringToDouble(TextBoxLatitude2.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Latitude value in second coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }
            (status, double longitude2) = Utilities.ConvertStringToDouble(TextBoxLongitude2.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Longitude value in second coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            GeoCoordinate first = new(latitude1, longitude1);
            GeoCoordinate second = new(latitude2, longitude2);

            GeoAzimuthDistance geoAzimuthDistance = first.GeoCoordinateBasic.WGS84Distance(second.GeoCoordinateBasic);

            TextBoxAzimuthForward.Text = geoAzimuthDistance.AzimuthForward.ToString();
            TextBoxAzimuthReverse.Text = geoAzimuthDistance.AzimuthReverse.ToString();

            TextBoxDistanceMetres.Text = geoAzimuthDistance.Distance.ConvertTo(LinearDistanceUnits.Metres).ToString(LinearDistanceFormat.InternalPrecision);
            TextBoxDistanceKm.Text = geoAzimuthDistance.Distance.ConvertTo(LinearDistanceUnits.KM).ToString(LinearDistanceFormat.InternalPrecision);
            TextBoxDistanceNm.Text = geoAzimuthDistance.Distance.ConvertTo(LinearDistanceUnits.NM).ToString(LinearDistanceFormat.InternalPrecision);
            TextBoxDistanceFeet.Text = geoAzimuthDistance.Distance.ConvertTo(LinearDistanceUnits.Feet).ToString(LinearDistanceFormat.InternalPrecision);
        }

        private void TextBoxLatitude1_TextChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        private void TextBoxLongitude1_TextChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        private void TextBoxLatitude2_TextChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        private void TextBoxLongitude2_TextChanged(object sender, EventArgs e)
        {
            CalculateDistance();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LinkLabelFaaDistance_Click(object sender, EventArgs e)
        {
            try
            {
                Program.VisitLink(@"http://api.fpassistant.com/api/FpAssistantCore.Geographical.GeoCoordinateBasic.html#FpAssistantCore_Geographical_GeoCoordinateBasic_DistanceTo_FpAssistantCore_Geographical_GeoCoordinateBasic_");
                LinkLabelFaaDistance.LinkVisited = true;
            }
            catch (Exception)
            {
                MessageBox.Show(Program.AppCantOpenUrlLink, Program.AppMessageBoxCaption);
            }
        }
    }
}
