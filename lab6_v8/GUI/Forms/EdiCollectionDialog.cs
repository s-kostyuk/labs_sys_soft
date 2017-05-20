using lab6_v8;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*****************************************************************************/

namespace GUI.Forms
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
