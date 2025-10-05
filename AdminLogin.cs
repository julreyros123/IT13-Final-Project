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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AdminUserTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminPasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            string username = AdminUserTb.Text.Trim();
            string password = AdminPasswordTb.Text.Trim();

            // 🔑 Hardcoded admin credentials
            if ((username == "admin" && password == "admin123") ||
                (username == "superadmin" && password == "super456"))
            {
                MessageBox.Show("Welcome Admin!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                AdminDashboard adminForm = new AdminDashboard();
                this.Hide();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid admin credentials.", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 🔄 Go back to normal client login form
            Login newForm = new Login();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }
    }
}