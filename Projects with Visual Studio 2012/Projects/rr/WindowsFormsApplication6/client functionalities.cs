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
    public partial class client_functionalities : Form
    {
        public client_functionalities()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reervation_appoitment form = new Reervation_appoitment();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Give_Feedback form = new Give_Feedback();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search_For_Flat form = new Search_For_Flat();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Flat_requirment form = new Flat_requirment();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buy_flat form = new Buy_flat();
            this.Hide();
            form.Show();
        }
    }
}
