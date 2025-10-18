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
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            RemCb = new CheckBox();
            label1 = new Label();
            SignInBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginUserTb
            // 
            LoginUserTb.Anchor = AnchorStyles.None;
            LoginUserTb.BackColor = Color.White;
            LoginUserTb.BorderStyle = BorderStyle.None;
            LoginUserTb.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginUserTb.ForeColor = Color.DimGray;
            LoginUserTb.Location = new Point(266, 245);
            LoginUserTb.Multiline = true;
            LoginUserTb.Name = "LoginUserTb";
            LoginUserTb.PlaceholderText = "Username";
            LoginUserTb.Size = new Size(176, 23);
            LoginUserTb.TabIndex = 0;
            LoginUserTb.TextChanged += LoginUserTb_TextChanged;
            // 
            // LoginPasswordTb
            // 
            LoginPasswordTb.Anchor = AnchorStyles.None;
            LoginPasswordTb.BackColor = Color.White;
            LoginPasswordTb.BorderStyle = BorderStyle.None;
            LoginPasswordTb.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginPasswordTb.ForeColor = Color.DimGray;
            LoginPasswordTb.Location = new Point(266, 288);
            LoginPasswordTb.Name = "LoginPasswordTb";
            LoginPasswordTb.PasswordChar = '*';
            LoginPasswordTb.PlaceholderText = "Password";
            LoginPasswordTb.Size = new Size(176, 19);
            LoginPasswordTb.TabIndex = 1;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.RoyalBlue;
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.DodgerBlue;
            linkLabel2.Location = new Point(316, 398);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(76, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to Signup";
            linkLabel2.VisitedLinkColor = Color.RoyalBlue;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LoginPasswordTb);
            panel1.Controls.Add(LoginUserTb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(RemCb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SignInBtn);
            panel1.Controls.Add(linkLabel2);
            panel1.Location = new Point(10, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 450);
            panel1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.OutlineButton;
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(266, 296);
            label7.Name = "label7";
            label7.Size = new Size(182, 15);
            label7.TabIndex = 12;
            label7.Text = "___________________________________";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(266, 257);
            label6.Name = "label6";
            label6.Size = new Size(182, 15);
            label6.TabIndex = 8;
            label6.Text = "___________________________________";
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
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(298, 383);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 10;
            label5.Text = "Don't have Account?";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(266, 323);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 9;
            label4.Text = "Remember me";
            // 
            // RemCb
            // 
            RemCb.Anchor = AnchorStyles.None;
            RemCb.AutoSize = true;
            RemCb.FlatStyle = FlatStyle.Flat;
            RemCb.Location = new Point(246, 325);
            RemCb.Name = "RemCb";
            RemCb.Size = new Size(12, 11);
            RemCb.TabIndex = 7;
            RemCb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(240, 191);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 4;
            label1.Text = "GRAND ARCHIVE";
            // 
            // SignInBtn
            // 
            SignInBtn.Anchor = AnchorStyles.None;
            SignInBtn.BackColor = Color.DodgerBlue;
            SignInBtn.FlatAppearance.BorderSize = 0;
            SignInBtn.FlatStyle = FlatStyle.Flat;
            SignInBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInBtn.ForeColor = Color.White;
            SignInBtn.Location = new Point(240, 342);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(247, 28);
            SignInBtn.TabIndex = 2;
            SignInBtn.Text = "Login";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(725, 480);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Location = new Point(358, 47);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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
        private Button SignInBtn;
        private Label label4;
        private CheckBox RemCb;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
    }
}