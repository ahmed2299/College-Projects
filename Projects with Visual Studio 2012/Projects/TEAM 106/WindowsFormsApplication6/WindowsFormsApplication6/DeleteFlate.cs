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
    public partial class DeleteFlate : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public DeleteFlate()
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
            string STR = "DELETE FROM Flat WHERE FlatID = @ID_Number";
            SqlCommand com = new SqlCommand(STR,con);
            com.Parameters.AddWithValue("@ID_Number", textBox1.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted succesfully");
            this.Hide();
            form.Show();

        }
    }
}
