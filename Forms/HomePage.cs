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

            // Load image
            Image cover = null;
            try
            {
                if (!(reader["BookImage"] is DBNull))
                {
                    string imgPath = reader["BookImage"].ToString();
                    if (File.Exists(imgPath))
                        cover = Image.FromFile(imgPath);
                }
            }
            catch { cover = null; }

            // ✅ Build book card
            Panel bookPanel = new Panel
            {
                BackColor = Color.NavajoWhite,
                Size = new Size(160, 240),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = bookId
            };

            PictureBox pb = new PictureBox
            {
                Image = cover,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(140, 140),
                Location = new Point(10, 10),
                BackColor = Color.LightGray,
                Cursor = Cursors.Hand,
                Tag = bookId
            };
            pb.Click += Book_Click;
            bookPanel.Controls.Add(pb);

            Label lblTitle = new Label
            {
                Text = title,
                Location = new Point(10, 155),
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.Black,
                MaximumSize = new Size(140, 0)
            };
            lblTitle.Click += Book_Click;
            bookPanel.Controls.Add(lblTitle);

            Label lblAvail = new Label
            {
                Text = available ? "Available" : "Unavailable",
                Location = new Point(10, 175),
                AutoSize = true,
                ForeColor = available ? Color.Green : Color.Red
            };
            bookPanel.Controls.Add(lblAvail);

            Label lblRating = new Label
            {
                Text = $"⭐ {rating}/5",
                Location = new Point(10, 195),
                AutoSize = true,
                ForeColor = Color.DarkGoldenrod
            };
            bookPanel.Controls.Add(lblRating);

            Button btnBorrow = new Button
            {
                Text = "Borrow",
                Size = new Size(70, 25),
                Location = new Point(80, 210),
                BackColor = Color.Peru,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Tag = bookId,
                Enabled = available
            };
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
