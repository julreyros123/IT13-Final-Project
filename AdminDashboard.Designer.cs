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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGenre = new System.Windows.Forms.TabPage();
            this.lblExistingGenres = new System.Windows.Forms.Label();
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPhotoPath = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.tabPageReturns = new System.Windows.Forms.TabPage();
            this.btnProcessReturn = new System.Windows.Forms.Button();
            this.dataGridViewReturns = new System.Windows.Forms.DataGridView();
            this.tabPageUpdateBooks = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBoxUpdate = new System.Windows.Forms.PictureBox();
            this.btnUpdateBrowse = new System.Windows.Forms.Button();
            this.txtUpdatePhoto = new System.Windows.Forms.TextBox();
            this.lblUpdatePhoto = new System.Windows.Forms.Label();
            this.cmbUpdateGenre = new System.Windows.Forms.ComboBox();
            this.lblUpdateGenre = new System.Windows.Forms.Label();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.txtUpdateAuthor = new System.Windows.Forms.TextBox();
            this.lblUpdateAuthor = new System.Windows.Forms.Label();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGenre.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.tabPageReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturns)).BeginInit();
            this.tabPageUpdateBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 79);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGenre);
            this.tabControl1.Controls.Add(this.tabPageBooks);
            this.tabControl1.Controls.Add(this.tabPageReturns);
            this.tabControl1.Controls.Add(this.tabPageUpdateBooks);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 371);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageGenre
            // 
            this.tabPageGenre.Controls.Add(this.lblExistingGenres);
            this.tabPageGenre.Controls.Add(this.listBoxGenres);
            this.tabPageGenre.Controls.Add(this.btnAddGenre);
            this.tabPageGenre.Controls.Add(this.txtGenreName);
            this.tabPageGenre.Controls.Add(this.lblGenreName);
            this.tabPageGenre.Location = new System.Drawing.Point(4, 24);
            this.tabPageGenre.Name = "tabPageGenre";
            this.tabPageGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGenre.Size = new System.Drawing.Size(792, 343);
            this.tabPageGenre.TabIndex = 0;
            this.tabPageGenre.Text = "Add Genre";
            this.tabPageGenre.UseVisualStyleBackColor = true;
            // 
            // lblExistingGenres
            // 
            this.lblExistingGenres.AutoSize = true;
            this.lblExistingGenres.Location = new System.Drawing.Point(50, 80);
            this.lblExistingGenres.Name = "lblExistingGenres";
            this.lblExistingGenres.Size = new System.Drawing.Size(100, 15);
            this.lblExistingGenres.TabIndex = 4;
            this.lblExistingGenres.Text = "Existing Genres:";
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.ItemHeight = 15;
            this.listBoxGenres.Location = new System.Drawing.Point(50, 100);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.Size = new System.Drawing.Size(300, 200);
            this.listBoxGenres.TabIndex = 3;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(200, 50);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(100, 25);
            this.btnAddGenre.TabIndex = 2;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Location = new System.Drawing.Point(150, 20);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(200, 23);
            this.txtGenreName.TabIndex = 1;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Location = new System.Drawing.Point(50, 23);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(80, 15);
            this.lblGenreName.TabIndex = 0;
            this.lblGenreName.Text = "Genre Name:";
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.pictureBoxBook);
            this.tabPageBooks.Controls.Add(this.btnBrowse);
            this.tabPageBooks.Controls.Add(this.txtPhotoPath);
            this.tabPageBooks.Controls.Add(this.lblPhoto);
            this.tabPageBooks.Controls.Add(this.btnAddBook);
            this.tabPageBooks.Controls.Add(this.cmbGenre);
            this.tabPageBooks.Controls.Add(this.lblGenre);
            this.tabPageBooks.Controls.Add(this.txtDescription);
            this.tabPageBooks.Controls.Add(this.lblDescription);
            this.tabPageBooks.Controls.Add(this.txtAuthor);
            this.tabPageBooks.Controls.Add(this.lblAuthor);
            this.tabPageBooks.Controls.Add(this.txtBookTitle);
            this.tabPageBooks.Controls.Add(this.lblBookTitle);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(792, 343);
            this.tabPageBooks.TabIndex = 1;
            this.tabPageBooks.Text = "Add Books";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.Location = new System.Drawing.Point(400, 30);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBook.TabIndex = 12;
            this.pictureBoxBook.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(310, 186);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtPhotoPath
            // 
            this.txtPhotoPath.Location = new System.Drawing.Point(150, 186);
            this.txtPhotoPath.Name = "txtPhotoPath";
            this.txtPhotoPath.Size = new System.Drawing.Size(150, 23);
            this.txtPhotoPath.TabIndex = 10;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(50, 190);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(42, 15);
            this.lblPhoto.TabIndex = 9;
            this.lblPhoto.Text = "Photo:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(200, 250);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 25);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(150, 150);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(200, 23);
            this.cmbGenre.TabIndex = 7;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(50, 154);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(45, 15);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 110);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 23);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(50, 114);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 15);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(150, 70);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 23);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(50, 74);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 15);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(150, 30);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(200, 23);
            this.txtBookTitle.TabIndex = 1;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(50, 34);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(68, 15);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // tabPageReturns
            // 
            this.tabPageReturns.Controls.Add(this.btnProcessReturn);
            this.tabPageReturns.Controls.Add(this.dataGridViewReturns);
            this.tabPageReturns.Location = new System.Drawing.Point(4, 24);
            this.tabPageReturns.Name = "tabPageReturns";
            this.tabPageReturns.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReturns.Size = new System.Drawing.Size(792, 343);
            this.tabPageReturns.TabIndex = 2;
            this.tabPageReturns.Text = "Manage Returns";
            this.tabPageReturns.UseVisualStyleBackColor = true;
            // 
            // btnProcessReturn
            // 
            this.btnProcessReturn.Location = new System.Drawing.Point(600, 300);
            this.btnProcessReturn.Name = "btnProcessReturn";
            this.btnProcessReturn.Size = new System.Drawing.Size(150, 25);
            this.btnProcessReturn.TabIndex = 1;
            this.btnProcessReturn.Text = "Process Selected Return";
            this.btnProcessReturn.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReturns
            // 
            this.dataGridViewReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturns.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewReturns.Name = "dataGridViewReturns";
            this.dataGridViewReturns.RowHeadersWidth = 51;
            this.dataGridViewReturns.RowTemplate.Height = 25;
            this.dataGridViewReturns.Size = new System.Drawing.Size(750, 250);
            this.dataGridViewReturns.TabIndex = 0;
            // 
            // tabPageUpdateBooks
            // 
            this.tabPageUpdateBooks.Controls.Add(this.btnDelete);
            this.tabPageUpdateBooks.Controls.Add(this.btnUpdate);
            this.tabPageUpdateBooks.Controls.Add(this.pictureBoxUpdate);
            this.tabPageUpdateBooks.Controls.Add(this.btnUpdateBrowse);
            this.tabPageUpdateBooks.Controls.Add(this.txtUpdatePhoto);
            this.tabPageUpdateBooks.Controls.Add(this.lblUpdatePhoto);
            this.tabPageUpdateBooks.Controls.Add(this.cmbUpdateGenre);
            this.tabPageUpdateBooks.Controls.Add(this.lblUpdateGenre);
            this.tabPageUpdateBooks.Controls.Add(this.txtUpdateDescription);
            this.tabPageUpdateBooks.Controls.Add(this.lblUpdateDescription);
            this.tabPageUpdateBooks.Controls.Add(this.txtUpdateAuthor);
            this.tabPageUpdateBooks.Controls.Add(this.lblUpdateAuthor);
            this.tabPageUpdateBooks.Controls.Add(this.txtUpdateTitle);
            this.tabPageUpdateBooks.Controls.Add(this.lblUpdateTitle);
            this.tabPageUpdateBooks.Controls.Add(this.dataGridViewBooks);
            this.tabPageUpdateBooks.Location = new System.Drawing.Point(4, 24);
            this.tabPageUpdateBooks.Name = "tabPageUpdateBooks";
            this.tabPageUpdateBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateBooks.Size = new System.Drawing.Size(792, 343);
            this.tabPageUpdateBooks.TabIndex = 3;
            this.tabPageUpdateBooks.Text = "Update Books";
            this.tabPageUpdateBooks.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(130, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(20, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUpdate
            // 
            this.pictureBoxUpdate.Location = new System.Drawing.Point(420, 180);
            this.pictureBoxUpdate.Name = "pictureBoxUpdate";
            this.pictureBoxUpdate.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpdate.TabIndex = 12;
            this.pictureBoxUpdate.TabStop = false;
            // 
            // btnUpdateBrowse
            // 
            this.btnUpdateBrowse.Location = new System.Drawing.Point(330, 256);
            this.btnUpdateBrowse.Name = "btnUpdateBrowse";
            this.btnUpdateBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBrowse.TabIndex = 11;
            this.btnUpdateBrowse.Text = "Browse";
            this.btnUpdateBrowse.UseVisualStyleBackColor = true;
            // 
            // txtUpdatePhoto
            // 
            this.txtUpdatePhoto.Location = new System.Drawing.Point(170, 256);
            this.txtUpdatePhoto.Name = "txtUpdatePhoto";
            this.txtUpdatePhoto.Size = new System.Drawing.Size(150, 23);
            this.txtUpdatePhoto.TabIndex = 10;
            // 
            // lblUpdatePhoto
            // 
            this.lblUpdatePhoto.AutoSize = true;
            this.lblUpdatePhoto.Location = new System.Drawing.Point(70, 260);
            this.lblUpdatePhoto.Name = "lblUpdatePhoto";
            this.lblUpdatePhoto.Size = new System.Drawing.Size(42, 15);
            this.lblUpdatePhoto.TabIndex = 9;
            this.lblUpdatePhoto.Text = "Photo:";
            // 
            // cmbUpdateGenre
            // 
            this.cmbUpdateGenre.FormattingEnabled = true;
            this.cmbUpdateGenre.Location = new System.Drawing.Point(170, 220);
            this.cmbUpdateGenre.Name = "cmbUpdateGenre";
            this.cmbUpdateGenre.Size = new System.Drawing.Size(200, 23);
            this.cmbUpdateGenre.TabIndex = 8;
            // 
            // lblUpdateGenre
            // 
            this.lblUpdateGenre.AutoSize = true;
            this.lblUpdateGenre.Location = new System.Drawing.Point(70, 224);
            this.lblUpdateGenre.Name = "lblUpdateGenre";
            this.lblUpdateGenre.Size = new System.Drawing.Size(45, 15);
            this.lblUpdateGenre.TabIndex = 7;
            this.lblUpdateGenre.Text = "Genre:";
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(170, 180);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateDescription.TabIndex = 6;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(70, 184);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(69, 15);
            this.lblUpdateDescription.TabIndex = 5;
            this.lblUpdateDescription.Text = "Description:";
            // 
            // txtUpdateAuthor
            // 
            this.txtUpdateAuthor.Location = new System.Drawing.Point(170, 220);
            this.txtUpdateAuthor.Name = "txtUpdateAuthor";
            this.txtUpdateAuthor.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateAuthor.TabIndex = 4;
            // 
            // lblUpdateAuthor
            // 
            this.lblUpdateAuthor.AutoSize = true;
            this.lblUpdateAuthor.Location = new System.Drawing.Point(70, 224);
            this.lblUpdateAuthor.Name = "lblUpdateAuthor";
            this.lblUpdateAuthor.Size = new System.Drawing.Size(47, 15);
            this.lblUpdateAuthor.TabIndex = 3;
            this.lblUpdateAuthor.Text = "Author:";
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(170, 180);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(200, 23);
            this.txtUpdateTitle.TabIndex = 2;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(70, 184);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(68, 15);
            this.lblUpdateTitle.TabIndex = 1;
            this.lblUpdateTitle.Text = "Book Title:";
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 25;
            this.dataGridViewBooks.Size = new System.Drawing.Size(750, 150);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGenre.ResumeLayout(false);
            this.tabPageGenre.PerformLayout();
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.tabPageReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturns)).EndInit();
            this.tabPageUpdateBooks.ResumeLayout(false);
            this.tabPageUpdateBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtUpdateAuthor;
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
    }
}