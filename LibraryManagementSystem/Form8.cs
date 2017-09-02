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
using System.Globalization;
namespace LibraryManagementSystem
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            String id = Class1.getID();
            String cs = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            String sql = "SELECT Books.ISBN,Books.Name,Issued.Date_Issued,Issued.Return_Date FROM Issued,Books WHERE Issued.Reg_No="+id+" AND Issued.ISBN=Books.ISBN";
            SqlConnection connection = new SqlConnection(cs);

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();

            connection.Open();
            dataadapter.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;
           

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 ob = new Form6();
            this.Close();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            String isbn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String id = Class1.getID();
            String date= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            String format = "dd/MM/yyyy";
            DateTime actual_return_date = DateTime.ParseExact(date, format, provider);
            DateTime today = DateTime.Now.Date;

            TimeSpan t = actual_return_date - today;

            double total_days = t.TotalDays;


            if (total_days<0)
            {
                MessageBox.Show("You have a late return fee of : "+Math.Abs(total_days*5),"Late return fine",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            SqlConnection objConnection = new SqlConnection();
            objConnection.ConnectionString = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            SqlCommand objCommand = new SqlCommand();
            objCommand.Connection = objConnection;
            objCommand.CommandText = "DELETE FROM Issued WHERE Reg_No="+id+" AND ISBN="+isbn;

            objConnection.Open();
            objCommand.ExecuteNonQuery();
            objConnection.Close();

            objCommand.CommandText = "UPDATE Books SET Available='1' WHERE ISBN=" + isbn;
            objConnection.Open();
            objCommand.ExecuteNonQuery();
            objConnection.Close();

            MessageBox.Show("You have successfully returned this book", "Check in Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            String cs = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            String sql = "SELECT Books.ISBN,Books.Name,Issued.Date_Issued,Issued.Return_Date FROM Issued,Books WHERE Issued.Reg_No=" + id + " AND Issued.ISBN=Books.ISBN";
            SqlConnection connection = new SqlConnection(cs);

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();

            connection.Open();
            dataadapter.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            String issued = today.ToString("dd/MM/yyyy");

            String return_date = today.AddDays(15).ToString("dd/MM/yyyy");

            String isbn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String id = Class1.getID();

            SqlConnection objConnection = new SqlConnection();
            objConnection.ConnectionString = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            SqlCommand objCommand = new SqlCommand();
            objCommand.Connection = objConnection;
            objCommand.CommandText = "UPDATE Issued SET Date_Issued='" + issued + "',Return_Date='" + return_date + "' WHERE ISBN=" + isbn + " AND Reg_No=" + id;

            objConnection.Open();
            objCommand.ExecuteNonQuery();
            objConnection.Close();

            MessageBox.Show("You have successfully renewed this book!", "Renew Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            String cs = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            String sql = "SELECT Books.ISBN,Books.Name,Issued.Date_Issued,Issued.Return_Date FROM Issued,Books WHERE Issued.Reg_No=" + id + " AND Issued.ISBN=Books.ISBN";
            SqlConnection connection = new SqlConnection(cs);

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();

            connection.Open();
            dataadapter.Fill(dt);
            connection.Close();
            dataGridView1.DataSource = dt;

        }
    }
}
