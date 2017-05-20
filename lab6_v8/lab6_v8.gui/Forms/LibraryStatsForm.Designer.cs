namespace lab6_v8.gui.Forms
{
    partial class LibraryStatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTables = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewPublishers = new System.Windows.Forms.DataGridView();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksByAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksByPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTables
            // 
            this.panelTables.ColumnCount = 2;
            this.panelTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelTables.Controls.Add(this.dataGridViewPublishers, 1, 0);
            this.panelTables.Controls.Add(this.dataGridViewAuthors, 0, 0);
            this.panelTables.Controls.Add(this.panelButtons, 0, 1);
            this.panelTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTables.Location = new System.Drawing.Point(0, 0);
            this.panelTables.Name = "panelTables";
            this.panelTables.RowCount = 2;
            this.panelTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panelTables.Size = new System.Drawing.Size(506, 261);
            this.panelTables.TabIndex = 0;
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.AllowUserToAddRows = false;
            this.dataGridViewPublishers.AllowUserToDeleteRows = false;
            this.dataGridViewPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPublishers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.BooksByAuthor});
            this.dataGridViewPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(256, 3);
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.ReadOnly = true;
            this.dataGridViewPublishers.RowHeadersVisible = false;
            this.dataGridViewPublishers.Size = new System.Drawing.Size(247, 215);
            this.dataGridViewPublishers.TabIndex = 1;
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AllowUserToDeleteRows = false;
            this.dataGridViewAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAuthors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Publisher,
            this.BooksByPublisher});
            this.dataGridViewAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.ReadOnly = true;
            this.dataGridViewAuthors.RowHeadersVisible = false;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(247, 215);
            this.dataGridViewAuthors.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelTables.SetColumnSpan(this.panelButtons, 2);
            this.panelButtons.Controls.Add(this.buttonUpdate);
            this.panelButtons.Controls.Add(this.buttonClose);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 224);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(500, 34);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(3, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(109, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Name";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // BooksByAuthor
            // 
            this.BooksByAuthor.DataPropertyName = "Count";
            this.BooksByAuthor.HeaderText = "Books";
            this.BooksByAuthor.Name = "BooksByAuthor";
            this.BooksByAuthor.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Name";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // BooksByPublisher
            // 
            this.BooksByPublisher.DataPropertyName = "Count";
            this.BooksByPublisher.HeaderText = "Books";
            this.BooksByPublisher.Name = "BooksByPublisher";
            this.BooksByPublisher.ReadOnly = true;
            // 
            // LibraryStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 261);
            this.Controls.Add(this.panelTables);
            this.Name = "LibraryStats";
            this.Text = "LibraryStats";
            this.panelTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelTables;
        private System.Windows.Forms.DataGridView dataGridViewPublishers;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksByAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksByPublisher;
    }
}