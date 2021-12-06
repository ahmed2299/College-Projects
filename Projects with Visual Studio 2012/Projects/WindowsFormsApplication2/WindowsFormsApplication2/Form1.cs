using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                XmlElement root = doc.DocumentElement;
                root.AppendChild(p);
                doc.Save("p.xml");
                    
            }
        }
    }
}
