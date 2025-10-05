using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    public partial class Catalog : Form
    {
        private string connectionString =
            "Server=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        private DataTable genresTable;
        private int _userId;  // Added to store UserID

        public Catalog(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        public Catalog()
        {
            InitializeComponent();
            _userId = 0;  // Default value, adjust as needed
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            LoadGenres();
        }

        private void LoadGenres()
        {
            genreFlowPanel.Controls.Clear();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // ✅ Make sure these column names exist in your database
                    string query = "SELECT GenreId, GenreName FROM Genre ORDER BY GenreName";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    genresTable = new DataTable();
                    da.Fill(genresTable);

                    foreach (DataRow row in genresTable.Rows)
                    {
                        Button btn = new Button();
                        btn.Text = row["GenreName"].ToString();
                        btn.Tag = row["GenreId"]; // store ID
                        btn.Width = 200;
                        btn.Height = 60;
                        btn.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold);
                        btn.BackColor = Color.Chocolate;
                        btn.ForeColor = Color.White;
                        btn.Margin = new Padding(10);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Click += GenreButton_Click;

                        genreFlowPanel.Controls.Add(btn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenreButton_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            string genreName = clicked.Text; // since your DB stores Genre as text

            // 👉 Hide Catalog while BookSelection is open
            this.Hide();

            using (BookSelection bookForm = new BookSelection(genreName, _userId))
            {
                bookForm.ShowDialog();
            }

            // 👉 Show Catalog again after closing BookSelection
            this.Show();
        }

        private void searchgenreTb_TextChanged(object sender, EventArgs e)
        {
            string filter = searchgenreTb.Text.Trim().ToLower();
            foreach (Control ctrl in genreFlowPanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Visible = btn.Text.ToLower().Contains(filter);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog(_userId);  // Pass _userId to new instance
            catalog.Dock = DockStyle.Fill;
            catalog.TopLevel = false;
            Dashboard.MainPanel.Controls.Clear();
            Dashboard.MainPanel.Controls.Add(catalog);
            catalog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Not needed anymore since genres load dynamically
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Not needed anymore since genres load dynamically
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: maybe go back to homepage
        }
    }
}