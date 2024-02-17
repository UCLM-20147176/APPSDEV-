namespace TestC
{
    partial class Display
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblint4 = new System.Windows.Forms.Label();
            this.lblint3 = new System.Windows.Forms.Label();
            this.lblint2 = new System.Windows.Forms.Label();
            this.lblint1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min";
            // 
            // lblint4
            // 
            this.lblint4.AutoSize = true;
            this.lblint4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblint4.Location = new System.Drawing.Point(439, 273);
            this.lblint4.Name = "lblint4";
            this.lblint4.Size = new System.Drawing.Size(0, 20);
            this.lblint4.TabIndex = 8;
            this.lblint4.Click += new System.EventHandler(this.lblint4_Click);
            // 
            // lblint3
            // 
            this.lblint3.AutoSize = true;
            this.lblint3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblint3.Location = new System.Drawing.Point(439, 222);
            this.lblint3.Name = "lblint3";
            this.lblint3.Size = new System.Drawing.Size(0, 20);
            this.lblint3.TabIndex = 7;
            this.lblint3.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblint2
            // 
            this.lblint2.AutoSize = true;
            this.lblint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblint2.Location = new System.Drawing.Point(439, 164);
            this.lblint2.Name = "lblint2";
            this.lblint2.Size = new System.Drawing.Size(0, 20);
            this.lblint2.TabIndex = 6;
            // 
            // lblint1
            // 
            this.lblint1.AutoSize = true;
            this.lblint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblint1.Location = new System.Drawing.Point(439, 103);
            this.lblint1.Name = "lblint1";
            this.lblint1.Size = new System.Drawing.Size(0, 20);
            this.lblint1.TabIndex = 5;
            this.lblint1.Click += new System.EventHandler(this.label10_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblint4);
            this.Controls.Add(this.lblint3);
            this.Controls.Add(this.lblint2);
            this.Controls.Add(this.lblint1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Display";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblint4;
        private System.Windows.Forms.Label lblint3;
        private System.Windows.Forms.Label lblint2;
        private System.Windows.Forms.Label lblint1;
    }
}

