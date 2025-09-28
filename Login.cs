using System;
using System.Windows.Forms;

namespace IT13_Final_Project
{
    public partial class Login : Form
    {

        private readonly Dictionary<string, string> _users = new Dictionary<string, string>
        {
            { "admin", "admin123" }, 
            { "user1", "pass123" },  
            { "testuser", "test456" } 
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

        // SignIn function
        public bool SignIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false; 
            }            
            return true; 
        }

        // Event handler for SignIn button
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            bool success = SignIn(LoginUserTb.Text, LoginPasswordTb.Text);
            if (success)
            {
                MessageBox.Show("Sign-in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Navigate to Dashboard form
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
    }
}