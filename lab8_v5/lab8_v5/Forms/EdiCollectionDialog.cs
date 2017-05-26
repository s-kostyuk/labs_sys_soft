using System;
using System.Windows.Forms;

/*****************************************************************************/

namespace lab8_v5.gui.Forms
{
    public partial class EditCollectionDialog : Form
    {
        /*-------------------------------------------------------------------*/

        public EditCollectionDialog(BindingSource source)
        {
            InitializeComponent();

            this.source = source;

            this.dataGridViewPublishers.DataSource = this.source;
        }

        /*-------------------------------------------------------------------*/

        private BindingSource source;

        /*-------------------------------------------------------------------*/

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        
        /*-------------------------------------------------------------------*/
    }
}
