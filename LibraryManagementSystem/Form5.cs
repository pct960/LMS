﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form10 ob = new Form10();
            this.Close();
            ob.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            String cs = "Server = PCT\\SQLExpress; Database = LMS; user = sa; password = SQL2014wrox";
            String sql = "SELECT * FROM Books";
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            this.Close();
            ob.Show();
        }
    }
}
