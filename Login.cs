using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace IT13_Final_Project
{
    public partial class Login : Form
    {
        private string connectionString =
           "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        public Login()
        {
            InitializeComponent();
            LoginPasswordTb.PasswordChar = '*'; // Set password character to *
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUserTb.Text.Trim();
            string password = LoginPasswordTb.Text.Trim();

            // ✅ Hash the entered password before comparing
            string hashedPassword = HashPassword(password);

            // ✅ Try logging in and get user info
            DataRow userInfo = SignIn(username, hashedPassword);

            if (userInfo != null)
            {
                try
                {
                    int userId = Convert.ToInt32(userInfo["UserId"]);
                    string role = userInfo["Role"].ToString(); // Get the role from the user info

                    if (role == "Admin")
                    {
                        MessageBox.Show("✅ Login successful! Redirecting to Admin Dashboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("✅ Login successful! Redirecting to User Dashboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dashboard dashboard = new Dashboard(userId);
                        dashboard.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("❌ Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Function to hash password using SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // ✅ Validate user with hashed password
        private DataRow SignIn(string username, string hashedPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(hashedPassword))
                return null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@username", username);
                        adapter.SelectCommand.Parameters.AddWithValue("@password", hashedPassword);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                            return dt.Rows[0];
                        else
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 newform = new Form1(this);
            newform.Show();
            this.Hide();
        }

        private void LoginUserTb_TextChanged(object sender, EventArgs e) { }
    }
}