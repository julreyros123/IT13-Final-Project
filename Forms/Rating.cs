using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    public partial class Rating : Form
    {
        private int _userId, _bookId;
        private int selectedRating = 0;
        private string _connectionString;
        private readonly int maxReviewLength = 500;
        private List<Button> starButtons;

        public Rating(int userId, int bookId, string bookTitle, string connectionString)
        {
            _userId = userId;
            _bookId = bookId;
            _connectionString = connectionString;
            starButtons = new List<Button>();
            InitializeComponent();
            lblTitle.Text = $"Review: {bookTitle}";
            SetupStarButtons();
            txtReview.TextChanged += TxtReview_TextChanged;
            btnSubmit.Click += BtnSubmit_Click;
            btnCancel.Click += (s, e) => this.Close();
        }

        private void SetupStarButtons()
        {
            int starSpacing = 10;
            starPanel.Controls.Clear();
            for (int i = 1; i <= 5; i++)
            {
                var star = new Button
                {
                    Text = "☆",
                    Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                    Size = new Size(50, 50),
                    Location = new Point(5 + (i - 1) * (50 + starSpacing), 5),
                    Tag = i,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.Goldenrod,
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };
                star.FlatAppearance.BorderSize = 0;
                star.MouseEnter += (s, e) => HighlightStars((int)((Button)s).Tag);
                star.MouseLeave += (s, e) => UpdateStarDisplay();
                star.Click += (s, e) => SelectRating((int)((Button)s).Tag);
                starPanel.Controls.Add(star);
                starButtons.Add(star);
            }
        }

        private void HighlightStars(int hoverRating)
        {
            foreach (var btn in starButtons)
            {
                int val = (int)btn.Tag;
                btn.Text = val <= hoverRating ? "★" : "☆";
                btn.ForeColor = val <= hoverRating ? Color.Gold : Color.Goldenrod;
            }
            lblRatingDisplay.Text = $"Rating: {hoverRating}/5";
        }

        private void UpdateStarDisplay()
        {
            foreach (var btn in starButtons)
            {
                int val = (int)btn.Tag;
                btn.Text = val <= selectedRating ? "★" : "☆";
                btn.ForeColor = val <= selectedRating ? Color.Gold : Color.Goldenrod;
            }
            lblRatingDisplay.Text = $"Rating: {selectedRating}/5";
        }

        private void SelectRating(int rating)
        {
            selectedRating = rating;
            UpdateStarDisplay();
        }

        private void TxtReview_TextChanged(object sender, EventArgs e)
        {
            int length = txtReview.Text.Length;
            lblCharCount.Text = $"{length}/{maxReviewLength} characters";
            lblCharCount.ForeColor = length > maxReviewLength * 0.9 ? Color.Red : Color.Gray;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (selectedRating == 0)
            {
                MessageBox.Show("Please select a rating (1–5 stars).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string insert = @"INSERT INTO BookReviews (UserID, BookID, Rating, ReviewText, ReviewDate)
                                      VALUES (@UserID, @BookID, @Rating, @ReviewText, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@BookID", _bookId);
                        cmd.Parameters.AddWithValue("@Rating", selectedRating);
                        cmd.Parameters.AddWithValue("@ReviewText", txtReview.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thank you for your review!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving review: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}