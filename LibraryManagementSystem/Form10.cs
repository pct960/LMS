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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
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
            Form5 ob = new Form5();
            this.Close();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
