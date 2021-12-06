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
    public partial class feedback : Form
    {
        static string sql = "Data Source=LENOVO;Initial Catalog=project;Integrated Security=True";
        SqlConnection con = new SqlConnection(sql);
        public feedback()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client form = new client();
            con.Open();
            string query = "INSERT INTO Feedback (FeedBack) VALUES (@FeedBack)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FeedBack", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thanks");
            this.Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client form = new client();
            this.Hide();
            form.Show();
        }
    }
}
