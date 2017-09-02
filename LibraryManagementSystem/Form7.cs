using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
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
            string sname = textBox1.Text;
            string regno = textBox2.Text;
            string pwd = textBox3.Text;
            string rpwd = textBox5.Text;
            string class_name = textBox4.Text;

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
            if (class_name == "")
            {
                MessageBox.Show("Please enter your branch");
            }
            if(!pwd.Equals(rpwd))
            {
                MessageBox.Show("Passwords don't match");
            }
            else if ((sname != "") && (regno != "") && (pwd != "") && (rpwd != "") && (class_name != ""))
            {
                SqlConnection objConnection = new SqlConnection();
                objConnection.ConnectionString = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandText = "INSERT INTO Student VALUES(@1,@2,@3,@4)";
                objCommand.Parameters.AddWithValue("@1", regno);
                objCommand.Parameters.AddWithValue("@2", sname);
                objCommand.Parameters.AddWithValue("@3", class_name);
                objCommand.Parameters.AddWithValue("@4", pwd);

                objConnection.Open();
                objCommand.ExecuteNonQuery();
                objConnection.Close();
                MessageBox.Show("Thank you. Application successfully added to the database", "Status");

                Form6 ob = new Form6();
                this.Close();
                ob.Show();

            }
            
        }
    }
}
