using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_v2.Forms
{
    public partial class EditUser : Form
    {

        /**********************************************************************************/

        public EditUser(AppManager _am)
        {
            InitializeComponent();

            m_app_manager = _am;
        }

        /**********************************************************************************/

        private AppManager m_app_manager;

        /**********************************************************************************/

        // TODO: Rewrite
        public void SetUsernameReadOnly(bool _is_read_only)
        {
            textBoxUsername.ReadOnly = _is_read_only;
        }

        /**********************************************************************************/

        public void SetOldPassReadOnly(bool _is_read_only)
        {
            textBoxOldPass.ReadOnly = _is_read_only;
        }

    }
}
