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
            button1 = new Button();
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
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            txtBookTitle = new TextBox();
            lblPhoto = new Label();
            btnAddBook = new Button();
            cmbGenre = new ComboBox();
            lblGenre = new Label();
            lblDescription = new Label();
            lblAuthor = new Label();
            lblBookTitle = new Label();
            tabPageUpdateBooks = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            pictureBoxUpdate = new PictureBox();
            btnUpdateBrowse = new Button();
            txtUpdatePhoto = new TextBox();
            txtUpdateDescription = new TextBox();
            txtUpdateAuthor = new TextBox();
            txtUpdateTitle = new TextBox();
            lblUpdatePhoto = new Label();
            cmbUpdateGenre = new ComboBox();
            lblUpdateGenre = new Label();
            lblUpdateDescription = new Label();
            lblUpdateAuthor = new Label();
            lblUpdateTitle = new Label();
            dataGridViewBooks = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Cover = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageGenre.SuspendLayout();
            tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).BeginInit();
            tabPageUpdateBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 79);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(701, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 1;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            tabControl1.Controls.Add(tabPageUpdateBooks);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 79);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(906, 454);
            tabControl1.TabIndex = 1;
            // 
            // tabPageGenre
            // 
            tabPageGenre.Controls.Add(label5);
            tabPageGenre.Controls.Add(lblExistingGenres);
            tabPageGenre.Controls.Add(listBoxGenres);
            tabPageGenre.Controls.Add(btnAddGenre);
            tabPageGenre.Controls.Add(txtGenreName);
            tabPageGenre.Controls.Add(lblGenreName);
            tabPageGenre.Location = new Point(4, 24);
            tabPageGenre.Name = "tabPageGenre";
            tabPageGenre.Padding = new Padding(3);
            tabPageGenre.Size = new Size(792, 343);
            tabPageGenre.TabIndex = 0;
            tabPageGenre.Text = "Add Genre";
            tabPageGenre.UseVisualStyleBackColor = true;
            // 
            // lblExistingGenres
            // 
            lblExistingGenres.AutoSize = true;
            lblExistingGenres.Location = new Point(50, 80);
            lblExistingGenres.Name = "lblExistingGenres";
            lblExistingGenres.Size = new Size(0, 15);
            lblExistingGenres.TabIndex = 4;
            // 
            // listBoxGenres
            // 
            listBoxGenres.FormattingEnabled = true;
            listBoxGenres.ItemHeight = 15;
            listBoxGenres.Location = new Point(50, 100);
            listBoxGenres.Name = "listBoxGenres";
            listBoxGenres.Size = new Size(300, 199);
            listBoxGenres.TabIndex = 3;
            listBoxGenres.SelectedIndexChanged += listBoxGenres_SelectedIndexChanged_1;
            // 
            // btnAddGenre
            // 
            btnAddGenre.Location = new Point(200, 50);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(100, 25);
            btnAddGenre.TabIndex = 2;
            btnAddGenre.Text = "Add Genre";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += btnAddGenre_Click_1;
            // 
            // txtGenreName
            // 
            txtGenreName.Location = new Point(150, 20);
            txtGenreName.Name = "txtGenreName";
            txtGenreName.Size = new Size(200, 23);
            txtGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            lblGenreName.AutoSize = true;
            lblGenreName.Location = new Point(50, 23);
            lblGenreName.Name = "lblGenreName";
            lblGenreName.Size = new Size(0, 15);
            lblGenreName.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            tabPageBooks.Controls.Add(Cover);
            tabPageBooks.Controls.Add(label4);
            tabPageBooks.Controls.Add(label3);
            tabPageBooks.Controls.Add(label2);
            tabPageBooks.Controls.Add(label1);
            tabPageBooks.Controls.Add(pictureBoxBook);
            tabPageBooks.Controls.Add(btnBrowse);
            tabPageBooks.Controls.Add(txtPhotoPath);
            tabPageBooks.Controls.Add(txtDescription);
            tabPageBooks.Controls.Add(txtAuthor);
            tabPageBooks.Controls.Add(txtBookTitle);
            tabPageBooks.Controls.Add(lblPhoto);
            tabPageBooks.Controls.Add(btnAddBook);
            tabPageBooks.Controls.Add(cmbGenre);
            tabPageBooks.Controls.Add(lblGenre);
            tabPageBooks.Controls.Add(lblDescription);
            tabPageBooks.Controls.Add(lblAuthor);
            tabPageBooks.Controls.Add(lblBookTitle);
            tabPageBooks.Location = new Point(4, 24);
            tabPageBooks.Name = "tabPageBooks";
            tabPageBooks.Padding = new Padding(3);
            tabPageBooks.Size = new Size(792, 343);
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
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(306, 220);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 11;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.Location = new Point(150, 221);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(150, 23);
            txtPhotoPath.TabIndex = 10;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(150, 110);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 59);
            txtDescription.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(150, 70);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(200, 23);
            txtAuthor.TabIndex = 3;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(150, 30);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(200, 23);
            txtBookTitle.TabIndex = 1;
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Location = new Point(50, 190);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(0, 15);
            lblPhoto.TabIndex = 9;
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
            cmbGenre.Location = new Point(150, 182);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(200, 23);
            cmbGenre.TabIndex = 7;
            cmbGenre.SelectedIndexChanged += cmbGenre_SelectedIndexChanged_1;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(50, 154);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(0, 15);
            lblGenre.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(50, 114);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 15);
            lblDescription.TabIndex = 4;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(50, 74);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(0, 15);
            lblAuthor.TabIndex = 2;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(50, 34);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(0, 15);
            lblBookTitle.TabIndex = 0;
            // 
            // tabPageUpdateBooks
            // 
            tabPageUpdateBooks.Controls.Add(label10);
            tabPageUpdateBooks.Controls.Add(label9);
            tabPageUpdateBooks.Controls.Add(label8);
            tabPageUpdateBooks.Controls.Add(label7);
            tabPageUpdateBooks.Controls.Add(label6);
            tabPageUpdateBooks.Controls.Add(btnDelete);
            tabPageUpdateBooks.Controls.Add(btnUpdate);
            tabPageUpdateBooks.Controls.Add(pictureBoxUpdate);
            tabPageUpdateBooks.Controls.Add(btnUpdateBrowse);
            tabPageUpdateBooks.Controls.Add(txtUpdatePhoto);
            tabPageUpdateBooks.Controls.Add(txtUpdateDescription);
            tabPageUpdateBooks.Controls.Add(txtUpdateAuthor);
            tabPageUpdateBooks.Controls.Add(txtUpdateTitle);
            tabPageUpdateBooks.Controls.Add(lblUpdatePhoto);
            tabPageUpdateBooks.Controls.Add(cmbUpdateGenre);
            tabPageUpdateBooks.Controls.Add(lblUpdateGenre);
            tabPageUpdateBooks.Controls.Add(lblUpdateDescription);
            tabPageUpdateBooks.Controls.Add(lblUpdateAuthor);
            tabPageUpdateBooks.Controls.Add(lblUpdateTitle);
            tabPageUpdateBooks.Controls.Add(dataGridViewBooks);
            tabPageUpdateBooks.Location = new Point(4, 24);
            tabPageUpdateBooks.Name = "tabPageUpdateBooks";
            tabPageUpdateBooks.Padding = new Padding(3);
            tabPageUpdateBooks.Size = new Size(898, 426);
            tabPageUpdateBooks.TabIndex = 3;
            tabPageUpdateBooks.Text = "Update Books";
            tabPageUpdateBooks.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(670, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 25);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(672, 250);
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
            // 
            // btnUpdateBrowse
            // 
            btnUpdateBrowse.Location = new Point(326, 356);
            btnUpdateBrowse.Name = "btnUpdateBrowse";
            btnUpdateBrowse.Size = new Size(75, 23);
            btnUpdateBrowse.TabIndex = 11;
            btnUpdateBrowse.Text = "Browse";
            btnUpdateBrowse.UseVisualStyleBackColor = true;
            btnUpdateBrowse.Click += btnUpdateBrowse_Click_1;
            // 
            // txtUpdatePhoto
            // 
            txtUpdatePhoto.Location = new Point(170, 357);
            txtUpdatePhoto.Name = "txtUpdatePhoto";
            txtUpdatePhoto.Size = new Size(150, 23);
            txtUpdatePhoto.TabIndex = 10;
            // 
            // txtUpdateDescription
            // 
            txtUpdateDescription.Location = new Point(170, 238);
            txtUpdateDescription.Multiline = true;
            txtUpdateDescription.Name = "txtUpdateDescription";
            txtUpdateDescription.Size = new Size(200, 83);
            txtUpdateDescription.TabIndex = 6;
            // 
            // txtUpdateAuthor
            // 
            txtUpdateAuthor.Location = new Point(170, 209);
            txtUpdateAuthor.Name = "txtUpdateAuthor";
            txtUpdateAuthor.Size = new Size(200, 23);
            txtUpdateAuthor.TabIndex = 4;
            txtUpdateAuthor.TextChanged += txtUpdateAuthor_TextChanged;
            // 
            // txtUpdateTitle
            // 
            txtUpdateTitle.Location = new Point(170, 180);
            txtUpdateTitle.Name = "txtUpdateTitle";
            txtUpdateTitle.Size = new Size(200, 23);
            txtUpdateTitle.TabIndex = 2;
            // 
            // lblUpdatePhoto
            // 
            lblUpdatePhoto.AutoSize = true;
            lblUpdatePhoto.Location = new Point(70, 260);
            lblUpdatePhoto.Name = "lblUpdatePhoto";
            lblUpdatePhoto.Size = new Size(0, 15);
            lblUpdatePhoto.TabIndex = 9;
            // 
            // cmbUpdateGenre
            // 
            cmbUpdateGenre.FormattingEnabled = true;
            cmbUpdateGenre.Location = new Point(170, 327);
            cmbUpdateGenre.Name = "cmbUpdateGenre";
            cmbUpdateGenre.Size = new Size(200, 23);
            cmbUpdateGenre.TabIndex = 8;
            // 
            // lblUpdateGenre
            // 
            lblUpdateGenre.AutoSize = true;
            lblUpdateGenre.Location = new Point(70, 224);
            lblUpdateGenre.Name = "lblUpdateGenre";
            lblUpdateGenre.Size = new Size(0, 15);
            lblUpdateGenre.TabIndex = 7;
            // 
            // lblUpdateDescription
            // 
            lblUpdateDescription.AutoSize = true;
            lblUpdateDescription.Location = new Point(70, 184);
            lblUpdateDescription.Name = "lblUpdateDescription";
            lblUpdateDescription.Size = new Size(0, 15);
            lblUpdateDescription.TabIndex = 5;
            // 
            // lblUpdateAuthor
            // 
            lblUpdateAuthor.AutoSize = true;
            lblUpdateAuthor.Location = new Point(70, 224);
            lblUpdateAuthor.Name = "lblUpdateAuthor";
            lblUpdateAuthor.Size = new Size(0, 15);
            lblUpdateAuthor.TabIndex = 3;
            // 
            // lblUpdateTitle
            // 
            lblUpdateTitle.AutoSize = true;
            lblUpdateTitle.Location = new Point(70, 184);
            lblUpdateTitle.Name = "lblUpdateTitle";
            lblUpdateTitle.Size = new Size(0, 15);
            lblUpdateTitle.TabIndex = 1;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(20, 20);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(750, 150);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellContentClick += dataGridViewBooks_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 34);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 13;
            label1.Text = "BookTitle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 73);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 14;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 113);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 15;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 182);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 16;
            label4.Text = "Genre";
            // 
            // Cover
            // 
            Cover.AutoSize = true;
            Cover.Location = new Point(50, 224);
            Cover.Name = "Cover";
            Cover.Size = new Size(70, 15);
            Cover.TabIndex = 17;
            Cover.Text = "Book Image";
            Cover.Click += label5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 23);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 5;
            label5.Text = "Genre Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 183);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 15;
            label6.Text = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 212);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 16;
            label7.Text = "Author";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(89, 250);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 17;
            label8.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(89, 330);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 18;
            label9.Text = "Genre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(89, 360);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 19;
            label10.Text = "Book Cover";
            label10.Click += label10_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 533);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += AdminDashboard_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageGenre.ResumeLayout(false);
            tabPageGenre.PerformLayout();
            tabPageBooks.ResumeLayout(false);
            tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBook).EndInit();
            tabPageUpdateBooks.ResumeLayout(false);
            tabPageUpdateBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private TabControl tabControl1;
        private Button button1;
        private TabPage tabPageGenre;
        private Label lblExistingGenres;
        private ListBox listBoxGenres;
        private Button btnAddGenre;
        private TextBox txtGenreName;
        private Label lblGenreName;
        private TabPage tabPageBooks;
        private PictureBox pictureBoxBook;
        private Button btnBrowse;
        private TextBox txtPhotoPath;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private TextBox txtBookTitle;
        private Label lblPhoto;
        private Button btnAddBook;
        private ComboBox cmbGenre;
        private Label lblGenre;
        private Label lblDescription;
        private Label lblAuthor;
        private Label lblBookTitle;
        private TabPage tabPageUpdateBooks;
        private Button btnDelete;
        private Button btnUpdate;
        private PictureBox pictureBoxUpdate;
        private Button btnUpdateBrowse;
        private TextBox txtUpdatePhoto;
        private TextBox txtUpdateDescription;
        private TextBox txtUpdateAuthor;
        private TextBox txtUpdateTitle;
        private Label lblUpdatePhoto;
        private ComboBox cmbUpdateGenre;
        private Label lblUpdateGenre;
        private Label lblUpdateDescription;
        private Label lblUpdateAuthor;
        private Label lblUpdateTitle;
        private DataGridView dataGridViewBooks;
        private Label Cover;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}