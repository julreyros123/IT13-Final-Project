namespace IT13_Final_Project.Forms
{
    partial class Book
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
            pictureBoxCover = new PictureBox();
            lblTitle = new Label();
            lblAuthor = new Label();
            txtDescription = new TextBox();
            lblRating = new Label();
            btnFavorite = new Button();
            btnBorrow = new Button();
            panelDetails = new Panel();
            lblReviewsHeader = new Label();
            reviewsPanel = new FlowLayoutPanel();
            lblDescription = new Label();
            panelHeader = new Panel();
            lblBookDetails = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            panelDetails.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCover.Location = new Point(50, 100);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(193, 257);
            pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCover.TabIndex = 0;
            pictureBoxCover.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 25);
            lblTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblAuthor.ForeColor = Color.DimGray;
            lblAuthor.Location = new Point(20, 55);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(0, 19);
            lblAuthor.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Location = new Point(20, 100);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(463, 161);
            txtDescription.TabIndex = 3;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 12F);
            lblRating.ForeColor = Color.DarkGoldenrod;
            lblRating.Location = new Point(20, 270);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(0, 21);
            lblRating.TabIndex = 4;
            // 
            // btnFavorite
            // 
            btnFavorite.BackColor = Color.Peru;
            btnFavorite.FlatStyle = FlatStyle.Flat;
            btnFavorite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFavorite.ForeColor = Color.White;
            btnFavorite.Location = new Point(20, 310);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(150, 30);
            btnFavorite.TabIndex = 5;
            btnFavorite.Text = "Add to Favorites";
            btnFavorite.UseVisualStyleBackColor = false;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.Peru;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBorrow.ForeColor = Color.White;
            btnBorrow.Location = new Point(340, 310);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(150, 30);
            btnBorrow.TabIndex = 6;
            btnBorrow.Text = "Borrow Book";
            btnBorrow.UseVisualStyleBackColor = false;
            // 
            // panelDetails
            // 
            panelDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDetails.BackColor = Color.NavajoWhite;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Controls.Add(lblReviewsHeader);
            panelDetails.Controls.Add(reviewsPanel);
            panelDetails.Controls.Add(lblDescription);
            panelDetails.Controls.Add(btnBorrow);
            panelDetails.Controls.Add(btnFavorite);
            panelDetails.Controls.Add(lblRating);
            panelDetails.Controls.Add(txtDescription);
            panelDetails.Controls.Add(lblAuthor);
            panelDetails.Controls.Add(lblTitle);
            panelDetails.Location = new Point(280, 100);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(555, 600);
            panelDetails.TabIndex = 7;
            // 
            // lblReviewsHeader
            // 
            lblReviewsHeader.AutoSize = true;
            lblReviewsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReviewsHeader.Location = new Point(20, 360);
            lblReviewsHeader.Name = "lblReviewsHeader";
            lblReviewsHeader.Size = new Size(114, 21);
            lblReviewsHeader.TabIndex = 9;
            lblReviewsHeader.Text = "User Reviews:";
            // 
            // reviewsPanel
            // 
            reviewsPanel.AutoScroll = true;
            reviewsPanel.BackColor = Color.WhiteSmoke;
            reviewsPanel.FlowDirection = FlowDirection.TopDown;
            reviewsPanel.Location = new Point(20, 390);
            reviewsPanel.Name = "reviewsPanel";
            reviewsPanel.Size = new Size(510, 180);
            reviewsPanel.TabIndex = 10;
            reviewsPanel.WrapContents = false;
            reviewsPanel.Paint += reviewsPanel_Paint;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.Location = new Point(20, 80);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 19);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(128, 64, 0);
            panelHeader.Controls.Add(lblBookDetails);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(819, 60);
            panelHeader.TabIndex = 8;
            // 
            // lblBookDetails
            // 
            lblBookDetails.AutoSize = true;
            lblBookDetails.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBookDetails.ForeColor = Color.White;
            lblBookDetails.Location = new Point(20, 15);
            lblBookDetails.Name = "lblBookDetails";
            lblBookDetails.Size = new Size(142, 30);
            lblBookDetails.TabIndex = 0;
            lblBookDetails.Text = "Book Details";
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(819, 720);
            Controls.Add(panelHeader);
            Controls.Add(panelDetails);
            Controls.Add(pictureBoxCover);
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Details";
            WindowState = FormWindowState.Maximized;
            Load += Book_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblBookDetails;

        // ✅ New controls for reviews
        private System.Windows.Forms.Label lblReviewsHeader;
        private System.Windows.Forms.FlowLayoutPanel reviewsPanel;

        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Button btnSubmitReview;

    }
}
