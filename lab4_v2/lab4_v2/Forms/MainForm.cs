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
    public partial class MainForm : Form
    {

        /**********************************************************************************/

        public MainForm(AppManager _am)
        {
            m_app_manager = _am;
            InitializeComponent();

            m_app_manager.ComputerInfoUpdated += UpdateSysInfoLabel;

            UpdateSysInfoLabel();

            App new_app1 = new App("app_name", "producer");
            App new_app2 = new App("app_name2", "producer2");

            new_app1.InstallationDate = DateTime.Today;
            new_app2.InstallationDate = DateTime.Today;

            m_app_manager.AddApplication(new_app1);
            m_app_manager.AddApplication(new_app2);
            

            //m_bs_apps = new BindingSource(m_app_manager.Apps, null);
            //listBoxApps.DataSource = m_bs_apps;
            //listBoxApps.DisplayMember = "Key";
            //listBoxApps.ValueMember = "Key";

            UpdateListBoxApps();

            m_app_manager.AddUser(new User("username1", "passwd"));

            //m_bs_users = new BindingSource(m_app_manager.Users, null);
            //listBoxUsers.DataSource = m_bs_users;
            //listBoxUsers.DisplayMember = "Key";
            //listBoxUsers.ValueMember = "Key";

            UpdateListBoxUsers();

            m_app_manager.NewUserAdded += ListBoxAddUser;
            m_app_manager.NewAppAdded += ListBoxAddApp;
        }

        /**********************************************************************************/

        /// <summary>
        /// Reference to AppManager instance
        /// </summary>
        private AppManager m_app_manager;
        //private BindingSource m_bs_apps;
        //private BindingSource m_bs_users;

        /**********************************************************************************/

        public void UpdateListBoxApps()
        {
            listBoxUsers.Items.Clear();

            foreach (KeyValuePair<string, App> app in m_app_manager.Apps)
            {
                listBoxApps.Items.Add(app.Key);
            }
        }

        /**********************************************************************************/

        public void UpdateListBoxUsers()
        {
            listBoxUsers.Items.Clear();

            foreach (KeyValuePair<string, User> user in m_app_manager.Users)
            {
                listBoxUsers.Items.Add(user.Key);
            }
        }

        /**********************************************************************************/

        public void ListBoxAddUser(object sender, NewElementEventArgs e)
        {
            AppManager app_manager = sender as AppManager;

            listBoxUsers.Items.Add(e.NewElementName);
        }

        /**********************************************************************************/

        public void ListBoxAddApp(object sender, NewElementEventArgs e)
        {
            AppManager app_manager = sender as AppManager;

            listBoxApps.Items.Add(e.NewElementName);
        }

        /**********************************************************************************/

        #region System info

        /**********************************************************************************/

        public void UpdateSysInfoLabel()
        {
            sysInfoLabel.Text = string.Format(
                "CPU Frequency: {0} MGz, RAM Capacity: {1} Mb, GPU Memory: {2} Mb, OS: {3}",
                m_app_manager.ComputerInfo.CpuFreq, 
                m_app_manager.ComputerInfo.RamCapacity,
                m_app_manager.ComputerInfo.GpuMem,
                m_app_manager.ComputerInfo.OSType
            );
        }

        /**********************************************************************************/

        public void UpdateSysInfoLabel(object sender, EventArgs e)
        {
            UpdateSysInfoLabel();
        }

        /**********************************************************************************/

        private void statusStripSysInfo_DoubleClick(object sender, EventArgs e)
        {
            new Forms.EditPCParams(m_app_manager).Show();
        }

        /**********************************************************************************/

        #endregion System info

        /**********************************************************************************/

        #region Apps

        /**********************************************************************************/

        private void buttonAddApp_Click(object sender, EventArgs e)
        {
            Form edit_app_form = new EditApp(m_app_manager);
            edit_app_form.Show();
        }

        /**********************************************************************************/

        private void buttonEditApp_Click(object sender, EventArgs e)
        {
            string target_username = listBoxApps.SelectedItem as string;
            Form edit_app_form = new EditApp(m_app_manager, target_username);
            edit_app_form.Show();
        }

        /**********************************************************************************/

        private void buttonRemoveApp_Click(object sender, EventArgs e)
        {
            string on_delete = listBoxApps.SelectedItem as string;

            m_app_manager.RemoveUser(
                on_delete
            );

            listBoxApps.Items.Remove(on_delete);
        }

        /**********************************************************************************/

        private void buttonRemoveAllApps_Click(object sender, EventArgs e)
        {
            m_app_manager.RemoveAllApps();

            listBoxApps.Items.Clear();
        }

        /**********************************************************************************/

        private void buttonUpdateApp_Click(object sender, EventArgs e)
        {
            string on_update = listBoxApps.SelectedItem as string;

            try
            {
                m_app_manager.UpdateApplication(on_update);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Update error");
            }
        }

        /**********************************************************************************/

        #endregion Apps

        /**********************************************************************************/

        #region Users

        /**********************************************************************************/

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            EditUser edit_user_form = new EditUser(m_app_manager);
            edit_user_form.SetUsernameReadOnly(false);
            edit_user_form.SetOldPassReadOnly(true);
            edit_user_form.Show();
        }

        /**********************************************************************************/

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            string target_username = listBoxUsers.SelectedItem as string;
            EditUser edit_user_form = new EditUser(m_app_manager, target_username);
            edit_user_form.SetUsernameReadOnly(true);
            edit_user_form.SetOldPassReadOnly(false);
            edit_user_form.Show();
        }

        /**********************************************************************************/

        private void buttonRmUser_Click(object sender, EventArgs e)
        {
            string on_delete = listBoxUsers.SelectedItem as string;

            m_app_manager.RemoveUser(
                on_delete
            );

            listBoxUsers.Items.Remove(on_delete);
        }

        /**********************************************************************************/

        private void buttonRmAllUsers_Click(object sender, EventArgs e)
        {
            m_app_manager.RemoveAllUsers();

            listBoxUsers.Items.Clear();
        }

        /**********************************************************************************/

        private void buttonEditUserApps_Click(object sender, EventArgs e)
        {
            string target_username = listBoxUsers.SelectedItem as string;
            EditUserApps form = new EditUserApps(m_app_manager, target_username);
            form.Show();
        }

        /**********************************************************************************/

        #endregion Users

        /**********************************************************************************/

    }
}
