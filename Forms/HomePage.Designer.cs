namespace IT13_Final_Project.Forms
{
    partial class HomePage
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

        private void InitializeComponent()
        {
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            flowLayoutNew = new FlowLayoutPanel();
            flowLayoutTop = new FlowLayoutPanel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 83);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(642, 21);
            label2.Name = "label2";
            label2.Size = new Size(0, 35);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(20, 100);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 9;
            label1.Text = "New Arrived";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(20, 401);
            label3.Name = "label3";
            label3.Size = new Size(116, 28);
            label3.TabIndex = 10;
            label3.Text = "Top Books";
            label3.Click += label3_Click;
            // 
            // flowLayoutNew
            // 
            flowLayoutNew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutNew.AutoScroll = true;
            flowLayoutNew.Location = new Point(20, 131);
            flowLayoutNew.Name = "flowLayoutNew";
            flowLayoutNew.Size = new Size(1044, 267);
            flowLayoutNew.TabIndex = 11;
            flowLayoutNew.WrapContents = false;
            // 
            // flowLayoutTop
            // 
            flowLayoutTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutTop.AutoScroll = true;
            flowLayoutTop.Location = new Point(20, 432);
            flowLayoutTop.Name = "flowLayoutTop";
            flowLayoutTop.Size = new Size(1044, 282);
            flowLayoutTop.TabIndex = 13;
            flowLayoutTop.WrapContents = false;
            flowLayoutTop.Paint += flowLayoutTop_Paint;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 749);
            Controls.Add(flowLayoutTop);
            Controls.Add(label3);
            Controls.Add(flowLayoutNew);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "HomePage";
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutNew;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutTop;
    }
}
