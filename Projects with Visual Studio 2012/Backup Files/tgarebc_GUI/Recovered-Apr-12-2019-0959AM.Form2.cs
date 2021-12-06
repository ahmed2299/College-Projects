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
            XmlNodeList gender = doc.GetElementsByTagName("Gender");
            XmlNodeList name = doc.GetElementsByTagName("Name");
            XmlNodeList id = doc.GetElementsByTagName("Id");
            XmlNodeList department = doc.GetElementsByTagName("Department");
            XmlNodeList projects = doc.GetElementsByTagName("Projects");
            string s = cmb_gender.SelectedItem.ToString();
            for (int i = 0; i < gender.Count; i++)
            {
                string idValue = id[i].InnerText;
                string nameValue = name[i].InnerText;
                string genderValue = gender[i].InnerText;
                string departmentValue = department[i].InnerText;
                string projectsValue = projects[i].InnerText;
                if (dgv_xml.ColumnCount == 0)
                {
                    dgv_xml.Columns.Add("ID", "Id");
                    dgv_xml.Columns.Add("Name", "Name");
                    dgv_xml.Columns.Add("Gender", "Gender");
                    dgv_xml.Columns.Add("Department", "Department");
                    dgv_xml.Columns.Add("projects", "Projects");

                }
                if (s == gender[i].InnerText)
                {
                    dgv_xml.Rows.Add(new string[] { idValue, nameValue, genderValue, departmentValue,projectsValue });
                }
            }
        }
    }
}
