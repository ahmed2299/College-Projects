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
    public partial class New_Brand : Form
    {
        int c = 0;
        public New_Brand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\lenovo pc\documents\visual studio 2012\Projects\e_commerce project\e_commerce project\" + textBox1.Text + ".txt";

            
            using (StreamWriter sw = File.AppendText(path))
            {
                
                sw.Write('\n');
                sw.Write(textBox4.Text.ToString() + '|');
                sw.Write(textBox2.Text.ToString() + '|');
                sw.Write(textBox3.Text.ToString() );
                
                
            }
            
            MessageBox.Show("Submitted Succesfully");
            }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\lenovo pc\documents\visual studio 2012\Projects\e_commerce project\e_commerce project\" + textBox1.Text + ".txt";
            c = c + 1;
            using (StreamWriter sw = File.AppendText(path))
            {

                sw.Write(c + '|');
                

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_page form = new Login_page();
            form.Show();
        }
        }
    }

