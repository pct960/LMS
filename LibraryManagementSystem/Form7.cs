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
    }
}
