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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LENOVO;Initial Catalog=Northwind;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string updateString = @"update Employees set Title=@VarTitle where FirstName=@VarName";
            SqlCommand cmd = new SqlCommand(updateString, con);
            SqlParameter paramTitle = new SqlParameter("@VarTitle", textBox2.Text);
            cmd.Parameters.Add(paramTitle);
            SqlParameter paramName = new SqlParameter("@VarName", textBox1.Text);
            cmd.Parameters.Add(paramName);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
