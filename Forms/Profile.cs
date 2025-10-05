using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IT13_Final_Project.Forms
{
    public partial class Profile : Form
    {
        private int _userId;
        private string connectionString =
            "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

        // Default constructor for Designer
        public Profile()
        {
            InitializeComponent();
        }

        // Constructor when opening with UserID
        public Profile(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            if (_userId > 0)
                LoadUserData(_userId);
        }

        private void LoadUserData(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Username, Email, Contact, Address, JoinDate, 
                                            TotalBorrowed, CurrentlyBorrowed, OverdueBooks, FinesDue
                                     FROM Users WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Panel 3: Basic info
                                lblName.Text = reader["Username"] != DBNull.Value ? reader["Username"].ToString() : "N/A";
                                lblEmail.Text = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "N/A";
                                lblContact.Text = reader["Contact"] != DBNull.Value ? reader["Contact"].ToString() : "N/A";
                                lblAddress.Text = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : "N/A";

                                // Panel 4: Membership + stats
                                lblMemberID.Text = userId.ToString(); // Membership ID
                                lblJoinDate.Text = reader["JoinDate"] != DBNull.Value ? Convert.ToDateTime(reader["JoinDate"]).ToString("yyyy-MM-dd") : "N/A";
                                lblTotalBorrowed.Text = reader["TotalBorrowed"] != DBNull.Value ? reader["TotalBorrowed"].ToString() : "0";
                                lblCurrentlyBorrowed.Text = reader["CurrentlyBorrowed"] != DBNull.Value ? reader["CurrentlyBorrowed"].ToString() : "0";
                                lblOverdue.Text = reader["OverdueBooks"] != DBNull.Value ? reader["OverdueBooks"].ToString() : "0";
                                lblFines.Text = reader["FinesDue"] != DBNull.Value ? "$ " + Convert.ToDecimal(reader["FinesDue"]).ToString("0.00") : "$ 0.00";
                            }
                            else
                            {
                                MessageBox.Show("No user data found for the given ID.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            this.Hide();
            LoginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfiles editProfiles = new EditProfiles(_userId); // Pass _userId to constructor
            this.Hide();
            editProfiles.Show();
        }
        private void Profile_Load_1(object sender, EventArgs e)
        {
            // You can call your existing load function here
            Profile_Load(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
    }
}
