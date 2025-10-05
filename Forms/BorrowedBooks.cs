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

        // 🚫 Remove this default constructor to avoid _userId = 0 issue
        // public BorrowedBooks() { InitializeComponent(); }

        private void LoadBorrowedBooks()
        {
            panel4.Controls.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT b.BookID, b.BookTitle, 
                                            bb.BorrowDate, bb.DueDate, bb.ReturnDate, bb.FineAmount
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
                                MessageBox.Show("No borrowed books found for userId = " + _userId);
                                return;
                            }

                            int yPosition = 10;
                            while (reader.Read())
                            {
                                int bookId = (int)reader["BookID"];
                                string title = reader["BookTitle"].ToString();
                                DateTime borrowDate = (DateTime)reader["BorrowDate"];
                                DateTime dueDate = (DateTime)reader["DueDate"];
                                DateTime? returnDate = reader["ReturnDate"] != DBNull.Value
                                                        ? (DateTime?)reader["ReturnDate"]
                                                        : null;
                                decimal fineAmount = reader["FineAmount"] != DBNull.Value
                                                        ? (decimal)reader["FineAmount"]
                                                        : 0;

                                // if still borrowed & overdue → calculate fine
                                if (!returnDate.HasValue && DateTime.Now > dueDate)
                                {
                                    int overdueDays = (DateTime.Now - dueDate).Days;
                                    fineAmount = overdueDays * 1.00m;
                                    UpdateFine(bookId, fineAmount);
                                }

                                Panel bookPanel = new Panel
                                {
                                    BackColor = Color.BurlyWood,
                                    Location = new Point(10, yPosition),
                                    Size = new Size(900, 100),
                                    BorderStyle = BorderStyle.FixedSingle
                                };

                                Label lblBook = new Label { Text = "Book: " + title, Location = new Point(20, 10), AutoSize = true };
                                Label lblBorrowDate = new Label { Text = "Borrowed: " + borrowDate.ToString("yyyy-MM-dd"), Location = new Point(20, 30), AutoSize = true };
                                Label lblDueDate = new Label { Text = "Due: " + dueDate.ToString("yyyy-MM-dd"), Location = new Point(20, 50), AutoSize = true };
                                Label lblFine = new Label { Text = "Fine: $" + fineAmount.ToString("0.00"), Location = new Point(200, 30), AutoSize = true };
                                Label lblStatus = new Label { Text = returnDate.HasValue ? $"Returned: {returnDate.Value:yyyy-MM-dd}" : "Not Returned", Location = new Point(200, 50), AutoSize = true };

                                bookPanel.Controls.Add(lblBook);
                                bookPanel.Controls.Add(lblBorrowDate);
                                bookPanel.Controls.Add(lblDueDate);
                                bookPanel.Controls.Add(lblFine);
                                bookPanel.Controls.Add(lblStatus);

                                if (!returnDate.HasValue)
                                {
                                    if (fineAmount > 0)
                                    {
                                        Button btnPay = new Button
                                        {
                                            Text = "Pay Fine",
                                            Location = new Point(400, 20),
                                            Size = new Size(100, 40),
                                            BackColor = Color.Peru,
                                            ForeColor = Color.White
                                        };
                                        btnPay.Click += (s, ev) => PayFine(bookId, fineAmount);
                                        bookPanel.Controls.Add(btnPay);
                                    }
                                    else
                                    {
                                        Button btnReturn = new Button
                                        {
                                            Text = "Return Book",
                                            Location = new Point(400, 20),
                                            Size = new Size(100, 40),
                                            BackColor = Color.Peru,
                                            ForeColor = Color.White
                                        };
                                        btnReturn.Click += (s, ev) => ReturnBook(bookId, title);
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

        private void UpdateFine(int bookId, decimal fineAmount)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE BorrowedBooks SET FineAmount = @FineAmount WHERE BookID = @BookID AND UserID = @UserID AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FineAmount", fineAmount);
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating fine: " + ex.Message);
            }
        }

        private void PayFine(int bookId, decimal fineAmount)
        {
            MessageBox.Show($"Paid fine of ${fineAmount}. You can now return the book.");
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = "UPDATE BorrowedBooks SET FineAmount = 0 WHERE BookID = @BookID AND UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookId);
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadBorrowedBooks();
                CalculateTotalDue();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error paying fine: " + ex.Message);
            }
        }

        private void ReturnBook(int bookId, string bookTitle)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string updateBorrow = "UPDATE BorrowedBooks SET ReturnDate = @ReturnDate WHERE BookID = @BookID AND UserID = @UserID AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(updateBorrow, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@BookID", bookId);
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

                // ask for rating
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
                        if (result != DBNull.Value)
                        {
                            totalDue = Convert.ToDecimal(result);
                        }
                    }
                }
                Amountbl.Text = "$ " + totalDue.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total due: " + ex.Message);
            }
        }

        private void BorrowedBooks_Load(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e){}
    }
}
