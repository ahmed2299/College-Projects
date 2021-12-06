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
    public partial class Add_Flat : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public Add_Flat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Flat(FlatID,Price,Location,EmpID) values(@flatid,@price,@location,@empid);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@flatid", textBox1.Text.ToString());
            cmd.Parameters.Add("@price", textBox2.Text.ToString());
            cmd.Parameters.Add("@location", textBox3.Text.ToString());
            cmd.Parameters.Add("@empid", textBox1.Text.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Flat added succesfully");
            this.Close();

        }
    }
}
