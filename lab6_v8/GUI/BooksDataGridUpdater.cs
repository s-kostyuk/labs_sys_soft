using lab6_v8.Model;
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

        private static object[] BookToRowSource(int index, Book book)
        {
            return new object[] {
                          index // book position in Collection
                        , book.Author.Name
                        , book.Title
                        , book.Publisher.Name
                        , book.Year
                    };
        }

        /*-------------------------------------------------------------------*/

        public void UpdateDGV()
        {
            dgv.Rows.Clear();

            int i = 0;

            foreach (Book book in binding) {
                dgv.Rows.Add
                    (
                    BookToRowSource(i++, book)
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
