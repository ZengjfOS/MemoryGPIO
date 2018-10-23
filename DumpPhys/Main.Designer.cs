namespace DumpPhys
{
    partial class Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutputWrite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputIndex = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InputRead = new System.Windows.Forms.Button();
            this.InputIndex = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputValue = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.InputValue = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OutputValue);
            this.groupBox1.Controls.Add(this.OutputWrite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OutputIndex);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(184, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // OutputWrite
            // 
            this.OutputWrite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OutputWrite.Location = new System.Drawing.Point(17, 96);
            this.OutputWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputWrite.Name = "OutputWrite";
            this.OutputWrite.Size = new System.Drawing.Size(156, 29);
            this.OutputWrite.TabIndex = 4;
            this.OutputWrite.Text = "Write";
            this.OutputWrite.UseVisualStyleBackColor = true;
            this.OutputWrite.Click += new System.EventHandler(this.OutputWrite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Value: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Index: ";
            // 
            // OutputIndex
            // 
            this.OutputIndex.FormattingEnabled = true;
            this.OutputIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.OutputIndex.Location = new System.Drawing.Point(76, 30);
            this.OutputIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputIndex.Name = "OutputIndex";
            this.OutputIndex.Size = new System.Drawing.Size(97, 23);
            this.OutputIndex.TabIndex = 0;
            this.OutputIndex.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InputIndex);
            this.groupBox2.Controls.Add(this.InputValue);
            this.groupBox2.Controls.Add(this.InputRead);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(212, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(181, 130);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // InputRead
            // 
            this.InputRead.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.InputRead.Location = new System.Drawing.Point(16, 96);
            this.InputRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputRead.Name = "InputRead";
            this.InputRead.Size = new System.Drawing.Size(156, 29);
            this.InputRead.TabIndex = 4;
            this.InputRead.Text = "Read";
            this.InputRead.UseVisualStyleBackColor = true;
            this.InputRead.Click += new System.EventHandler(this.InputRead_Click);
            // 
            // InputIndex
            // 
            this.InputIndex.FormattingEnabled = true;
            this.InputIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.InputIndex.Location = new System.Drawing.Point(75, 30);
            this.InputIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputIndex.Name = "InputIndex";
            this.InputIndex.Size = new System.Drawing.Size(97, 23);
            this.InputIndex.TabIndex = 0;
            this.InputIndex.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Value: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Index: ";
            // 
            // OutputValue
            // 
            this.OutputValue.FormattingEnabled = true;
            this.OutputValue.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.OutputValue.Location = new System.Drawing.Point(76, 56);
            this.OutputValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputValue.Name = "OutputValue";
            this.OutputValue.Size = new System.Drawing.Size(97, 23);
            this.OutputValue.TabIndex = 0;
            this.OutputValue.Text = "Low";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox4.Location = new System.Drawing.Point(75, 56);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(97, 23);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.Text = "0";
            // 
            // InputValue
            // 
            this.InputValue.FormattingEnabled = true;
            this.InputValue.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.InputValue.Location = new System.Drawing.Point(75, 56);
            this.InputValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(97, 23);
            this.InputValue.TabIndex = 0;
            this.InputValue.Text = "Low";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 147);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Text = "Win32GPIO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OutputWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OutputIndex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button InputRead;
        private System.Windows.Forms.ComboBox InputIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OutputValue;
        private System.Windows.Forms.ComboBox InputValue;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

