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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regno = textBox1.Text;
            string pwd = textBox2.Text;
            if (regno == "")
            {
                MessageBox.Show("Please enter your register number");
            }
            if(pwd == "")
            {
                MessageBox.Show("Please enter your password");
            }
            if((regno!="") && (pwd!=""))
            {
                //LOGIN validation goes here
                Form6 f6 = new Form6();
                f6.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7=new Form7();
            f7.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            this.Close();
            ob.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form6 ob = new Form6();
            this.Close();
            ob.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form7 ob = new Form7();
            this.Close();
            ob.Show();
        }
    }
}
