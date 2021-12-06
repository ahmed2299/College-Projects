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
    public partial class AdminPage : Form
    {
        
        public AdminPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add form = new Add();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            main form = new main();
            this.Hide();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddFlat form = new AddFlat();
            this.Hide();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteFlate form = new DeleteFlate();
            this.Hide();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteEmployee form = new DeleteEmployee();
            this.Hide();
            form.Show();
        }

       /* private void button8_Click(object sender, EventArgs e)
        {

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            Up_date form = new Up_date();
            this.Hide();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FEED_BACK form = new FEED_BACK();
            this.Hide();
            form.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Show_All_Flats form = new Show_All_Flats() ;
            this.Hide();
            form.Show();
        }
    }
}
