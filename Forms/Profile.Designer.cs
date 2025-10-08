namespace IT13_Final_Project.Forms
{
    partial class Profile
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            Logoutbtn = new Button();
            button1 = new Button();
            panel4 = new Panel();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel3 = new Panel();
            textBox10 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1132, 83);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(472, 23);
            label2.Name = "label2";
            label2.Size = new Size(121, 35);
            label2.TabIndex = 0;
            label2.Text = "PROFILE";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(Logoutbtn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(160, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 604);
            panel1.TabIndex = 4;
            // 
            // Logoutbtn
            // 
            Logoutbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Logoutbtn.BackColor = Color.Peru;
            Logoutbtn.FlatStyle = FlatStyle.Flat;
            Logoutbtn.ForeColor = Color.White;
            Logoutbtn.Location = new Point(600, 550);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(180, 35);
            Logoutbtn.TabIndex = 3;
            Logoutbtn.Text = "Logout";
            Logoutbtn.UseVisualStyleBackColor = false;
            Logoutbtn.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 550);
            button1.Name = "button1";
            button1.Size = new Size(180, 35);
            button1.TabIndex = 2;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.BurlyWood;
            panel4.Controls.Add(textBox9);
            panel4.Controls.Add(textBox8);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(32, 320);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20);
            panel4.Size = new Size(748, 200);
            panel4.TabIndex = 1;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.None;
            textBox9.BackColor = Color.BurlyWood;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(470, 120);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(142, 16);
            textBox9.TabIndex = 18;
            textBox9.Text = "0";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.BackColor = Color.BurlyWood;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(564, 80);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(142, 16);
            textBox8.TabIndex = 17;
            textBox8.Text = "0";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.BackColor = Color.BurlyWood;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(468, 40);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(142, 16);
            textBox7.TabIndex = 16;
            textBox7.Text = "0";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.BackColor = Color.BurlyWood;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(182, 120);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(142, 16);
            textBox6.TabIndex = 15;
            textBox6.Text = "0";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.BackColor = Color.BurlyWood;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(219, 80);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(142, 16);
            textBox5.TabIndex = 14;
            textBox5.Text = "0";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = Color.BurlyWood;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(182, 39);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(142, 16);
            textBox4.TabIndex = 13;
            textBox4.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(400, 120);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 6;
            label9.Text = "Fines Due:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(400, 80);
            label10.Name = "label10";
            label10.Size = new Size(158, 15);
            label10.TabIndex = 5;
            label10.Text = "Books Currently Borrowed:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(400, 40);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 4;
            label11.Text = "Join Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(80, 120);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 3;
            label12.Text = "Overdue Books:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(80, 80);
            label13.Name = "label13";
            label13.Size = new Size(133, 15);
            label13.TabIndex = 2;
            label13.Text = "Total Books Borrowed:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(80, 40);
            label14.Name = "label14";
            label14.Size = new Size(96, 15);
            label14.TabIndex = 1;
            label14.Text = "Membership ID:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.BurlyWood;
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(32, 32);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(748, 260);
            panel3.TabIndex = 0;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.None;
            textBox10.BackColor = Color.BurlyWood;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Enabled = false;
            textBox10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.ForeColor = SystemColors.InfoText;
            textBox10.Location = new Point(130, 23);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(428, 54);
            textBox10.TabIndex = 10;
            textBox10.Text = "Name";
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = Color.BurlyWood;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(320, 180);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(142, 16);
            textBox3.TabIndex = 9;
            textBox3.Text = "Empty";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.BurlyWood;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(320, 140);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(142, 16);
            textBox2.TabIndex = 8;
            textBox2.Text = "Empty";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.BurlyWood;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(320, 100);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(142, 16);
            textBox1.TabIndex = 7;
            textBox1.Text = "Empty";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(200, 180);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(200, 140);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(200, 100);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 1;
            label3.Text = "Contact:";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1132, 749);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            WindowState = FormWindowState.Maximized;
            Load += Profile_Load_2;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button Logoutbtn;
        private Button button1;

        // Renamed Labels
        private Label lblName;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox10;
    }
}
