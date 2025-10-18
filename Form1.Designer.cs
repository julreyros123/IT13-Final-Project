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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            UserTb = new TextBox();
            EmailTb = new TextBox();
            PasswordTb = new TextBox();
            SignupBtn = new Button();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            passregTB = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserTb
            // 
            UserTb.Anchor = AnchorStyles.None;
            UserTb.BackColor = Color.White;
            UserTb.BorderStyle = BorderStyle.None;
            UserTb.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserTb.ForeColor = Color.DimGray;
            UserTb.Location = new Point(274, 242);
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
            EmailTb.BackColor = Color.White;
            EmailTb.BorderStyle = BorderStyle.None;
            EmailTb.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailTb.ForeColor = Color.DimGray;
            EmailTb.Location = new Point(274, 330);
            EmailTb.Multiline = true;
            EmailTb.Name = "EmailTb";
            EmailTb.PlaceholderText = "Email";
            EmailTb.Size = new Size(176, 25);
            EmailTb.TabIndex = 1;
            EmailTb.TextChanged += EmailTb_TextChanged; // Corrected event handler
            // 
            // PasswordTb
            // 
            PasswordTb.Anchor = AnchorStyles.None;
            PasswordTb.BackColor = Color.White;
            PasswordTb.BorderStyle = BorderStyle.None;
            PasswordTb.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.ForeColor = Color.DimGray;
            PasswordTb.Location = new Point(274, 286);
            PasswordTb.Multiline = true;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*'; // Explicitly set to asterisk
            PasswordTb.PlaceholderText = "Password";
            PasswordTb.Size = new Size(176, 29);
            PasswordTb.TabIndex = 2;
            PasswordTb.TextChanged += PasswordTb_TextChanged; // Corrected event handler
            // 
            // SignupBtn
            // 
            SignupBtn.Anchor = AnchorStyles.None;
            SignupBtn.BackColor = Color.DodgerBlue;
            SignupBtn.FlatAppearance.BorderSize = 0;
            SignupBtn.FlatStyle = FlatStyle.Flat;
            SignupBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = Color.White;
            SignupBtn.Location = new Point(274, 366);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(177, 28);
            SignupBtn.TabIndex = 3;
            SignupBtn.Text = "Sign Up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.RoyalBlue;
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(319, 397);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back to Login";
            linkLabel1.VisitedLinkColor = Color.RoyalBlue;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(EmailTb);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(passregTB);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(UserTb);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(SignupBtn);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(10, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 450);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(274, 347);
            label4.Name = "label4";
            label4.Size = new Size(192, 15);
            label4.TabIndex = 8;
            label4.Text = "_____________________________________";
            // 
            // passregTB
            // 
            passregTB.Anchor = AnchorStyles.None;
            passregTB.AutoSize = true;
            passregTB.ForeColor = Color.LightGray;
            passregTB.Location = new Point(274, 303);
            passregTB.Name = "passregTB";
            passregTB.Size = new Size(192, 15);
            passregTB.TabIndex = 7;
            passregTB.Text = "_____________________________________";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(274, 259);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 6;
            label2.Text = "_____________________________________";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(262, 191);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 5;
            label1.Text = "Grand Archive";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(725, 480);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}