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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStripSysInfo = new System.Windows.Forms.StatusStrip();
            this.sysInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabChooser.SuspendLayout();
            this.statusStripSysInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChooser
            // 
            this.tabChooser.Controls.Add(this.tabPage1);
            this.tabChooser.Controls.Add(this.tabPage2);
            this.tabChooser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChooser.Location = new System.Drawing.Point(0, 0);
            this.tabChooser.MinimumSize = new System.Drawing.Size(400, 150);
            this.tabChooser.Name = "tabChooser";
            this.tabChooser.SelectedIndex = 0;
            this.tabChooser.Size = new System.Drawing.Size(631, 311);
            this.tabChooser.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Apps";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.statusStripSysInfo.ResumeLayout(false);
            this.statusStripSysInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabChooser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStripSysInfo;
        private System.Windows.Forms.ToolStripStatusLabel sysInfoLabel;
    }
}