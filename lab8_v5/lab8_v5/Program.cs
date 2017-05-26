using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8_v5
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LibraryModel lm = new LibraryModel();

            Model.Author author = new Model.Author(Guid.NewGuid(), "Bob");
            lm.Authors.Add(author);
            lm.SaveChanges();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
