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

            Guid new_author_guid = Guid.NewGuid();

            Model.Author author = new Model.Author(new_author_guid, "John");

            using (lm = new LibraryModel())
            {
                lm.Authors.Add(author);
                lm.SaveChanges();
            }

            using (lm = new LibraryModel())
            {
                var restored_author = lm.Authors.Find(new_author_guid);

                Console.WriteLine(restored_author.Id == author.Id);
                Console.WriteLine(restored_author.Equals(author));
                Console.WriteLine(restored_author.Equals(author) ? "same" : "not same");

                foreach (Model.Author item in lm.Authors) {
                    Console.WriteLine(item);
                }
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
