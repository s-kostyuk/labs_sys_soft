namespace lab4_v2.Forms
{
    partial class EditUserApps
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
            this.tableLayoutPanelUserApps = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxAllApps = new System.Windows.Forms.ListBox();
            this.listBoxAllowedApps = new System.Windows.Forms.ListBox();
            this.buttonAddApp = new System.Windows.Forms.Button();
            this.buttonRemoveApp = new System.Windows.Forms.Button();
            this.tableLayoutPanelUserApps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelUserApps
            // 
            this.tableLayoutPanelUserApps.ColumnCount = 3;
            this.tableLayoutPanelUserApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUserApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelUserApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUserApps.Controls.Add(this.listBoxAllApps, 0, 0);
            this.tableLayoutPanelUserApps.Controls.Add(this.listBoxAllowedApps, 2, 0);
            this.tableLayoutPanelUserApps.Controls.Add(this.buttonAddApp, 1, 0);
            this.tableLayoutPanelUserApps.Controls.Add(this.buttonRemoveApp, 1, 1);
            this.tableLayoutPanelUserApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUserApps.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUserApps.Name = "tableLayoutPanelUserApps";
            this.tableLayoutPanelUserApps.RowCount = 3;
            this.tableLayoutPanelUserApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserApps.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanelUserApps.TabIndex = 0;
            // 
            // listBoxAllApps
            // 
            this.listBoxAllApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAllApps.FormattingEnabled = true;
            this.listBoxAllApps.Location = new System.Drawing.Point(3, 3);
            this.listBoxAllApps.Name = "listBoxAllApps";
            this.tableLayoutPanelUserApps.SetRowSpan(this.listBoxAllApps, 3);
            this.listBoxAllApps.Size = new System.Drawing.Size(111, 255);
            this.listBoxAllApps.TabIndex = 0;
            // 
            // listBoxAllowedApps
            // 
            this.listBoxAllowedApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAllowedApps.FormattingEnabled = true;
            this.listBoxAllowedApps.Location = new System.Drawing.Point(170, 3);
            this.listBoxAllowedApps.Name = "listBoxAllowedApps";
            this.tableLayoutPanelUserApps.SetRowSpan(this.listBoxAllowedApps, 3);
            this.listBoxAllowedApps.Size = new System.Drawing.Size(111, 255);
            this.listBoxAllowedApps.TabIndex = 1;
            // 
            // buttonAddApp
            // 
            this.buttonAddApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddApp.Location = new System.Drawing.Point(120, 3);
            this.buttonAddApp.Name = "buttonAddApp";
            this.buttonAddApp.Size = new System.Drawing.Size(44, 24);
            this.buttonAddApp.TabIndex = 2;
            this.buttonAddApp.Text = ">>";
            this.buttonAddApp.UseVisualStyleBackColor = true;
            this.buttonAddApp.Click += new System.EventHandler(this.buttonAddApp_Click);
            // 
            // buttonRemoveApp
            // 
            this.buttonRemoveApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveApp.Location = new System.Drawing.Point(120, 33);
            this.buttonRemoveApp.Name = "buttonRemoveApp";
            this.buttonRemoveApp.Size = new System.Drawing.Size(44, 24);
            this.buttonRemoveApp.TabIndex = 3;
            this.buttonRemoveApp.Text = "<<";
            this.buttonRemoveApp.UseVisualStyleBackColor = true;
            this.buttonRemoveApp.Click += new System.EventHandler(this.buttonRemoveApp_Click);
            // 
            // EditUserApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanelUserApps);
            this.Name = "EditUserApps";
            this.Text = "EditUserApps";
            this.tableLayoutPanelUserApps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserApps;
        private System.Windows.Forms.ListBox listBoxAllApps;
        private System.Windows.Forms.ListBox listBoxAllowedApps;
        private System.Windows.Forms.Button buttonAddApp;
        private System.Windows.Forms.Button buttonRemoveApp;
    }
}