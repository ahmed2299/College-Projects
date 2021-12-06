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
using System.Xml;
namespace tgarebc_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!File.Exists("p.xml"))
            {
                XmlWriter w = XmlWriter.Create("p.xml");
                w.WriteStartDocument();
                w.WriteStartElement("table");
                w.WriteAttributeString("name", "Products");
                //w.WriteString("Products");
                w.WriteStartElement("Product");
                w.WriteStartElement("Id");
                w.WriteString(tb_id.Text);
                w.WriteEndElement();
                w.WriteStartElement("Name");
                w.WriteString(tb_name.Text);
                w.WriteEndElement();
                w.WriteStartElement("Gender");
                if(cb_male.Checked)
                w.WriteString("male");
                else if(cb_female.Checked)
                    w.WriteString("female");
                w.WriteEndElement();
                w.WriteStartElement("Department");
                w.WriteString(combobox_department.Text);
                w.WriteEndElement();
                w.WriteStartElement("Projects");
                for (int i = 0; i < clb_projects.Items.Count; i++)
                {

                    if (clb_projects.GetItemChecked(i))
                    {
                        w.WriteStartElement("Project");
                        w.WriteString(clb_projects.Items[i].ToString());
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
                XmlElement product = doc.CreateElement("Product");
                XmlNode node = doc.CreateElement("Id");
                node.InnerText = tb_id.Text;
                product.AppendChild(node);
                node = doc.CreateElement("Name");
                node.InnerText = tb_name.Text;
                product.AppendChild(node);
                node = doc.CreateElement("Gender");
                if(cb_male.Checked)
                {
                node.InnerText="male";
                product.AppendChild(node);
                }
                else if(cb_female.Checked)
                {
                node.InnerText = "female";
                product.AppendChild(node);
                }
                node = doc.CreateElement("Department");
                node.InnerText=combobox_department.Text;
                product.AppendChild(node);
                XmlElement projects = doc.CreateElement("Projects");
                for (int i = 0; i < clb_projects.Items.Count; i++)
                {

                    if (clb_projects.GetItemChecked(i))
                    {
                        node = doc.CreateElement("Project");
                        node.InnerText = clb_projects.Items[i].ToString();
                        projects.AppendChild(node);
                        
                    }
                }
                product.AppendChild(projects);
                doc.Load("p.xml");
                XmlElement root = doc.DocumentElement;
                root.AppendChild(product);
                doc.Save("p.xml");

            }
            MessageBox.Show("Added successfully");
            
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            try
            {
                XmlReader reader = XmlReader.Create("p.xml");
                XmlDocument doc = new XmlDocument();
                doc.Load("p.xml");
                XmlNodeList node = doc.GetElementsByTagName("Gender");
                int count = 0;
                for (int i = 0; i < node.Count; i++)
                {
                    if (node.Item(i).InnerText == "female") count++;
                }
                MessageBox.Show("count = "+count);

            }
            catch
            {
                MessageBox.Show("file is empty");
            }

        }

        private void tb_delete_Click(object sender, EventArgs e)
        {
            File.Delete("p.xml");
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
