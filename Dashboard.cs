using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT13_Final_Project.Forms;


namespace IT13_Final_Project
{
    public partial class Dashboard : Form
    {
        private System.Windows.Forms.Panel panelpaint1;
        private bool isCollapsed = false;

        public static Panel MainPanel;


        public Dashboard()
        {
            InitializeComponent();


        }
        private void OpenChildForm(Form childForm)
        {
            panel6.Controls.Clear();


            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;


            panel6.Controls.Add(childForm);
            childForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            OpenChildForm(new HomePage());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Catalog());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new HomePage());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BorrowedBooks());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Favorites());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile());
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                // expand
                panel1.Width = 200;
                isCollapsed = false;
            }
            else
            {
                // collapse
                panel1.Width = 50;
                isCollapsed = true;
            }



        }
    }
}
