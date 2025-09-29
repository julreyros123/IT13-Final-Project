namespace IT13_Final_Project
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            UserTb = new TextBox();
            EmailTb = new TextBox();
            PasswordTb = new TextBox();
            SignupBtn = new Button();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            label4 = new Label();
            passregTB = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UserTb
            // 
            UserTb.Anchor = AnchorStyles.None;
            UserTb.BackColor = Color.NavajoWhite;
            UserTb.BorderStyle = BorderStyle.None;
            UserTb.Location = new Point(111, 211);
            UserTb.Multiline = true;
            UserTb.Name = "UserTb";
            UserTb.PlaceholderText = "Username";
            UserTb.Size = new Size(176, 28);
            UserTb.TabIndex = 0;
            UserTb.TextChanged += UserTb_TextChanged;
            // 
            // EmailTb
            // 
            EmailTb.Anchor = AnchorStyles.None;
            EmailTb.BackColor = Color.NavajoWhite;
            EmailTb.BorderStyle = BorderStyle.None;
            EmailTb.Location = new Point(112, 300);
            EmailTb.Multiline = true;
            EmailTb.Name = "EmailTb";
            EmailTb.PlaceholderText = "Email";
            EmailTb.Size = new Size(176, 30);
            EmailTb.TabIndex = 1;
            EmailTb.UseSystemPasswordChar = true;
            EmailTb.TextChanged += PasswordTb_TextChanged;
            // 
            // PasswordTb
            // 
            PasswordTb.Anchor = AnchorStyles.None;
            PasswordTb.BackColor = Color.NavajoWhite;
            PasswordTb.BorderStyle = BorderStyle.None;
            PasswordTb.Location = new Point(111, 254);
            PasswordTb.Multiline = true;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PlaceholderText = "Password";
            PasswordTb.Size = new Size(176, 29);
            PasswordTb.TabIndex = 2;
            PasswordTb.TextChanged += EmailTb_TextChanged;
            // 
            // SignupBtn
            // 
            SignupBtn.Anchor = AnchorStyles.None;
            SignupBtn.BackColor = Color.Peru;
            SignupBtn.FlatStyle = FlatStyle.Flat;
            SignupBtn.Font = new Font("Microsoft New Tai Lue", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = SystemColors.Window;
            SignupBtn.Location = new Point(111, 337);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(177, 28);
            SignupBtn.TabIndex = 3;
            SignupBtn.Text = "Sign Up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.Location = new Point(156, 368);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 22);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.NavajoWhite;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(passregTB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserTb);
            panel1.Controls.Add(EmailTb);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(SignupBtn);
            panel1.Location = new Point(307, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 418);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(128, 64, 0);
            label4.Location = new Point(111, 315);
            label4.Name = "label4";
            label4.Size = new Size(192, 15);
            label4.TabIndex = 8;
            label4.Text = "_____________________________________";
            // 
            // passregTB
            // 
            passregTB.Anchor = AnchorStyles.None;
            passregTB.AutoSize = true;
            passregTB.ForeColor = Color.FromArgb(128, 64, 0);
            passregTB.Location = new Point(111, 271);
            passregTB.Name = "passregTB";
            passregTB.Size = new Size(192, 15);
            passregTB.TabIndex = 7;
            passregTB.Text = "_____________________________________";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(111, 227);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 6;
            label2.Text = "_____________________________________";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(99, 154);
            label1.Name = "label1";
            label1.Size = new Size(189, 31);
            label1.TabIndex = 5;
            label1.Text = "Grand Archive";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(984, 536);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox UserTb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label passregTB;
        private Label label2;
    }
}