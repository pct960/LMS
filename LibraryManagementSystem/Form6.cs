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
            String cs = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            String sql = "SELECT * FROM Books WHERE Available = '1'";
            SqlConnection connection = new SqlConnection(cs);

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();

            connection.Open();
            dataadapter.Fill(ds, "Books");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Books";
            dataGridView1.Columns[3].Visible = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String cs = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            String sql = "SELECT * FROM Books WHERE Available = '1' AND Name LIKE '%"+textBox1.Text+"%'";
            SqlConnection connection = new SqlConnection(cs);

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();

            connection.Open();
            dataadapter.Fill(ds, "Books");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Books";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int count = dataGridView1.CurrentCell.RowIndex;

            if(count==-1)
            {
                MessageBox.Show("Nothing selected");
            }
            else
            {
                DateTime today = DateTime.Now;
                String date = today.ToString("dd/MM/yyyy");
                DateTime later = today.AddDays(15);
                String return_date = later.ToString("dd/MM/yyyy");
                String isbn = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                String type = Class1.getType();
                String id = Class1.getID();

                SqlConnection objConnection = new SqlConnection();
                objConnection.ConnectionString = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandText = "SELECT * FROM Issued WHERE Reg_No=@1";
                objCommand.Parameters.AddWithValue("@1", int.Parse(id));
             
                SqlDataReader reader;
                objConnection.Open();
                reader = objCommand.ExecuteReader();
                int number = 0;
                while (reader.Read())
                {
                    number++;
                   
                }

                objConnection.Close();

                if (number>=2)
                {
                    MessageBox.Show("Sorry, you can't borrow any more books", "Checkout Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                else
                {
                    if(MessageBox.Show("Are you sure you want to borrow this book?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        objCommand.CommandText = "INSERT INTO Issued VALUES(@2,@3,@4,@5)";
                        objCommand.Parameters.AddWithValue("@2", id);
                        objCommand.Parameters.AddWithValue("@3", isbn);
                        objCommand.Parameters.AddWithValue("@4", date);
                        objCommand.Parameters.AddWithValue("@5", return_date);

                        objConnection.Open();
                        objCommand.ExecuteNonQuery();
                        objConnection.Close();

                        objCommand.CommandText = "UPDATE Books SET Available='0' WHERE ISBN=@6";
                        objCommand.Parameters.AddWithValue("@6", isbn);
                        objConnection.Open();
                        objCommand.ExecuteNonQuery();
                        objConnection.Close();

                        MessageBox.Show("You have successfully borrowed this book", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        String cs = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
                        String sql = "SELECT * FROM Books WHERE Available = '1'";
                        SqlConnection connection = new SqlConnection(cs);

                        SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                        DataSet ds = new DataSet();
                        SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();

                        connection.Open();
                        dataadapter.Fill(ds, "Books");
                        connection.Close();
                        dataGridView1.DataSource = ds;
                        dataGridView1.DataMember = "Books";
                    }
                }
                
            }
        }
    }
}
