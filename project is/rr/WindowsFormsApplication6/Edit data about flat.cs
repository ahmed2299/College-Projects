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
using System.IO;
namespace WindowsFormsApplication6
{
    public partial class Edit_data_about_flat : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);

        public Edit_data_about_flat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Flat set Price='" + this.textBox2.Text.ToString() + "'" + "where EmpID='" + this.textBox1.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

            }
            con.Close();
            MessageBox.Show("Edited");
            this.Close();
        }
    }
}
