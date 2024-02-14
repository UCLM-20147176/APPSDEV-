namespace WindowsFormsApp1
{
    partial class display
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
            this.lbldisplay1 = new System.Windows.Forms.Label();
            this.lbldisplay2 = new System.Windows.Forms.Label();
            this.lbllabel3 = new System.Windows.Forms.Label();
            this.lbllabel4 = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldisplay1
            // 
            this.lbldisplay1.AutoSize = true;
            this.lbldisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplay1.Location = new System.Drawing.Point(503, 72);
            this.lbldisplay1.Name = "lbldisplay1";
            this.lbldisplay1.Size = new System.Drawing.Size(0, 29);
            this.lbldisplay1.TabIndex = 0;
            // 
            // lbldisplay2
            // 
            this.lbldisplay2.AutoSize = true;
            this.lbldisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisplay2.Location = new System.Drawing.Point(503, 113);
            this.lbldisplay2.Name = "lbldisplay2";
            this.lbldisplay2.Size = new System.Drawing.Size(0, 29);
            this.lbldisplay2.TabIndex = 1;
            // 
            // lbllabel3
            // 
            this.lbllabel3.AutoSize = true;
            this.lbllabel3.Location = new System.Drawing.Point(506, 167);
            this.lbllabel3.Name = "lbllabel3";
            this.lbllabel3.Size = new System.Drawing.Size(0, 16);
            this.lbllabel3.TabIndex = 2;
            // 
            // lbllabel4
            // 
            this.lbllabel4.AutoSize = true;
            this.lbllabel4.Location = new System.Drawing.Point(627, 169);
            this.lbllabel4.Name = "lbllabel4";
            this.lbllabel4.Size = new System.Drawing.Size(0, 16);
            this.lbllabel4.TabIndex = 3;
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmax.Location = new System.Drawing.Point(504, 193);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(0, 25);
            this.lblmax.TabIndex = 4;
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(504, 239);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(0, 25);
            this.lblmin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Average";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximum";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Minimum";
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lbllabel4);
            this.Controls.Add(this.lbllabel3);
            this.Controls.Add(this.lbldisplay2);
            this.Controls.Add(this.lbldisplay1);
            this.Name = "display";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.display_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldisplay1;
        private System.Windows.Forms.Label lbldisplay2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllabel3;
        private System.Windows.Forms.Label lbllabel4;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

