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
    public partial class Reservetion : Form
    {
        bool flag = false;
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public Reservetion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client form = new client();
            this.Hide();
            form.Show();
        }

        private void Reservetion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            con.Open();
            string query1 = "insert into Appointment (Client_ID,Date,Flat_ID,Emp_ID) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')";
            string query2 = "select * from Appointment";
            SqlCommand cmd = new SqlCommand(query2, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if ((dr[3].ToString() == textBox4.Text)&&(dr[1].ToString()==textBox2.Text))
                {
                    MessageBox.Show("Not accepted");
                    flag = true;
                    break;
                }
                
            }
            if (flag)
            {
                textBox2.Clear();
                dr.Close();
                con.Close();
            }
            else
            {
                client form = new client();
                SqlDataAdapter da = new SqlDataAdapter(query1, con);
                dr.Close();
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Accepted");
                this.Hide();
                form.Show();

            }
        
            
        }
    }
}
        
