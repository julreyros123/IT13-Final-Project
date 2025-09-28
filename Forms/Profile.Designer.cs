namespace IT13_Final_Project.Forms
{
    partial class Profile
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
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
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
            label2.Location = new Point(705, 23);
            label2.Name = "label2";
            label2.Size = new Size(121, 35);
            label2.TabIndex = 0;
            label2.Text = "PROFILE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(420, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(668, 604);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(399, 555);
            button2.Name = "button2";
            button2.Size = new Size(85, 30);
            button2.TabIndex = 3;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(237, 555);
            button1.Name = "button1";
            button1.Size = new Size(85, 30);
            button1.TabIndex = 2;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.BurlyWood;
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(28, 299);
            panel4.Name = "panel4";
            panel4.Size = new Size(618, 220);
            panel4.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(437, 122);
            label20.Name = "label20";
            label20.Size = new Size(37, 15);
            label20.TabIndex = 12;
            label20.Text = "$ 0.00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(533, 90);
            label19.Name = "label19";
            label19.Size = new Size(13, 15);
            label19.TabIndex = 11;
            label19.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(437, 53);
            label18.Name = "label18";
            label18.Size = new Size(65, 15);
            label18.TabIndex = 10;
            label18.Text = "0000-00-00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(195, 123);
            label17.Name = "label17";
            label17.Size = new Size(13, 15);
            label17.TabIndex = 9;
            label17.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(228, 90);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 8;
            label16.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(195, 54);
            label15.Name = "label15";
            label15.Size = new Size(77, 15);
            label15.TabIndex = 7;
            label15.Text = "Not provided";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 9F);
            label9.Location = new Point(371, 123);
            label9.Name = "label9";
            label9.Size = new Size(67, 14);
            label9.TabIndex = 6;
            label9.Text = "Fines Due:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 9F);
            label10.Location = new Point(371, 91);
            label10.Name = "label10";
            label10.Size = new Size(156, 14);
            label10.TabIndex = 5;
            label10.Text = "BooksCurrently Barrowed:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 9F);
            label11.Location = new Point(371, 54);
            label11.Name = "label11";
            label11.Size = new Size(60, 14);
            label11.TabIndex = 4;
            label11.Text = "Join Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 9F);
            label12.Location = new Point(90, 123);
            label12.Name = "label12";
            label12.Size = new Size(99, 14);
            label12.TabIndex = 3;
            label12.Text = "Overdue Books:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Rockwell", 9F);
            label13.Location = new Point(91, 91);
            label13.Name = "label13";
            label13.Size = new Size(132, 14);
            label13.TabIndex = 2;
            label13.Text = "Total Books Barrowed:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 9F);
            label14.Location = new Point(91, 54);
            label14.Name = "label14";
            label14.Size = new Size(98, 14);
            label14.TabIndex = 1;
            label14.Text = "Membership ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.BurlyWood;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(28, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(618, 254);
            panel3.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 9F);
            label8.Location = new Point(306, 181);
            label8.Name = "label8";
            label8.Size = new Size(82, 14);
            label8.TabIndex = 6;
            label8.Text = "Not Provided";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 9F);
            label7.Location = new Point(306, 158);
            label7.Name = "label7";
            label7.Size = new Size(125, 14);
            label7.TabIndex = 5;
            label7.Text = "Example@gmail.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 9F);
            label6.Location = new Point(306, 134);
            label6.Name = "label6";
            label6.Size = new Size(83, 14);
            label6.TabIndex = 4;
            label6.Text = "Not provided";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 9F);
            label5.Location = new Point(252, 181);
            label5.Name = "label5";
            label5.Size = new Size(59, 14);
            label5.TabIndex = 3;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 9F);
            label4.Location = new Point(270, 158);
            label4.Name = "label4";
            label4.Size = new Size(41, 14);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 9F);
            label3.Location = new Point(257, 134);
            label3.Name = "label3";
            label3.Size = new Size(54, 14);
            label3.TabIndex = 1;
            label3.Text = "Contact:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 98);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 749);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Profile";
            Text = "Form1";
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
        private Label label1;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label17;
        private Label label16;
        private Label label15;
        private Button button2;
        private Button button1;
        private Label label20;
        private Label label19;
        private Label label18;
    }
}