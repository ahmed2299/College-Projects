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
namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        DataGridView myDatagridview = new DataGridView();
        DataTable myDatatable = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("C:\\Users\\lenovo pc\\Documents\\Visual Studio 2012\\Projects\\WindowsFormsApplication3\\WindowsFormsApplication3\\bin\\Debug");
            dgv_xml.DataSource = ds.Tables;
            //  dataGridView1.DataMember = "Employee";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("p.xml");
            dgv_xml.DataSource = ds.Tables[3];
        }

        private void dgv_xml_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv_xml.Rows.Clear();
            //XmlDocument doc = new XmlDocument();
            //doc.Load("p.xml");
            //XmlNodeList list = doc.GetElementsByTagName("Gender");
            //string s = cmb_gender.SelectedItem.ToString();
            //for (int i = 0; i < list.Count; i++)
            //{

            //    if (s == list[i].InnerText)
            //    {
            //        XmlNodeList childrens = list[i].ChildNodes;
            //        string id = childrens[0].Name;
            //        string idValue = childrens[0].InnerText;
            //        string name = childrens[1].Name;
            //        string nameValue = childrens[1].InnerText;
            //        string gender = childrens[2].Name;
            //        string genderValue = childrens[2].InnerText;
            //        string department = childrens[3].Name;
            //        string departmentValue = childrens[3].InnerText;
            //        if (dgv_xml.ColumnCount == 0)
            //        {
            //            dgv_xml.Columns.Add("ID", "id");
            //            dgv_xml.Columns.Add("Name", "name");
            //            dgv_xml.Columns.Add("gender", "gender");
            //            dgv_xml.Columns.Add("department", "department");
            //        }

            //        dgv_xml.Rows.Add(new string[] { idValue, nameValue, genderValue, departmentValue });


            //    }

            //}
        }

        private void cmb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_xml.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("p.xml");
            XmlNodeList gender = doc.GetElementsByTagName("Gender");
            XmlNodeList id = doc.GetElementsByTagName("ID");
            XmlNodeList name = doc.GetElementsByTagName("Name");
            XmlNodeList department = doc.GetElementsByTagName("Department");
            string s = cmb_gender.SelectedItem.ToString();
            for (int i = 0; i < gender.Count; i++)
            {

                if (s == gender[i].InnerText)
                {
                    //XmlNodeList childrens = gender[i].ChildNodes;
                    //String id = "ID";
                    string idValue =id[i].InnerText;
                    //String name = childrens[1].Name;
                    string nameValue = name[i].InnerText;
                    //String gender = childrens[2].Name;
                    string genderValue = gender[i].InnerText;
                    //String department = childrens[3].Name;
                    string departmentValue = department[i].InnerText;
                    if (dgv_xml.ColumnCount == 0)
                    {
                        dgv_xml.Columns.Add("ID", "ID");
                        dgv_xml.Columns.Add("Name", "Name");
                        dgv_xml.Columns.Add("gender", "Gender");
                        dgv_xml.Columns.Add("department", "Department");
                    }

                    dgv_xml.Rows.Add(new string[] { idValue, nameValue, genderValue, departmentValue });


                }

            }

         }
        }
    }
