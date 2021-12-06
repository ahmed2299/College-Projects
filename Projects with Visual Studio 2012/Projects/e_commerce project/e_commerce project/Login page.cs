using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace e_commerce_project
{
    public partial class Login_page : Form
    {
        bool flag = false;
        public Login_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string admin_path = @"C:\Users\lenovo pc\documents\visual studio 2012\Projects\e_commerce project\e_commerce project\admin.txt";
            StreamReader sr = new StreamReader(admin_path);
            string text = sr.ReadLine();
            while (text!= " ")
            {
                if (textBox1.Text.ToString() == text)
                {
                    flag = true;
                    break;

                }
                else
                {
                    flag = false;
                    break;
                }
            }
            while (!sr.EndOfStream)
            {
                if (textBox2.Text.ToString() == sr.ReadLine())
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag)
            {
                Admin form = new Admin();
                MessageBox.Show("Login successfully");
                this.Hide();
                form.Show();

            }
            else
            {
                MessageBox.Show("Error in username or password ");
            }
        }
    }
}
