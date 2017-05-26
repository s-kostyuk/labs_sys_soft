using System;
using System.Windows.Forms;

/*****************************************************************************/

namespace lab8_v5.gui.Forms
{
    public partial class LibraryStatsForm : Form
    {
        /*-------------------------------------------------------------------*/

        public LibraryStatsForm(StatsViewProvider stats)
        {
            InitializeComponent();

            this.stats = stats;

            author_stats_binding = new BindingSource();
            publisher_stats_binding = new BindingSource();
            
            UpdateAuthors();
            UpdatePublishers();

            dataGridViewAuthors.DataSource = author_stats_binding;
            dataGridViewPublishers.DataSource = publisher_stats_binding;
        }

        /*-------------------------------------------------------------------*/

        private StatsViewProvider stats;
        private BindingSource author_stats_binding;
        private BindingSource publisher_stats_binding;

        /*-------------------------------------------------------------------*/

        private void UpdateAuthors()
        {
            author_stats_binding.Clear();
            author_stats_binding.DataSource = stats.AuthorStats;
        }

        /*-------------------------------------------------------------------*/

        private void UpdatePublishers()
        {
            publisher_stats_binding.Clear();
            publisher_stats_binding.DataSource = stats.PublisherStats;
        }

        /*-------------------------------------------------------------------*/

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateAuthors();
            UpdatePublishers();
        }

        /*-------------------------------------------------------------------*/

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*-------------------------------------------------------------------*/
    }
}

/*****************************************************************************/
