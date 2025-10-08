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

namespace IT13_Final_Project
{
    public partial class Login : Form
    {
        private string connectionString =
           "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        public Login()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUserTb.Text.Trim();
            string password = LoginPasswordTb.Text.Trim();

            // ✅ Try logging in and get user info
            DataRow userInfo = SignIn(username, password);

            if (userInfo != null)
            {
                MessageBox.Show("✅ Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Pass user info to Dashboard
                int userId = Convert.ToInt32(userInfo["UserId"]); // Replace "UserId" with the actual column name for the user ID in your Users table
                Dashboard dashboard = new Dashboard(userId);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("❌ Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Return DataRow with user details
        private DataRow SignIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
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
                        adapter.SelectCommand.Parameters.AddWithValue("@password", password);

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

        private void AdminAccessBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}