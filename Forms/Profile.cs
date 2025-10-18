using System;
using System.Data;
using System.Drawing;
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

        private void Profile_Load_2(object sender, EventArgs e) // Matches designer
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
                                MessageBox.Show($"No user data found for UserID: {userId}. Check the Users table.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }

                    // 🔹 Now load the dynamic statistics
                    // 1️⃣ Total Reservations
                    string totalReservationsQuery = "SELECT COUNT(*) FROM Reservations WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(totalReservationsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        int totalReservations = Convert.ToInt32(cmd.ExecuteScalar() ?? 0); // Handle null
                        textBox5.Text = totalReservations.ToString();
                    }

                    // 2️⃣ Reservations currently held
                    string reservedQuery = "SELECT COUNT(*) FROM Reservations WHERE UserID = @UserID AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(reservedQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        int reservedCount = Convert.ToInt32(cmd.ExecuteScalar() ?? 0); // Handle null
                        textBox8.Text = reservedCount.ToString();
                    }

                    // 3️⃣ Overdue Reservations
                    string overdueQuery = "SELECT COUNT(*) FROM Reservations WHERE UserID = @UserID AND DueDate < GETDATE() AND ReturnDate IS NULL";
                    using (SqlCommand cmd = new SqlCommand(overdueQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        int overdueCount = Convert.ToInt32(cmd.ExecuteScalar() ?? 0); // Handle null
                        textBox6.Text = overdueCount.ToString();
                    }

                    // 4️⃣ Fines Due
                    string finesQuery = "SELECT ISNULL(SUM(FineAmount), 0) FROM Reservations WHERE UserID = @UserID AND FineAmount > 0";
                    using (SqlCommand cmd = new SqlCommand(finesQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        decimal finesDue = Convert.ToDecimal(cmd.ExecuteScalar()); // No null check needed due to ISNULL
                        textBox9.Text = finesDue.ToString("0.00");
                    }

                    MakeTextboxesReadOnly();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}\nStack Trace: {ex.StackTrace}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        // ✅ Edit profile button
        private void button1_Click(object sender, EventArgs e)
        {
            EditProfiles editForm = new EditProfiles(_userId);
            editForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }

        // Example: Show Profile as a layer in a parent panel (e.g., Dashboard.MainPanel)
        public void ShowAsLayer(int userId)
        {
            var profileLayer = new Profile(userId);
            profileLayer.TopLevel = false;
            profileLayer.Dock = DockStyle.Fill;
            Dashboard.MainPanel.Controls.Clear();
            Dashboard.MainPanel.Controls.Add(profileLayer);
            profileLayer.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Empty handler, can be removed if not needed
        }
    }
}