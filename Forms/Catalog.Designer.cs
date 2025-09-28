namespace IT13_Final_Project.Forms
{
    partial class Catalog
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
            panel2 = new Panel();
            label2 = new Label();
            searchgenreTb = new TextBox();
            comedyBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.BurlyWood;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1244, 83);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft New Tai Lue", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(642, 21);
            label2.Name = "label2";
            label2.Size = new Size(139, 35);
            label2.TabIndex = 0;
            label2.Text = "CATALOG";
            label2.Click += label2_Click;
            // 
            // searchgenreTb
            // 
            searchgenreTb.BackColor = SystemColors.ControlLight;
            searchgenreTb.BorderStyle = BorderStyle.FixedSingle;
            searchgenreTb.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold);
            searchgenreTb.Location = new Point(622, 125);
            searchgenreTb.Multiline = true;
            searchgenreTb.Name = "searchgenreTb";
            searchgenreTb.PlaceholderText = "Search Genres...";
            searchgenreTb.Size = new Size(268, 30);
            searchgenreTb.TabIndex = 3;
            // 
            // comedyBtn
            // 
            comedyBtn.BackColor = Color.Chocolate;
            comedyBtn.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comedyBtn.ForeColor = SystemColors.ButtonHighlight;
            comedyBtn.Location = new Point(312, 189);
            comedyBtn.Name = "comedyBtn";
            comedyBtn.Size = new Size(200, 100);
            comedyBtn.TabIndex = 10;
            comedyBtn.Text = "Adventure";
            comedyBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(754, 189);
            button1.Name = "button1";
            button1.Size = new Size(200, 100);
            button1.TabIndex = 11;
            button1.Text = "Biograph";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(534, 189);
            button2.Name = "button2";
            button2.Size = new Size(200, 100);
            button2.TabIndex = 12;
            button2.Text = "Autobiograph";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Chocolate;
            button3.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(976, 189);
            button3.Name = "button3";
            button3.Size = new Size(200, 100);
            button3.TabIndex = 11;
            button3.Text = "Business";
            button3.UseVisualStyleBackColor = false;
            // 
            // Catalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 484);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(comedyBtn);
            Controls.Add(searchgenreTb);
            Controls.Add(panel2);
            Name = "Catalog";
            Text = "Catalog";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private TextBox searchgenreTb;
        private Button comedyBtn;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}