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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderSize = 1;
           
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 ob = new Form8();
            this.Close();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            this.Close();
            ob.Show();
        }
    }
}
