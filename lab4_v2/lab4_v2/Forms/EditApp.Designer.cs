namespace lab4_v2.Forms
{
    partial class EditApp
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
            this.buttonReset = new System.Windows.Forms.Button();
            this.pcParamsEditPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxOsType = new System.Windows.Forms.TextBox();
            this.textBoxCpuFreq = new System.Windows.Forms.TextBox();
            this.textBoxRamCapacity = new System.Windows.Forms.TextBox();
            this.textBoxGpuMem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateInstalled = new System.Windows.Forms.Label();
            this.textBoxAppName = new System.Windows.Forms.TextBox();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.dateTimePickerDateInstalled = new System.Windows.Forms.DateTimePicker();
            this.pcParamsEditPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(3, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 30);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // pcParamsEditPanel
            // 
            this.pcParamsEditPanel.Controls.Add(this.tableLayoutPanel2);
            this.pcParamsEditPanel.Controls.Add(this.tableLayoutPanel1);
            this.pcParamsEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcParamsEditPanel.Location = new System.Drawing.Point(0, 0);
            this.pcParamsEditPanel.Name = "pcParamsEditPanel";
            this.pcParamsEditPanel.Size = new System.Drawing.Size(309, 331);
            this.pcParamsEditPanel.TabIndex = 3;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 283);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 36);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(97, 3);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(89, 30);
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
            this.buttonCancel.Location = new System.Drawing.Point(192, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 30);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxOsType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCpuFreq, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRamCapacity, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGpuMem, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelDateInstalled, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAppName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProducer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVersion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAppName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProducer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVersion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDateInstalled, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxOsType
            // 
            this.textBoxOsType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOsType.Location = new System.Drawing.Point(103, 123);
            this.textBoxOsType.Name = "textBoxOsType";
            this.textBoxOsType.Size = new System.Drawing.Size(179, 20);
            this.textBoxOsType.TabIndex = 16;
            // 
            // textBoxCpuFreq
            // 
            this.textBoxCpuFreq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCpuFreq.Location = new System.Drawing.Point(103, 153);
            this.textBoxCpuFreq.Name = "textBoxCpuFreq";
            this.textBoxCpuFreq.Size = new System.Drawing.Size(179, 20);
            this.textBoxCpuFreq.TabIndex = 15;
            // 
            // textBoxRamCapacity
            // 
            this.textBoxRamCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRamCapacity.Location = new System.Drawing.Point(103, 183);
            this.textBoxRamCapacity.Name = "textBoxRamCapacity";
            this.textBoxRamCapacity.Size = new System.Drawing.Size(179, 20);
            this.textBoxRamCapacity.TabIndex = 14;
            // 
            // textBoxGpuMem
            // 
            this.textBoxGpuMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGpuMem.Location = new System.Drawing.Point(103, 213);
            this.textBoxGpuMem.Name = "textBoxGpuMem";
            this.textBoxGpuMem.Size = new System.Drawing.Size(179, 20);
            this.textBoxGpuMem.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "GPU memory:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "RAM Capacity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "OS type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPU frequency:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDateInstalled
            // 
            this.labelDateInstalled.AutoSize = true;
            this.labelDateInstalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDateInstalled.Location = new System.Drawing.Point(3, 90);
            this.labelDateInstalled.Name = "labelDateInstalled";
            this.labelDateInstalled.Size = new System.Drawing.Size(94, 30);
            this.labelDateInstalled.TabIndex = 7;
            this.labelDateInstalled.Text = "Date installed:";
            this.labelDateInstalled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAppName
            // 
            this.textBoxAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAppName.Location = new System.Drawing.Point(103, 3);
            this.textBoxAppName.Name = "textBoxAppName";
            this.textBoxAppName.Size = new System.Drawing.Size(179, 20);
            this.textBoxAppName.TabIndex = 0;
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProducer.Location = new System.Drawing.Point(103, 33);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(179, 20);
            this.textBoxProducer.TabIndex = 1;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVersion.Location = new System.Drawing.Point(103, 63);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.Size = new System.Drawing.Size(179, 20);
            this.textBoxVersion.TabIndex = 2;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAppName.Location = new System.Drawing.Point(3, 0);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(94, 30);
            this.labelAppName.TabIndex = 4;
            this.labelAppName.Text = "Name:";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProducer.Location = new System.Drawing.Point(3, 30);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(94, 30);
            this.labelProducer.TabIndex = 5;
            this.labelProducer.Text = "Producer";
            this.labelProducer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(3, 60);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(94, 30);
            this.labelVersion.TabIndex = 6;
            this.labelVersion.Text = "Version:";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerDateInstalled
            // 
            this.dateTimePickerDateInstalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerDateInstalled.Location = new System.Drawing.Point(103, 93);
            this.dateTimePickerDateInstalled.Name = "dateTimePickerDateInstalled";
            this.dateTimePickerDateInstalled.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerDateInstalled.TabIndex = 8;
            // 
            // EditApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 331);
            this.Controls.Add(this.pcParamsEditPanel);
            this.Name = "EditApp";
            this.Text = "EditApp";
            this.pcParamsEditPanel.ResumeLayout(false);
            this.pcParamsEditPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel pcParamsEditPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxAppName;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelDateInstalled;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateInstalled;
        private System.Windows.Forms.TextBox textBoxOsType;
        private System.Windows.Forms.TextBox textBoxCpuFreq;
        private System.Windows.Forms.TextBox textBoxRamCapacity;
        private System.Windows.Forms.TextBox textBoxGpuMem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}