using FpAssistantCore.General;
using FpAssistantCore.Geographical;

namespace FPAssistantSampleAppWf.Forms.General
{
    public partial class GreatCircleForm : Form
    {
        private GeoCoordinate geoCoordinate = new(31, 54);
        private bool proceedWithTextChanged = true;

        public GreatCircleForm()
        {
            InitializeComponent();

            proceedWithTextChanged = false;
            TextBoxLatitude.Text = geoCoordinate.Latitude.ToString();
            TextBoxLongitude.Text = geoCoordinate.Longitude.ToString();
            proceedWithTextChanged = true;
            UpdateForm();
        }

        private async void UpdateForm()
        {
            (bool success, double textBoxBearing) = Utilities.ConvertStringToDouble(TextBoxBearing.Text);
            if (!success)
            {
                return;
            }
            CompassBearing compassBearing = new(textBoxBearing);

            (success, double textBoxDistance) = Utilities.ConvertStringToDouble(TextBoxDistance.Text);
            if (!success)
            {
                return;
            }

            LinearDistance linearDistance = new(textBoxDistance, LinearDistanceUnits.Metres);

            GeoCoordinateBasic geoCoordinateBasic = geoCoordinate.GeoCoordinateBasic.WGS84Destination(compassBearing, linearDistance);
            TextBoxLatitudeResultFaa.Text = geoCoordinateBasic.Latitude.ToString(Program.AppLatitudeFormat);
            TextBoxLongitudeResultFaa.Text = geoCoordinateBasic.Longitude.ToString(Program.AppLongitudeFormat);

            GeoCoordinate result = await Task.Run(() =>
            {
                GeoCoordinate.ModeOfOperation = GeoCoordinate.ModesOfOperation.CsMapWebServiceAPI;
                GeoCoordinate geoCoordinateTranslated = new(0, 0);
                int result = geoCoordinate.TranslatedByAzimuthAndDistance(compassBearing, linearDistance, ref geoCoordinateTranslated);
                return geoCoordinateTranslated;

            });
            TextBoxLatitudeResultCsMap.Text = result.Latitude.ToString(Program.AppLatitudeFormat);
            TextBoxLongitudeResultCsMap.Text = result.Longitude.ToString(Program.AppLongitudeFormat);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxLatitude_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double latitude) = Utilities.ConvertStringToDouble(TextBoxLatitude.Text);
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

        private void TextBoxLongitude_TextChanged(object sender, EventArgs e)
        {
            if (proceedWithTextChanged == false)
            {
                return;
            }

            (bool status, double longitude) = Utilities.ConvertStringToDouble(TextBoxLongitude.Text);
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

        private void TextBoxBearing_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void TextBoxDistance_TextChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void LinkLabelApiFaa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Program.VisitLink(@"http://api.fpassistant.com/api/FpAssistantCore.Geographical.GeoCoordinateBasic.html#FpAssistantCore_Geographical_GeoCoordinateBasic_WGS84Destination_FpAssistantCore_General_CompassBearing_FpAssistantCore_General_LinearDistance_");
                LinkLabelApiFaa.LinkVisited = true;
            }
            catch (Exception)
            {
                MessageBox.Show(Program.AppCantOpenUrlLink, Program.AppMessageBoxCaption);
            }
        }

        private void LinkLabelApiCsMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Program.VisitLink(@"http://api.fpassistant.com/api/FpAssistantCore.Geographical.GeoCoordinate.html#FpAssistantCore_Geographical_GeoCoordinate_TranslatedByAzimuthAndDistance_FpAssistantCore_General_CompassBearing_FpAssistantCore_General_LinearDistance_FpAssistantCore_Geographical_GeoCoordinate__");
                LinkLabelApiCsMap.LinkVisited = true;
            }
            catch (Exception)
            {
                MessageBox.Show(Program.AppCantOpenUrlLink, Program.AppMessageBoxCaption);
            }
        }
    }
}