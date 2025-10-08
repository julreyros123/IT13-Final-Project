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
    public partial class EditProfiles : Form
    {
        private string connectionString = "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
        public int UserID { get; set; }

        public EditProfiles(int userID)
        {
            InitializeComponent();
            UserID = userID;
        }

        private void EditProfiles_Load(object sender, EventArgs e)
        {
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Username, Email, Address, Contact FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtUsername.Text = reader["Username"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
                                txtContact.Text = reader["Contact"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }



        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string passwordSql = string.IsNullOrEmpty(txtPassword.Text) ? "" : ", Password = @Password";
                    string query = $"UPDATE Users SET Username = @Username, Email = @Email, Address = @Address, Contact = @Contact{passwordSql} WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                        if (!string.IsNullOrEmpty(txtPassword.Text))
                        {
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text); // Note: In production, hash the password
                        }
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Profile updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }
    }
}