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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                timer1.Enabled = false;
                System.Threading.Thread.Sleep(2000);
                this.Hide();
                Form1 ob = new Form1();
                ob.Show();
                
            }


            this.Opacity = this.Opacity + 0.01;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }
    }
}
