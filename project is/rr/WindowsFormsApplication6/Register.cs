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
    public partial class Register : Form
    {
        static string sql = "Data Source=DESKTOP-MDGTOTO\\SQLEXPRESS;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client form = new client();
             con.Open();
             string query = "INSERT INTO Client (UserName,Password,Location) VALUES (@UserName,@Password,@Location)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.AddWithValue("@UserName",textBox1.Text);
            cmd.Parameters.AddWithValue("@Password",textBox2.Text);
            cmd.Parameters.AddWithValue("@Location", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            form.Show();

        }
    }
}
