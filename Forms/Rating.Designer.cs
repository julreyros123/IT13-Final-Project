namespace IT13_Final_Project.Forms
{
    partial class Rating
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
            lblTitle = new Label();
            starPanel = new Panel();
            txtReview = new TextBox();
            lblReviewPrompt = new Label();
            lblCharCount = new Label();
            lblRatingDisplay = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(60, 40, 20);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Rate this book";
            // 
            // starPanel
            // 
            starPanel.BackColor = Color.White;
            starPanel.BorderStyle = BorderStyle.FixedSingle;
            starPanel.Location = new Point(83, 60);
            starPanel.Name = "starPanel";
            starPanel.Padding = new Padding(5);
            starPanel.Size = new Size(300, 74);
            starPanel.TabIndex = 1;
            // 
            // txtReview
            // 
            txtReview.BorderStyle = BorderStyle.FixedSingle;
            txtReview.Font = new Font("Segoe UI", 11F);
            txtReview.Location = new Point(20, 200);
            txtReview.MaxLength = 500;
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.ScrollBars = ScrollBars.Vertical;
            txtReview.Size = new Size(460, 250);
            txtReview.TabIndex = 2;
            // 
            // lblReviewPrompt
            // 
            lblReviewPrompt.AutoSize = true;
            lblReviewPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblReviewPrompt.ForeColor = Color.FromArgb(60, 40, 20);
            lblReviewPrompt.Location = new Point(20, 170);
            lblReviewPrompt.Name = "lblReviewPrompt";
            lblReviewPrompt.Size = new Size(108, 21);
            lblReviewPrompt.TabIndex = 3;
            lblReviewPrompt.Text = "Your Review:";
            // 
            // lblCharCount
            // 
            lblCharCount.AutoSize = true;
            lblCharCount.Font = new Font("Segoe UI", 10F);
            lblCharCount.ForeColor = Color.Gray;
            lblCharCount.Location = new Point(20, 460);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(112, 19);
            lblCharCount.TabIndex = 4;
            lblCharCount.Text = "0/500 characters";
            // 
            // lblRatingDisplay
            // 
            lblRatingDisplay.AutoSize = true;
            lblRatingDisplay.Font = new Font("Segoe UI", 12F);
            lblRatingDisplay.ForeColor = Color.FromArgb(60, 40, 20);
            lblRatingDisplay.Location = new Point(197, 137);
            lblRatingDisplay.Name = "lblRatingDisplay";
            lblRatingDisplay.Size = new Size(86, 21);
            lblRatingDisplay.TabIndex = 5;
            lblRatingDisplay.Text = "Rating: 0/5";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(90, 60, 30);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 10F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(20, 500);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(200, 40);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit Review";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(210, 90, 45);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(262, 500);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Rating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(500, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(lblRatingDisplay);
            Controls.Add(lblCharCount);
            Controls.Add(lblReviewPrompt);
            Controls.Add(txtReview);
            Controls.Add(starPanel);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Rating";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Submit Book Review";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel starPanel;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Label lblReviewPrompt;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Label lblRatingDisplay;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}