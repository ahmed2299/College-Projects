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
using System.Collections.Generic;
namespace e_commerce_project
{
    public partial class Display_Brand : Form
    {
        public Display_Brand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_item = @"C:\Users\lenovo pc\documents\visual studio 2012\Projects\e_commerce project\e_commerce project\" + textBox1.Text + ".txt";
            listBox1.Items.Clear();
            List<string> list = new List<string>();
            using (StreamReader sr = new StreamReader(path_item))
            {
                string line;
                while ((line=sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
            }
        }
    }
}
