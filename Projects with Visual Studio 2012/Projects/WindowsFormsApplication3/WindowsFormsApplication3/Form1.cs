using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Xml;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string department = cb_department.SelectedItem.ToString();
            String projects;
            if (!File.Exists("p.xml"))
            {
                XmlWriter w = XmlWriter.Create("p.xml");
                w.WriteStartDocument();
                w.WriteStartElement("table");
                w.WriteAttributeString("name", "product");

                w.WriteStartElement("product");
                w.WriteStartElement("ID");
                w.WriteString(tb_id.Text);
                w.WriteEndElement();

                w.WriteStartElement("Name");
                w.WriteString(tb_name.Text);
                w.WriteEndElement();

                w.WriteStartElement("Gender");
                if(rb_male.Checked)
                    w.WriteString("male");
                else if(rb_female.Checked)
                    w.WriteString("female");
                    w.WriteEndElement();

                w.WriteStartElement("Department");
                w.WriteString(department);                
                w.WriteEndElement();

                w.WriteStartElement("Projects");
                 
                for (int i = 0; i < lb_checked.Items.Count; i++)
                {
                    if (lb_checked.GetItemChecked(i))
                    {

                        projects = lb_checked.Items[i].ToString();//.Text;
                        w.WriteStartElement("Project");
                        w.WriteString(projects);
                        w.WriteEndElement();
                    }
                }
                w.WriteEndElement();
                
                w.WriteEndElement();
                w.WriteEndElement();
                w.WriteEndDocument();
                w.Close();
            }

            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("p.xml");
                XmlElement p = doc.CreateElement("product");
                XmlElement child = doc.CreateElement("ID");
                child.InnerText = tb_id.Text;
                p.AppendChild(child);
                child = doc.CreateElement("Name");
                child.InnerText = tb_name.Text;
                p.AppendChild(child);
                child = doc.CreateElement("Gender");
                if (rb_male.Checked)
                    child.InnerText = rb_male.Text;
                else if (rb_female.Checked)
                    child.InnerText = rb_female.Text;
                
                p.AppendChild(child);
                child = doc.CreateElement("Department");
                p.AppendChild(child);
                child = doc.CreateElement("Projects");
                for (int i = 0; i < lb_checked.Items.Count; i++)
                {
                    if (lb_checked.GetItemChecked(i))
                    {

                        projects = lb_checked.Text;
                        child = doc.CreateElement("Name");
                        child.InnerText = projects;
                        p.AppendChild(child);
                    }
                }
                XmlElement root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("p.xml");
                
            }
            MessageBox.Show("data added succesfully");

        }

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            File.Delete("p.xml");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }
        

        
    }
}
