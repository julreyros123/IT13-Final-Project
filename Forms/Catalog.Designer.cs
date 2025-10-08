using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    partial class Catalog
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
            searchgenreTb = new TextBox();
            genreFlowPanel = new FlowLayoutPanel();
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
            panel2.Size = new Size(1306, 83);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(572, 23);
            label2.Name = "label2";
            label2.Size = new Size(139, 35);
            label2.TabIndex = 0;
            label2.Text = "CATALOG";
            label2.Click += label2_Click;
            // 
            // searchgenreTb
            // 
            searchgenreTb.BackColor = SystemColors.ControlLight;
            searchgenreTb.BorderStyle = BorderStyle.FixedSingle;
            searchgenreTb.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold);
            searchgenreTb.Location = new Point(513, 121);
            searchgenreTb.Multiline = true;
            searchgenreTb.Name = "searchgenreTb";
            searchgenreTb.PlaceholderText = "Search Genres...";
            searchgenreTb.Size = new Size(268, 30);
            searchgenreTb.TabIndex = 3;
            searchgenreTb.TextChanged += searchgenreTb_TextChanged;
            // 
            // genreFlowPanel
            // 
            genreFlowPanel.AutoScroll = true;
            genreFlowPanel.Location = new Point(100, 180);
            genreFlowPanel.Name = "genreFlowPanel";
            genreFlowPanel.Size = new Size(1044, 280);
            genreFlowPanel.TabIndex = 4;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 623);
            Controls.Add(genreFlowPanel);
            Controls.Add(searchgenreTb);
            Controls.Add(panel2);
            Name = "Catalog";
            Text = "Catalog";
            WindowState = FormWindowState.Maximized;
            Load += Catalog_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TextBox searchgenreTb;
        private FlowLayoutPanel genreFlowPanel;
    }
}
