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
    public partial class BorrowedBooks : Form
    {
        private string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        private int _userId;

        public BorrowedBooks(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadBorrowedBooks();
            CalculateTotalDue();
        }

        private void LoadBorrowedBooks()
        {
            panel4.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT b.BookID, b.BookTitle,
                               bb.BorrowID, bb.BorrowDate, bb.DueDate, bb.ReturnDate, bb.FineAmount, ISNULL(bb.CanReturn, 0) AS CanReturn
                        FROM BorrowedBooks bb
                        INNER JOIN Books b ON bb.BookID = b.BookID
                        WHERE bb.UserID = @UserID
                        ORDER BY bb.BorrowDate DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Label noData = new Label
                                {
                                    Text = "No borrowed books found.",
                                    Location = new Point(20, 20),
                                    AutoSize = true,
                                    ForeColor = Color.Gray
                                };
                                panel4.Controls.Add(noData);
                                return;
                            }

                            int yPosition = 10;
                            while (reader.Read())
                            {
                                int bookId = (int)reader["BookID"];
                                int borrowId = (int)reader["BorrowID"];
                                string title = reader["BookTitle"].ToString();
                                DateTime borrowDate = (DateTime)reader["BorrowDate"];
                                DateTime dueDate = (DateTime)reader["DueDate"];
                                DateTime? returnDate = reader["ReturnDate"] != DBNull.Value
                                                        ? (DateTime?)reader["ReturnDate"]
                                                        : null;
                                decimal fineAmount = reader["FineAmount"] != DBNull.Value
                                                        ? (decimal)reader["FineAmount"]
                                                        : 0m;
                                bool canReturn = reader["CanReturn"] != DBNull.Value && (bool)reader["CanReturn"];

                                // Recalculate overdue fine only if:
                                // - book not returned
                                // - due date passed
                                // - fineAmount currently 0
                                // - AND CanReturn is FALSE (so we don't overwrite a paid-and-flagged row)
                                if (!returnDate.HasValue && DateTime.Now > dueDate && fineAmount == 0m && !canReturn)
                                {
                                    int overdueDays = (DateTime.Now - dueDate).Days;
                                    if (overdueDays < 0) overdueDays = 0;
                                    fineAmount = overdueDays * 1.00m;
                                    UpdateFine(borrowId, fineAmount); // update by borrowId
                                    // ensure ui variable matches DB write
                                    canReturn = false;
                                }

                                // Build UI card
                                Panel bookPanel = new Panel
                                {
                                    BackColor = Color.BurlyWood,
                                    Location = new Point(10, yPosition),
                                    Size = new Size(890, 100),
                                    BorderStyle = BorderStyle.FixedSingle
                                };

                                Label lblBook = new Label { Text = "Book: " + title, Location = new Point(20, 10), AutoSize = true };
                                Label lblBorrowDate = new Label { Text = "Borrowed: " + borrowDate.ToString("yyyy-MM-dd"), Location = new Point(20, 30), AutoSize = true };
                                Label lblDueDate = new Label { Text = "Due: " + dueDate.ToString("yyyy-MM-dd"), Location = new Point(20, 50), AutoSize = true };
                                Label lblFine = new Label { Text = "Fine: ₱" + fineAmount.ToString("0.00"), Location = new Point(200, 30), AutoSize = true };
                                Label lblStatus = new Label { Text = returnDate.HasValue ? $"Returned: {returnDate.Value:yyyy-MM-dd}" : "Not Returned", Location = new Point(200, 50), AutoSize = true };

                                bookPanel.Controls.Add(lblBook);
                                bookPanel.Controls.Add(lblBorrowDate);
                                bookPanel.Controls.Add(lblDueDate);
                                bookPanel.Controls.Add(lblFine);
                                bookPanel.Controls.Add(lblStatus);

                                // Button logic: use borrowId for updates
                                if (!returnDate.HasValue)
                                {
                                    // if there's a fine and canReturn is false => show pay button
                                    if (fineAmount > 0m && !canReturn)
                                    {
                                        Button btnPay = new Button
                                        {
                                            Text = "Pay Fine",
                                            Location = new Point(400, 20),
                                            Size = new Size(100, 40),
                                            BackColor = Color.Peru,
                                            ForeColor = Color.White
                                        };
                                        // capture borrowId/bookId/fineAmount for the handler
                                        int bId = borrowId;
                                        int bkId = bookId;
                                        decimal fAmt = fineAmount;
                                        btnPay.Click += (s, ev) => PayFine(bId, bkId, fAmt);
                                        bookPanel.Controls.Add(btnPay);
                                    }
                                    else
                                    {
                                        // either fineAmount == 0 OR canReturn==true => show Return button
                                        Button btnReturn = new Button
                                        {
                                            Text = "Return Book",
                                            Location = new Point(400, 20),
                                            Size = new Size(100, 40),
                                            BackColor = Color.Peru,
                                            ForeColor = Color.White
                                        };
                                        int bId = borrowId;
                                        int bkId = bookId;
                                        string t = title;
                                        btnReturn.Click += (s, ev) => ReturnBook(bId, bkId, t);
                                        bookPanel.Controls.Add(btnReturn);
                                    }
                                }

                                panel4.Controls.Add(bookPanel);
                                yPosition += 110;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading borrowed books: " + ex.Message);
            }
        }

        // update fine by BorrowID (unique borrow record)
        private void UpdateFine(int borrowId, decimal fineAmount)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // set CanReturn = 0 because fine exists
                    string updateQuery = @"UPDATE BorrowedBooks 
                                           SET FineAmount = @FineAmount, CanReturn = 0 
                                           WHERE BorrowID = @BorrowID AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FineAmount", fineAmount);
                        cmd.Parameters.AddWithValue("@BorrowID", borrowId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating fine: " + ex.Message);
            }
        }

        // Pay fine: mark FineAmount=0 and CanReturn=1 on this borrow row
        private void PayFine(int borrowId, int bookId, decimal fineAmount)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = @"UPDATE BorrowedBooks 
                                           SET FineAmount = 0, CanReturn = 1 
                                           WHERE BorrowID = @BorrowID AND UserID = @UserID AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BorrowID", borrowId);
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Paid fine of ₱{fineAmount:0.00}. You can now return the book.", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reload UI — now LoadBorrowedBooks will NOT recalc the fine because CanReturn = 1
                LoadBorrowedBooks();
                CalculateTotalDue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error paying fine: " + ex.Message);
            }
        }

        // ReturnBook uses BorrowID to mark the record returned
        private void ReturnBook(int borrowId, int bookId, string bookTitle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateBorrow = @"UPDATE BorrowedBooks 
                                            SET ReturnDate = GETDATE(), CanReturn = 0 
                                            WHERE BorrowID = @BorrowID AND UserID = @UserID AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(updateBorrow, conn))
                    {
                        cmd.Parameters.AddWithValue("@BorrowID", borrowId);
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.ExecuteNonQuery();
                    }

                    // Update book availability
                    string updateBook = "UPDATE Books SET IsAvailable = 1 WHERE BookID = @BookID";
                    using (SqlCommand cmd = new SqlCommand(updateBook, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.ExecuteNonQuery();
                    }
                }

                DialogResult result = MessageBox.Show($"Do you want to rate '{bookTitle}'?", "Rate Book", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ShowRatingForm(bookId, bookTitle);
                }

                MessageBox.Show("Book returned successfully!");
                LoadBorrowedBooks();
                CalculateTotalDue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning book: " + ex.Message);
            }
        }

        private void ShowRatingForm(int bookId, string bookTitle)
        {
            Form ratingForm = new Form
            {
                Text = $"Rate {bookTitle}",
                Size = new Size(350, 250)
            };

            Label lbl = new Label { Text = "Rate (1-5):", Location = new Point(20, 20), AutoSize = true };
            NumericUpDown numRating = new NumericUpDown { Minimum = 1, Maximum = 5, Location = new Point(120, 20), Width = 50 };

            Label lblReview = new Label { Text = "Review:", Location = new Point(20, 60), AutoSize = true };
            TextBox txtReview = new TextBox { Location = new Point(120, 60), Width = 180, Height = 60, Multiline = true };

            Button btnSubmit = new Button { Text = "Submit", Location = new Point(120, 140), Width = 100 };
            btnSubmit.Click += (s, e) =>
            {
                SaveRating(bookId, (int)numRating.Value, txtReview.Text);
                ratingForm.Close();
            };

            ratingForm.Controls.Add(lbl);
            ratingForm.Controls.Add(numRating);
            ratingForm.Controls.Add(lblReview);
            ratingForm.Controls.Add(txtReview);
            ratingForm.Controls.Add(btnSubmit);

            ratingForm.ShowDialog();
        }

        private void SaveRating(int bookId, int rating, string review)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO BookReviews (UserID, BookID, Rating, ReviewText, ReviewDate)
                                           VALUES (@UserID, @BookID, @Rating, @Review, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.Parameters.AddWithValue("@Rating", rating);
                        cmd.Parameters.AddWithValue("@Review", review);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Thank you for rating the book!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving rating: " + ex.Message);
            }
        }

        private void CalculateTotalDue()
        {
            decimal totalDue = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SUM(FineAmount) AS TotalFine FROM BorrowedBooks WHERE UserID = @UserID AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            totalDue = Convert.ToDecimal(result);
                        }
                    }
                }
                Amountbl.Text = "₱ " + totalDue.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total due: " + ex.Message);
            }
        }

        private void BorrowedBooks_Load(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel4_Scroll(object sender, ScrollEventArgs e) { }
    }
}