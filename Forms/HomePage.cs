using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    public partial class HomePage : Form
    {
        private string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        private int _userId; // ✅ User session
        public static Panel MainPanel;

        public HomePage(int userId)
        {
            InitializeComponent();
            _userId = userId;

            MainPanel = this.panel2;

            LoadNewlyAddedBooks();    // ✅ Newly Added
            LoadTopBooks();           // ✅ Top Books by Reviews
        }

        // ⚠ Default constructor only for designer
        public HomePage()
        {
            InitializeComponent();
            MessageBox.Show("Error: User session not found. Please re-login.", "Invalid Access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            // Automatically refresh when form is activated
            LoadNewlyAddedBooks();
            LoadTopBooks();
        }

        // ✅ Load Newly Added Books (with dynamic rating from BookReviews)
        private void LoadNewlyAddedBooks()
        {
            try
            {
                flowLayoutNew.Controls.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT TOP 10 
                            b.BookID,
                            b.BookTitle,
                            b.IsAvailable,
                            b.BookImage,
                            ISNULL(AVG(r.Rating), 0) AS AvgRating
                        FROM Books b
                        LEFT JOIN BookReviews r ON b.BookID = r.BookID
                        GROUP BY b.BookID, b.BookTitle, b.IsAvailable, b.BookImage, b.DateAdded
                        ORDER BY b.DateAdded DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Panel bookPanel = CreateBookCard(reader);
                            flowLayoutNew.Controls.Add(bookPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading newly added books: " + ex.Message);
            }
        }

        // ✅ Load Top Books based on average rating in BookReviews
        private void LoadTopBooks()
        {
            try
            {
                flowLayoutTop.Controls.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT TOP 10 
                            b.BookID, 
                            b.BookTitle, 
                            b.IsAvailable, 
                            b.BookImage,
                            ISNULL(AVG(r.Rating), 0) AS AvgRating
                        FROM Books b
                        LEFT JOIN BookReviews r ON b.BookID = r.BookID
                        GROUP BY b.BookID, b.BookTitle, b.IsAvailable, b.BookImage
                        ORDER BY AvgRating DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Panel bookPanel = CreateBookCard(reader);
                            flowLayoutTop.Controls.Add(bookPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading top books: " + ex.Message);
            }
        }

        // ✅ Reusable function to create book card
        private Panel CreateBookCard(SqlDataReader reader)
        {
            int bookId = Convert.ToInt32(reader["BookID"]);
            string title = reader["BookTitle"].ToString();
            bool available = reader["IsAvailable"] != DBNull.Value && (bool)reader["IsAvailable"];
            int rating = reader["AvgRating"] != DBNull.Value ? Convert.ToInt32(Math.Round(Convert.ToDouble(reader["AvgRating"]))) : 0;

            // Load book image safely
            Image cover = Properties.Resources.noimage; // fallback
            try
            {
                if (!(reader["BookImage"] is DBNull))
                {
                    string imgPath = reader["BookImage"].ToString();
                    if (File.Exists(imgPath))
                        cover = Image.FromFile(imgPath);
                }
            }
            catch { }

            // 🟫 Card style (medium)
            Panel bookPanel = new Panel
            {
                Width = 220,
                Height = 300,
                BackColor = Color.FromArgb(245, 236, 220), // soft cream background
                Margin = new Padding(9),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = bookId
            };

            // 🖼️ Image
            PictureBox pb = new PictureBox
            {
                Image = cover,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(220, 160),
                Location = new Point(0, 0),
                BackColor = Color.White,
                Cursor = Cursors.Hand,
                Tag = bookId
            };
            pb.Click += Book_Click;
            bookPanel.Controls.Add(pb);

            // 📖 Title
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Size = new Size(200, 25),
                Location = new Point(10, 170),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Black
            };
            lblTitle.Click += Book_Click;
            bookPanel.Controls.Add(lblTitle);

            // 🟡 Rating
            Label lblRating = new Label
            {
                Text = $"⭐ {rating}/5",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Size = new Size(200, 20),
                Location = new Point(10, 195),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.DarkGoldenrod
            };
            bookPanel.Controls.Add(lblRating);

            // ✅ Availability
            Label lblAvail = new Label
            {
                Text = available ? "Available" : "Not Available",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Size = new Size(200, 20),
                Location = new Point(10, 215),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = available ? Color.ForestGreen : Color.Red
            };
            bookPanel.Controls.Add(lblAvail);

            // ☕ Borrow Button
            Button btnBorrow = new Button
            {
                Text = "View Detail",
                Size = new Size(200, 30),
                Location = new Point((bookPanel.Width - 200) / 2, 250), // centered button
                BackColor = Color.FromArgb(120, 63, 4), // coffee brown
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Tag = bookId,
                Cursor = Cursors.Hand
            };
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.Click += Book_Click;
            bookPanel.Controls.Add(btnBorrow);

            return bookPanel;
        }

        // ✅ Handle clicks on any book item
        private void Book_Click(object sender, EventArgs e)
        {
            if (sender is Control ctrl && ctrl.Tag != null)
            {
                int bookId = Convert.ToInt32(ctrl.Tag);
                var bookForm = new Book(bookId, _userId);
                bookForm.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage HPForm = new HomePage(_userId);
            HPForm.TopLevel = false;
            HPForm.Dock = DockStyle.Fill;
            HomePage.MainPanel.Controls.Clear();
            HomePage.MainPanel.Controls.Add(HPForm);
            HPForm.Show();
        }

        private void HomePage_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void flowLayoutTop_Paint(object sender, PaintEventArgs e) { }
    }
}