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
            lblFines = new Label();
            label9 = new Label();
            lblCurrentlyBorrowed = new Label();
            label10 = new Label();
            lblJoinDate = new Label();
            label11 = new Label();
            lblOverdue = new Label();
            label12 = new Label();
            lblTotalBorrowed = new Label();
            label13 = new Label();
            lblMemberID = new Label();
            label14 = new Label();
            panel3 = new Panel();
            lblAddress = new Label();
            label5 = new Label();
            lblEmail = new Label();
            label4 = new Label();
            lblContact = new Label();
            label3 = new Label();
            lblName = new Label();
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
            panel4.Controls.Add(lblFines);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lblCurrentlyBorrowed);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblJoinDate);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblOverdue);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblTotalBorrowed);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(lblMemberID);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(32, 320);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20);
            panel4.Size = new Size(748, 200);
            panel4.TabIndex = 1;
            // 
            // lblFines
            // 
            lblFines.AutoSize = true;
            lblFines.Font = new Font("Segoe UI", 9F);
            lblFines.Location = new Point(468, 120);
            lblFines.Name = "lblFines";
            lblFines.Size = new Size(37, 15);
            lblFines.TabIndex = 12;
            lblFines.Text = "$ 0.00";
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
            // lblCurrentlyBorrowed
            // 
            lblCurrentlyBorrowed.AutoSize = true;
            lblCurrentlyBorrowed.Font = new Font("Segoe UI", 9F);
            lblCurrentlyBorrowed.Location = new Point(564, 80);
            lblCurrentlyBorrowed.Name = "lblCurrentlyBorrowed";
            lblCurrentlyBorrowed.Size = new Size(13, 15);
            lblCurrentlyBorrowed.TabIndex = 11;
            lblCurrentlyBorrowed.Text = "0";
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
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Font = new Font("Segoe UI", 9F);
            lblJoinDate.Location = new Point(468, 40);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(65, 15);
            lblJoinDate.TabIndex = 10;
            lblJoinDate.Text = "0000-00-00";
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
            // lblOverdue
            // 
            lblOverdue.AutoSize = true;
            lblOverdue.Font = new Font("Segoe UI", 9F);
            lblOverdue.Location = new Point(182, 120);
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(13, 15);
            lblOverdue.TabIndex = 9;
            lblOverdue.Text = "0";
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
            // lblTotalBorrowed
            // 
            lblTotalBorrowed.AutoSize = true;
            lblTotalBorrowed.Font = new Font("Segoe UI", 9F);
            lblTotalBorrowed.Location = new Point(219, 80);
            lblTotalBorrowed.Name = "lblTotalBorrowed";
            lblTotalBorrowed.Size = new Size(13, 15);
            lblTotalBorrowed.TabIndex = 8;
            lblTotalBorrowed.Text = "0";
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
            // lblMemberID
            // 
            lblMemberID.AutoSize = true;
            lblMemberID.Font = new Font("Segoe UI", 9F);
            lblMemberID.Location = new Point(182, 40);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(77, 15);
            lblMemberID.TabIndex = 7;
            lblMemberID.Text = "Not provided";
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
            panel3.Controls.Add(lblAddress);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblContact);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblName);
            panel3.Location = new Point(32, 32);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(748, 260);
            panel3.TabIndex = 0;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.Location = new Point(320, 180);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Not Provided";
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
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(320, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(119, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Example@gmail.com";
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
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 9F);
            lblContact.Location = new Point(320, 100);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(77, 15);
            lblContact.TabIndex = 4;
            lblContact.Text = "Not provided";
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(300, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 26);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1132, 749);
            Controls.Add(panel1);
            Controls.Add(panel2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            WindowState = FormWindowState.Maximized;
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
        private Label lblEmail;
        private Label lblContact;
        private Label lblAddress;
        private Label lblMemberID;
        private Label lblJoinDate;
        private Label lblTotalBorrowed;
        private Label lblCurrentlyBorrowed;
        private Label lblOverdue;
        private Label lblFines;
    }
}
