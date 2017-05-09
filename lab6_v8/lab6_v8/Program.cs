using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab6_v8.Forms;

/*****************************************************************************/

namespace lab6_v8
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Controller controller = new Controller();
			controller.AddSampleData ();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mf = new MainForm(controller);
			mf.ImportBooks ();
            Application.Run(mf);
        }
    }
}
