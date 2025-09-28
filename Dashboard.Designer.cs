namespace IT13_Final_Project
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            menuBtn = new Button();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel6 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(menuBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 749);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // menuBtn
            // 
            menuBtn.AutoSize = true;
            menuBtn.BackColor = Color.Tan;
            menuBtn.Dock = DockStyle.Top;
            menuBtn.FlatAppearance.BorderSize = 0;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.Image = (Image)resources.GetObject("menuBtn.Image");
            menuBtn.Location = new Point(0, 0);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(194, 32);
            menuBtn.TabIndex = 7;
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(3, 130);
            label1.Name = "label1";
            label1.Size = new Size(187, 24);
            label1.TabIndex = 2;
            label1.Text = "GRAND ARCHIVE";
            // 
            // button5
            // 
            button5.BackColor = Color.Tan;
            button5.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(0, 0, 64);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(12, 419);
            button5.Name = "button5";
            button5.Size = new Size(175, 41);
            button5.TabIndex = 6;
            button5.Text = "Profile";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(0, 0, 64);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(12, 362);
            button4.Name = "button4";
            button4.Size = new Size(178, 41);
            button4.TabIndex = 5;
            button4.Text = "Favorites";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(0, 0, 64);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(9, 305);
            button3.Name = "button3";
            button3.Size = new Size(178, 41);
            button3.TabIndex = 4;
            button3.Text = "Borrowed ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 189);
            button1.Name = "button1";
            button1.Size = new Size(178, 41);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 0, 64);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 246);
            button2.Name = "button2";
            button2.Size = new Size(175, 41);
            button2.TabIndex = 3;
            button2.TabStop = false;
            button2.Text = "Catalogs";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(984, 749);
            panel6.TabIndex = 7;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 749);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Name = "Dashboard";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "b";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
        private Label label1;
        private Panel panel6;
        private Button menuBtn;
    }
}