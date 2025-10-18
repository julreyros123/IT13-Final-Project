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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            genreFlowPanel = new FlowLayoutPanel();
            panelHeader = new Panel();
            lblTitle = new Label();
            Filter = new ComboBox();
            searchgenreTb = new TextBox();
            lblFilter = new Label();
            panelTopControls = new Panel();
            panelHeader.SuspendLayout();
            panelTopControls.SuspendLayout();
            SuspendLayout();
            // 
            // genreFlowPanel
            // 
            genreFlowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            genreFlowPanel.AutoScroll = true;
            genreFlowPanel.BackColor = Color.White;
            genreFlowPanel.Location = new Point(100, 153);
            genreFlowPanel.Margin = new Padding(5);
            genreFlowPanel.Name = "genreFlowPanel";
            genreFlowPanel.Padding = new Padding(10);
            genreFlowPanel.Size = new Size(1100, 465);
            genreFlowPanel.TabIndex = 4;
            genreFlowPanel.Paint += genreFlowPanel_Paint;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DodgerBlue;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(10);
            panelHeader.Size = new Size(1306, 80);
            panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1286, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 CATALOG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Filter
            // 
            Filter.BackColor = Color.WhiteSmoke;
            Filter.DropDownStyle = ComboBoxStyle.DropDownList;
            Filter.FlatStyle = FlatStyle.Flat;
            Filter.Font = new Font("Segoe UI", 11F);
            Filter.ForeColor = Color.FromArgb(92, 51, 23);
            Filter.Location = new Point(90, 12);
            Filter.Name = "Filter";
            Filter.Size = new Size(250, 28);
            Filter.TabIndex = 0;
            Filter.SelectedIndexChanged += Filter_SelectedIndexChanged;
            // 
            // searchgenreTb
            // 
            searchgenreTb.Font = new Font("Segoe UI", 10F);
            searchgenreTb.ForeColor = Color.Gray;
            searchgenreTb.Location = new Point(422, 12);
            searchgenreTb.Name = "searchgenreTb";
            searchgenreTb.PlaceholderText = "🔍 Search books or authors...";
            searchgenreTb.Size = new Size(280, 25);
            searchgenreTb.TabIndex = 1;
            searchgenreTb.TextChanged += searchgenreTb_TextChanged;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFilter.ForeColor = Color.FromArgb(92, 51, 23);
            lblFilter.Location = new Point(10, 15);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(63, 19);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Filter by:";
            // 
            // panelTopControls
            // 
            panelTopControls.BackColor = Color.Transparent;
            panelTopControls.Controls.Add(lblFilter);
            panelTopControls.Controls.Add(Filter);
            panelTopControls.Controls.Add(searchgenreTb);
            panelTopControls.Location = new Point(100, 95);
            panelTopControls.Name = "panelTopControls";
            panelTopControls.Size = new Size(1100, 50);
            panelTopControls.TabIndex = 5;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1306, 623);
            Controls.Add(panelTopControls);
            Controls.Add(genreFlowPanel);
            Controls.Add(panelHeader);
            Name = "Catalog";
            Text = "Catalog";
            WindowState = FormWindowState.Maximized;
            Load += Catalog_Load;
            panelHeader.ResumeLayout(false);
            panelTopControls.ResumeLayout(false);
            panelTopControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private FlowLayoutPanel genreFlowPanel;
        private ComboBox Filter;
        private TextBox searchgenreTb;
        private Label lblFilter;
        private Panel panelTopControls;
    }
}