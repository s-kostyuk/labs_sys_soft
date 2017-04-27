namespace lab5_v8_gui
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
            this.generateBox = new System.Windows.Forms.GroupBox();
            this.buttonGenerateSource2 = new System.Windows.Forms.Button();
            this.buttonGenerateSource1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOpenSource2 = new System.Windows.Forms.Button();
            this.buttonOpenSource1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxSource2 = new System.Windows.Forms.ListBox();
            this.listBoxSource1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxMerged = new System.Windows.Forms.ListBox();
            this.buttonGenerateMerged = new System.Windows.Forms.Button();
            this.generateBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateBox
            // 
            this.generateBox.Controls.Add(this.buttonGenerateSource2);
            this.generateBox.Controls.Add(this.buttonGenerateSource1);
            this.generateBox.Location = new System.Drawing.Point(12, 12);
            this.generateBox.Name = "generateBox";
            this.generateBox.Size = new System.Drawing.Size(249, 54);
            this.generateBox.TabIndex = 0;
            this.generateBox.TabStop = false;
            this.generateBox.Text = "Generate Sources";
            // 
            // buttonGenerateSource2
            // 
            this.buttonGenerateSource2.Location = new System.Drawing.Point(132, 19);
            this.buttonGenerateSource2.Name = "buttonGenerateSource2";
            this.buttonGenerateSource2.Size = new System.Drawing.Size(104, 23);
            this.buttonGenerateSource2.TabIndex = 1;
            this.buttonGenerateSource2.Text = "Generate Second";
            this.buttonGenerateSource2.UseVisualStyleBackColor = true;
            this.buttonGenerateSource2.Click += new System.EventHandler(this.buttonGenerateSource2_Click);
            // 
            // buttonGenerateSource1
            // 
            this.buttonGenerateSource1.Location = new System.Drawing.Point(12, 19);
            this.buttonGenerateSource1.Name = "buttonGenerateSource1";
            this.buttonGenerateSource1.Size = new System.Drawing.Size(104, 23);
            this.buttonGenerateSource1.TabIndex = 0;
            this.buttonGenerateSource1.Text = "Generate First";
            this.buttonGenerateSource1.UseVisualStyleBackColor = true;
            this.buttonGenerateSource1.Click += new System.EventHandler(this.buttonGenerateSource1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOpenSource2);
            this.groupBox1.Controls.Add(this.buttonOpenSource1);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Open Sources";
            // 
            // buttonOpenSource2
            // 
            this.buttonOpenSource2.Location = new System.Drawing.Point(132, 19);
            this.buttonOpenSource2.Name = "buttonOpenSource2";
            this.buttonOpenSource2.Size = new System.Drawing.Size(104, 23);
            this.buttonOpenSource2.TabIndex = 1;
            this.buttonOpenSource2.Text = "Open Second";
            this.buttonOpenSource2.UseVisualStyleBackColor = true;
            this.buttonOpenSource2.Click += new System.EventHandler(this.buttonOpenSource2_Click);
            // 
            // buttonOpenSource1
            // 
            this.buttonOpenSource1.Location = new System.Drawing.Point(12, 19);
            this.buttonOpenSource1.Name = "buttonOpenSource1";
            this.buttonOpenSource1.Size = new System.Drawing.Size(104, 23);
            this.buttonOpenSource1.TabIndex = 0;
            this.buttonOpenSource1.Text = "Open First";
            this.buttonOpenSource1.UseVisualStyleBackColor = true;
            this.buttonOpenSource1.Click += new System.EventHandler(this.buttonOpenSource1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxSource2);
            this.groupBox2.Controls.Add(this.listBoxSource1);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // listBoxSource2
            // 
            this.listBoxSource2.FormattingEnabled = true;
            this.listBoxSource2.Location = new System.Drawing.Point(132, 19);
            this.listBoxSource2.Name = "listBoxSource2";
            this.listBoxSource2.Size = new System.Drawing.Size(104, 95);
            this.listBoxSource2.TabIndex = 1;
            // 
            // listBoxSource1
            // 
            this.listBoxSource1.FormattingEnabled = true;
            this.listBoxSource1.Location = new System.Drawing.Point(12, 19);
            this.listBoxSource1.Name = "listBoxSource1";
            this.listBoxSource1.Size = new System.Drawing.Size(104, 95);
            this.listBoxSource1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxMerged);
            this.groupBox3.Controls.Add(this.buttonGenerateMerged);
            this.groupBox3.Location = new System.Drawing.Point(271, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 295);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Merged File";
            // 
            // listBoxMerged
            // 
            this.listBoxMerged.FormattingEnabled = true;
            this.listBoxMerged.Location = new System.Drawing.Point(12, 85);
            this.listBoxMerged.Name = "listBoxMerged";
            this.listBoxMerged.Size = new System.Drawing.Size(104, 186);
            this.listBoxMerged.TabIndex = 2;
            // 
            // buttonGenerateMerged
            // 
            this.buttonGenerateMerged.Location = new System.Drawing.Point(12, 19);
            this.buttonGenerateMerged.Name = "buttonGenerateMerged";
            this.buttonGenerateMerged.Size = new System.Drawing.Size(104, 23);
            this.buttonGenerateMerged.TabIndex = 0;
            this.buttonGenerateMerged.Text = "Generate Merged";
            this.buttonGenerateMerged.UseVisualStyleBackColor = true;
            this.buttonGenerateMerged.Click += new System.EventHandler(this.buttonGenerateMerged_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 319);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generateBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.generateBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox generateBox;
        private System.Windows.Forms.Button buttonGenerateSource2;
        private System.Windows.Forms.Button buttonGenerateSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOpenSource2;
        private System.Windows.Forms.Button buttonOpenSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxSource2;
        private System.Windows.Forms.ListBox listBoxSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGenerateMerged;
        private System.Windows.Forms.ListBox listBoxMerged;
    }
}

