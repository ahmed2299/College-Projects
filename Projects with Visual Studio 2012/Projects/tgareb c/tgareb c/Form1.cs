﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myNamespace;
using System.IO;
namespace tgareb_c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //StreamWriter sw = new StreamWriter(File.OpenWrite(ofd.FileName));
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                StreamWriter sw = new StreamWriter(File.OpenWrite(path));
                sw.WriteLine(textBox1.Text);
                sw.WriteLine("hiiii");
                sw.Dispose();
        }
            

        }
    }
