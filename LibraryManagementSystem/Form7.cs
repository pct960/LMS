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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sname = textBox1.Text;
            string regno = textBox2.Text;
            string pwd = textBox3.Text;
            string rpwd = textBox4.Text;
            string branch = textBox5.Text;

            if (sname == "")
            {
                MessageBox.Show("Please enter the student name");
            }
            if (regno == "")
            {
                MessageBox.Show("Please enter the register number");
            }
            if (pwd == "")
            {
                MessageBox.Show("Please enter the password");
            }
            if (rpwd == "")
            {
                MessageBox.Show("Please retype the password");
            }
            if (branch == "")
            {
                MessageBox.Show("Please enter your branch");
            }
            else if((sname!="") && (regno!="") && (pwd!="") && (rpwd!="") && (branch!=""))
            {
                //Store into database and go to Dashboard form-form6
                Form6 f6 = new Form6();
                f6.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderSize = 1;
            
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
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
    }
}
