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

            
        }

        /**********************************************************************************/

        private AppManager m_app_manager;
        private string m_app_full_name;
        private App m_temp_app;

        /**********************************************************************************/



        /**********************************************************************************/

    }
}
