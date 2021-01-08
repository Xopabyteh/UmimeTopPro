using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace UmimeTopPro
{
    static class Program
    {
        public static string Path = Directory.GetCurrentDirectory() + @"\dat.txt";
        public static string[] srDat;
        public static string username;
        public static string password;

        public static IWebDriver Driver = null;
        public static ISolutionSolver CurrentSolver = null;
        public static MainWorkspace Workspace = null;
        public static IJavaScriptExecutor Js;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Workspace = new MainWorkspace();

            UpdateDat();
            Application.Run(Workspace);

        }

        public static void UpdateDat()
        {
            if (!File.Exists(Path))
            {
                var f = File.CreateText(Path);
                f.Close();
            }
            else
            {
                StreamReader sr = new StreamReader(Path);
                string srText = sr.ReadLine();
                sr.Close();
                if (srText != null && srText.Contains('€'))
                {
                    srDat = srText.Split('€');
                    sr.Close();
                    username = srDat[0];
                    password = srDat[1];
                }
                else
                {
                    File.Delete(Path);
                }

            }
        }
    }
}
