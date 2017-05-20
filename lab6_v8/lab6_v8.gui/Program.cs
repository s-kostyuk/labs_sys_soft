using lab6_v8.library;

using System;
using System.Windows.Forms;

/*****************************************************************************/

namespace lab6_v8.gui
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
