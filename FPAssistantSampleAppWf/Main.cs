using FPAssistantSampleAppWf.Forms.General;
using FPAssistantSampleAppWf.Forms.Icao;

namespace FPAssistantSampleAppWf
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

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