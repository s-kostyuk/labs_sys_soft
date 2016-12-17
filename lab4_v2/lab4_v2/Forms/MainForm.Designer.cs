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
            this.tableLayoutPanelApps = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUpdateApp = new System.Windows.Forms.Button();
            this.buttonAddApp = new System.Windows.Forms.Button();
            this.buttonEditApp = new System.Windows.Forms.Button();
            this.buttonRemoveApp = new System.Windows.Forms.Button();
            this.buttonRemoveAppApps = new System.Windows.Forms.Button();
            this.listBoxApps = new System.Windows.Forms.ListBox();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelUsers = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.buttonRmUser = new System.Windows.Forms.Button();
            this.buttonRmAllUsers = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.statusStripSysInfo = new System.Windows.Forms.StatusStrip();
            this.sysInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonEditUserApps = new System.Windows.Forms.Button();
            this.tabChooser.SuspendLayout();
            this.tabPageApps.SuspendLayout();
            this.tableLayoutPanelApps.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tableLayoutPanelUsers.SuspendLayout();
            this.statusStripSysInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChooser
            // 
            this.tabChooser.Controls.Add(this.tabPageApps);
            this.tabChooser.Controls.Add(this.tabPageUsers);
            this.tabChooser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChooser.Location = new System.Drawing.Point(0, 0);
            this.tabChooser.MinimumSize = new System.Drawing.Size(400, 150);
            this.tabChooser.Multiline = true;
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
            // tableLayoutPanelApps
            // 
            this.tableLayoutPanelApps.ColumnCount = 2;
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanelApps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelApps.Controls.Add(this.buttonUpdateApp, 0, 4);
            this.tableLayoutPanelApps.Controls.Add(this.buttonAddApp, 0, 0);
            this.tableLayoutPanelApps.Controls.Add(this.buttonEditApp, 0, 1);
            this.tableLayoutPanelApps.Controls.Add(this.buttonRemoveApp, 0, 2);
            this.tableLayoutPanelApps.Controls.Add(this.buttonRemoveAppApps, 0, 3);
            this.tableLayoutPanelApps.Controls.Add(this.listBoxApps, 1, 0);
            this.tableLayoutPanelApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelApps.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelApps.Name = "tableLayoutPanelApps";
            this.tableLayoutPanelApps.RowCount = 6;
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelApps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelApps.Size = new System.Drawing.Size(617, 279);
            this.tableLayoutPanelApps.TabIndex = 0;
            // 
            // buttonUpdateApp
            // 
            this.buttonUpdateApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpdateApp.Location = new System.Drawing.Point(3, 123);
            this.buttonUpdateApp.Name = "buttonUpdateApp";
            this.buttonUpdateApp.Size = new System.Drawing.Size(112, 24);
            this.buttonUpdateApp.TabIndex = 6;
            this.buttonUpdateApp.Text = "Update app";
            this.buttonUpdateApp.UseVisualStyleBackColor = true;
            this.buttonUpdateApp.Click += new System.EventHandler(this.buttonUpdateApp_Click);
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
            this.buttonAddApp.Click += new System.EventHandler(this.buttonAddApp_Click);
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
            this.buttonEditApp.Click += new System.EventHandler(this.buttonEditApp_Click);
            // 
            // buttonRemoveApp
            // 
            this.buttonRemoveApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveApp.Location = new System.Drawing.Point(3, 63);
            this.buttonRemoveApp.Name = "buttonRemoveApp";
            this.buttonRemoveApp.Size = new System.Drawing.Size(112, 24);
            this.buttonRemoveApp.TabIndex = 3;
            this.buttonRemoveApp.Text = "Remove application";
            this.buttonRemoveApp.UseVisualStyleBackColor = true;
            this.buttonRemoveApp.Click += new System.EventHandler(this.buttonRemoveApp_Click);
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
            this.buttonRemoveAppApps.Click += new System.EventHandler(this.buttonRemoveAllApps_Click);
            // 
            // listBoxApps
            // 
            this.listBoxApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxApps.FormattingEnabled = true;
            this.listBoxApps.Location = new System.Drawing.Point(121, 3);
            this.listBoxApps.Name = "listBoxApps";
            this.tableLayoutPanelApps.SetRowSpan(this.listBoxApps, 6);
            this.listBoxApps.Size = new System.Drawing.Size(493, 273);
            this.listBoxApps.TabIndex = 5;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.tableLayoutPanelUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(623, 285);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelUsers
            // 
            this.tableLayoutPanelUsers.ColumnCount = 2;
            this.tableLayoutPanelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanelUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUsers.Controls.Add(this.buttonEditUserApps, 0, 4);
            this.tableLayoutPanelUsers.Controls.Add(this.buttonAddUser, 0, 0);
            this.tableLayoutPanelUsers.Controls.Add(this.buttonEditUser, 0, 1);
            this.tableLayoutPanelUsers.Controls.Add(this.buttonRmUser, 0, 2);
            this.tableLayoutPanelUsers.Controls.Add(this.buttonRmAllUsers, 0, 3);
            this.tableLayoutPanelUsers.Controls.Add(this.listBoxUsers, 1, 0);
            this.tableLayoutPanelUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUsers.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelUsers.Name = "tableLayoutPanelUsers";
            this.tableLayoutPanelUsers.RowCount = 6;
            this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUsers.Size = new System.Drawing.Size(617, 279);
            this.tableLayoutPanelUsers.TabIndex = 0;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddUser.Location = new System.Drawing.Point(3, 3);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(112, 24);
            this.buttonAddUser.TabIndex = 0;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditUser.Location = new System.Drawing.Point(3, 33);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(112, 24);
            this.buttonEditUser.TabIndex = 1;
            this.buttonEditUser.Text = "Edit user";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            this.buttonEditUser.Click += new System.EventHandler(this.buttonEditUser_Click);
            // 
            // buttonRmUser
            // 
            this.buttonRmUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRmUser.Location = new System.Drawing.Point(3, 63);
            this.buttonRmUser.Name = "buttonRmUser";
            this.buttonRmUser.Size = new System.Drawing.Size(112, 24);
            this.buttonRmUser.TabIndex = 2;
            this.buttonRmUser.Text = "Remove user";
            this.buttonRmUser.UseVisualStyleBackColor = true;
            this.buttonRmUser.Click += new System.EventHandler(this.buttonRmUser_Click);
            // 
            // buttonRmAllUsers
            // 
            this.buttonRmAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRmAllUsers.Location = new System.Drawing.Point(3, 93);
            this.buttonRmAllUsers.Name = "buttonRmAllUsers";
            this.buttonRmAllUsers.Size = new System.Drawing.Size(112, 24);
            this.buttonRmAllUsers.TabIndex = 3;
            this.buttonRmAllUsers.Text = "Remove all users";
            this.buttonRmAllUsers.UseVisualStyleBackColor = true;
            this.buttonRmAllUsers.Click += new System.EventHandler(this.buttonRmAllUsers_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(121, 3);
            this.listBoxUsers.Name = "listBoxUsers";
            this.tableLayoutPanelUsers.SetRowSpan(this.listBoxUsers, 6);
            this.listBoxUsers.Size = new System.Drawing.Size(493, 273);
            this.listBoxUsers.TabIndex = 4;
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
            // buttonEditUserApps
            // 
            this.buttonEditUserApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditUserApps.Location = new System.Drawing.Point(3, 123);
            this.buttonEditUserApps.Name = "buttonEditUserApps";
            this.buttonEditUserApps.Size = new System.Drawing.Size(112, 24);
            this.buttonEditUserApps.TabIndex = 5;
            this.buttonEditUserApps.Text = "Edit user apps";
            this.buttonEditUserApps.UseVisualStyleBackColor = true;
            this.buttonEditUserApps.Click += new System.EventHandler(this.buttonEditUserApps_Click);
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
            this.tableLayoutPanelApps.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tableLayoutPanelUsers.ResumeLayout(false);
            this.statusStripSysInfo.ResumeLayout(false);
            this.statusStripSysInfo.PerformLayout();
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
        private System.Windows.Forms.Button buttonAddApp;
        private System.Windows.Forms.Button buttonEditApp;
        private System.Windows.Forms.Button buttonRemoveApp;
        private System.Windows.Forms.Button buttonRemoveAppApps;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.Button buttonRmUser;
        private System.Windows.Forms.Button buttonRmAllUsers;
        private System.Windows.Forms.ListBox listBoxApps;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button buttonUpdateApp;
        private System.Windows.Forms.Button buttonEditUserApps;
    }
}