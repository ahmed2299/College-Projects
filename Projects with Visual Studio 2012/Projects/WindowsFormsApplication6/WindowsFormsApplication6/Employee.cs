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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                con.Open();
                string query = "select * from Appointment where Client_ID= " + textBox1.Text.ToString();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = ("Client_ID".ToString());
                    textBox3.Text = ("Emp_ID".ToString());
                    textBox4.Text = ("Date".ToString());
                    textBox5.Text = ("Flat_ID".ToString());

                }
                con.Close();
            
           
            
        }

        
    }
}
