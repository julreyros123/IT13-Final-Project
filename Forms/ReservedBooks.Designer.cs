using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    partial class ReservedBooks
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeader = new Label();
            panelSummary = new Panel();
            lblAmount = new Label();
            Amountbl = new Label();
            flowReserved = new FlowLayoutPanel();
            lblSectionTitle = new Label();
            panelHeader.SuspendLayout();
            panelSummary.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DodgerBlue;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(10);
            panelHeader.Size = new Size(1324, 80);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(10, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1304, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "📖 Reserved Books";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.White;
            panelSummary.BorderStyle = BorderStyle.FixedSingle;
            panelSummary.Controls.Add(lblAmount);
            panelSummary.Controls.Add(Amountbl);
            panelSummary.Location = new Point(358, 104);
            panelSummary.Name = "panelSummary";
            panelSummary.Padding = new Padding(10);
            panelSummary.Size = new Size(450, 70);
            panelSummary.TabIndex = 1;
            panelSummary.Paint += panelSummary_Paint;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(92, 51, 23);
            lblAmount.Location = new Point(20, 20);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(154, 25);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "💰 Due Amount:";
            // 
            // Amountbl
            // 
            Amountbl.AutoSize = true;
            Amountbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Amountbl.ForeColor = Color.FromArgb(20, 60, 20);
            Amountbl.Location = new Point(190, 20);
            Amountbl.Name = "Amountbl";
            Amountbl.Size = new Size(66, 25);
            Amountbl.TabIndex = 1;
            Amountbl.Text = "$ 0.00";
            // 
            // flowReserved
            // 
            flowReserved.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowReserved.AutoScroll = true;
            flowReserved.BackColor = Color.FromArgb(250, 248, 243);
            flowReserved.FlowDirection = FlowDirection.TopDown;
            flowReserved.Location = new Point(40, 210);
            flowReserved.Name = "flowReserved";
            flowReserved.Padding = new Padding(20);
            flowReserved.Size = new Size(1226, 500);
            flowReserved.TabIndex = 3;
            flowReserved.WrapContents = false;
            // 
            // lblSectionTitle
            // 
            lblSectionTitle.AutoSize = true;
            lblSectionTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSectionTitle.ForeColor = Color.FromArgb(92, 51, 23);
            lblSectionTitle.Location = new Point(140, 177);
            lblSectionTitle.Name = "lblSectionTitle";
            lblSectionTitle.Size = new Size(246, 30);
            lblSectionTitle.TabIndex = 2;
            lblSectionTitle.Text = "📚 All Reserved Books";
            // 
            // ReservedBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 242, 238);
            ClientSize = new Size(1324, 737);
            Controls.Add(panelHeader);
            Controls.Add(panelSummary);
            Controls.Add(lblSectionTitle);
            Controls.Add(flowReserved);
            Name = "ReservedBooks";
            Text = "Reserved Books";
            WindowState = FormWindowState.Maximized;
            Load += ReservedBooks_Load;
            panelHeader.ResumeLayout(false);
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        #endregion

        private Panel panelHeader;
        private Label lblHeader;
        private Panel panelSummary;
        private Label lblAmount;
        private Label Amountbl;
        private FlowLayoutPanel flowReserved;
        private Label lblSectionTitle;
    }
}