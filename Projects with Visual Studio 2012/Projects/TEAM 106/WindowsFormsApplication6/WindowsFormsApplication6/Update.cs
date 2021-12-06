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
    public partial class Up_date : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public Up_date()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPage form = new AdminPage();
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client form = new client();
            con.Open();
            string query = "update Flat set Price='" + this.textBox2.Text + "'" + "where FlatID='" + this.textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

            }
            con.Close();
            MessageBox.Show("Edited");
            this.Hide();
            form.Show();
        }

        private void Up_date_Load(object sender, EventArgs e)
        {

        }
    }
}
