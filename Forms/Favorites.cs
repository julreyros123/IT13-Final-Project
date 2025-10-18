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
        private string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        private int _userId;

        public Favorites(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        public Favorites()
        {
            InitializeComponent();
            _userId = 0;
        }

        private void Favorites_Load(object sender, EventArgs e)
        {
            LoadFavoriteBooks();
        }

        // ✅ Load favorite books for the current user
        private void LoadFavoriteBooks()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; // Ensure horizontal layout
            flowLayoutPanel1.WrapContents = true; // Allow wrapping if needed
            flowLayoutPanel1.AutoScroll = true; // Enable scrolling if 4+ cards exceed width

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT B.BookID, B.BookTitle, B.Author, B.Genre, B.BookImage, B.IsAvailable
                        FROM Favorites F
                        INNER JOIN Books B ON F.BookID = B.BookID
                        WHERE F.UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Panel bookPanel = CreateBookCard(reader);
                                flowLayoutPanel1.Controls.Add(bookPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading favorites: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Create a book display panel from the SQL data
        private Panel CreateBookCard(SqlDataReader reader)
        {
            Panel bookPanel = new Panel
            {
                Size = new Size(200, 300), // Reduced from 220x340
                BackColor = Color.FromArgb(250, 242, 230),
                Margin = new Padding(10), // Reduced from 70
                BorderStyle = BorderStyle.FixedSingle
            };

            // 🖼️ Book image
            PictureBox pic = new PictureBox
            {
                Size = new Size(160, 160), // Reduced from 180x180
                Location = new Point(20, 15),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White
            };

            string imagePath = reader["BookImage"]?.ToString();
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                pic.Image = Image.FromFile(imagePath);

            // 📘 Title
            Label title = new Label
            {
                Text = reader["BookTitle"].ToString(),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold), // Slightly reduced font
                ForeColor = Color.FromArgb(100, 50, 10),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(180, 25), // Reduced from 200
                Location = new Point(10, 190) // Adjusted for new height
            };

            // ✍️ Author
            Label author = new Label
            {
                Text = "by " + reader["Author"].ToString(),
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                AutoSize = false,
                Size = new Size(180, 20), // Reduced from 200
                Location = new Point(10, 215), // Adjusted for new height
                TextAlign = ContentAlignment.MiddleCenter
            };

            // 🏷️ Genre
            Label genre = new Label
            {
                Text = "Genre: " + reader["Genre"].ToString(),
                Font = new Font("Segoe UI", 8), // Slightly reduced font
                AutoSize = false,
                Size = new Size(180, 20), // Reduced from 200
                Location = new Point(10, 235), // Adjusted for new height
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ✅ Availability
            bool available = reader["IsAvailable"] != DBNull.Value && Convert.ToBoolean(reader["IsAvailable"]);
            Label availability = new Label
            {
                Text = available ? "Available" : "Not Available",
                ForeColor = available ? Color.ForestGreen : Color.Red,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(180, 20), // Reduced from 200
                Location = new Point(10, 250), // Adjusted for new height
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ❤️ Remove from favorites button
            Button removeBtn = new Button
            {
                Text = "Remove",
                Size = new Size(90, 25), // Reduced from 100x28
                Location = new Point(55, 270), // Adjusted for new height
                BackColor = Color.FromArgb(120, 63, 4),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            removeBtn.FlatAppearance.BorderSize = 0;

            int bookId = Convert.ToInt32(reader["BookID"]);
            removeBtn.Click += (s, e) => RemoveFavoriteBook(bookId);

            // 🧩 Add all controls to the card
            bookPanel.Controls.Add(pic);
            bookPanel.Controls.Add(title);
            bookPanel.Controls.Add(author);
            bookPanel.Controls.Add(genre);
            bookPanel.Controls.Add(availability);
            bookPanel.Controls.Add(removeBtn);

            return bookPanel;
        }

        // ✅ Remove a favorite book
        private void RemoveFavoriteBook(int bookId)
        {
            DialogResult result = MessageBox.Show("Remove this book from favorites?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM Favorites WHERE UserID = @UserID AND BookID = @BookID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@UserID", _userId);
                            cmd.Parameters.AddWithValue("@BookID", bookId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Book removed from favorites!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadFavoriteBooks(); // refresh
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing book: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Optional refresh button
        private void button3_Click(object sender, EventArgs e)
        {
            LoadFavoriteBooks();
        }
    }
}