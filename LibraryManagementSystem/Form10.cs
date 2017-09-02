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
            String isbn = textBox3.Text;
            String name = textBox1.Text;
            String author = textBox2.Text;
            SqlConnection objConnection = new SqlConnection();
            objConnection.ConnectionString = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            SqlCommand objCommand = new SqlCommand();
            objCommand.Connection = objConnection;
            objCommand.CommandText = "INSERT INTO Books VALUES(@1,@2,@3,'1')";
            objCommand.Parameters.AddWithValue("@1", isbn);
            objCommand.Parameters.AddWithValue("@2", name);
            objCommand.Parameters.AddWithValue("@3", author);

            objConnection.Open();
            objCommand.ExecuteNonQuery();
            objConnection.Close();

            MessageBox.Show("You have successfullly added the book to the database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
