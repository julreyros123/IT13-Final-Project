using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    public partial class BookSelection : Form
    {
        private string connectionString =
            "Server=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        private string _genreName;
        private int _userId;  // Added to store UserID

        public BookSelection(string genreName, int userId)
        {
            InitializeComponent();
            _genreName = genreName;
            _userId = userId;
            this.Text = $"Books in {_genreName}";
            this.BackColor = Color.White;
        }

        private void BookSelection_Load(object sender, EventArgs e)
        {
            lblGenre.Text = _genreName;
            lblGenre.Left = (headerPanel.Width - lblGenre.Width) / 2;
            LoadBooksByGenre();
        }

        private void LoadBooksByGenre()
        {
            DataTable booksTable = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT BookID, BookTitle, Author, Description, Genre, BookImage, IsAvailable, Rating
                                     FROM Books 
                                     WHERE Genre = @Genre";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Genre", _genreName);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(booksTable);
                    }
                }

                bookFlowPanel.Controls.Clear();

                foreach (DataRow row in booksTable.Rows)
                {
                    int bookId = Convert.ToInt32(row["BookID"]);
                    string title = row["BookTitle"].ToString();
                    string author = row["Author"].ToString();
                    string desc = row["Description"].ToString();
                    string imagePath = row["BookImage"].ToString();
                    bool available = row["IsAvailable"] != DBNull.Value && (bool)row["IsAvailable"];
                    int rating = row["Rating"] != DBNull.Value ? Convert.ToInt32(row["Rating"]) : 0;

                    // Create Panel
                    Panel bookPanel = new Panel
                    {
                        BackColor = Color.FromArgb(255, 255, 192),
                        Size = new Size(200, 250),
                        Margin = new Padding(15),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Picture
                    PictureBox pb = new PictureBox
                    {
                        ImageLocation = imagePath,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(200, 150),
                        Location = new Point(0, 0),
                        Cursor = Cursors.Hand
                    };
                    bookPanel.Controls.Add(pb);

                    // Title
                    Label lblTitle = new Label
                    {
                        Text = title,
                        Location = new Point(10, 160),
                        AutoSize = true,
                        Font = new Font("Times New Roman", 9F, FontStyle.Bold),
                        ForeColor = Color.Black
                    };
                    bookPanel.Controls.Add(lblTitle);

                    // Availability
                    Label lblAvail = new Label
                    {
                        Text = available ? "Available" : "Unavailable",
                        Location = new Point(10, 180),
                        AutoSize = true,
                        ForeColor = Color.Black
                    };
                    bookPanel.Controls.Add(lblAvail);

                    // Rating
                    Label lblRating = new Label
                    {
                        Text = new string('⭐', rating),
                        Location = new Point(10, 200),
                        AutoSize = true,
                        ForeColor = Color.DarkGoldenrod
                    };
                    bookPanel.Controls.Add(lblRating);

                    // Borrow Button
                    Button btnBorrow = new Button
                    {
                        Text = "Borrow",
                        Size = new Size(80, 23),
                        Location = new Point(60, 220),
                        BackColor = Color.FromArgb(0, 0, 64),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Popup,
                        Enabled = available
                    };
                    bookPanel.Controls.Add(btnBorrow);

                    // Hover effect
                    bookPanel.MouseEnter += (s, e) => bookPanel.BackColor = Color.AliceBlue;
                    bookPanel.MouseLeave += (s, e) => bookPanel.BackColor = Color.FromArgb(255, 255, 192);

                    // Open book details on picture click
                    pb.Click += (s, e) =>
                    {
                        Book bookForm = new Book(bookId, _userId); // pass bookId and userId
                        bookForm.ShowDialog();
                    };

                    // Or open book details on borrow button click
                    btnBorrow.Click += (s, e) =>
                    {
                        Book bookForm = new Book(bookId, _userId); // pass bookId and userId
                        bookForm.ShowDialog();
                    };

                    // Add to FlowPanel
                    bookFlowPanel.Controls.Add(bookPanel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }
    }
}