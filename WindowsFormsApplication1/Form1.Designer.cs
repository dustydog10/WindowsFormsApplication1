namespace XmlCompareApp
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openBaseXMLFile = new System.Windows.Forms.Button();
            this.baseLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openTestXMLFile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.testLabel = new System.Windows.Forms.Label();
            this.compareLabel = new System.Windows.Forms.Label();
            this.compareBtn = new System.Windows.Forms.Button();
            this.compareTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openBaseXMLFile
            // 
            this.openBaseXMLFile.Location = new System.Drawing.Point(108, 39);
            this.openBaseXMLFile.Name = "openBaseXMLFile";
            this.openBaseXMLFile.Size = new System.Drawing.Size(115, 27);
            this.openBaseXMLFile.TabIndex = 0;
            this.openBaseXMLFile.Text = "Base XML";
            this.openBaseXMLFile.UseVisualStyleBackColor = true;
            this.openBaseXMLFile.Click += new System.EventHandler(this.openBaseXMLButton_Click);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(46, 78);
            this.baseLabel.MaximumSize = new System.Drawing.Size(239, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(0, 13);
            this.baseLabel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(239, 328);
            this.textBox1.TabIndex = 2;
            // 
            // openTestXMLFile
            // 
            this.openTestXMLFile.Location = new System.Drawing.Point(383, 39);
            this.openTestXMLFile.Name = "openTestXMLFile";
            this.openTestXMLFile.Size = new System.Drawing.Size(115, 27);
            this.openTestXMLFile.TabIndex = 3;
            this.openTestXMLFile.Text = "Test XML";
            this.openTestXMLFile.UseVisualStyleBackColor = true;
            this.openTestXMLFile.Click += new System.EventHandler(this.openTestXMLFile_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 113);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(239, 328);
            this.textBox2.TabIndex = 4;
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(322, 78);
            this.testLabel.MaximumSize = new System.Drawing.Size(239, 0);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 13);
            this.testLabel.TabIndex = 5;
            // 
            // compareLabel
            // 
            this.compareLabel.Location = new System.Drawing.Point(612, 78);
            this.compareLabel.MaximumSize = new System.Drawing.Size(239, 14);
            this.compareLabel.Name = "compareLabel";
            this.compareLabel.Size = new System.Drawing.Size(239, 14);
            this.compareLabel.TabIndex = 8;
            this.compareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(671, 39);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(115, 27);
            this.compareBtn.TabIndex = 9;
            this.compareBtn.Text = "Compare XML";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // compareTextBox
            // 
            this.compareTextBox.Location = new System.Drawing.Point(612, 113);
            this.compareTextBox.Multiline = true;
            this.compareTextBox.Name = "compareTextBox";
            this.compareTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.compareTextBox.Size = new System.Drawing.Size(239, 328);
            this.compareTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 470);
            this.Controls.Add(this.compareTextBox);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.compareLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.openTestXMLFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.openBaseXMLFile);
            this.Name = "Form1";
            this.Text = "XML Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button openBaseXMLFile;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openTestXMLFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label compareLabel;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.TextBox compareTextBox;
    }
}

