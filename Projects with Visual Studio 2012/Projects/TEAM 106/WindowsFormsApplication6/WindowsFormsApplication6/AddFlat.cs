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
    public partial class AddFlat : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public AddFlat()
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
            AdminPage form = new AdminPage();
            con.Open();
            string query = "INSERT INTO Flat (Price,Location,EmpID) VALUES (@Price,@Location,@EmpID)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Price", textBox1.Text);
            cmd.Parameters.AddWithValue("@Location", textBox2.Text);
            cmd.Parameters.AddWithValue("@EmpID", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            MessageBox.Show("Added succefully");
            form.Show();
        }
    }
}
