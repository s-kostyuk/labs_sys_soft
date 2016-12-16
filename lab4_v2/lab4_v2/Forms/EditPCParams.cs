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

        /**********************************************************************************/

        private void buttonReset_Click(object sender, EventArgs e)
        {
            m_comp_info_copy = m_app_manager.ComputerInfo;

            UpdateTextBoxes();
        }

        /**********************************************************************************/

        private double ExtractValueFromTextBox(TextBox _tb)
        {
            return Convert.ToDouble(_tb.Text);
        }

        /**********************************************************************************/

        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Think about how to reduce code duplications
                m_comp_info_copy.CpuFreq = ExtractValueFromTextBox(textBoxCpuFreq);
                m_comp_info_copy.RamCapacity = ExtractValueFromTextBox(textBoxRamCapacity);
                m_comp_info_copy.GpuMem = ExtractValueFromTextBox(textBoxGpuMem);
                m_comp_info_copy.OSType = textBoxOsType.Text;
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Unable to get value form text box(es). Please, remove any reduntant letters in your input", 
                    "Invalid format"
                );
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Unable to set specified value. {0}",
                        ex.Message
                        ),
                    "Argument out of range"
                );
            }

            m_app_manager.ComputerInfo = m_comp_info_copy;

            Close();
        }

        /**********************************************************************************/

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**********************************************************************************/

        
    }
}
