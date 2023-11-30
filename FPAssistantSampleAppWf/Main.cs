using FPAssistantSampleAppWf.Forms.Faa;
using FPAssistantSampleAppWf.Forms.General;
using FPAssistantSampleAppWf.Forms.Icao;

namespace FPAssistantSampleAppWf
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Assign the license for the FPAssistant SDK basic free version
            FpAssistantCore.General.DeveloperLicense.License = "\u009dD\u008b\u0085\u0083\u0091\u0092\u0083\u0090\u0095\u0091\u0092\u0095D\\\u0088\u0083\u008e\u0095\u0087ND\u0088\u0083\u0083\u0096\u0087\u0094\u0092\u0095D\\\u0088\u0083\u008e\u0095\u0087ND\u0091\u0084\u0095\u0096\u0083\u0085\u008e\u0087\u0087\u0098\u0083\u008e\u0097\u0083\u0096\u008b\u0091\u0090D\\\u0088\u0083\u008e\u0095\u0087ND\u0083\u0094\u008b\u0090\u0085VTVD\\\u0088\u0083\u008e\u0095\u0087ND\u0088\u0092\u0083\u0095\u0095\u008b\u0095\u0096\u0083\u0090\u0096\u0095\u0086\u008d\u0084\u0083\u0095\u008b\u0085D\\\u0096\u0094\u0097\u0087ND\u008b\u0085\u0083\u0091\u0083\u0092\u008b\u0086\u0083\u0096\u0083\u0095\u0087\u0094\u0098\u008b\u0085\u0087D\\\u0088\u0083\u008e\u0095\u0087ND\u0086\u0087\u0098\u0087\u008e\u0091\u0092\u0087\u0094\u0090\u0083\u008f\u0087D\\Dhrc\u0095\u0095\u008b\u0095\u0096\u0083\u0090\u0096BufmBd\u0083\u0095\u008b\u0085Bn\u008b\u0085\u0087\u0090\u0095\u0087BOBecf\u0091\u008e\u0091\u0089\u009bNBwmDND\u0086\u0087\u0098\u0087\u008e\u0091\u0092\u0087\u0094\u008d\u0087\u009bD\\DRRRRRRRRORRRRORRRRORRRRORRRRRRRRRRRRD\u009f";

            #region Splash Screen
            SplashScreenForm splashScreenForm = new()
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.8,
                TopMost = true,
                ShowInTaskbar = false
            };
            splashScreenForm.Show();    
#if (DEBUG)
            System.Threading.Thread.Sleep(500);
#else
            System.Threading.Thread.Sleep(2000);
#endif
            splashScreenForm.Close();
            #endregion
        }

        #region Menu bar clicks
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new();
            aboutForm.ShowDialog();
        }

        private void ConversionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConversionsForm conversionsForm = new();
            conversionsForm.Show();
        }

        private void BasicILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicIlsForm basicIlsForm = new();
            basicIlsForm.Show();
        }

        private void AirSpeedIndicatedToTrueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirSpeedForm airSpeedForm = new();
            airSpeedForm.Show();
        }

        private void DistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaaDistanceForm faaDistanceForm = new();
            faaDistanceForm.Show();
        }

        private void DestinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FaaDestinationForm faaDestinationForm = new();
            faaDestinationForm.Show();
        }

        private void GeoCoordinateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeoCoordinateForm geoCoordinateForm = new();
            geoCoordinateForm.Show();
        }

        private void GreatCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreatCircleForm greatCircleForm = new();    
            greatCircleForm.Show(); 
        }
        #endregion

        private void LinkLabelFpassistantSdkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Program.VisitLink(@"http://api.fpassistant.com/index.html");
                LinkLabelFpassistantSdkHome.LinkVisited = true;
            }
            catch (Exception)
            {
                MessageBox.Show(Program.AppCantOpenUrlLink, Program.AppMessageBoxCaption);
            }
        }
    }
}