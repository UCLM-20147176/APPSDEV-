namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtbag = new TextBox();
            txtsmall = new TextBox();
            txtmed = new TextBox();
            txtlarge = new TextBox();
            btnadd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(192, 34);
            label1.Name = "label1";
            label1.Size = new Size(364, 31);
            label1.TabIndex = 0;
            label1.Text = "CANTECSON TINDAHAN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(165, 104);
            label2.Name = "label2";
            label2.Size = new Size(205, 21);
            label2.TabIndex = 1;
            label2.Text = "Number of Bags Ordered";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(303, 175);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 2;
            label3.Text = "Large :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(303, 209);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 3;
            label4.Text = "Medium :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(183, 349);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 4;
            label5.Text = "Your total cost :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(192, 135);
            label6.Name = "label6";
            label6.Size = new Size(82, 17);
            label6.TabIndex = 5;
            label6.Text = "Boxes Used:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(303, 248);
            label7.Name = "label7";
            label7.Size = new Size(50, 17);
            label7.TabIndex = 6;
            label7.Text = "Small :";
            label7.Click += label7_Click;
            // 
            // txtbag
            // 
            txtbag.BackColor = Color.White;
            txtbag.ForeColor = Color.Black;
            txtbag.Location = new Point(418, 106);
            txtbag.Name = "txtbag";
            txtbag.Size = new Size(100, 23);
            txtbag.TabIndex = 7;
            // 
            // txtsmall
            // 
            txtsmall.Location = new Point(418, 247);
            txtsmall.Name = "txtsmall";
            txtsmall.Size = new Size(100, 23);
            txtsmall.TabIndex = 8;
            txtsmall.TextChanged += txtsmall_TextChanged;
            // 
            // txtmed
            // 
            txtmed.Location = new Point(418, 209);
            txtmed.Name = "txtmed";
            txtmed.Size = new Size(100, 23);
            txtmed.TabIndex = 9;
            // 
            // txtlarge
            // 
            txtlarge.Location = new Point(418, 169);
            txtlarge.Name = "txtlarge";
            txtlarge.Size = new Size(100, 23);
            txtlarge.TabIndex = 10;
            txtlarge.TextChanged += textBox4_TextChanged;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(433, 304);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(69, 30);
            btnadd.TabIndex = 11;
            btnadd.Text = "ENTER";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnadd);
            Controls.Add(txtlarge);
            Controls.Add(txtmed);
            Controls.Add(txtsmall);
            Controls.Add(txtbag);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtbag;
        private TextBox txtsmall;
        private TextBox txtmed;
        private TextBox txtlarge;
        private Button btnadd;
    }
}
