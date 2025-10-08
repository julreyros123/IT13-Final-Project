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
    public partial class Profile : Form
    {
        private int _userId;
        private string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void Profile_Load_2(object sender, EventArgs e)
        {
            if (_userId > 0)
            {
                LoadUserData(_userId);
            }
            else
            {
                MessageBox.Show("⚠ No user ID provided. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ✅ Load all user data and live stats into textboxes
        private void LoadUserData(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 🔹 Get basic profile info
                    string query = @"
                        SELECT Username, Email, Contact, Address, JoinDate
                        FROM Users
                        WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ✅ Basic Info
                                textBox10.Text = reader["Username"] != DBNull.Value ? reader["Username"].ToString() : "N/A";
                                textBox1.Text = reader["Contact"] != DBNull.Value ? reader["Contact"].ToString() : "N/A";
                                textBox2.Text = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "N/A";
                                textBox3.Text = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : "N/A";

                                // ✅ Membership Info
                                textBox4.Text = userId.ToString(); // Membership ID
                                textBox7.Text = reader["JoinDate"] != DBNull.Value
                                                ? Convert.ToDateTime(reader["JoinDate"]).ToString("yyyy-MM-dd")
                                                : "N/A";
                            }
                            else
                            {
                                MessageBox.Show("No user data found for this ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }

                    // 🔹 Now load the dynamic statistics
                    // 1️⃣ Total Books
                    string totalBooksQuery = "SELECT COUNT(*) FROM Books";
                    using (SqlCommand cmd = new SqlCommand(totalBooksQuery, conn))
                    {
                        int totalBooks = Convert.ToInt32(cmd.ExecuteScalar());
                        textBox5.Text = totalBooks.ToString(); // Total Books
                    }

                    // 2️⃣ Books currently borrowed by this user
                    string borrowedQuery = "SELECT COUNT(*) FROM BorrowedBooks WHERE UserID = @UserID AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(borrowedQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        int borrowedCount = Convert.ToInt32(cmd.ExecuteScalar());
                        textBox8.Text = borrowedCount.ToString(); // Currently Borrowed
                    }

                    // 3️⃣ Overdue Books
                    string overdueQuery = "SELECT COUNT(*) FROM BorrowedBooks WHERE UserID = @UserID AND DueDate < GETDATE() AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(overdueQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        int overdueCount = Convert.ToInt32(cmd.ExecuteScalar());
                        textBox6.Text = overdueCount.ToString(); // Overdue Books
                    }

                    // 4️⃣ Fines Due
                    string finesQuery = "SELECT ISNULL(SUM(FineAmount), 0) FROM BorrowedBooks WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(finesQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        decimal finesDue = Convert.ToDecimal(cmd.ExecuteScalar());
                        textBox9.Text = finesDue.ToString("0.00"); // Fines Due
                    }

                    MakeTextboxesReadOnly();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Make all textboxes read-only
        private void MakeTextboxesReadOnly()
        {
            foreach (Control panel in this.Controls)
            {
                if (panel is Panel)
                {
                    foreach (Control ctrl in panel.Controls)
                    {
                        if (ctrl is TextBox tb)
                            tb.ReadOnly = true;
                    }
                }
            }
        }

        // ✅ Log out button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        // ✅ Edit profile button
        private void button1_Click(object sender, EventArgs e)
        {
            EditProfiles editForm = new EditProfiles(_userId);
            this.Hide();
            editForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
    }
}
