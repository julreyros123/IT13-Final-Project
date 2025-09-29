
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginUserTb
            // 
            LoginUserTb.Anchor = AnchorStyles.None;
            LoginUserTb.BackColor = Color.NavajoWhite;
            LoginUserTb.BorderStyle = BorderStyle.None;
            LoginUserTb.Location = new Point(106, 185);
            LoginUserTb.Multiline = true;
            LoginUserTb.Name = "LoginUserTb";
            LoginUserTb.PlaceholderText = "Username";
            LoginUserTb.Size = new Size(176, 28);
            LoginUserTb.TabIndex = 0;
            LoginUserTb.TextChanged += LoginUserTb_TextChanged;
            // 
            // LoginPasswordTb
            // 
            LoginPasswordTb.Anchor = AnchorStyles.None;
            LoginPasswordTb.BackColor = Color.NavajoWhite;
            LoginPasswordTb.BorderStyle = BorderStyle.None;
            LoginPasswordTb.Location = new Point(106, 231);
            LoginPasswordTb.Multiline = true;
            LoginPasswordTb.Name = "LoginPasswordTb";
            LoginPasswordTb.PlaceholderText = "Password";
            LoginPasswordTb.Size = new Size(176, 28);
            LoginPasswordTb.TabIndex = 1;
            LoginPasswordTb.UseSystemPasswordChar = true;
            LoginPasswordTb.TextChanged += LoginPasswordTb_TextChanged;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.Location = new Point(161, 350);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(88, 22);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Go to Signup";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked_1;
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
            panel1.Size = new Size(385, 399);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(131, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 94);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Tai Le", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 334);
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
            label4.Location = new Point(106, 277);
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
            RemCb.Location = new Point(85, 277);
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
            label3.Location = new Point(106, 244);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 6;
            label3.Text = "_____________________________________";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(106, 198);
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
            label1.Location = new Point(80, 122);
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
            SignInBtn.Location = new Point(80, 298);
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
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(984, 536);
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
    }
}