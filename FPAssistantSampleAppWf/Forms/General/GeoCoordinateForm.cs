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

namespace FPAssistantSampleAppWf.Forms.General
{
    public partial class GeoCoordinateForm : Form
    {
        private GeoCoordinate geoCoordinate = new(54, 31);
        private bool proceedWithTextChanged = true;

        public GeoCoordinateForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        private void UpdateForm()
        {
            TextBoxLatitudeDecimalDms.Text = geoCoordinate.Latitude.ToString("00.0000");
            TextBoxLongitudeDecimalDms.Text = geoCoordinate.Longitude.ToString("000.0000");

            TextBoxLatitudeDegrees.Text = geoCoordinate.LatitudeDegrees.ToString();
            TextBoxLongitudeDegrees.Text = geoCoordinate.LongitudeDegrees.ToString();

            TextBoxLatitudeMinutes.Text = geoCoordinate.LatitudeMinutes.ToString();
            TextBoxLongitudeMinutes.Text = geoCoordinate.LongitudeMinutes.ToString();

            TextBoxLatitudeSeconds.Text = geoCoordinate.LatitudeSeconds.ToString("0.0000");
            TextBoxLongitudeSeconds.Text = geoCoordinate.LongitudeSeconds.ToString("0.0000");

            ComboBoxLatitudeCardinal.SelectedItem = geoCoordinate.LatitudeCardinalDirection.ToString();
            ComboBoxLongitudeCardinal.SelectedItem = geoCoordinate.LongitudeCardinalDirection.ToString();

            TextBoxGeography.Text = geoCoordinate.AsGeography();
        }

        private void TextBoxLatitudeDecimalDms_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double latitude) = Utilities.ConvertStringToDouble(TextBoxLatitudeDecimalDms.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Latitude value in coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            geoCoordinate = new GeoCoordinate(latitude, geoCoordinate.Longitude);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void TextBoxLongitudeDecimalDms_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double longitude) = Utilities.ConvertStringToDouble(TextBoxLongitudeDecimalDms.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Longitude value in coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            geoCoordinate = new GeoCoordinate(geoCoordinate.Latitude, longitude);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxLatitudeDegrees_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double latitudeDegrees) = Utilities.ConvertStringToDouble(TextBoxLatitudeDegrees.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Latitude Degrees value in coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            geoCoordinate = new GeoCoordinate(geoCoordinate.LatitudeCardinalDirection, latitudeDegrees, geoCoordinate.LatitudeMinutes, geoCoordinate.LatitudeSeconds, geoCoordinate.LongitudeCardinalDirection, geoCoordinate.LongitudeDegrees, geoCoordinate.LongitudeMinutes, geoCoordinate.LongitudeSeconds);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void TextBoxLongitudeDegrees_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double longitudeDegrees) = Utilities.ConvertStringToDouble(TextBoxLongitudeDegrees.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Longitude Degrees value in coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            geoCoordinate = new GeoCoordinate(geoCoordinate.LatitudeCardinalDirection, geoCoordinate.LatitudeDegrees, geoCoordinate.LatitudeMinutes, geoCoordinate.LatitudeSeconds, geoCoordinate.LongitudeCardinalDirection, longitudeDegrees, geoCoordinate.LongitudeMinutes, geoCoordinate.LongitudeSeconds);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void TextBoxLatitudeMinutes_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double latitudeMinutes) = Utilities.ConvertStringToDouble(TextBoxLatitudeMinutes.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Latitudes Minutes value in coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            geoCoordinate = new GeoCoordinate(geoCoordinate.LatitudeCardinalDirection, geoCoordinate.LatitudeDegrees, latitudeMinutes, geoCoordinate.LatitudeSeconds, geoCoordinate.LongitudeCardinalDirection, geoCoordinate.LongitudeDegrees, geoCoordinate.LongitudeMinutes, geoCoordinate.LongitudeSeconds);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void TextBoxLongitudeMinutes_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double longitudeMinutes) = Utilities.ConvertStringToDouble(TextBoxLongitudeMinutes.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Longitude Minutes value in coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            geoCoordinate = new GeoCoordinate(geoCoordinate.LatitudeCardinalDirection, geoCoordinate.LatitudeDegrees, geoCoordinate.LatitudeMinutes, geoCoordinate.LatitudeSeconds, geoCoordinate.LongitudeCardinalDirection, geoCoordinate.LongitudeDegrees, longitudeMinutes, geoCoordinate.LongitudeSeconds);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void TextBoxLatitudeSeconds_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double latitudeSeconds) = Utilities.ConvertStringToDouble(TextBoxLatitudeSeconds.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Latitude Seconds value in coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            geoCoordinate = new GeoCoordinate(geoCoordinate.LatitudeCardinalDirection, geoCoordinate.LatitudeDegrees, geoCoordinate.LatitudeMinutes, latitudeSeconds, geoCoordinate.LongitudeCardinalDirection, geoCoordinate.LongitudeDegrees, geoCoordinate.LongitudeMinutes, geoCoordinate.LongitudeSeconds);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void TextBoxLongitudeSeconds_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double longitudeSeconds) = Utilities.ConvertStringToDouble(TextBoxLongitudeSeconds.Text);
            if (status == false)
            {
                MessageBox.Show("Unable to understand Longitude Seconds value in coordinate!", Program.AppMessageBoxCaption, MessageBoxButtons.OK);
                return;
            }

