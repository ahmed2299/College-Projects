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
namespace tgarebc_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cmb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_xml.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("p.xml");
           
            XmlNodeList list = doc.GetElementsByTagName("Product");
            XmlNodeList projects = doc.GetElementsByTagName("Projects");
            string s = cmb_gender.SelectedItem.ToString();
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                string id = children[0].Name;
                string idValue = children[0].InnerText;
                string name = children[1].Name;
                string nameValue = children[1].InnerText;
                string gender = children[2].Name;
                string genderValue = children[2].InnerText;
                string department = children[3].Name;
                string departmentValue = children[3].InnerText;
                
                if (dgv_xml.ColumnCount == 0)
                {
                    dgv_xml.Columns.Add("ID",id);
                    dgv_xml.Columns.Add("Name", name);
                    dgv_xml.Columns.Add("Gender", gender);
                    dgv_xml.Columns.Add("Department", department);
                    dgv_xml.Columns.Add("Projects", "Projects");

                }
                if (s == genderValue)
                {
                    for (int j = 0; j < projects.Count-1; j++)
                    {
                        XmlNodeList child = projects[j].ChildNodes;
                        
                            string projectValue = child[j].InnerText;
                            dgv_xml.Rows.Add(new string[] { idValue, nameValue, genderValue, departmentValue,projectValue });
                        
                    }
                }
            }
        }
    }
}
