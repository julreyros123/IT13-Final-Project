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
    public partial class AdminDashboard : Form
    {

        private readonly string connectionString =
           "Data Source=LUPIN\\SQLEXPRESS;Initial Catalog=IT13;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
        private int selectedBookId;

        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load;
        }

        // ✅ Load genres into ComboBox
        private void LoadGenresToComboBox()
        {
            cmbGenre.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT GenreName FROM Genre ORDER BY GenreName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbGenre.Items.Add(reader["GenreName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres (ComboBox): " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ✅ Load Books into DataGridView
        private void LoadBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT BookID, BookTitle, Author, Description, Genre, BookImage FROM Books";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewBooks.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadGenres();
        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAddGenre_Click_1(object sender, EventArgs e)
        {
            string genreName = txtGenreName.Text.Trim();

            if (string.IsNullOrWhiteSpace(genreName))
            {
                MessageBox.Show("Please enter a genre name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Genre (GenreName) VALUES (@name)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", genreName);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Genre added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtGenreName.Clear();
                            LoadGenres();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add genre.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ✅ Load genres into ListBox
        private void LoadGenres()
        {
            listBoxGenres.Items.Clear();
            cmbGenre.Items.Clear();
            cmbUpdateGenre.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT GenreName FROM Genre ORDER BY GenreName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string genre = reader["GenreName"]?.ToString() ?? string.Empty;

                            if (!string.IsNullOrEmpty(genre))
                            {
                                listBoxGenres.Items.Add(genre);
                                cmbGenre.Items.Add(genre);
                                cmbUpdateGenre.Items.Add(genre);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbGenre_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBoxGenres_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxGenres.SelectedItem != null)
            {
                txtGenreName.Text = listBoxGenres.SelectedItem.ToString();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select Book Image";
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        txtPhotoPath.Text = ofd.FileName;
                        pictureBoxBook.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtBookTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string description = txtDescription.Text.Trim();
            string genre = cmbGenre.SelectedItem?.ToString();
            string imagePath = txtPhotoPath.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Books (BookTitle, Author, Description, Genre, BookImage) " +
                                   "VALUES (@title, @auth, @desc, @genre, @img)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@auth", author);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@img", imagePath);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Book added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear inputs
                            txtBookTitle.Clear();
                            txtAuthor.Clear();
                            txtDescription.Clear();
                            txtPhotoPath.Clear();
                            pictureBoxBook.Image = null;
                            cmbGenre.SelectedIndex = -1;

                            LoadBooks(); // refresh book list
                        }
                        else
                        {
                            MessageBox.Show("Failed to add book.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];
                selectedBookId = Convert.ToInt32(row.Cells["BookID"].Value);
                txtUpdateTitle.Text = row.Cells["BookTitle"].Value.ToString();
                txtUpdateAuthor.Text = row.Cells["Author"].Value.ToString();
                txtUpdateDescription.Text = row.Cells["Description"].Value.ToString();
                cmbUpdateGenre.Text = row.Cells["Genre"].Value.ToString();
                txtUpdatePhoto.Text = row.Cells["BookImage"].Value.ToString();

                try
                {
                    if (!string.IsNullOrEmpty(txtUpdatePhoto.Text) && System.IO.File.Exists(txtUpdatePhoto.Text))
                    {
                        pictureBoxUpdate.Image = Image.FromFile(txtUpdatePhoto.Text);
                    }
                    else
                    {
                        pictureBoxUpdate.Image = null;
                    }
                }
                catch
                {
                    pictureBoxUpdate.Image = null;
                }
            }
        }

        private void btnUpdateBrowse_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Book Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtUpdatePhoto.Text = ofd.FileName;
                    pictureBoxUpdate.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBookId == -1)
            {
                MessageBox.Show("Please select a book first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string booktitle = txtUpdateTitle.Text.Trim();
            string description = txtUpdateDescription.Text.Trim();
            string author = txtUpdateAuthor.Text.Trim();
            string genre = cmbUpdateGenre.SelectedItem?.ToString();
            string imagePath = txtUpdatePhoto.Text.Trim();

            if (string.IsNullOrWhiteSpace(booktitle) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(genre) ||
                string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please fill in all update fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Books 
                                     SET BookTitle = @title, Description = @desc, Author = @auth, Genre = @genre, BookImage = @img 
                                     WHERE BookID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", booktitle);
                        cmd.Parameters.AddWithValue("@desc", description);
                        cmd.Parameters.AddWithValue("@auth", author);
                        cmd.Parameters.AddWithValue("@genre", genre);
                        cmd.Parameters.AddWithValue("@img", imagePath);
                        cmd.Parameters.AddWithValue("@id", selectedBookId);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks(); // refresh table
                        }
                        else
                        {
                            MessageBox.Show("Failed to update book.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            if (selectedBookId == -1)
            {
                MessageBox.Show("Please select a book first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this book?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Books WHERE BookID = @id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedBookId);
                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Book deleted successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadBooks();
                                selectedBookId = -1;
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete book.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUpdateAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

