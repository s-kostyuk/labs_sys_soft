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
    public partial class EditApp : Form
    {

        /**********************************************************************************/

        public EditApp(AppManager _am, string _app_full_name = null)
        {
            InitializeComponent();

            m_app_manager = _am;
            m_app_full_name = _app_full_name;

            m_temp_ci = new ComputerInfo();
            m_temp_ci.OSType = "temp";

            if (m_app_full_name != null)
            {
                m_temp_app = m_app_manager.GetApplication(m_app_full_name);

                textBoxAppName.Text = m_temp_app.Name;
                textBoxProducer.Text = m_temp_app.Producer;
                dateTimePickerDateInstalled.Value = m_temp_app.InstallationDate;
                textBoxVersion.Text = m_temp_app.AppVersion.ToString();
                m_temp_ci = m_temp_app.MinRequirements;
            }

            textBoxOsType.DataBindings.Add(new Binding("Text", m_temp_ci, "OSType"));
            textBoxCpuFreq.DataBindings.Add(new Binding("Text", m_temp_ci, "CpuFreq"));
            textBoxRamCapacity.DataBindings.Add(new Binding("Text", m_temp_ci, "RamCapacity"));
            textBoxGpuMem.DataBindings.Add(new Binding("Text", m_temp_ci, "GpuMem"));
        }

        /**********************************************************************************/

        private AppManager m_app_manager;
        private string m_app_full_name;
        private App m_temp_app;
        private ComputerInfo m_temp_ci;

        /**********************************************************************************/

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        /**********************************************************************************/

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string app_name = textBoxAppName.Text;
            string app_producer = textBoxProducer.Text;
            string app_version_text = textBoxVersion.Text;
            DateTime app_date_installed = dateTimePickerDateInstalled.Value;

            Version app_version;

            try
            {
                app_version = new Version(app_version_text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid version format");

                return;
            }

            try
            {
                if (m_app_full_name == null)
                {
                    m_temp_app = new App(app_name, app_producer, app_version, app_date_installed, m_temp_ci);
                    m_app_manager.AddApplication(m_temp_app);
                }
                else
                {
                    m_temp_app = m_app_manager.GetApplication(m_app_full_name);
                    m_temp_app.Name = app_name;
                    m_temp_app.Producer = app_producer;
                    m_temp_app.AppVersion = app_version;
                    m_temp_app.InstallationDate = app_date_installed;
                    m_temp_app.MinRequirements = m_temp_ci;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "invalid value");
                return;
            }

            Close();
        }

        /**********************************************************************************/

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /**********************************************************************************/



        /**********************************************************************************/

    }
}