            geoCoordinate = new GeoCoordinate(geoCoordinate.LatitudeCardinalDirection, geoCoordinate.LatitudeDegrees, geoCoordinate.LatitudeMinutes, geoCoordinate.LatitudeSeconds, geoCoordinate.LongitudeCardinalDirection, geoCoordinate.LongitudeDegrees, geoCoordinate.LongitudeMinutes, longitudeSeconds);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void ComboBoxLatitudeCardinal_SelectedValueChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            LatitudeCardinalDirection latitudeCardinalDirection = LatitudeCardinalDirection.N;
            switch (ComboBoxLatitudeCardinal.SelectedItem)
            {
                case "N":
                    break;
                case "S":
                    latitudeCardinalDirection = LatitudeCardinalDirection.S;
                    break;
            }
            geoCoordinate = new GeoCoordinate(latitudeCardinalDirection, geoCoordinate.LatitudeDegrees, geoCoordinate.LatitudeMinutes, geoCoordinate.LatitudeSeconds, geoCoordinate.LongitudeCardinalDirection, geoCoordinate.LongitudeDegrees, geoCoordinate.LongitudeMinutes, geoCoordinate.LongitudeSeconds);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void ComboBoxLongitudeCardinal_SelectedValueChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            LongitudeCardinalDirection longitudeCardinalDirection = LongitudeCardinalDirection.E;
            switch (ComboBoxLongitudeCardinal.SelectedItem)
            {
                case "E":
                    break;
                case "W":
                    longitudeCardinalDirection = LongitudeCardinalDirection.W;
                    break;
            }
            geoCoordinate = new GeoCoordinate(geoCoordinate.LatitudeCardinalDirection, geoCoordinate.LatitudeDegrees, geoCoordinate.LatitudeMinutes, geoCoordinate.LatitudeSeconds, longitudeCardinalDirection, geoCoordinate.LongitudeDegrees, geoCoordinate.LongitudeMinutes, geoCoordinate.LongitudeSeconds);
            proceedWithTextChanged = false;
            UpdateForm();
            proceedWithTextChanged = true;
        }

        private void LinkLabelApiGeoCoordinate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Program.VisitLink(@"http://api.fpassistant.com/api/FpAssistantCore.Geographical.GeoCoordinate.html");
                LinkLabelApiGeoCoordinate.LinkVisited = true;
            }
            catch (Exception)
            {
                MessageBox.Show(Program.AppCantOpenUrlLink, Program.AppMessageBoxCaption);
            }
        }
    }
}
