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
using System.Windows.Forms.DataVisualization.Charting;

namespace IT13_Final_Project
{
    public partial class AdminDashboard : Form
    {
        private readonly string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
        private int selectedBookId = -1;
        private int selectedReservationId = -1;

        // Added missing txtPhotoPath field (should be in designer, added as fallback)
        private System.Windows.Forms.TextBox txtPhotoPath;

        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load;
        }

        // ✅ Load genres into ComboBox
        private void LoadGenresToComboBox()
        {
            cmbGenre.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT GenreName FROM Genre ORDER BY GenreName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbGenre.Items.Add(reader["GenreName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres (ComboBox): " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Load Books into DataGridView
        private void LoadBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT BookID, BookTitle, Author, Description, Genre, BookImage FROM Books";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewBooks.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Ensure InitializeComponent runs first (handled by designer)
            LoadBooks();
            LoadGenres();
            LoadReservations();
            LoadAnalytics();
            LoadReports();

            // Fallback initialization for txtPhotoPath if not in designer
            if (txtPhotoPath == null)
            {
                txtPhotoPath = new TextBox
                {
                    Location = new Point(150, 230),
                    Size = new Size(150, 19),
                    Name = "txtPhotoPath",
                    TabIndex = 10,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    Font = new Font("Segoe UI", 10.5F),
                    ForeColor = Color.DimGray
                };
                tabPageBooks.Controls.Add(txtPhotoPath);
            }

            // Set up chart properties
            if (chartAnalytics != null)
            {
                chartAnalytics.Visible = true;
                chartAnalytics.Size = new Size(400, 200);
                chartAnalytics.Location = new Point(10, 10);
            }
            if (chartPieAnalytics != null)
            {
                chartPieAnalytics.Visible = true;
                chartPieAnalytics.Size = new Size(600, 300); // Enlarged pie chart
                chartPieAnalytics.Location = new Point(420, 10); // Adjusted to fit larger size
            }
        }

        private void btnAddGenre_Click_1(object sender, EventArgs e)
        {
            string genreName = txtGenreName.Text.Trim();

            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Please enter a genre name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Genre (GenreName) VALUES (@name)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", genreName);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Genre added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtGenreName.Clear();
                            LoadGenres();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add genre.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Load genres into ListBox
        private void LoadGenres()
        {
            listBoxGenres.Items.Clear();
            cmbGenre.Items.Clear();
            cmbUpdateGenre.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT GenreName FROM Genre ORDER BY GenreName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string genre = reader["GenreName"]?.ToString() ?? string.Empty;

                            if (!string.IsNullOrEmpty(genre))
                            {
                                listBoxGenres.Items.Add(genre);
                                cmbGenre.Items.Add(genre);
                                cmbUpdateGenre.Items.Add(genre);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxGenres_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxGenres.SelectedItem != null)
            {
                txtGenreName.Text = listBoxGenres.SelectedItem.ToString();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Book Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (txtPhotoPath != null) // Safety check
                    {
                        txtPhotoPath.Text = ofd.FileName;
                        if (pictureBoxBook != null)
                        {
                            pictureBoxBook.Image = Image.FromFile(ofd.FileName);
                        }
                    }
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtBookTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string description = txtDescription.Text.Trim();
            string genre = cmbGenre.SelectedItem?.ToString();
            string imagePath = txtPhotoPath?.Text.Trim() ?? string.Empty; // Handle null safely

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Books (BookTitle, Author, Description, Genre, BookImage) " +
                                   "VALUES (@title, @auth, @desc, @genre, @img)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@auth", author);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@img", imagePath);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Book added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear inputs
                            txtBookTitle.Clear();
                            txtAuthor.Clear();
                            txtDescription.Clear();
                            if (txtPhotoPath != null) txtPhotoPath.Clear();
                            if (pictureBoxBook != null) pictureBoxBook.Image = null;
                            cmbGenre.SelectedIndex = -1;

                            LoadBooks(); // refresh book list
                        }
                        else
                        {
                            MessageBox.Show("Failed to add book.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];
                selectedBookId = Convert.ToInt32(row.Cells["BookID"].Value);
                txtUpdateTitle.Text = row.Cells["BookTitle"].Value.ToString();
                txtUpdateAuthor.Text = row.Cells["Author"].Value.ToString();
                txtUpdateDescription.Text = row.Cells["Description"].Value.ToString();
                cmbUpdateGenre.Text = row.Cells["Genre"].Value.ToString();
                txtUpdatePhoto.Text = row.Cells["BookImage"].Value.ToString();

                try
                {
                    if (!string.IsNullOrEmpty(txtUpdatePhoto.Text) && File.Exists(txtUpdatePhoto.Text))
                    {
                        pictureBoxUpdate.Image = Image.FromFile(txtUpdatePhoto.Text);
                    }
                    else
                    {
                        pictureBoxUpdate.Image = null;
                    }
                }
                catch
                {
                    pictureBoxUpdate.Image = null;
                }
            }
        }

        private void btnUpdateBrowse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Book Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtUpdatePhoto.Text = ofd.FileName;
                    pictureBoxUpdate.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please select a book first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string booktitle = txtUpdateTitle.Text.Trim();
            string description = txtUpdateDescription.Text.Trim();
            string author = txtUpdateAuthor.Text.Trim();
            string genre = cmbUpdateGenre.SelectedItem?.ToString();
            string imagePath = txtUpdatePhoto.Text.Trim();

            if (string.IsNullOrWhiteSpace(booktitle) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please fill in all update fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Books 
                                     SET BookTitle = @title, Description = @desc, Author = @auth, Genre = @genre, BookImage = @img 
                                     WHERE BookID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", booktitle);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@auth", author);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@img", imagePath);
                        cmd.Parameters.AddWithValue("@id", selectedBookId);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks(); // refresh table
                        }
                        else
                        {
                            MessageBox.Show("Failed to update book.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please select a book first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this book?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Books WHERE BookID = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedBookId);
                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Book deleted successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadBooks();
                                selectedBookId = -1;
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete book.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectedBookId = -1; // Reset on failure
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        // ✅ Updated: LoadReservations - Shows only specified fields
        private void LoadReservations()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT R.ReservationID, R.UserID, R.BookID, R.ReservationDate, R.BorrowDate, R.DueDate, R.ReturnDate, R.Status
                        FROM Reservations R
                        ORDER BY R.ReservationDate DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewReservations.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewReservations.Rows[e.RowIndex];
                selectedReservationId = Convert.ToInt32(row.Cells["ReservationID"].Value);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (selectedReservationId == -1)
            {
                MessageBox.Show("Please select a reservation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateReservationStatus("Borrowed");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (selectedReservationId == -1)
            {
                MessageBox.Show("Please select a reservation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateReservationStatus("Returned");
        }

        private void UpdateReservationStatus(string status)
        {
            try
            {
                if (selectedReservationId == -1)
                {
                    MessageBox.Show("Please select a reservation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.Transaction = transaction;

                            string query;
                            if (status == "Borrowed")
                            {
                                query = @"
                            UPDATE Reservations 
                            SET Status = @status, 
                                BorrowDate = @borrowDate, 
                                DueDate = DATEADD(day, 5, @borrowDate)
                            WHERE ReservationID = @id";
                            }
                            else if (status == "Returned")
                            {
                                query = @"
                            UPDATE Reservations 
                            SET Status = @status, 
                                ReturnDate = @returnDate, 
                                FineAmount = 0
                            WHERE ReservationID = @id";
                                // Debug the BookID
                                string bookIdQuery = "SELECT BookID FROM Reservations WHERE ReservationID = @id";
                                int bookId;
                                using (SqlCommand bookIdCmd = new SqlCommand(bookIdQuery, conn, transaction))
                                {
                                    bookIdCmd.Parameters.AddWithValue("@id", selectedReservationId);
                                    var result = bookIdCmd.ExecuteScalar();
                                    bookId = result != DBNull.Value ? Convert.ToInt32(result) : -1;
                                    if (bookId == -1)
                                    {
                                        MessageBox.Show("No BookID found for the selected reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        transaction.Rollback();
                                        return;
                                    }
                                }
                                // Update Books table
                                string updateBookQuery = "UPDATE Books SET IsAvailable = 1 WHERE BookID = @bookId";
                                using (SqlCommand bookCmd = new SqlCommand(updateBookQuery, conn, transaction))
                                {
                                    bookCmd.Parameters.AddWithValue("@bookId", bookId);
                                    bookCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                query = "UPDATE Reservations SET Status = @status WHERE ReservationID = @id";
                            }

                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@id", selectedReservationId);

                            if (status == "Borrowed")
                            {
                                cmd.Parameters.AddWithValue("@borrowDate", DateTime.Now);
                            }
                            else if (status == "Returned")
                            {
                                cmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                            }

                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show($"Reservation updated to {status}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadReservations();
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Failed to update reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Updated: LoadAnalytics - Ensure whole numbers and no duplicates on bar graph
        private void LoadAnalytics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Query for bar chart: Total reservations per genre
                    string barQuery = @"
                SELECT B.Genre, COUNT(*) as ReserveCount
                FROM Books B
                INNER JOIN Reservations R ON B.BookId = R.BookId
                GROUP BY B.Genre
                ORDER BY ReserveCount DESC";

                    // Query for pie chart: Reservations per genre, aggregated by user preference
                    string pieQuery = @"
                SELECT B.Genre, COUNT(*) as UserPreferenceCount
                FROM Books B
                INNER JOIN Reservations R ON B.BookId = R.BookId
                INNER JOIN Users U ON R.UserId = U.UserId
                GROUP BY B.Genre
                ORDER BY UserPreferenceCount DESC";

                    using (SqlCommand barCmd = new SqlCommand(barQuery, conn))
                    using (SqlCommand pieCmd = new SqlCommand(pieQuery, conn))
                    {
                        using (SqlDataReader barReader = barCmd.ExecuteReader())
                        {
                            // Initialize charts if null
                            if (chartAnalytics == null)
                            {
                                chartAnalytics = new System.Windows.Forms.DataVisualization.Charting.Chart();
                                chartAnalytics.Location = new Point(10, 10);
                                chartAnalytics.Size = new Size(400, 200);
                                chartAnalytics.Visible = true;
                                chartAnalytics.BackColor = Color.White;
                                tabPageAnalytics.Controls.Add(chartAnalytics);
                                Console.WriteLine("Initialized chartAnalytics");
                            }
                            if (chartPieAnalytics == null)
                            {
                                chartPieAnalytics = new System.Windows.Forms.DataVisualization.Charting.Chart();
                                chartPieAnalytics.Location = new Point(420, 10);
                                chartPieAnalytics.Size = new Size(600, 300); // Enlarged pie chart
                                chartPieAnalytics.Visible = true;
                                chartPieAnalytics.BackColor = Color.White;
                                tabPageAnalytics.Controls.Add(chartPieAnalytics);
                                Console.WriteLine("Initialized chartPieAnalytics");
                            }

                            // Clear existing series
                            chartAnalytics.Series.Clear();
                            chartPieAnalytics.Series.Clear();

                            // Bar chart setup (Total reservations per genre)
                            Series barSeries = new Series("Reserved Books (Bar)")
                            {
                                ChartType = SeriesChartType.Bar,
                                IsVisibleInLegend = true,
                                IsValueShownAsLabel = false // No labels on bars to avoid confusion
                            };
                            chartAnalytics.Series.Add(barSeries);

                            bool hasBarData = false;
                            int barRowCount = 0;
                            HashSet<string> uniqueGenres = new HashSet<string>(); // Ensure no duplicate genres
                            while (barReader.Read())
                            {
                                string genre = barReader["Genre"].ToString();
                                int count = Convert.ToInt32(barReader["ReserveCount"]);
                                if (!uniqueGenres.Contains(genre)) // Add only unique genres
                                {
                                    barSeries.Points.AddXY(genre, count); // Add point with whole number count
                                    uniqueGenres.Add(genre);
                                    hasBarData = true;
                                    barRowCount++;
                                    Console.WriteLine($"Bar Row {barRowCount}: Genre={genre}, Count={count}");
                                }
                            }

                            barReader.Close(); // Close barReader before using pieCmd

                            // Pie chart setup (User preferences based on reservations per genre)
                            using (SqlDataReader pieReader = pieCmd.ExecuteReader())
                            {
                                Series pieSeries = new Series("User Favorite Genres (Pie)")
                                {
                                    ChartType = SeriesChartType.Pie,
                                    IsVisibleInLegend = true,
                                    IsValueShownAsLabel = true // Keep labels on pie slices
                                };
                                chartPieAnalytics.Series.Add(pieSeries);

                                bool hasPieData = false;
                                int pieRowCount = 0;
                                double totalCount = 0; // To calculate percentage
                                List<int> counts = new List<int>(); // Store counts for percentage calculation

                                // First pass: Calculate total count
                                while (pieReader.Read())
                                {
                                    int count = Convert.ToInt32(pieReader["UserPreferenceCount"]);
                                    counts.Add(count);
                                    totalCount += count;
                                }
                                pieReader.Close(); // Close and reopen reader
                                using (SqlDataReader pieReader2 = pieCmd.ExecuteReader())
                                {
                                    int index = 0;
                                    while (pieReader2.Read())
                                    {
                                        string genre = pieReader2["Genre"].ToString();
                                        int count = Convert.ToInt32(pieReader2["UserPreferenceCount"]);
                                        double percentage = (totalCount > 0) ? (count / totalCount) * 100 : 0;
                                        string label = $"{genre} ({percentage:F1}%)"; // Genre + percentage with 1 decimal
                                        int pointIndex = pieSeries.Points.AddXY(genre, count); // Add point and get index
                                        DataPoint point = pieSeries.Points[pointIndex]; // Access the DataPoint
                                        point.Label = label; // Set custom label
                                        hasPieData = true;
                                        pieRowCount++;
                                        Console.WriteLine($"Pie Row {pieRowCount}: Genre={genre}, Count={count}, Percentage={percentage:F1}%");
                                        index++;
                                    }
                                }

                                if (hasBarData || hasPieData)
                                {
                                    chartAnalytics.Titles.Clear();
                                    chartAnalytics.Titles.Add("Reserved Books by Genre (Bar)");
                                    chartPieAnalytics.Titles.Clear();
                                    chartPieAnalytics.Titles.Add("User Favorite Genres (Pie)");

                                    // Ensure chart areas are defined with whole number formatting
                                    if (chartAnalytics.ChartAreas.Count == 0)
                                    {
                                        chartAnalytics.ChartAreas.Add(new ChartArea("Default")
                                        {
                                            AxisX = { Title = "Genre" },
                                            AxisY = { Title = "Count", LabelStyle = { Format = "{0}" } } // Enforce whole numbers on Y-axis
                                        });
                                        chartPieAnalytics.ChartAreas.Add(new ChartArea("Default")
                                        {
                                            AxisX = { Title = "Genre" },
                                            AxisY = { Title = "Count" }
                                        });
                                    }

                                    // Force redraw
                                    chartAnalytics.Invalidate();
                                    chartPieAnalytics.Invalidate();
                                }
                                else
                                {
                                    MessageBox.Show("No data available to display in the charts. Ensure Reservations, Books, and Users tables have matching data.", "Info",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    chartAnalytics.Series.Clear();
                                    chartPieAnalytics.Series.Clear();
                                    Console.WriteLine("No data retrieved from queries.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading analytics: " + ex.Message + "\nStack Trace: " + ex.StackTrace, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Analytics Error: " + ex.Message);
            }
        }

        // ✅ FIXED: LoadReports - Escaped reserved keyword and simplified query
        private void LoadReports()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT R.ReservationID, U.Username AS [User], B.BookTitle AS Book, 
                               R.ReservationDate, R.Status
                        FROM Reservations R
                        INNER JOIN Users U ON R.UserId = U.UserId
                        INNER JOIN Books B ON R.BookId = B.BookId
                        ORDER BY R.ReservationDate DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        // Note: dataGridViewReports is removed, so no DataSource assignment
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Empty event handlers (can be removed if not needed)
        private void AdminDashboard_Load_1(object sender, EventArgs e) { }
        private void cmbGenre_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void txtUpdateAuthor_TextChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void txtUpdatePhoto_TextChanged(object sender, EventArgs e) { }
        private void underlineUpdateTitle_Click(object sender, EventArgs e) { }
        private void lblUpdatePhoto_Click(object sender, EventArgs e) { }
        private void tabPageBooks_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtUpdateTitle_TextChanged(object sender, EventArgs e) { }
        private void underlineGenreName_Click(object sender, EventArgs e) { }
        private void txtGenreName_TextChanged(object sender, EventArgs e) { }
    }
}