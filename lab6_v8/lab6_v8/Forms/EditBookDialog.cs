using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_v8.Forms
{
    public partial class EditBookDialog : Form
    {
        private Controller controller;
        private DataGridViewRow currentRow;

        int GetIndexAuthor()
        {
            string value = (string)this.currentRow.Cells["Author"].Value;
            
            int index = 0;

            foreach (string i in this.controller.AuthorNames)
            {
                if (i == value)
                {
                    return index;
                }
                else
                {
                    ++index;
                }
            }

            // if not found
            return -1;
        }

        int GetIndexPublisher()
        {
            string value = (string)this.currentRow.Cells["Publisher"].Value;

            int index = 0;

            foreach (string i in this.controller.PublisherNames)
            {
                if (i == value)
                {
                    return index;
                }
                else
                {
                    ++index;
                }
            }

            // if not found
            return -1;
        }

        private void InitializeItemData()
        {
            this.comboBoxAuthor.DataSource = this.controller.AuthorsBinding;
            this.comboBoxAuthor.DisplayMember = "Name";

            this.comboBoxPublisher.DataSource = this.controller.PublishersBinding;
            this.comboBoxPublisher.DisplayMember = "Name";

            if (this.currentRow.Cells[0].Value != null)
            {
                this.comboBoxAuthor.SelectedIndex = GetIndexAuthor();
                
                this.comboBoxPublisher.SelectedIndex = GetIndexPublisher();

                //this.textBoxTitle.Text = this.currentRow.Cells[1].Value.ToString();
                this.textBoxTitle.Text = this.currentRow.Cells["Title"].Value.ToString();

                this.numericUpDownYear.Value = int.Parse(
                    this.currentRow.Cells["Year"].Value.ToString()
                    //this.currentRow.Cells[3].Value.ToString()
                );
            }
            else
            {
                this.comboBoxAuthor.SelectedIndex = -1;

                this.comboBoxPublisher.SelectedIndex = -1;
            }
        }

        public EditBookDialog(Controller controller, DataGridViewRow row)
        {
            this.controller = controller;
            this.currentRow = row;

            InitializeComponent();
            InitializeItemData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.currentRow.SetValues(
                new object[] {
                ((Model.Author)comboBoxAuthor.SelectedValue).Name,
                textBoxTitle.Text,
                ((Model.Publisher)comboBoxPublisher.SelectedValue).Name,
                numericUpDownYear.Value
                }
            );
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
