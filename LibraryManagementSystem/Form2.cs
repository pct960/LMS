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
    }
}
