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

namespace IT13_Final_Project.Forms
{
    public partial class Favorites : Form
    {
        private readonly string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        private readonly int _userId;

        // ✅ Constructor with userId (required)
        public Favorites(int userId)
        {
            InitializeComponent();
            _userId = userId;

            if (_userId <= 0)
            {
                MessageBox.Show("Invalid user session. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.Resize += Favorites_Resize;
        }

        // ⚠ Default constructor disabled for safety
        public Favorites()
        {
            InitializeComponent();
            MessageBox.Show("Error: User session not found. Please re-login.", "Invalid Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void Favorites_Load(object sender, EventArgs e)
        {
            LoadFavoriteBooks();
        }

        private void Favorites_Resize(object sender, EventArgs e)
        {
            int padding = 20;
            flowLayoutPanel1.Width = this.ClientSize.Width - (2 * padding);
            flowLayoutPanel1.Location = new Point(padding, flowLayoutPanel1.Location.Y);
        }

        private void LoadFavoriteBooks()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT b.BookID, b.BookTitle, b.Author, b.Description, b.Genre, b.BookImage
                        FROM Favorites f
                        INNER JOIN Books b ON f.BookID = b.BookID
                        WHERE f.UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            bool hasFavorites = false;

                            while (reader.Read())
                            {
                                hasFavorites = true;

                                int bookId = (int)reader["BookID"];
                                string title = reader["BookTitle"]?.ToString() ?? "N/A";
                                string author = reader["Author"]?.ToString() ?? "N/A";
                                string description = reader["Description"]?.ToString() ?? "No description.";
                                string genre = reader["Genre"]?.ToString() ?? "Unknown";
                                string bookImagePath = reader["BookImage"]?.ToString() ?? "";

                                Panel bookPanel = new Panel
                                {
                                    Size = new Size(300, 140),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    BackColor = Color.NavajoWhite,
                                    Margin = new Padding(10)
                                };

                                PictureBox coverImage = new PictureBox
                                {
                                    Size = new Size(80, 100),
                                    Location = new Point(10, 10),
                                    SizeMode = PictureBoxSizeMode.StretchImage
                                };

                                try
                                {
                                    if (!string.IsNullOrEmpty(bookImagePath) && System.IO.File.Exists(bookImagePath))
                                    {
                                        using (var tempImg = Image.FromFile(bookImagePath))
                                        {
                                            coverImage.Image = new Bitmap(tempImg);
                                        }
                                    }
                                    else
                                    {
                                        coverImage.BackColor = Color.LightGray;
                                    }
                                }
                                catch
                                {
                                    coverImage.BackColor = Color.LightGray;
                                }

                                Label lblTitle = new Label
                                {
                                    Text = title,
                                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                                    AutoSize = true,
                                    Location = new Point(100, 10)
                                };

                                Label lblAuthor = new Label
                                {
                                    Text = "by " + author,
                                    Font = new Font("Segoe UI", 8F, FontStyle.Italic),
                                    AutoSize = true,
                                    Location = new Point(100, 30)
                                };

                                Label lblGenre = new Label
                                {
                                    Text = "Genre: " + genre,
                                    Font = new Font("Segoe UI", 8F),
                                    AutoSize = true,
                                    Location = new Point(100, 50)
                                };

                                Label lblDescription = new Label
                                {
                                    Text = description.Length > 40 ? description.Substring(0, 40) + "..." : description,
                                    Font = new Font("Segoe UI", 8F),
                                    AutoSize = true,
                                    Location = new Point(100, 70)
                                };

                                Button btnRemove = new Button
                                {
                                    Text = "Remove",
                                    Size = new Size(80, 30),
                                    Location = new Point(200, 100),
                                    BackColor = Color.Peru,
                                    ForeColor = Color.White,
                                    FlatStyle = FlatStyle.Flat
                                };
                                btnRemove.Click += (s, ev) => RemoveFavoriteBook(bookId);

                                bookPanel.Controls.Add(coverImage);
                                bookPanel.Controls.Add(lblTitle);
                                bookPanel.Controls.Add(lblAuthor);
                                bookPanel.Controls.Add(lblGenre);
                                bookPanel.Controls.Add(lblDescription);
                                bookPanel.Controls.Add(btnRemove);

                                flowLayoutPanel1.Controls.Add(bookPanel);
                            }

                            if (!hasFavorites)
                            {
                                Label noFav = new Label
                                {
                                    Text = "You have no favorite books yet.",
                                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                                    ForeColor = Color.Gray,
                                    AutoSize = true,
                                    Margin = new Padding(20)
                                };
                                flowLayoutPanel1.Controls.Add(noFav);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading favorite books: " + ex.Message);
            }
        }

        private void RemoveFavoriteBook(int bookId)
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
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Book removed from favorites successfully!");
                    LoadFavoriteBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing book from favorites: " + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Favorites favForm = new Favorites(_userId);
            favForm.TopLevel = false;
            favForm.Dock = DockStyle.Fill;
            Dashboard.MainPanel.Controls.Clear();
            Dashboard.MainPanel.Controls.Add(favForm);
            favForm.Show();
        }
    }
}