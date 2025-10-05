namespace IT13_Final_Project
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTitle = new Label();
            tabControl1 = new TabControl();
            tabPageGenre = new TabPage();
            lblExistingGenres = new Label();
            listBoxGenres = new ListBox();
            btnAddGenre = new Button();
            txtGenreName = new TextBox();
            lblGenreName = new Label();
            tabPageBooks = new TabPage();
            pictureBoxBook = new PictureBox();
            btnBrowse = new Button();
            txtPhotoPath = new TextBox();
            lblPhoto = new Label();
            btnAddBook = new Button();
            cmbGenre = new ComboBox();
            lblGenre = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtAuthor = new TextBox();
            lblAuthor = new Label();
            txtBookTitle = new TextBox();
            lblBookTitle = new Label();
            tabPageReturns = new TabPage();
            btnProcessReturn = new Button();
            dataGridViewReturns = new DataGridView();
            tabPageUpdateBooks = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            pictureBoxUpdate = new PictureBox();
            btnUpdateBrowse = new Button();
            txtUpdatePhoto = new TextBox();
            lblUpdatePhoto = new Label();
            cmbUpdateGenre = new ComboBox();
            lblUpdateGenre = new Label();
            txtUpdateDescription = new TextBox();
            lblUpdateDescription = new Label();
            txtUpdateAuthor = new TextBox();
            lblUpdateAuthor = new Label();
            txtUpdateTitle = new TextBox();
            lblUpdateTitle = new Label();
            dataGridViewBooks = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageGenre.SuspendLayout();
            tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).BeginInit();
            tabPageReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturns).BeginInit();
            tabPageUpdateBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 79);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Dashboard";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageGenre);
            tabControl1.Controls.Add(tabPageBooks);
            tabControl1.Controls.Add(tabPageReturns);
            tabControl1.Controls.Add(tabPageUpdateBooks);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 79);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 425);
            tabControl1.TabIndex = 1;
            // 
            // tabPageGenre
            // 
            tabPageGenre.Controls.Add(lblExistingGenres);
            tabPageGenre.Controls.Add(listBoxGenres);
            tabPageGenre.Controls.Add(btnAddGenre);
            tabPageGenre.Controls.Add(txtGenreName);
            tabPageGenre.Controls.Add(lblGenreName);
            tabPageGenre.Location = new Point(4, 24);
            tabPageGenre.Name = "tabPageGenre";
            tabPageGenre.Padding = new Padding(3);
            tabPageGenre.Size = new Size(792, 397);
            tabPageGenre.TabIndex = 0;
            tabPageGenre.Text = "Add Genre";
            tabPageGenre.UseVisualStyleBackColor = true;
            // 
            // lblExistingGenres
            // 
            lblExistingGenres.AutoSize = true;
            lblExistingGenres.Location = new Point(50, 80);
            lblExistingGenres.Name = "lblExistingGenres";
            lblExistingGenres.Size = new Size(89, 15);
            lblExistingGenres.TabIndex = 4;
            lblExistingGenres.Text = "Existing Genres:";
            // 
            // listBoxGenres
            // 
            listBoxGenres.FormattingEnabled = true;
            listBoxGenres.ItemHeight = 15;
            listBoxGenres.Location = new Point(50, 100);
            listBoxGenres.Name = "listBoxGenres";
            listBoxGenres.Size = new Size(300, 199);
            listBoxGenres.TabIndex = 3;
            listBoxGenres.SelectedIndexChanged += listBoxGenres_SelectedIndexChanged;
            // 
            // btnAddGenre
            // 
            btnAddGenre.Location = new Point(200, 50);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(100, 25);
            btnAddGenre.TabIndex = 2;
            btnAddGenre.Text = "Add Genre";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += btnAddGenre_Click;
            // 
            // txtGenreName
            // 
            txtGenreName.Location = new Point(150, 20);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(200, 23);
            txtGenreName.TabIndex = 1;
            txtGenreName.TextChanged += txtGenreName_TextChanged;
            // 
            // lblGenreName
            // 
            lblGenreName.AutoSize = true;
            lblGenreName.Location = new Point(50, 23);
            lblGenreName.Name = "lblGenreName";
            lblGenreName.Size = new Size(76, 15);
            lblGenreName.TabIndex = 0;
            lblGenreName.Text = "Genre Name:";
            // 
            // tabPageBooks
            // 
            tabPageBooks.Controls.Add(pictureBoxBook);
            tabPageBooks.Controls.Add(btnBrowse);
            tabPageBooks.Controls.Add(txtPhotoPath);
            tabPageBooks.Controls.Add(lblPhoto);
            tabPageBooks.Controls.Add(btnAddBook);
            tabPageBooks.Controls.Add(cmbGenre);
            tabPageBooks.Controls.Add(lblGenre);
            tabPageBooks.Controls.Add(txtDescription);
            tabPageBooks.Controls.Add(lblDescription);
            tabPageBooks.Controls.Add(txtAuthor);
            tabPageBooks.Controls.Add(lblAuthor);
            tabPageBooks.Controls.Add(txtBookTitle);
            tabPageBooks.Controls.Add(lblBookTitle);
            tabPageBooks.Location = new Point(4, 24);
            tabPageBooks.Name = "tabPageBooks";
            tabPageBooks.Padding = new Padding(3);
            tabPageBooks.Size = new Size(792, 397);
            tabPageBooks.TabIndex = 1;
            tabPageBooks.Text = "Add Books";
            tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBook
            // 
            pictureBoxBook.Location = new Point(400, 30);
            pictureBoxBook.Name = "pictureBoxBook";
            pictureBoxBook.Size = new Size(200, 200);
            pictureBoxBook.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBook.TabIndex = 12;
            pictureBoxBook.TabStop = false;
            pictureBoxBook.Click += pictureBoxBook_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(306, 207);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 11;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.Location = new Point(150, 207);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(150, 23);
            txtPhotoPath.TabIndex = 10;
            txtPhotoPath.TextChanged += txtPhotoPath_TextChanged;
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Location = new Point(50, 210);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(42, 15);
            lblPhoto.TabIndex = 9;
            lblPhoto.Text = "Photo:";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(200, 250);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(100, 25);
            btnAddBook.TabIndex = 8;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(150, 178);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(200, 23);
            cmbGenre.TabIndex = 7;
            cmbGenre.SelectedIndexChanged += cmbGenre_SelectedIndexChanged;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(50, 181);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(41, 15);
            lblGenre.TabIndex = 6;
            lblGenre.Text = "Genre:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(150, 110);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 62);
            txtDescription.TabIndex = 5;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(50, 114);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(150, 70);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 23);
            txtAuthor.TabIndex = 3;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(50, 74);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(47, 15);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author:";
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(150, 30);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(200, 23);
            txtBookTitle.TabIndex = 1;
            txtBookTitle.TextChanged += txtBookTitle_TextChanged;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(50, 34);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(63, 15);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "Book Title:";
            // 
            // tabPageReturns
            // 
            tabPageReturns.Controls.Add(btnProcessReturn);
            tabPageReturns.Controls.Add(dataGridViewReturns);
            tabPageReturns.Location = new Point(4, 24);
            tabPageReturns.Name = "tabPageReturns";
            tabPageReturns.Padding = new Padding(3);
            tabPageReturns.Size = new Size(792, 397);
            tabPageReturns.TabIndex = 2;
            tabPageReturns.Text = "Manage Returns";
            tabPageReturns.UseVisualStyleBackColor = true;
            // 
            // btnProcessReturn
            // 
            btnProcessReturn.Location = new Point(600, 300);
            btnProcessReturn.Name = "btnProcessReturn";
            btnProcessReturn.Size = new Size(150, 25);
            btnProcessReturn.TabIndex = 1;
            btnProcessReturn.Text = "Process Selected Return";
            btnProcessReturn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReturns
            // 
            dataGridViewReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReturns.Location = new Point(20, 20);
            dataGridViewReturns.Name = "dataGridViewReturns";
            dataGridViewReturns.RowHeadersWidth = 51;
            dataGridViewReturns.Size = new Size(750, 250);
            dataGridViewReturns.TabIndex = 0;
            // 
            // tabPageUpdateBooks
            // 
            tabPageUpdateBooks.Controls.Add(btnDelete);
            tabPageUpdateBooks.Controls.Add(btnUpdate);
            tabPageUpdateBooks.Controls.Add(pictureBoxUpdate);
            tabPageUpdateBooks.Controls.Add(btnUpdateBrowse);
            tabPageUpdateBooks.Controls.Add(txtUpdatePhoto);
            tabPageUpdateBooks.Controls.Add(lblUpdatePhoto);
            tabPageUpdateBooks.Controls.Add(cmbUpdateGenre);
            tabPageUpdateBooks.Controls.Add(lblUpdateGenre);
            tabPageUpdateBooks.Controls.Add(txtUpdateDescription);
            tabPageUpdateBooks.Controls.Add(lblUpdateDescription);
            tabPageUpdateBooks.Controls.Add(txtUpdateAuthor);
            tabPageUpdateBooks.Controls.Add(lblUpdateAuthor);
            tabPageUpdateBooks.Controls.Add(txtUpdateTitle);
            tabPageUpdateBooks.Controls.Add(lblUpdateTitle);
            tabPageUpdateBooks.Controls.Add(dataGridViewBooks);
            tabPageUpdateBooks.Location = new Point(4, 24);
            tabPageUpdateBooks.Name = "tabPageUpdateBooks";
            tabPageUpdateBooks.Padding = new Padding(3);
            tabPageUpdateBooks.Size = new Size(792, 397);
            tabPageUpdateBooks.TabIndex = 3;
            tabPageUpdateBooks.Text = "Update Books";
            tabPageUpdateBooks.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(670, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 25);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(670, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 25);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureBoxUpdate
            // 
            pictureBoxUpdate.Location = new Point(420, 180);
            pictureBoxUpdate.Name = "pictureBoxUpdate";
            pictureBoxUpdate.Size = new Size(200, 200);
            pictureBoxUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUpdate.TabIndex = 12;
            pictureBoxUpdate.TabStop = false;
            pictureBoxUpdate.Click += pictureBoxUpdate_Click;
            // 
            // btnUpdateBrowse
            // 
            btnUpdateBrowse.Location = new Point(326, 303);
            btnUpdateBrowse.Name = "btnUpdateBrowse";
            btnUpdateBrowse.Size = new Size(75, 23);
            btnUpdateBrowse.TabIndex = 11;
            btnUpdateBrowse.Text = "Browse";
            btnUpdateBrowse.UseVisualStyleBackColor = true;
            btnUpdateBrowse.Click += btnUpdateBrowse_Click;
            // 
            // txtUpdatePhoto
            // 
            txtUpdatePhoto.Location = new Point(170, 303);
            txtUpdatePhoto.Name = "txtUpdatePhoto";
            txtUpdatePhoto.Size = new Size(150, 23);
            txtUpdatePhoto.TabIndex = 10;
            txtUpdatePhoto.TextChanged += txtUpdatePhoto_TextChanged;
            // 
            // lblUpdatePhoto
            // 
            lblUpdatePhoto.AutoSize = true;
            lblUpdatePhoto.Location = new Point(70, 307);
            lblUpdatePhoto.Name = "lblUpdatePhoto";
            lblUpdatePhoto.Size = new Size(42, 15);
            lblUpdatePhoto.TabIndex = 9;
            lblUpdatePhoto.Text = "Photo:";
            // 
            // cmbUpdateGenre
            // 
            cmbUpdateGenre.FormattingEnabled = true;
            cmbUpdateGenre.Location = new Point(170, 274);
            cmbUpdateGenre.Name = "cmbUpdateGenre";
            cmbUpdateGenre.Size = new Size(200, 23);
            cmbUpdateGenre.TabIndex = 8;
            cmbUpdateGenre.SelectedIndexChanged += cmbUpdateGenre_SelectedIndexChanged;
            // 
            // lblUpdateGenre
            // 
            lblUpdateGenre.AutoSize = true;
            lblUpdateGenre.Location = new Point(70, 277);
            lblUpdateGenre.Name = "lblUpdateGenre";
            lblUpdateGenre.Size = new Size(41, 15);
            lblUpdateGenre.TabIndex = 7;
            lblUpdateGenre.Text = "Genre:";
            // 
            // txtUpdateDescription
            // 
            txtUpdateDescription.Location = new Point(170, 180);
            txtUpdateDescription.Multiline = true;
            txtUpdateDescription.Name = "txtUpdateDescription";
            txtUpdateDescription.Size = new Size(200, 59);
            txtUpdateDescription.TabIndex = 6;
            txtUpdateDescription.TextChanged += txtUpdateDescription_TextChanged;
            // 
            // lblUpdateDescription
            // 
            lblUpdateDescription.AutoSize = true;
            lblUpdateDescription.Location = new Point(70, 184);
            lblUpdateDescription.Name = "lblUpdateDescription";
            lblUpdateDescription.Size = new Size(70, 15);
            lblUpdateDescription.TabIndex = 5;
            lblUpdateDescription.Text = "Description:";
            // 
            // txtUpdateAuthor
            // 
            txtUpdateAuthor.Location = new Point(170, 245);
            txtUpdateAuthor.Name = "txtUpdateAuthor";
            txtUpdateAuthor.Size = new Size(200, 23);
            txtUpdateAuthor.TabIndex = 4;
            txtUpdateAuthor.TextChanged += txtUpdateAuthor_TextChanged;
            // 
            // lblUpdateAuthor
            // 
            lblUpdateAuthor.AutoSize = true;
            lblUpdateAuthor.Location = new Point(70, 248);
            lblUpdateAuthor.Name = "lblUpdateAuthor";
            lblUpdateAuthor.Size = new Size(47, 15);
            lblUpdateAuthor.TabIndex = 3;
            lblUpdateAuthor.Text = "Author:";
            // 
            // txtUpdateTitle
            // 
            txtUpdateTitle.Location = new Point(170, 180);
            txtUpdateTitle.Name = "txtUpdateTitle";
            txtUpdateTitle.Size = new Size(200, 23);
            txtUpdateTitle.TabIndex = 2;
            // 
            // lblUpdateTitle
            // 
            lblUpdateTitle.AutoSize = true;
            lblUpdateTitle.Location = new Point(70, 184);
            lblUpdateTitle.Name = "lblUpdateTitle";
            lblUpdateTitle.Size = new Size(63, 15);
            lblUpdateTitle.TabIndex = 1;
            lblUpdateTitle.Text = "Book Title:";
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(20, 20);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(750, 150);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellContentClick += dataGridViewBooks_CellContentClick;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageGenre.ResumeLayout(false);
            tabPageGenre.PerformLayout();
            tabPageBooks.ResumeLayout(false);
            tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).EndInit();
            tabPageReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReturns).EndInit();
            tabPageUpdateBooks.ResumeLayout(false);
            tabPageUpdateBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGenre;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.TabPage tabPageReturns;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label lblGenreName;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Button btnProcessReturn;
        private System.Windows.Forms.DataGridView dataGridViewReturns;
        private System.Windows.Forms.ListBox listBoxGenres;
        private System.Windows.Forms.Label lblExistingGenres;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TextBox txtPhotoPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.TabPage tabPageUpdateBooks;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label lblUpdateAuthor;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Label lblUpdateGenre;
        private System.Windows.Forms.ComboBox cmbUpdateGenre;
        private System.Windows.Forms.Label lblUpdatePhoto;
        private System.Windows.Forms.TextBox txtUpdatePhoto;
        private System.Windows.Forms.Button btnUpdateBrowse;
        private System.Windows.Forms.PictureBox pictureBoxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private TextBox txtUpdateAuthor;
    }
}