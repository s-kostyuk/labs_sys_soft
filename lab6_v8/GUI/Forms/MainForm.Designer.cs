namespace GUI.Forms
{
    partial class MainForm
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerBooksMenu = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonModifyBook = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonAuthorsMenu = new System.Windows.Forms.Button();
            this.buttonPublishersMenu = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBooksMenu)).BeginInit();
            this.splitContainerBooksMenu.Panel1.SuspendLayout();
            this.splitContainerBooksMenu.Panel2.SuspendLayout();
            this.splitContainerBooksMenu.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Author,
            this.Title,
            this.Publisher,
            this.Year});
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(437, 212);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // splitContainerBooksMenu
            // 
            this.splitContainerBooksMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBooksMenu.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerBooksMenu.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBooksMenu.Name = "splitContainerBooksMenu";
            this.splitContainerBooksMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBooksMenu.Panel1
            // 
            this.splitContainerBooksMenu.Panel1.Controls.Add(this.dataGridViewBooks);
            // 
            // splitContainerBooksMenu.Panel2
            // 
            this.splitContainerBooksMenu.Panel2.Controls.Add(this.flowLayoutPanelButtons);
            this.splitContainerBooksMenu.Size = new System.Drawing.Size(437, 287);
            this.splitContainerBooksMenu.SplitterDistance = 212;
            this.splitContainerBooksMenu.TabIndex = 2;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAddBook);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonModifyBook);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonRemoveBook);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAuthorsMenu);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonPublishersMenu);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonStats);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(437, 71);
            this.flowLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(8, 8);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(100, 23);
            this.buttonAddBook.TabIndex = 0;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonModifyBook
            // 
            this.buttonModifyBook.Location = new System.Drawing.Point(114, 8);
            this.buttonModifyBook.Name = "buttonModifyBook";
            this.buttonModifyBook.Size = new System.Drawing.Size(100, 23);
            this.buttonModifyBook.TabIndex = 1;
            this.buttonModifyBook.Text = "Modify Book";
            this.buttonModifyBook.UseVisualStyleBackColor = true;
            this.buttonModifyBook.Click += new System.EventHandler(this.buttonModifyBook_Click);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Location = new System.Drawing.Point(220, 8);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(100, 23);
            this.buttonRemoveBook.TabIndex = 2;
            this.buttonRemoveBook.Text = "Remove Book";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // buttonAuthorsMenu
            // 
            this.buttonAuthorsMenu.Location = new System.Drawing.Point(326, 8);
            this.buttonAuthorsMenu.Name = "buttonAuthorsMenu";
            this.buttonAuthorsMenu.Size = new System.Drawing.Size(100, 23);
            this.buttonAuthorsMenu.TabIndex = 3;
            this.buttonAuthorsMenu.Text = "Authors Menu";
            this.buttonAuthorsMenu.UseVisualStyleBackColor = true;
            this.buttonAuthorsMenu.Click += new System.EventHandler(this.buttonAuthorsMenu_Click);
            // 
            // buttonPublishersMenu
            // 
            this.buttonPublishersMenu.Location = new System.Drawing.Point(8, 37);
            this.buttonPublishersMenu.Name = "buttonPublishersMenu";
            this.buttonPublishersMenu.Size = new System.Drawing.Size(100, 23);
            this.buttonPublishersMenu.TabIndex = 4;
            this.buttonPublishersMenu.Text = "Publishers Menu";
            this.buttonPublishersMenu.UseVisualStyleBackColor = true;
            this.buttonPublishersMenu.Click += new System.EventHandler(this.buttonPublishersMenu_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(114, 37);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(100, 23);
            this.buttonStats.TabIndex = 5;
            this.buttonStats.Text = "Statistics";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 287);
            this.Controls.Add(this.splitContainerBooksMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.splitContainerBooksMenu.Panel1.ResumeLayout(false);
            this.splitContainerBooksMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBooksMenu)).EndInit();
            this.splitContainerBooksMenu.ResumeLayout(false);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.SplitContainer splitContainerBooksMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonModifyBook;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonAuthorsMenu;
        private System.Windows.Forms.Button buttonPublishersMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.Button buttonStats;
    }
}