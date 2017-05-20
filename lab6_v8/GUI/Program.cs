using lab6_v8;

using System;
using System.Windows.Forms;

/*****************************************************************************/

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BindingRepoWrapper wrapper =
                new BindingRepoWrapper(
                    new Repository()
                );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm(wrapper));
        }
    }
}

/*****************************************************************************/
