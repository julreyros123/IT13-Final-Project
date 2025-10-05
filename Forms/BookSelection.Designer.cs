namespace IT13_Final_Project.Forms
{
    partial class BookSelection
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
            bookFlowPanel = new FlowLayoutPanel();
            headerPanel = new Panel();
            lblGenre = new Label();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bookFlowPanel
            // 
            bookFlowPanel.AutoScroll = true;
            bookFlowPanel.BackColor = Color.White;
            bookFlowPanel.Dock = DockStyle.Fill;
            bookFlowPanel.Location = new Point(0, 56);
            bookFlowPanel.Name = "bookFlowPanel";
            bookFlowPanel.Padding = new Padding(18, 19, 18, 19);
            bookFlowPanel.Size = new Size(700, 366);
            bookFlowPanel.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(128, 64, 0);
            headerPanel.Controls.Add(lblGenre);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(700, 56);
            headerPanel.TabIndex = 1;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblGenre.ForeColor = Color.White;
            lblGenre.Location = new Point(18, 14);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(0, 30);
            lblGenre.TabIndex = 0;
            // 
            // BookSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 422);
            Controls.Add(bookFlowPanel);
            Controls.Add(headerPanel);
            Name = "BookSelection";
            Text = "Book Selection";
            WindowState = FormWindowState.Maximized;
            Load += BookSelection_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bookFlowPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblGenre;
    }
}