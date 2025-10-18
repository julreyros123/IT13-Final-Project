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
            btnReserve = new Button();
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
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 32);
            lblTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            lblAuthor.ForeColor = Color.Black;
            lblAuthor.Location = new Point(20, 40);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(0, 28);
            lblAuthor.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(20, 100);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "There is no description on this book";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(553, 161);
            txtDescription.TabIndex = 3;
            txtDescription.TabStop = false;
            txtDescription.UseWaitCursor = true;
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
            btnFavorite.BackColor = Color.DodgerBlue;
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
            // btnReserve
            // 
            btnReserve.BackColor = Color.DodgerBlue;
            btnReserve.FlatStyle = FlatStyle.Flat;
            btnReserve.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReserve.ForeColor = Color.White;
            btnReserve.Location = new Point(340, 310);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(150, 30);
            btnReserve.TabIndex = 6;
            btnReserve.Text = "Reserve Book";
            btnReserve.UseVisualStyleBackColor = false;
            // 
            // panelDetails
            // 
            panelDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDetails.BackColor = Color.LightGray;
            panelDetails.BorderStyle = BorderStyle.FixedSingle;
            panelDetails.Controls.Add(lblReviewsHeader);
            panelDetails.Controls.Add(reviewsPanel);
            panelDetails.Controls.Add(lblDescription);
            panelDetails.Controls.Add(btnReserve);
            panelDetails.Controls.Add(btnFavorite);
            panelDetails.Controls.Add(lblRating);
            panelDetails.Controls.Add(txtDescription);
            panelDetails.Controls.Add(lblAuthor);
            panelDetails.Controls.Add(lblTitle);
            panelDetails.Location = new Point(280, 100);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(586, 600);
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
            reviewsPanel.BackColor = Color.White;
            reviewsPanel.FlowDirection = FlowDirection.TopDown;
            reviewsPanel.Location = new Point(20, 384);
            reviewsPanel.Name = "reviewsPanel";
            reviewsPanel.Size = new Size(553, 180);
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
            panelHeader.BackColor = Color.DodgerBlue;
            panelHeader.Controls.Add(lblBookDetails);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(866, 60);
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
            ClientSize = new Size(866, 720);
            Controls.Add(panelHeader);
            Controls.Add(panelDetails);
            Controls.Add(pictureBoxCover);
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Details";
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
        private System.Windows.Forms.Button btnReserve;
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
