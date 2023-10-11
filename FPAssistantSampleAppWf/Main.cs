using FPAssistantSampleAppWf.Forms.General;

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
            ConversionsForm conversionsForm = new ConversionsForm();
            conversionsForm.Show();
        }
    }
}