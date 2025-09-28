using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT13_Final_Project.Forms
{
    public partial class BorrowedBooks : Form
    {
        public BorrowedBooks()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Dock = DockStyle.Fill;
            catalog.TopLevel = false;
            Dashboard.MainPanel.Controls.Clear();
            Dashboard.MainPanel.Controls.Add(catalog);
            catalog.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
