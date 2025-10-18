using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;

namespace IT13_Final_Project.Forms
{
    public partial class Book : Form
    {
        private string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        private int _bookId;
        private int _userId;
        private bool _isFavorited = false;

        public Book(int bookId, int userId)
        {
            InitializeComponent();
            _bookId = bookId;
            _userId = userId;

            btnReserve.Click += BtnReserve_Click;
            btnFavorite.Click += BtnFavorite_Click;
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadBook(_bookId); // Automatically reload book data when form is activated
        }

        private void Book_Load(object sender, EventArgs e)
        {
            if (_bookId <= 0)
            {
                MessageBox.Show("Invalid book selected.");
                this.Close();
                return;
            }

            if (_userId <= 0)
            {
                MessageBox.Show("Invalid user session. Please log in again.");
                this.Close();
                return;
            }

            LoadBook(_bookId);
            CheckIfBookIsFavorited();
            LoadReviews(_bookId);
        }

        private void LoadBook(int bookId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT BookTitle, Author, Description, Genre, BookImage, IsAvailable 
                                     FROM Books WHERE BookID = @BookID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string title = reader["BookTitle"].ToString();
                            string author = reader["Author"].ToString();
                            string description = reader["Description"].ToString();
                            string imagePath = reader["BookImage"].ToString();
                            bool isAvailable = reader["IsAvailable"] != DBNull.Value ? Convert.ToBoolean(reader["IsAvailable"]) : false;

                            int avgRating = GetAverageRating(bookId);

                            SetBookInfo(title, author, description, imagePath, avgRating, isAvailable);
                        }
                        else
                        {
                            MessageBox.Show("Book not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading book: " + ex.Message);
            }
        }

        private void SetBookInfo(string title, string author, string description, string imagePath, int rating, bool isAvailable)
        {
            lblTitle.Text = title;
            lblAuthor.Text = $"by {author}";
            txtDescription.Text = description;

            // Show stars (⭐) up to 5
            rating = Math.Max(0, Math.Min(rating, 5));
            lblRating.Text = new string('⭐', rating) + $" ({rating}/5)";

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                using (var imgTemp = Image.FromFile(imagePath))
                {
                    pictureBoxCover.Image = new Bitmap(imgTemp);
                }
            }
            else
            {
                pictureBoxCover.Image = null;
            }

            // Update reserve button based on availability
            btnReserve.Enabled = isAvailable;
            btnReserve.Text = isAvailable ? "Reserve" : "Unavailable";
        }

        private int GetAverageRating(int bookId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT AVG(Rating) FROM BookReviews WHERE BookID = @BookID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            return Convert.ToInt32(Math.Round(Convert.ToDouble(result)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rating: " + ex.Message);
            }
            return 0;
        }

        private void BtnReserve_Click(object sender, EventArgs e) => ReserveBook();

        private void ReserveBook()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string reserveQuery = @"INSERT INTO Reservations (UserID, BookID, ReservationDate, Status)
                                            VALUES (@UserID, @BookID, GETDATE(), 'Reserved')";
                    using (SqlCommand cmd = new SqlCommand(reserveQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@BookID", _bookId);
                        cmd.ExecuteNonQuery();
                    }

                    string updateBookQuery = "UPDATE Books SET IsAvailable = 0 WHERE BookID = @BookID";
                    using (SqlCommand cmd = new SqlCommand(updateBookQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", _bookId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book reserved successfully!");
                    LoadBook(_bookId); // Refresh the book details
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reserving book: " + ex.Message);
            }
        }

        private void BtnFavorite_Click(object sender, EventArgs e)
        {
            if (_isFavorited)
                RemoveFromFavorites();
            else
                AddToFavorites();
        }

        private void CheckIfBookIsFavorited()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Favorites WHERE UserID = @UserID AND BookID = @BookID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@BookID", _bookId);

                        int count = (int)cmd.ExecuteScalar();
                        _isFavorited = count > 0;
                        btnFavorite.Text = _isFavorited ? "Unfavorite" : "Add to Favorites";
                        btnFavorite.BackColor = _isFavorited ? Color.Sienna : Color.Peru;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking favorite status: " + ex.Message);
            }
        }

        private void AddToFavorites()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO Favorites (UserID, BookID, AddedDate) VALUES (@UserID, @BookID, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@BookID", _bookId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book added to favorites successfully!");
                    _isFavorited = true;
                    btnFavorite.Text = "Unfavorite";
                    btnFavorite.BackColor = Color.Sienna;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to favorites: " + ex.Message);
            }
        }

        private void RemoveFromFavorites()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string deleteQuery = "DELETE FROM Favorites WHERE UserID = @UserID AND BookID = @BookID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@BookID", _bookId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book removed from favorites.");
                    _isFavorited = false;
                    btnFavorite.Text = "Add to Favorites";
                    btnFavorite.BackColor = Color.Peru;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing favorite: " + ex.Message);
            }
        }

        private void LoadReviews(int bookId)
        {
            reviewsPanel.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT U.Username, R.Rating, R.ReviewText, R.ReviewDate
                                     FROM BookReviews R
                                     INNER JOIN Users U ON R.UserID = U.UserID
                                     WHERE R.BookID = @BookID
                                     ORDER BY R.ReviewDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string username = reader["Username"].ToString();
                            int rating = Convert.ToInt32(reader["Rating"]);
                            string review = reader["ReviewText"].ToString();
                            DateTime date = Convert.ToDateTime(reader["ReviewDate"]);

                            Panel reviewBox = new Panel
                            {
                                Width = reviewsPanel.Width - 10,
                                Height = 70,
                                BackColor = Color.Beige,
                                Margin = new Padding(5)
                            };

                            Label lblUser = new Label
                            {
                                Text = $"{username} - {new string('⭐', rating)}",
                                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                                Dock = DockStyle.Top
                            };

                            Label lblReview = new Label
                            {
                                Text = $"{review} ({date.ToShortDateString()})",
                                AutoSize = false,
                                Dock = DockStyle.Fill
                            };

                            reviewBox.Controls.Add(lblReview);
                            reviewBox.Controls.Add(lblUser);
                            reviewsPanel.Controls.Add(reviewBox);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reviews: " + ex.Message);
            }
        }

        private void reviewsPanel_Paint(object sender, PaintEventArgs e)
        {
            // custom paint if needed
        }
    }
}