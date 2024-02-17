namespace TestC
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
            this.btnenter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtoption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(459, 366);
            this.btnenter.Margin = new System.Windows.Forms.Padding(4);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(133, 48);
            this.btnenter.TabIndex = 10;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtoption);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 172);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(539, 165);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // txtoption
            // 
            this.txtoption.Location = new System.Drawing.Point(325, 55);
            this.txtoption.Margin = new System.Windows.Forms.Padding(4);
            this.txtoption.Multiline = true;
            this.txtoption.Name = "txtoption";
            this.txtoption.Size = new System.Drawing.Size(132, 36);
            this.txtoption.TabIndex = 5;
            this.txtoption.TextChanged += new System.EventHandler(this.txtoption_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "1 - Sum\r\n2 - Average\r\n3 - Maximum and Minimum";
            // 
            // txtinput2
            // 
            this.txtinput2.Location = new System.Drawing.Point(459, 110);
            this.txtinput2.Margin = new System.Windows.Forms.Padding(4);
            this.txtinput2.Multiline = true;
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(132, 36);
            this.txtinput2.TabIndex = 8;
            this.txtinput2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // txtinput1
            // 
            this.txtinput1.Location = new System.Drawing.Point(459, 37);
            this.txtinput1.Margin = new System.Windows.Forms.Padding(4);
            this.txtinput1.Multiline = true;
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(132, 36);
            this.txtinput1.TabIndex = 7;
            this.txtinput1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter two integers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtoption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.Label label1;
    }
}

