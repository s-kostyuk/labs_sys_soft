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

        public EditUser(AppManager _am, string _username = null)
        {
            InitializeComponent();

            m_app_manager = _am;
            m_username = _username;

            textBoxUsername.Text = _username;
        }

        /**********************************************************************************/

        private AppManager m_app_manager;
        private string m_username;

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

        /**********************************************************************************/

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = m_username;
            textBoxOldPass.Text = "";
            textBoxNewPass.Text = "";
        }

        /**********************************************************************************/

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string new_username = textBoxUsername.Text;
            string old_pass = textBoxOldPass.Text;
            string new_pass = textBoxNewPass.Text;

            if (new_username != m_username)  // If adding new user...
            {
                try
                {
                    m_app_manager.AddUser(new_username, new_pass);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "User exists");
                    return;
                }
                
            }
            else  // else - edit existing user (change password)
            {
                try
                {
                    m_app_manager.ChangeUserPassword(new_username, old_pass, new_pass);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Unable to change password: invalid old password", "Access denied");
                    return;
                }
            }

            Close();
        }

        /**********************************************************************************/

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
