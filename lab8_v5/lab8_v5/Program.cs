using lab8_v5;

using System;
using System.Windows.Forms;

/*****************************************************************************/

namespace lab8_v5.gui
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TestDataFiller tf = new TestDataFiller();

			BindingRepoWrapper wrapper =
                new BindingRepoWrapper(
                    new Repository()
                );

			tf.FillTestData(wrapper);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm(wrapper));

            }
    }
}

/*****************************************************************************/
