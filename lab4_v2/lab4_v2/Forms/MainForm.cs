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
        public MainForm(AppManager _am)
        {
            m_app_manager = _am;
            InitializeComponent();

            UpdateSysInfoLabel();
        }

        /// <summary>
        /// Reference to AppManager instance
        /// </summary>
        private AppManager m_app_manager;

        private void sysInfo_Click(object sender, EventArgs e)
        {

        }

        public void UpdateSysInfoLabel()
        {
            ComputerInfo ci = m_app_manager.ComputerInfo;

            this.sysInfoLabel.Text = String.Format(
                "CPU Frequency: {0} MGz, RAM Capacity: {1} Mb, GPU Memory: {2} Mb, OS: {3}",
                ci.CpuFreq, ci.RamCapacity, ci.GpuMem, ci.OSType
            );
        }
    }
}
