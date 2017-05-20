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
            Repository repo = new Repository();

            BindingRepoWrapper old_wrapper =
                new BindingRepoWrapper(
                    repo
                );

            TestDataFiller tf = new TestDataFiller();
            tf.FillTestData(old_wrapper);

            string repo_string = old_wrapper.Serialize();
            
            BindingRepoWrapper wrapper =
                new BindingRepoWrapper(
                    new Repository()
                );

            wrapper.Deserialize(repo_string);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm(wrapper));

            }
    }
}

/*****************************************************************************/
