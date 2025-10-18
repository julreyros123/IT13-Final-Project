using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    public partial class ReservedBooks : Form
    {
        private string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        private int _userId;

        public ReservedBooks(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadReservedBooks();
        }

        private void LoadReservedBooks()
        {
            flowReserved.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT r.ReservationID, r.ReservationDate, r.Status, r.BorrowDate, r.DueDate, r.ReturnDate, r.FineAmount, ISNULL(r.CanReturn, 0) AS CanReturn,
                               b.BookID, b.BookTitle, b.BookImage
                        FROM Reservations r
                        INNER JOIN Books b ON r.BookID = b.BookID
                        WHERE r.UserID = @UserID AND r.Status != 'Cancelled'
                        ORDER BY r.ReservationDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Label noData = new Label
                                {
                                    Text = "No reserved books found.",
                                    AutoSize = true,
                                    ForeColor = Color.Gray,
                                    Font = new Font("Segoe UI", 12F, FontStyle.Italic),
                                    Padding = new Padding(10)
                                };
                                flowReserved.Controls.Add(noData);
                                return;
                            }

                            while (reader.Read())
                            {
                                int bookId = (int)reader["BookID"];
                                int reservationId = (int)reader["ReservationID"];
                                string title = reader["BookTitle"].ToString();
                                DateTime reservationDate = (DateTime)reader["ReservationDate"];
                                string status = reader["Status"].ToString();
                                DateTime? borrowDate = reader["BorrowDate"] != DBNull.Value ? (DateTime?)reader["BorrowDate"] : null;
                                DateTime? dueDate = reader["DueDate"] != DBNull.Value ? (DateTime?)reader["DueDate"] : null;
                                DateTime? returnDate = reader["ReturnDate"] != DBNull.Value ? (DateTime?)reader["ReturnDate"] : null;
                                decimal fineAmount = reader["FineAmount"] != DBNull.Value ? (decimal)reader["FineAmount"] : 0m;
                                bool canReturn = reader["CanReturn"] != DBNull.Value && (bool)reader["CanReturn"];

                                // Calculate and update fine if borrowed and overdue
                                if (status == "Borrowed" && !returnDate.HasValue && dueDate.HasValue && DateTime.Now > dueDate.Value)
                                {
                                    int daysOverdue = (DateTime.Now - dueDate.Value).Days;
                                    decimal newFine = daysOverdue * 5m; // Assume 5 per day
                                    if (newFine != fineAmount)
                                    {
                                        UpdateFine(reservationId, newFine);
                                        fineAmount = newFine;
                                    }
                                }

                                Image cover = Properties.Resources.noimage;
                                try
                                {
                                    if (!(reader["BookImage"] is DBNull))
                                    {
                                        string imgPath = reader["BookImage"].ToString();
                                        if (System.IO.File.Exists(imgPath))
                                            cover = Image.FromFile(imgPath);
                                    }
                                }
                                catch { }

                                Panel bookPanel = new Panel
                                {
                                    BackColor = Color.FromArgb(252, 243, 225),
                                    Width = 980,
                                    Height = 150,
                                    Margin = new Padding(10),
                                    Padding = new Padding(10),
                                    BorderStyle = BorderStyle.FixedSingle
                                };

                                PictureBox pbCover = new PictureBox
                                {
                                    Image = cover,
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Size = new Size(90, 120),
                                    Location = new Point(10, 10),
                                    BackColor = Color.WhiteSmoke,
                                    BorderStyle = BorderStyle.FixedSingle
                                };
                                bookPanel.Controls.Add(pbCover);

                                Label lblBook = new Label
                                {
                                    Text = title,
                                    Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold),
                                    ForeColor = Color.FromArgb(60, 40, 20),
                                    Location = new Point(120, 10),
                                    AutoSize = true
                                };
                                bookPanel.Controls.Add(lblBook);

                                Label lblReservationDate = new Label
                                {
                                    Text = $"📅 Reserved: {reservationDate:yyyy-MM-dd}",
                                    Font = new Font("Segoe UI", 10F),
                                    ForeColor = Color.FromArgb(90, 60, 30),
                                    Location = new Point(120, 45),
                                    AutoSize = true
                                };
                                bookPanel.Controls.Add(lblReservationDate);

                                Label lblStatus = new Label
                                {
                                    Text = $"Status: {status}",
                                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                                    Location = new Point(120, 70),
                                    AutoSize = true
                                };
                                if (status == "Reserved")
                                    lblStatus.ForeColor = Color.Peru;
                                else if (status == "Borrowed")
                                    lblStatus.ForeColor = DateTime.Now > dueDate ? Color.DarkRed : Color.FromArgb(90, 60, 30);
                                else if (status == "Returned")
                                    lblStatus.ForeColor = Color.ForestGreen;
                                bookPanel.Controls.Add(lblStatus);

                                if (status == "Borrowed" && borrowDate.HasValue && dueDate.HasValue)
                                {
                                    Label lblBorrowDate = new Label
                                    {
                                        Text = $"📅 Borrowed: {borrowDate.Value:yyyy-MM-dd}",
                                        Font = new Font("Segoe UI", 10F),
                                        ForeColor = Color.FromArgb(90, 60, 30),
                                        Location = new Point(120, 95),
                                        AutoSize = true
                                    };
                                    bookPanel.Controls.Add(lblBorrowDate);

                                    Label lblDueDate = new Label
                                    {
                                        Text = $"⏰ Due: {dueDate.Value:yyyy-MM-dd}",
                                        Font = new Font("Segoe UI", 10F),
                                        ForeColor = DateTime.Now > dueDate.Value ? Color.DarkRed : Color.FromArgb(90, 60, 30),
                                        Location = new Point(120, 120),
                                        AutoSize = true
                                    };
                                    bookPanel.Controls.Add(lblDueDate);

                                    Label lblFine = new Label
                                    {
                                        Text = $"💰 Fine: ₱{fineAmount:0.00}",
                                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                                        ForeColor = fineAmount > 0 ? Color.DarkRed : Color.ForestGreen,
                                        Location = new Point(300, 120),
                                        AutoSize = true
                                    };
                                    bookPanel.Controls.Add(lblFine);
                                }

                                Button actionButton = new Button
                                {
                                    Size = new Size(120, 40),
                                    Location = new Point(830, 55),
                                    FlatStyle = FlatStyle.Flat,
                                    Font = new Font("Segoe UI Semibold", 10F),
                                    Cursor = Cursors.Hand,
                                    Tag = reservationId
                                };
                                actionButton.FlatAppearance.BorderSize = 0;

                                if (status == "Reserved")
                                {
                                    actionButton.Text = "Cancel";
                                    actionButton.BackColor = Color.FromArgb(210, 90, 45);
                                    actionButton.ForeColor = Color.White;
                                    int rId = reservationId;
                                    int bkId = bookId;
                                    string t = title;
                                    actionButton.Click += (s, ev) => CancelReservation(rId, bkId, t);
                                }
                                else if (status == "Returned")
                                {
                                    // Check if the user has already rated this book
                                    if (!HasUserRatedBook(bookId))
                                    {
                                        actionButton.Text = "Rate";
                                        actionButton.BackColor = Color.FromArgb(90, 60, 30);
                                        actionButton.ForeColor = Color.White;
                                        int bkId = bookId;
                                        string t = title;
                                        actionButton.Click += (s, ev) => RateBook(bkId, t);
                                    }
                                    else
                                    {
                                        // Skip adding the Rate button if already rated
                                        actionButton = null;
                                    }
                                }

                                if (actionButton != null)
                                    bookPanel.Controls.Add(actionButton);
                                flowReserved.Controls.Add(bookPanel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reserved books: " + ex.Message);
            }
        }

        private bool HasUserRatedBook(int bookId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM BookReviews WHERE UserID = @UserID AND BookID = @BookID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void UpdateFine(int reservationId, decimal fineAmount)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE Reservations 
                                           SET FineAmount = @FineAmount 
                                           WHERE ReservationID = @ReservationID AND Status = 'Borrowed' AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FineAmount", fineAmount);
                        cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating fine: " + ex.Message);
            }
        }

        private void CancelReservation(int reservationId, int bookId, string bookTitle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateReservation = @"UPDATE Reservations 
                                                 SET Status = 'Cancelled' 
                                                 WHERE ReservationID = @ReservationID AND UserID = @UserID AND Status = 'Reserved'";
                    using (SqlCommand cmd = new SqlCommand(updateReservation, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.ExecuteNonQuery();
                    }

                    string updateBook = "UPDATE Books SET IsAvailable = 1 WHERE BookID = @BookID";
                    using (SqlCommand cmd = new SqlCommand(updateBook, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Reservation cancelled successfully!");
                LoadReservedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling reservation: " + ex.Message);
            }
        }

        private void RateBook(int bookId, string bookTitle)
        {
            using (Rating ratingForm = new Rating(_userId, bookId, bookTitle, connectionString))
            {
                ratingForm.ShowDialog();
            }
            LoadReservedBooks();
        }

        private void ReservedBooks_Load(object sender, EventArgs e) { }

        private void panelSummary_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}