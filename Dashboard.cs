using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using IT13_Final_Project.Forms;
using Microsoft.Data.SqlClient;

namespace IT13_Final_Project
{
    public partial class Dashboard : Form
    {
        private bool isCollapsed = false;
        public static Panel MainPanel;
        private int _userId;
        private DataRow loggedInUser;

        private string connectionString =
           "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        // ✅ Label fields for displaying user info
        private Label lblUsername = new Label();
        private Label lblEmail = new Label();
        private Label lblContact = new Label();
        private Label lblAddress = new Label();

        // ✅ Constructor that accepts a UserID (passed after login)
        public Dashboard(int userId)
        {
            InitializeComponent();
            _userId = userId;

            // Setup labels visually
            InitializeUserLabels();
        }

        // ✅ Dashboard load event
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Load user info from the database
            LoadUserData(_userId);

            // Open HomePage by default
            OpenChildForm(new HomePage(_userId));
        }

        // ✅ Create and position user info labels
        private void InitializeUserLabels()
        {
            // Username
            lblUsername.Name = "lblUsername";
            lblUsername.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblUsername.Location = new Point(220, 20);
            lblUsername.Size = new Size(250, 20);
            this.Controls.Add(lblUsername);

            // Email
            lblEmail.Name = "lblEmail";
            lblEmail.Font = new Font("Segoe UI", 9);
            lblEmail.Location = new Point(220, 50);
            lblEmail.Size = new Size(250, 20);
            this.Controls.Add(lblEmail);

            // Contact
            lblContact.Name = "lblContact";
            lblContact.Font = new Font("Segoe UI", 9);
            lblContact.Location = new Point(220, 80);
            lblContact.Size = new Size(250, 20);
            this.Controls.Add(lblContact);

            // Address
            lblAddress.Name = "lblAddress";
            lblAddress.Font = new Font("Segoe UI", 9);
            lblAddress.Location = new Point(220, 110);
            lblAddress.Size = new Size(250, 20);
            this.Controls.Add(lblAddress);
        }

        // ✅ Load user data from the database
        private void LoadUserData(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Username, Email, Contact, Address FROM Users WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblUsername.Text = "👤 " + reader["Username"].ToString();
                                lblEmail.Text = "📧 " + reader["Email"].ToString();
                                lblContact.Text = "📱 " + reader["Contact"].ToString();
                                lblAddress.Text = "🏠 " + reader["Address"].ToString();
                            }
                            else
                            {
                                lblUsername.Text = "User not found.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user info: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Opens a child form inside the dashboard panel
        private void OpenChildForm(Form childForm)
        {
            panel6.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel6.Controls.Add(childForm);
            childForm.Show();
        }

        // ✅ Navigation Buttons
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new HomePage(_userId));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Catalog(_userId));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BorrowedBooks(_userId));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Favorites(_userId));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(_userId));
        }

        // ✅ Collapsible side menu
        private void menuBtn_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel1.Width = 200; // expand
                isCollapsed = false;
            }
            else
            {
                panel1.Width = 50; // collapse
                isCollapsed = true;
            }
        }
    }
}
