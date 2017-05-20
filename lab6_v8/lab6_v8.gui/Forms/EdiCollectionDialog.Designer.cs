namespace lab6_v8.gui.Forms
{
    partial class EditCollectionDialog
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
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNotice = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.splitContainerBooksMenu = new System.Windows.Forms.SplitContainer();
            this.dataGridViewPublishers = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBooksMenu)).BeginInit();
            this.splitContainerBooksMenu.Panel1.SuspendLayout();
            this.splitContainerBooksMenu.Panel2.SuspendLayout();
            this.splitContainerBooksMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.labelNotice);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonOK);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(277, 40);
            this.flowLayoutPanelButtons.TabIndex = 0;
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNotice.Location = new System.Drawing.Point(8, 5);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(94, 29);
            this.labelNotice.TabIndex = 1;
            this.labelNotice.Text = "All changes saved";
            this.labelNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(108, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
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
            this.splitContainerBooksMenu.Panel1.Controls.Add(this.dataGridViewPublishers);
            // 
            // splitContainerBooksMenu.Panel2
            // 
            this.splitContainerBooksMenu.Panel2.Controls.Add(this.flowLayoutPanelButtons);
            this.splitContainerBooksMenu.Size = new System.Drawing.Size(277, 261);
            this.splitContainerBooksMenu.SplitterDistance = 217;
            this.splitContainerBooksMenu.TabIndex = 3;
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPublishers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPublishers.Size = new System.Drawing.Size(277, 217);
            this.dataGridViewPublishers.TabIndex = 1;
            // 
            // EditCollectionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 261);
            this.Controls.Add(this.splitContainerBooksMenu);
            this.Name = "EditCollectionDialog";
            this.Text = "EditCollectionDialog";
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.flowLayoutPanelButtons.PerformLayout();
            this.splitContainerBooksMenu.Panel1.ResumeLayout(false);
            this.splitContainerBooksMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBooksMenu)).EndInit();
            this.splitContainerBooksMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.SplitContainer splitContainerBooksMenu;
        private System.Windows.Forms.DataGridView dataGridViewPublishers;
        private System.Windows.Forms.Label labelNotice;
    }
}