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
    public partial class Flat_requirment : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public Flat_requirment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select FlatID,Price,Location from Flat where Location='" +this.textBox1.Text.ToString()+"'";
            dt.Clear();
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;

        }
    }
}
