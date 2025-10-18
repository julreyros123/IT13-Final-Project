using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    public partial class Catalog : Form
    {
        private string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        private int _userId;
        private DataTable booksTable;

        public Catalog(int userId)
        {
            InitializeComponent();
            _userId = userId;
            this.Resize += Catalog_Resize; // Handle resize events
            // Removed Activated += Catalog_Activated since OnActivated handles it
        }

        public Catalog()
        {
            InitializeComponent();
            _userId = 0;
            this.Resize += Catalog_Resize; // Handle resize events
            // Removed Activated += Catalog_Activated since OnActivated handles it
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            // Automatically refresh when form is activated
            if (Filter != null && Filter.SelectedValue != null)
            {
                LoadBooks(Filter.SelectedValue.ToString(), 300); // Increased height to ensure visibility
            }
            else
            {
                LoadBooks("All Genres", 300); // Increased height to ensure visibility
            }
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            if (genreFlowPanel == null)
            {
                MessageBox.Show("FlowLayoutPanel 'genreFlowPanel' is not initialized. Please add it in the Designer.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Filter == null || searchgenreTb == null)
            {
                MessageBox.Show("ComboBox 'Filter' or TextBox 'searchgenreTb' is not initialized. Please add them in the Designer.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadGenreFilter();
            LoadBooks("All Genres", 300); // Increased height to ensure visibility
        }

        private void Catalog_Resize(object sender, EventArgs e)
        {
            LoadBooks(Filter.SelectedValue?.ToString() ?? "All Genres", 300); // Reload books on resize with increased height
        }

        private void LoadGenreFilter()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT DISTINCT Genre FROM Books WHERE Genre IS NOT NULL ORDER BY Genre";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow allRow = dt.NewRow();
                    allRow["Genre"] = "All Genres";
                    dt.Rows.InsertAt(allRow, 0);

                    Filter.DisplayMember = "Genre";
                    Filter.ValueMember = "Genre";
                    Filter.DataSource = dt;
                    Filter.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks(string selectedGenre = "All Genres", int cardHeight = 300)
        {
            if (genreFlowPanel == null)
            {
                MessageBox.Show("FlowLayoutPanel not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            genreFlowPanel.Controls.Clear();
            genreFlowPanel.AutoScroll = true;
            genreFlowPanel.WrapContents = true;
            genreFlowPanel.Padding = new Padding(70, 20, 70, 40); // Increased bottom padding for space below cards
            genreFlowPanel.FlowDirection = FlowDirection.LeftToRight;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"SELECT BookID, BookTitle, Author, Description, Genre, BookImage, IsAvailable
                                     FROM Books";
                    if (selectedGenre != "All Genres")
                        query += " WHERE Genre = @Genre";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (selectedGenre != "All Genres")
                            cmd.Parameters.AddWithValue("@Genre", selectedGenre);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            booksTable = new DataTable();
                            da.Fill(booksTable);
                        }
                    }

                    int panelWidth = genreFlowPanel.ClientSize.Width;
                    int cardWidth = Math.Max(180, (panelWidth - 80) / 4);

                    foreach (DataRow row in booksTable.Rows)
                    {
                        Panel bookPanel = new Panel
                        {
                            Width = cardWidth,
                            Height = cardHeight, // Increased to 300 for better visibility
                            BackColor = Color.FromArgb(250, 242, 230),
                            Margin = new Padding(15, 5, 15, 20), // Added padding below each card
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        PictureBox bookImage = new PictureBox
                        {
                            Dock = DockStyle.Top,
                            Height = (int)(cardHeight * 0.45), // Adjusted to 45% to free up space
                            SizeMode = PictureBoxSizeMode.Zoom,
                            BackColor = Color.White
                        };

                        try
                        {
                            string imagePath = row["BookImage"].ToString();
                            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                                bookImage.Image = Image.FromFile(imagePath);
                            else
                                bookImage.Image = Properties.Resources.noimage;
                        }
                        catch
                        {
                            bookImage.Image = Properties.Resources.noimage;
                        }

                        Label titleLabel = new Label
                        {
                            Text = row["BookTitle"].ToString(),
                            Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                            Dock = DockStyle.Top,
                            Height = (int)(cardHeight * 0.09), // Slightly increased to 9%
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        Label authorLabel = new Label
                        {
                            Text = "by " + row["Author"].ToString(),
                            Font = new Font("Segoe UI", 8, FontStyle.Italic),
                            Dock = DockStyle.Top,
                            Height = (int)(cardHeight * 0.07), // Slightly increased to 7%
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        Label genreLabel = new Label
                        {
                            Text = "Genre: " + row["Genre"].ToString(),
                            Dock = DockStyle.Top,
                            Height = (int)(cardHeight * 0.06), // 6% of card height
                            Font = new Font("Segoe UI", 8),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        bool available = row["IsAvailable"] != DBNull.Value && Convert.ToBoolean(row["IsAvailable"]);
                        Label availabilityLabel = new Label
                        {
                            Text = available ? "Available" : "Not Available",
                            ForeColor = available ? Color.ForestGreen : Color.Red,
                            Font = new Font("Segoe UI", 8, FontStyle.Bold),
                            Dock = DockStyle.Top,
                            Height = (int)(cardHeight * 0.06), // 6% of card height
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        Button viewBookBtn = new Button
                        {
                            Text = "View Details",
                            Dock = DockStyle.Bottom,
                            Height = (int)(cardHeight * 0.12), // Increased to 12% for better visibility
                            BackColor = Color.FromArgb(120, 63, 4),
                            ForeColor = Color.White,
                            FlatStyle = FlatStyle.Flat,
                            Cursor = Cursors.Hand
                        };
                        viewBookBtn.FlatAppearance.BorderSize = 0;

                        // Open the Book form when clicked
                        viewBookBtn.Click += (s, e) =>
                        {
                            int bookId = Convert.ToInt32(row["BookID"]);
                            Book bookForm = new Book(bookId, _userId)
                            {
                                FormBorderStyle = FormBorderStyle.FixedDialog,
                                StartPosition = FormStartPosition.CenterParent,
                                Size = new Size(882, 759),
                                MaximizeBox = false,
                                MinimizeBox = false,
                                ShowInTaskbar = false
                            };
                            bookForm.Show(this); // Show as a small, centered frame over Catalog
                        };

                        bookPanel.Controls.Add(viewBookBtn);
                        bookPanel.Controls.Add(availabilityLabel);
                        bookPanel.Controls.Add(genreLabel);
                        bookPanel.Controls.Add(authorLabel);
                        bookPanel.Controls.Add(titleLabel);
                        bookPanel.Controls.Add(bookImage);

                        genreFlowPanel.Controls.Add(bookPanel);
                    }

                    if (booksTable.Rows.Count == 0)
                    {
                        Label noBooks = new Label
                        {
                            Text = "No books found.",
                            Font = new Font("Segoe UI", 10, FontStyle.Italic),
                            AutoSize = true,
                            ForeColor = Color.Gray,
                            Margin = new Padding(10)
                        };
                        genreFlowPanel.Controls.Add(noBooks);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchgenreTb_TextChanged(object sender, EventArgs e)
        {
            string filter = searchgenreTb.Text.Trim().ToLower();
            foreach (Control ctrl in genreFlowPanel.Controls)
            {
                if (ctrl is Panel panel)
                {
                    bool visible = string.IsNullOrEmpty(filter);
                    foreach (Control inner in panel.Controls)
                    {
                        if (inner is Label lbl && lbl.Text.ToLower().Contains(filter))
                        {
                            visible = true;
                            break;
                        }
                    }
                    // Additional search fields
                    DataRow[] rows = booksTable.Select($"BookTitle LIKE '%{filter}%' OR Author LIKE '%{filter}%' OR Genre LIKE '%{filter}%'");
                    visible |= rows.Any(r => Convert.ToInt32(r["BookID"]) == GetBookIdFromPanel(panel));
                    panel.Visible = visible;
                }
            }
        }

        private int GetBookIdFromPanel(Panel panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is PictureBox pb && pb.Image != null)
                {
                    var row = booksTable.AsEnumerable().FirstOrDefault(r => r["BookImage"].ToString() == GetImagePathFromPictureBox(pb));
                    if (row != null) return Convert.ToInt32(row["BookID"]);
                }
            }
            return -1;
        }

        private string GetImagePathFromPictureBox(PictureBox pb)
        {
            // This is a simplistic approach; adjust based on how images are stored
            return pb.Image != Properties.Resources.noimage ? pb.ImageLocation : "";
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filter.SelectedValue != null)
            {
                string selectedGenre = Filter.SelectedValue.ToString();
                LoadBooks(selectedGenre, 300); // Increased height to ensure visibility
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog(_userId);
            catalog.Dock = DockStyle.Fill;
            catalog.TopLevel = false;
            Dashboard.MainPanel.Controls.Clear();
            Dashboard.MainPanel.Controls.Add(catalog);
            catalog.Show();
        }

        private void button2_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void genreFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}