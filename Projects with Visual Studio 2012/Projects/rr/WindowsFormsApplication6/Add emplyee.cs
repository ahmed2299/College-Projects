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
    public partial class Add_emplyee : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public Add_emplyee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO Employee (EmpID,UserName,password,Admin_ID) VALUES (@employeeID,@Username,@pass,@AdminID)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@employeeID", textBox1.Text.ToString());
            cmd.Parameters.Add("@Username", textBox2.Text.ToString());
            cmd.Parameters.Add("@pass", textBox3.Text.ToString());
            cmd.Parameters.Add("@AdminID", textBox4.Text.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            MessageBox.Show("Added succefully");
        }
    }
}
