namespace lab4_v2.Forms
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
            this.tabChooser = new System.Windows.Forms.TabControl();
            this.tabPageApps = new System.Windows.Forms.TabPage();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.statusStripSysInfo = new System.Windows.Forms.StatusStrip();
            this.sysInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelApps = new System.Windows.Forms.TableLayoutPanel();
            this.listViewApps = new System.Windows.Forms.ListView();
            this.buttonAddApp = new System.Windows.Forms.Button();
            this.buttonEditApp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonRemoveAppApps = new System.Windows.Forms.Button();
            this.tabChooser.SuspendLayout();
            this.tabPageApps.SuspendLayout();
            this.statusStripSysInfo.SuspendLayout();
            this.tableLayoutPanelApps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChooser
            // 
            this.tabChooser.Controls.Add(this.tabPageApps);
            this.tabChooser.Controls.Add(this.tabPageUsers);
            this.tabChooser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChooser.Location = new System.Drawing.Point(0, 0);
            this.tabChooser.MinimumSize = new System.Drawing.Size(400, 150);
            this.tabChooser.Name = "tabChooser";
            this.tabChooser.SelectedIndex = 0;
            this.tabChooser.Size = new System.Drawing.Size(631, 311);
            this.tabChooser.TabIndex = 0;
            // 
            // tabPageApps
            // 
            this.tabPageApps.Controls.Add(this.tableLayoutPanelApps);
            this.tabPageApps.Location = new System.Drawing.Point(4, 22);
            this.tabPageApps.Name = "tabPageApps";
            this.tabPageApps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApps.Size = new System.Drawing.Size(623, 285);
            this.tabPageApps.TabIndex = 0;
            this.tabPageApps.Text = "Apps";
            this.tabPageApps.UseVisualStyleBackColor = true;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(623, 285);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // statusStripSysInfo
            // 
            this.statusStripSysInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sysInfoLabel});
            this.statusStripSysInfo.Location = new System.Drawing.Point(0, 289);
            this.statusStripSysInfo.Name = "statusStripSysInfo";
            this.statusStripSysInfo.Size = new System.Drawing.Size(631, 22);
            this.statusStripSysInfo.TabIndex = 1;
            this.statusStripSysInfo.Text = "statusStripSysInfo";
            this.statusStripSysInfo.DoubleClick += new System.EventHandler(this.statusStripSysInfo_DoubleClick);
            // 
            // sysInfoLabel
            // 
            this.sysInfoLabel.Name = "sysInfoLabel";
            this.sysInfoLabel.Size = new System.Drawing.Size(72, 17);
            this.sysInfoLabel.Text = "sysInfoLabel";
            // 
            // tableLayoutPanelApps
            // 
            this.tableLayoutPanelApps.ColumnCount = 2;
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelApps.Controls.Add(this.listViewApps, 1, 0);
            this.tableLayoutPanelApps.Controls.Add(this.buttonAddApp, 0, 0);
            this.tableLayoutPanelApps.Controls.Add(this.buttonEditApp, 0, 1);
            this.tableLayoutPanelApps.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanelApps.Controls.Add(this.buttonRemoveAppApps, 0, 3);
            this.tableLayoutPanelApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelApps.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelApps.Name = "tableLayoutPanelApps";
            this.tableLayoutPanelApps.RowCount = 5;
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelApps.Size = new System.Drawing.Size(617, 279);
            this.tableLayoutPanelApps.TabIndex = 0;
            // 
            // listViewApps
            // 
            this.listViewApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewApps.Location = new System.Drawing.Point(121, 3);
            this.listViewApps.Name = "listViewApps";
            this.tableLayoutPanelApps.SetRowSpan(this.listViewApps, 5);
            this.listViewApps.Size = new System.Drawing.Size(493, 273);
            this.listViewApps.TabIndex = 0;
            this.listViewApps.UseCompatibleStateImageBehavior = false;
            // 
            // buttonAddApp
            // 
            this.buttonAddApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddApp.Location = new System.Drawing.Point(3, 3);
            this.buttonAddApp.Name = "buttonAddApp";
            this.buttonAddApp.Size = new System.Drawing.Size(112, 24);
            this.buttonAddApp.TabIndex = 1;
            this.buttonAddApp.Text = "Add application";
            this.buttonAddApp.UseVisualStyleBackColor = true;
            // 
            // buttonEditApp
            // 
            this.buttonEditApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditApp.Location = new System.Drawing.Point(3, 33);
            this.buttonEditApp.Name = "buttonEditApp";
            this.buttonEditApp.Size = new System.Drawing.Size(112, 24);
            this.buttonEditApp.TabIndex = 2;
            this.buttonEditApp.Text = "Edit application";
            this.buttonEditApp.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Remove application";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveAppApps
            // 
            this.buttonRemoveAppApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveAppApps.Location = new System.Drawing.Point(3, 93);
            this.buttonRemoveAppApps.Name = "buttonRemoveAppApps";
            this.buttonRemoveAppApps.Size = new System.Drawing.Size(112, 24);
            this.buttonRemoveAppApps.TabIndex = 4;
            this.buttonRemoveAppApps.Text = "Remove all apps";
            this.buttonRemoveAppApps.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 311);
            this.Controls.Add(this.statusStripSysInfo);
            this.Controls.Add(this.tabChooser);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabChooser.ResumeLayout(false);
            this.tabPageApps.ResumeLayout(false);
            this.statusStripSysInfo.ResumeLayout(false);
            this.statusStripSysInfo.PerformLayout();
            this.tableLayoutPanelApps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabChooser;
        private System.Windows.Forms.TabPage tabPageApps;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.StatusStrip statusStripSysInfo;
        private System.Windows.Forms.ToolStripStatusLabel sysInfoLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelApps;
        private System.Windows.Forms.ListView listViewApps;
        private System.Windows.Forms.Button buttonAddApp;
        private System.Windows.Forms.Button buttonEditApp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonRemoveAppApps;
    }
}