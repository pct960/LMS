using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The login validation code goes here
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderSize = 1;
            button3.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 ob = new Form9();
            this.Close();
            ob.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            this.Close();
            ob.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            this.Close();
            ob.Show();
        }
    }
}
