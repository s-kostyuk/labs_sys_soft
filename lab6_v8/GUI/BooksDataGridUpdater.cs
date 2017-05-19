using lab6_v8.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*****************************************************************************/

namespace GUI
{
    class BooksDataGridUpdater
    {
        /*-------------------------------------------------------------------*/

        public BooksDataGridUpdater(DataGridView dgv, BindingSource binding)
        {
            this.dgv = dgv;
            this.binding = binding;

            this.binding.ListChanged += Binding_ListChanged;
        }

        /*-------------------------------------------------------------------*/

        private void Binding_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            this.UpdateDGV();
        }

        /*-------------------------------------------------------------------*/

        public void UpdateDGV()
        {
            dgv.Rows.Clear();

            int i = 0;

            foreach (Book book in binding) {
                dgv.Rows.Add
                    (
                    new object[] {
                          i++ // book position on Collection
                        , book.Author.Name
                        , book.Title
                        , book.Publisher.Name
                        , book.Year
                    }
                    );
            }
        }

        /*-------------------------------------------------------------------*/

        private DataGridView dgv;
        private BindingSource binding;

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
