using System.Diagnostics;
using System.Speech.Synthesis;

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
            ProcessStartInfo psi = new()
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        static public readonly string AppMessageBoxCaption = "FPAssistant";
        static public readonly string AppCantOpenUrlLink = "Unable to open URL link in default browser!";

        static public readonly string AppLatitudeFormat = "00.000000000000000";
        static public readonly string AppLongitudeFormat = "000.000000000000000";

        static public SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
    }
}