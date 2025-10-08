namespace IT13_Final_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginUserTb = new TextBox();
            LoginPasswordTb = new TextBox();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            RemCb = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SignInBtn = new Button();
            AdminAccessBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginUserTb
            // 
            LoginUserTb.Anchor = AnchorStyles.None;
            LoginUserTb.BackColor = Color.NavajoWhite;
            LoginUserTb.BorderStyle = BorderStyle.None;
            LoginUserTb.Location = new Point(266, 242);
            LoginUserTb.Multiline = true;
            LoginUserTb.Name = "LoginUserTb";
            LoginUserTb.PlaceholderText = "Username";
            LoginUserTb.Size = new Size(176, 28);
            LoginUserTb.TabIndex = 0;
            // 
            // LoginPasswordTb
            // 
            LoginPasswordTb.Anchor = AnchorStyles.None;
            LoginPasswordTb.BackColor = Color.NavajoWhite;
            LoginPasswordTb.BorderStyle = BorderStyle.None;
            LoginPasswordTb.Location = new Point(267, 297);
            LoginPasswordTb.Multiline = true;
            LoginPasswordTb.Name = "LoginPasswordTb";
            LoginPasswordTb.PasswordChar = '*';
            LoginPasswordTb.PlaceholderText = "Password";
            LoginPasswordTb.Size = new Size(176, 28);
            LoginPasswordTb.TabIndex = 1;
            LoginPasswordTb.UseSystemPasswordChar = true;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.Location = new Point(317, 408);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(88, 22);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to Signup";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.NavajoWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(RemCb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LoginUserTb);
            panel1.Controls.Add(LoginPasswordTb);
            panel1.Controls.Add(SignInBtn);
            panel1.Controls.Add(linkLabel2);
            panel1.Location = new Point(307, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 495);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(246, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(303, 392);
            label5.Name = "label5";
            label5.Size = new Size(117, 16);
            label5.TabIndex = 10;
            label5.Text = "Don't have Account?";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(266, 341);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 9;
            label4.Text = "Remember me";
            // 
            // RemCb
            // 
            RemCb.Anchor = AnchorStyles.None;
            RemCb.AutoSize = true;
            RemCb.Font = new Font("Segoe Fluent Icons", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemCb.Location = new Point(245, 341);
            RemCb.Name = "RemCb";
            RemCb.Size = new Size(15, 14);
            RemCb.TabIndex = 7;
            RemCb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(128, 64, 0);
            label3.Location = new Point(266, 310);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 6;
            label3.Text = "_____________________________________";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(266, 264);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 5;
            label2.Text = "_____________________________________";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(240, 191);
            label1.Name = "label1";
            label1.Size = new Size(247, 31);
            label1.TabIndex = 4;
            label1.Text = "GRAND ARCHIVE";
            // 
            // SignInBtn
            // 
            SignInBtn.Anchor = AnchorStyles.None;
            SignInBtn.BackColor = Color.Peru;
            SignInBtn.FlatStyle = FlatStyle.Flat;
            SignInBtn.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInBtn.ForeColor = Color.White;
            SignInBtn.Location = new Point(240, 361);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(247, 28);
            SignInBtn.TabIndex = 2;
            SignInBtn.Text = "Login";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // AdminAccessBtn
            // 
            AdminAccessBtn.BackColor = Color.FromArgb(20, 255, 224, 192);
            AdminAccessBtn.FlatAppearance.BorderSize = 0;
            AdminAccessBtn.FlatStyle = FlatStyle.Flat;
            AdminAccessBtn.Location = new Point(944, 10);
            AdminAccessBtn.Name = "AdminAccessBtn";
            AdminAccessBtn.Size = new Size(30, 30);
            AdminAccessBtn.TabIndex = 7;
            AdminAccessBtn.UseVisualStyleBackColor = false;
            AdminAccessBtn.Click += AdminAccessBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1304, 632);
            Controls.Add(AdminAccessBtn);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Location = new Point(358, 47);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private System.Windows.Forms.TextBox LoginUserTb;
        private System.Windows.Forms.TextBox LoginPasswordTb;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Panel panel1;
        private Label label1;
        private PaintEventHandler panel1_Paint;
        private Label label2;
        private Label label3;
        private Button SignInBtn;
        private Label label4;
        private CheckBox RemCb;
        private Label label5;
        private PictureBox pictureBox1;
        private Button AdminAccessBtn;
    }
}