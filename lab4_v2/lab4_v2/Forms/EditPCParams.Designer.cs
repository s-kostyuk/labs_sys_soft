namespace lab4_v2.Forms
{
    partial class EditPCParams
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxCpuFreq = new System.Windows.Forms.TextBox();
            this.textBoxRamCapacity = new System.Windows.Forms.TextBox();
            this.textBoxGpuMem = new System.Windows.Forms.TextBox();
            this.textBoxOsType = new System.Windows.Forms.TextBox();
            this.labelCpuFreq = new System.Windows.Forms.Label();
            this.labelRamCapacity = new System.Windows.Forms.Label();
            this.labelOsType = new System.Windows.Forms.Label();
            this.labelGpuMem = new System.Windows.Forms.Label();
            this.pcParamsEditPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pcParamsEditPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxCpuFreq, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRamCapacity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGpuMem, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOsType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCpuFreq, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRamCapacity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelOsType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelGpuMem, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 109);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxCpuFreq
            // 
            this.textBoxCpuFreq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCpuFreq.Location = new System.Drawing.Point(103, 3);
            this.textBoxCpuFreq.Name = "textBoxCpuFreq";
            this.textBoxCpuFreq.Size = new System.Drawing.Size(154, 20);
            this.textBoxCpuFreq.TabIndex = 0;
            // 
            // textBoxRamCapacity
            // 
            this.textBoxRamCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRamCapacity.Location = new System.Drawing.Point(103, 30);
            this.textBoxRamCapacity.Name = "textBoxRamCapacity";
            this.textBoxRamCapacity.Size = new System.Drawing.Size(154, 20);
            this.textBoxRamCapacity.TabIndex = 1;
            // 
            // textBoxGpuMem
            // 
            this.textBoxGpuMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGpuMem.Location = new System.Drawing.Point(103, 57);
            this.textBoxGpuMem.Name = "textBoxGpuMem";
            this.textBoxGpuMem.Size = new System.Drawing.Size(154, 20);
            this.textBoxGpuMem.TabIndex = 2;
            // 
            // textBoxOsType
            // 
            this.textBoxOsType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOsType.Location = new System.Drawing.Point(103, 84);
            this.textBoxOsType.Name = "textBoxOsType";
            this.textBoxOsType.Size = new System.Drawing.Size(154, 20);
            this.textBoxOsType.TabIndex = 3;
            // 
            // labelCpuFreq
            // 
            this.labelCpuFreq.AutoSize = true;
            this.labelCpuFreq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCpuFreq.Location = new System.Drawing.Point(3, 0);
            this.labelCpuFreq.Name = "labelCpuFreq";
            this.labelCpuFreq.Size = new System.Drawing.Size(94, 27);
            this.labelCpuFreq.TabIndex = 4;
            this.labelCpuFreq.Text = "CPU Frequency:";
            this.labelCpuFreq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRamCapacity
            // 
            this.labelRamCapacity.AutoSize = true;
            this.labelRamCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRamCapacity.Location = new System.Drawing.Point(3, 27);
            this.labelRamCapacity.Name = "labelRamCapacity";
            this.labelRamCapacity.Size = new System.Drawing.Size(94, 27);
            this.labelRamCapacity.TabIndex = 5;
            this.labelRamCapacity.Text = "RAM Capacity:";
            this.labelRamCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOsType
            // 
            this.labelOsType.AutoSize = true;
            this.labelOsType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOsType.Location = new System.Drawing.Point(3, 81);
            this.labelOsType.Name = "labelOsType";
            this.labelOsType.Size = new System.Drawing.Size(94, 28);
            this.labelOsType.TabIndex = 7;
            this.labelOsType.Text = "OS:";
            this.labelOsType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGpuMem
            // 
            this.labelGpuMem.AutoSize = true;
            this.labelGpuMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGpuMem.Location = new System.Drawing.Point(3, 54);
            this.labelGpuMem.Name = "labelGpuMem";
            this.labelGpuMem.Size = new System.Drawing.Size(94, 27);
            this.labelGpuMem.TabIndex = 6;
            this.labelGpuMem.Text = "GPU Memory:";
            this.labelGpuMem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcParamsEditPanel
            // 
            this.pcParamsEditPanel.Controls.Add(this.tableLayoutPanel2);
            this.pcParamsEditPanel.Controls.Add(this.tableLayoutPanel1);
            this.pcParamsEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcParamsEditPanel.Location = new System.Drawing.Point(0, 0);
            this.pcParamsEditPanel.Name = "pcParamsEditPanel";
            this.pcParamsEditPanel.Size = new System.Drawing.Size(284, 261);
            this.pcParamsEditPanel.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.buttonReset, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonApply, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 213);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 36);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(3, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 30);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(89, 3);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(80, 30);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(175, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 30);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditPCParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pcParamsEditPanel);
            this.Name = "EditPCParams";
            this.Text = "EditPCParams";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pcParamsEditPanel.ResumeLayout(false);
            this.pcParamsEditPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxCpuFreq;
        private System.Windows.Forms.TextBox textBoxRamCapacity;
        private System.Windows.Forms.TextBox textBoxGpuMem;
        private System.Windows.Forms.TextBox textBoxOsType;
        private System.Windows.Forms.Label labelCpuFreq;
        private System.Windows.Forms.Label labelRamCapacity;
        private System.Windows.Forms.Label labelOsType;
        private System.Windows.Forms.Label labelGpuMem;
        private System.Windows.Forms.Panel pcParamsEditPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
    }
}