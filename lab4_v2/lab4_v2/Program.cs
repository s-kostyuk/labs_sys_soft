using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace lab4_v2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            ComputerInfo ci = new ComputerInfo();
            ci.CpuFreq = 2000;
            ci.GpuMem = 512;
            ci.RamCapacity = 4096;
            ci.OSType = "Windows 7 x64";

            AppManager am = new AppManager(ci);

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Form main_form = new Forms.MainForm(am);

            Application.Run(main_form);
        }
    }
}