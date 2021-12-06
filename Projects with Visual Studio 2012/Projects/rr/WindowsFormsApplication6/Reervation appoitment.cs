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
    public partial class Reervation_appoitment : Form
    {
        bool flag = false;
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public Reervation_appoitment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query1 = "insert into Appointment (Client_ID,Date,Flat_ID,Emp_ID) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')";
            string query2 = "select * from Appointment";
            SqlCommand cmd = new SqlCommand(query2, con);
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(query1, con);
            while (dr.Read())
            {
                if (dr[3].ToString()==textBox4.Text)
                {
                    MessageBox.Show("Not accepted");

                    flag = true;
                }
                
            }
            if (flag)
            {
                this.Close();
                dr.Close();
                con.Close();
            }
            else
            {
                dr.Close();
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Accepted");
            }
        }
    }
}
