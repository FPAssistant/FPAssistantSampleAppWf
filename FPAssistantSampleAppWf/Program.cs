using System.Diagnostics;

namespace FPAssistantSampleAppWf
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }

        static public void VisitLink(string url)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        static public string AppMessageBoxCaption = "FPAssistant";
        static public string AppCantOpenUrlLink = "Unable to open URL link in default browser!";
    }
}
