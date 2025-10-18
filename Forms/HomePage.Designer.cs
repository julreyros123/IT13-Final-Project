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
            label1 = new Label();
            label3 = new Label();
            flowLayoutNew = new FlowLayoutPanel();
            flowLayoutTop = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(20, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 9;
            label1.Text = "New Arrived";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(12, 372);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 10;
            label3.Text = "Top Books";
            label3.Click += label3_Click;
            // 
            // flowLayoutNew
            // 
            flowLayoutNew.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutNew.AutoScroll = true;
            flowLayoutNew.BackColor = Color.White;
            flowLayoutNew.Location = new Point(20, 28);
            flowLayoutNew.Name = "flowLayoutNew";
            flowLayoutNew.Size = new Size(1044, 341);
            flowLayoutNew.TabIndex = 11;
            flowLayoutNew.WrapContents = false;
            // 
            // flowLayoutTop
            // 
            flowLayoutTop.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutTop.AutoScroll = true;
            flowLayoutTop.BackColor = Color.White;
            flowLayoutTop.Location = new Point(20, 408);
            flowLayoutTop.Name = "flowLayoutTop";
            flowLayoutTop.Size = new Size(1044, 340);
            flowLayoutTop.TabIndex = 13;
            flowLayoutTop.WrapContents = false;
            flowLayoutTop.Paint += flowLayoutTop_Paint;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1084, 749);
            Controls.Add(flowLayoutTop);
            Controls.Add(flowLayoutNew);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "HomePage";
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
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