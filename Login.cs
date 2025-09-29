using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT13_Final_Project
{
    public partial class Login : Form
    {
        private readonly string connectionString =
            "Server=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        private readonly Dictionary<string, string> _admins = new Dictionary<string, string>
        {
            { "admin", "admin123" },
            { "superadmin", "super456" }
        };

        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }


        private void CenterPanel()
        {
            if (panel1 != null)
            {
                int formWidth = this.ClientSize.Width;
                int formHeight = this.ClientSize.Height;
                int panelWidth = panel1.Width;
                int panelHeight = panel1.Height;

                panel1.Location = new System.Drawing.Point(
                    (formWidth - panelWidth) / 2,
                    (formHeight - panelHeight) / 2
                );
            }
        }


        public string SignIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            // 1️⃣ Strict check: only "admin" with "admin123" can be Admin
            if (username == "admin" && password == "admin123")
            {
                return "Admin";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0 ? "Client" : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Update the SignInBtn_Click event handler to call the instance SignIn method.

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            string role = SignIn(LoginUserTb.Text, LoginPasswordTb.Text);

    if (role == "Admin")
    {
        MessageBox.Show("Welcome Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        AdminDashboard adminForm = new AdminDashboard();
        this.Hide();
        adminForm.Show();
    }
    else if (role == "Client")
    {
        MessageBox.Show("Sign-in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        Dashboard dashboardForm = new Dashboard();
        this.Hide();
        dashboardForm.Show();
    }
    else
    {
        MessageBox.Show("Invalid username or password.", "Sign-in Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}



        // Event handler for LinkLabel to navigate to Signup form
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 signupForm = new Form1(this);
            this.Hide();
            signupForm.Show();
        }

        private void LoginUserTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 newForm = new Form1(this);
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}