using StresserWinGUI.Helpers;
using StresserWinGUI.Forms;

namespace StresserWinGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static HLogger hLogger = new HLogger();
        public static string appWorkDir = Application.StartupPath;
        
        [STAThread]
        static void Main(string[] args)
        {
            Start(args);
        }

        public static void Start(string[] args)
        {
            //Prints a random ascii art
            AsciiPrints.Random();
            //Start the WINUI App Configurator
            ApplicationConfiguration.Initialize();
            //Set the working dir to the right dir!
            Directory.SetCurrentDirectory(appWorkDir);
            Environment.CurrentDirectory = appWorkDir;
            hLogger.Log(LogType.Warning, "DEBUG Mode Started");
            //Starts the APP
            Application.Run(new FrmLogin());
        }

        public static void Stop()
        {
            Application.Exit();
        }

        public static void Crash(string message)
        {
            hLogger.Log(LogType.Error, "!FATAL CRASH!"+message);
            Environment.Exit(0);
        }

        public static void Restart()
        {
            hLogger.Log(LogType.Warning, "Please wait while we restart the APP");
            Application.Restart();
            Environment.Exit(0);
        }
    }
}