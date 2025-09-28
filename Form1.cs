using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT13_Final_Project
{
    public partial class Form1 : Form
    {
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
            bool success = Signup(UserTb.Text, PasswordTb.Text, EmailTb.Text);
            if (success)
            {
                MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Navigate back to Login, reinitialize if necessary
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
            else
            {
                MessageBox.Show("Please fill in all fields.", "Signup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

