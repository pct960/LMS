using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
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
            String reg_no = textBox1.Text;
            String password = textBox2.Text;
            bool login_success = false;
            SqlConnection objConnection = new SqlConnection();
            objConnection.ConnectionString = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            SqlCommand objCommand = new SqlCommand();
            objCommand.Connection = objConnection;
            objCommand.CommandText = "SELECT * FROM Student WHERE Reg_No=@1 AND Password=@2";
            objCommand.Parameters.AddWithValue("@1", int.Parse(reg_no));
            objCommand.Parameters.AddWithValue("@2", password);
            SqlDataReader reader;
            objConnection.Open();
            reader = objCommand.ExecuteReader();

            while(reader.Read())
            {
                login_success = true;
                Class1 obj = new Class1("Student", reg_no);
                Form6 ob = new Form6();
                this.Close();
                ob.Show();
            }

            if(!login_success)
            {
                MessageBox.Show("Incorrect Email or Password. Try again", "Login Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form7 ob = new Form7();
            this.Close();
            ob.Show();
        }
    }
}
