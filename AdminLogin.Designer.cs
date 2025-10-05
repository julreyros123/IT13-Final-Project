namespace IT13_Final_Project
{
    partial class AdminLogin
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            AdminUserTb = new TextBox();
            label2 = new Label();
            AdminPasswordTb = new TextBox();
            label3 = new Label();
            AdminLoginBtn = new Button();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.NavajoWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AdminUserTb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AdminPasswordTb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AdminLoginBtn);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(119, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 435);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Location = new Point(131, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 94);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(80, 143);
            label1.Name = "label1";
            label1.Size = new Size(205, 31);
            label1.TabIndex = 1;
            label1.Text = "ADMIN LOGIN";
            // 
            // AdminUserTb
            // 
            AdminUserTb.Anchor = AnchorStyles.None;
            AdminUserTb.BackColor = Color.NavajoWhite;
            AdminUserTb.BorderStyle = BorderStyle.None;
            AdminUserTb.Location = new Point(106, 203);
            AdminUserTb.Multiline = true;
            AdminUserTb.Name = "AdminUserTb";
            AdminUserTb.PlaceholderText = "Admin Username";
            AdminUserTb.Size = new Size(176, 28);
            AdminUserTb.TabIndex = 2;
            AdminUserTb.TextChanged += AdminUserTb_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(106, 219);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 3;
            label2.Text = "_____________________________________";
            // 
            // AdminPasswordTb
            // 
            AdminPasswordTb.Anchor = AnchorStyles.None;
            AdminPasswordTb.BackColor = Color.NavajoWhite;
            AdminPasswordTb.BorderStyle = BorderStyle.None;
            AdminPasswordTb.Location = new Point(106, 249);
            AdminPasswordTb.Multiline = true;
            AdminPasswordTb.Name = "AdminPasswordTb";
            AdminPasswordTb.PlaceholderText = "Password";
            AdminPasswordTb.Size = new Size(176, 28);
            AdminPasswordTb.TabIndex = 4;
            AdminPasswordTb.UseSystemPasswordChar = true;
            AdminPasswordTb.TextChanged += AdminPasswordTb_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(106, 265);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 5;
            label3.Text = "_____________________________________";
            // 
            // AdminLoginBtn
            // 
            AdminLoginBtn.Anchor = AnchorStyles.None;
            AdminLoginBtn.BackColor = Color.Peru;
            AdminLoginBtn.FlatStyle = FlatStyle.Flat;
            AdminLoginBtn.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            AdminLoginBtn.ForeColor = Color.White;
            AdminLoginBtn.Location = new Point(80, 316);
            AdminLoginBtn.Name = "AdminLoginBtn";
            AdminLoginBtn.Size = new Size(247, 28);
            AdminLoginBtn.TabIndex = 6;
            AdminLoginBtn.Text = "Admin Login";
            AdminLoginBtn.UseVisualStyleBackColor = false;
            AdminLoginBtn.Click += AdminLoginBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.Location = new Point(161, 368);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 22);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(622, 453);
            Controls.Add(panel1);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminUserTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminPasswordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AdminLoginBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}