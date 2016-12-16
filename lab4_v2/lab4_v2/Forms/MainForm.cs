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
            m_comp_info = m_app_manager.ComputerInfo;
            InitializeComponent();

            m_app_manager.ComputerInfoUpdated += UpdateSysInfoLabel;

            UpdateSysInfoLabel();
        }

        /**********************************************************************************/

        /// <summary>
        /// Reference to AppManager instance
        /// </summary>
        private AppManager m_app_manager;
        private ComputerInfo m_comp_info;

        /**********************************************************************************/

        public void UpdateSysInfoLabel()
        {
            sysInfoLabel.Text = string.Format(
                "CPU Frequency: {0} MGz, RAM Capacity: {1} Mb, GPU Memory: {2} Mb, OS: {3}",
                m_comp_info.CpuFreq, m_comp_info.RamCapacity, m_comp_info.GpuMem, m_comp_info.OSType
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

    }
}
