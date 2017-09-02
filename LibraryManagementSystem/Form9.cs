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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
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
            Form1 ob = new Form1();
            this.Close();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string admin_id = textBox2.Text;
            string pwd = textBox3.Text;
            string rpwd = textBox4.Text;

            if (name == "")
            {
                MessageBox.Show("Please enter the student name");
            }
            if (admin_id == "")
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

            if (!pwd.Equals(rpwd))
            {
                MessageBox.Show("Passwords don't match");
            }
            else if ((name != "") && (admin_id != "") && (pwd != "") && (rpwd != ""))
            {
                SqlConnection objConnection = new SqlConnection();
                objConnection.ConnectionString = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandText = "INSERT INTO Admin VALUES(@1,@2,@3)";
                objCommand.Parameters.AddWithValue("@1", admin_id);
                objCommand.Parameters.AddWithValue("@2", name);
                objCommand.Parameters.AddWithValue("@3", pwd);

                objConnection.Open();
                objCommand.ExecuteNonQuery();
                objConnection.Close();
                MessageBox.Show("Thank you. Application successfully added to the database", "Status");
                Form5 ob = new Form5();
                this.Close();
                ob.Show();
            }
        }
    }
}
