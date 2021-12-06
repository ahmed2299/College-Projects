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
    public partial class New_Item : Form
    {
        public New_Item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\lenovo pc\documents\visual studio 2012\Projects\e_commerce project\e_commerce project\" + textBox1.Text.ToString() + ".txt";
            StreamWriter sw = new StreamWriter(path);
            sw.Close();
            MessageBox.Show("New item added successfully");
        }
    }
}
