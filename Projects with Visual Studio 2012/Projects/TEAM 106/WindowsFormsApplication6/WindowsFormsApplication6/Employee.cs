﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication6
{
    public partial class Employee : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main form = new main();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Appointment WHERE Emp_ID=" + textBox1.Text; 
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        
        }
    }
}
