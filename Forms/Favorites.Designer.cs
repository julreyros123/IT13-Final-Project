namespace IT13_Final_Project.Forms
{
    partial class Favorites
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
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            panel2.Size = new Size(1312, 83);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(528, 22);
            label2.Name = "label2";
            label2.Size = new Size(158, 35);
            label2.TabIndex = 0;
            label2.Text = "FAVORITES";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Chocolate;
            flowLayoutPanel1.Location = new Point(137, 125);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1030, 481);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Scroll += flowLayoutPanel1_Scroll;
            // 
            // Favorites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 630);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "Favorites";
            Text = "Favorites";
            WindowState = FormWindowState.Maximized;
            Load += Favorites_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}