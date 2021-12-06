using System;
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
    public partial class Employees_Functionalities : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);

        public Employees_Functionalities()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select Client_ID,Date,Emp_ID,Flat_ID from Appointment where Client_ID=" + textBox1.Text.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = (dr["Client_ID"].ToString());
                textBox3.Text = (dr["Date"].ToString());
                textBox4.Text = (dr["Emp_ID"].ToString());
                textBox5.Text = (dr["Flat_ID"].ToString());
            }
            con.Close();
        }
    }
}
