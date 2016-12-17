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

            m_app_manager.AddApplication(new App("app_name", "producer"));
            m_app_manager.AddApplication(new App("app_name2", "producer2"));

            listBoxApps.DataSource = new BindingSource(m_app_manager.Apps, null);

            listBoxApps.DisplayMember = "Key";
        }

        /**********************************************************************************/

        /// <summary>
        /// Reference to AppManager instance
        /// </summary>
        private AppManager m_app_manager;

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

        }

        /**********************************************************************************/

        private void buttonRemoveApp_Click(object sender, EventArgs e)
        {

        }

        /**********************************************************************************/

        private void buttonRemoveAppApps_Click(object sender, EventArgs e)
        {

        }

        /**********************************************************************************/

        #endregion Apps

        /**********************************************************************************/

        #region Users

        /**********************************************************************************/

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        /**********************************************************************************/

        private void buttonEditUser_Click(object sender, EventArgs e)
        {

        }

        /**********************************************************************************/

        private void buttonRmUser_Click(object sender, EventArgs e)
        {

        }

        /**********************************************************************************/

        private void buttonRmAllUsers_Click(object sender, EventArgs e)
        {

        }

        /**********************************************************************************/

        #endregion Users

        /**********************************************************************************/

    }
}
