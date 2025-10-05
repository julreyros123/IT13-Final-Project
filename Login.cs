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
           "Server=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Login()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUserTb.Text.Trim();
            string password = LoginPasswordTb.Text.Trim();

            // ✅ Try logging in and get UserID
            int? userId = SignIn(username, password);

            if (userId.HasValue)
            {
                MessageBox.Show("✅ Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Pass the logged-in user's ID to Dashboard
                Dashboard dashboard = new Dashboard(userId.Value);
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("❌ Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Return UserID instead of bool
        private int? SignIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT UserID FROM Users WHERE Username = @username AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            // ✅ Return the UserID
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void LoginPasswordTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void LoginUserTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 newform = new Form1(this);
            newform.Show();
            this.Hide();
        }

        private void AdminAccessBtn_Click(object sender, EventArgs e)
        {
            AdminLogin Adminlogin = new AdminLogin();
            Adminlogin.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}