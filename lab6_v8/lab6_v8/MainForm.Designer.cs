namespace lab6_v8
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.splitContainerBooksMenu = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonModifyBook = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonAuthorsMenu = new System.Windows.Forms.Button();
            this.buttonPublishersMenu = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumnAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnAuthor,
            this.dataGridViewTextBoxColumnTitle,
            this.dataGridViewTextBoxColumnPublisher,
            this.dataGridViewTextBoxColumnYear});
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(546, 190);
            this.dataGridViewBooks.TabIndex = 0;
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
            this.splitContainerBooksMenu.Size = new System.Drawing.Size(546, 234);
            this.splitContainerBooksMenu.SplitterDistance = 190;
            this.splitContainerBooksMenu.TabIndex = 1;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAddBook);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonModifyBook);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonRemoveBook);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonAuthorsMenu);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonPublishersMenu);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(546, 40);
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
            // 
            // buttonModifyBook
            // 
            this.buttonModifyBook.Location = new System.Drawing.Point(114, 8);
            this.buttonModifyBook.Name = "buttonModifyBook";
            this.buttonModifyBook.Size = new System.Drawing.Size(100, 23);
            this.buttonModifyBook.TabIndex = 1;
            this.buttonModifyBook.Text = "Modify Book";
            this.buttonModifyBook.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Location = new System.Drawing.Point(220, 8);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(100, 23);
            this.buttonRemoveBook.TabIndex = 2;
            this.buttonRemoveBook.Text = "Remove Book";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            // 
            // buttonAuthorsMenu
            // 
            this.buttonAuthorsMenu.Location = new System.Drawing.Point(326, 8);
            this.buttonAuthorsMenu.Name = "buttonAuthorsMenu";
            this.buttonAuthorsMenu.Size = new System.Drawing.Size(100, 23);
            this.buttonAuthorsMenu.TabIndex = 3;
            this.buttonAuthorsMenu.Text = "Authors Menu";
            this.buttonAuthorsMenu.UseVisualStyleBackColor = true;
            // 
            // buttonPublishersMenu
            // 
            this.buttonPublishersMenu.Location = new System.Drawing.Point(432, 8);
            this.buttonPublishersMenu.Name = "buttonPublishersMenu";
            this.buttonPublishersMenu.Size = new System.Drawing.Size(100, 23);
            this.buttonPublishersMenu.TabIndex = 4;
            this.buttonPublishersMenu.Text = "Publishers Menu";
            this.buttonPublishersMenu.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumnAuthor
            // 
            this.dataGridViewTextBoxColumnAuthor.HeaderText = "Author";
            this.dataGridViewTextBoxColumnAuthor.Name = "dataGridViewTextBoxColumnAuthor";
            this.dataGridViewTextBoxColumnAuthor.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnTitle
            // 
            this.dataGridViewTextBoxColumnTitle.HeaderText = "Title";
            this.dataGridViewTextBoxColumnTitle.Name = "dataGridViewTextBoxColumnTitle";
            this.dataGridViewTextBoxColumnTitle.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnPublisher
            // 
            this.dataGridViewTextBoxColumnPublisher.HeaderText = "Publisher";
            this.dataGridViewTextBoxColumnPublisher.Name = "dataGridViewTextBoxColumnPublisher";
            this.dataGridViewTextBoxColumnPublisher.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnYear
            // 
            this.dataGridViewTextBoxColumnYear.HeaderText = "Year";
            this.dataGridViewTextBoxColumnYear.Name = "dataGridViewTextBoxColumnYear";
            this.dataGridViewTextBoxColumnYear.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 234);
            this.Controls.Add(this.splitContainerBooksMenu);
            this.Name = "MainForm";
            this.Text = "Lab 6: LINQ";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnYear;
    }
}

