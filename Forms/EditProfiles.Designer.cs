namespace IT13_Final_Project.Forms
{
    partial class EditProfiles
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
            panelHeader = new Panel();
            lblEditProfile = new Label();
            panelForm = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(33, 150, 243); // Modern blue shade
            panelHeader.Controls.Add(lblEditProfile);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(600, 50);
            panelHeader.TabIndex = 0;
            // 
            // lblEditProfile
            // 
            lblEditProfile.AutoSize = true;
            lblEditProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblEditProfile.ForeColor = Color.White;
            lblEditProfile.Location = new Point(15, 12);
            lblEditProfile.Name = "lblEditProfile";
            lblEditProfile.Size = new Size(128, 25);
            lblEditProfile.TabIndex = 0;
            lblEditProfile.Text = "Edit Profile";
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BackColor = Color.White;
            panelForm.BorderStyle = BorderStyle.None;
            panelForm.Controls.Add(btnCancel);
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(txtConfirmPassword);
            panelForm.Controls.Add(lblConfirmPassword);
            panelForm.Controls.Add(txtPassword);
            panelForm.Controls.Add(lblPassword);
            panelForm.Controls.Add(txtContact);
            panelForm.Controls.Add(lblContact);
            panelForm.Controls.Add(txtAddress);
            panelForm.Controls.Add(lblAddress);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(txtUsername);
            panelForm.Controls.Add(lblUsername);
            panelForm.Location = new Point(10, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(15);
            panelForm.Size = new Size(580, 300);
            panelForm.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(244, 67, 54); // Modern red shade
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(360, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 47, 47);
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(33, 150, 243); // Modern blue shade
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(240, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 118, 210);
            btnSave.Click += btnSave_Click_1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.None;
            txtConfirmPassword.BackColor = Color.FromArgb(245, 245, 245);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.ForeColor = Color.DimGray;
            txtConfirmPassword.Location = new Point(130, 225);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm your password";
            txtConfirmPassword.Size = new Size(400, 25);
            txtConfirmPassword.TabIndex = 11;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.ForeColor = Color.DimGray;
            lblConfirmPassword.Location = new Point(15, 225);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(123, 19);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(245, 245, 245);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(130, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(400, 25);
            txtPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.DimGray;
            lblPassword.Location = new Point(15, 190);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 19);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.None;
            txtContact.BackColor = Color.FromArgb(245, 245, 245);
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10F);
            txtContact.ForeColor = Color.DimGray;
            txtContact.Location = new Point(130, 155);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Enter your contact number";
            txtContact.Size = new Size(400, 25);
            txtContact.TabIndex = 7;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 10F);
            lblContact.ForeColor = Color.DimGray;
            lblContact.Location = new Point(15, 155);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(60, 19);
            lblContact.TabIndex = 6;
            lblContact.Text = "Contact:";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.BackColor = Color.FromArgb(245, 245, 245);
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.ForeColor = Color.DimGray;
            txtAddress.Location = new Point(130, 120);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Enter your address";
            txtAddress.Size = new Size(400, 25);
            txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 10F);
            lblAddress.ForeColor = Color.DimGray;
            lblAddress.Location = new Point(15, 120);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(61, 19);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.BackColor = Color.FromArgb(245, 245, 245);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(130, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(400, 25);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.DimGray;
            lblEmail.Location = new Point(15, 85);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BackColor = Color.FromArgb(245, 245, 245);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Location = new Point(130, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(400, 25);
            txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.DimGray;
            lblUsername.Location = new Point(15, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 19);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // EditProfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245); // Modern light background
            ClientSize = new Size(600, 370);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Name = "EditProfiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Profile";
            WindowState = FormWindowState.Normal;
            Load += EditProfiles_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
    }
}