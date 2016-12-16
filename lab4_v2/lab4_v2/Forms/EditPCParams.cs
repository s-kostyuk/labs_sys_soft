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
    public partial class EditPCParams : Form
    {
        /**********************************************************************************/

        public EditPCParams(AppManager _am)
        {
            InitializeComponent();

            m_app_manager = _am;
            m_comp_info_copy = _am.ComputerInfo;

            UpdateTextBoxes ();
        }

        /**********************************************************************************/

        private ComputerInfo m_comp_info_copy;
        private AppManager m_app_manager;

        /**********************************************************************************/

        private void UpdateTextBoxes()
        {
            textBoxCpuFreq.Text = m_comp_info_copy.CpuFreq.ToString();
            textBoxRamCapacity.Text = m_comp_info_copy.RamCapacity.ToString();
            textBoxGpuMem.Text = m_comp_info_copy.GpuMem.ToString();
            textBoxOsType.Text = m_comp_info_copy.OSType;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            UpdateTextBoxes();
        }

        /**********************************************************************************/



        /**********************************************************************************/
    }
}
