using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT13_Final_Project
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
        private Login loginForm;
        public Form1(Login loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm ?? new Login(); // Ensure loginForm is initialized
        }

        public bool Signup(string username, string password, string email)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email))
            {
                return false; // Invalid input
            }
            // TODO: Add actual registration logic (e.g., save to database)
            return true;
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            string username = UserTb.Text;
            string password = passregTB.Text;  // In production, hash this! (e.g., using BCrypt or SHA256)
            string email = EmailTb.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Assuming a table 'Users' with columns Username (varchar), Password (varchar), Email (varchar)
                    // Create table if needed: CREATE TABLE Users (Id INT IDENTITY PRIMARY KEY, Username VARCHAR(50), Password VARCHAR(255), Email VARCHAR(100));
                    string query = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);  // Hash in real apps!
                        cmd.Parameters.AddWithValue("@Email", email);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            // Optionally call library method here if needed
                            // Helper helper = new Helper();
                            // string message = helper.GetMessage();
                            // MessageBox.Show(message);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loginForm != null && !loginForm.IsDisposed)
            {
                this.Hide();
                loginForm.Show();
                loginForm.BringToFront();
                loginForm.Activate(); // Ensure focus returns to Login form
            }
            else
            {
                loginForm = new Login();
                this.Hide();
                loginForm.Show();
                loginForm.BringToFront();
                loginForm.Activate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

