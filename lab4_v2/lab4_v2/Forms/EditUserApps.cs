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
    public partial class EditUserApps : Form
    {

        /**********************************************************************************/

        public EditUserApps(AppManager _am, string _username)
        {
            InitializeComponent();

            m_app_manager = _am;
            m_username = _username;
            m_user = _am.Users[_username];

            UpdateListBoxAllApps();
            UpdateListBoxAllowedApps();
        }

        /**********************************************************************************/

        private AppManager m_app_manager;
        private User m_user;
        private string m_username;

        /**********************************************************************************/

        public void UpdateListBoxAllApps()
        {
            listBoxAllApps.Items.Clear();

            foreach (KeyValuePair<string, App> app in m_app_manager.Apps)
            {
                listBoxAllApps.Items.Add(app.Key);
            }
        }

        /**********************************************************************************/

        public void UpdateListBoxAllowedApps()
        {
            listBoxAllowedApps.Items.Clear();

            foreach (string app_name in m_user.Apps)
            {
                listBoxAllowedApps.Items.Add(app_name);
            }
        }

        /**********************************************************************************/

        private void buttonAddApp_Click(object sender, EventArgs e)
        {
            string target_app = listBoxAllApps.SelectedItem as string;

            try
            {
                m_app_manager.AllowUsage(target_app, m_username);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Not enougth RAM");
                return;
            }
            listBoxAllowedApps.Items.Add(target_app);
        }

        /**********************************************************************************/

        private void buttonRemoveApp_Click(object sender, EventArgs e)
        {
            string target_app = listBoxAllowedApps.SelectedItem as string;

            m_app_manager.DenyUsage(target_app, m_username);
            listBoxAllowedApps.Items.Remove(target_app);
        }

        /**********************************************************************************/

    }
}
