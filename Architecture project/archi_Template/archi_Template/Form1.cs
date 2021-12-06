using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archi_Template
{
    public partial class Form1 : Form
    {
          Cycle c = new Cycle();
        public int []registers=new int[40];
        public int number_of_cycles = 0;
        public int level_1 = 0;
        public int level_2 = 0;
        public int level_3 = 0;
        public int level_4 = 0;
        public int level_5 = 0; 
        public static void operations()
        {

        }
        private void MipsRegisterGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PiplineGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void runCycleBtn_Click(object sender, EventArgs e)
        {

            number_of_cycles++;
            if (number_of_cycles > 0) level_1++;
            if (number_of_cycles > 1) level_2++;
            if (number_of_cycles > 2) level_3++;
            if (number_of_cycles > 3) level_4++;
            if (number_of_cycles > 4) level_5++;

            if (level_1 == 1)  c.fetch();  
  
            if (level_1 == 2)  c.decode();
            
            if (level_1 == 3)  c.choose();
            
            if (level_1 == 4)  c.main_memory();
            
            if (level_1 == 5)
            {
                int ret=c.writeBack();                            
                string[] a2 = new string[10];
                a2 = c.MEMWB.Split('#');
                registers[ret] = int.Parse(a2[0]);                                                      
            }

            if (level_2 == 1)   c.fetch();
            
            if (level_2 == 2)   c.decode();
            
            if (level_2 == 3)   c.choose();
            
            if (level_2 == 4)   c.main_memory();
            
            if (level_2 == 5)
            {
                int ret = c.writeBack();
                string[] a2 = new string[10];
                a2 = c.MEMWB.Split('#');
                registers[ret] = int.Parse(a2[0]);

            }

            if (level_3 == 1)  c.fetch();
            
            if (level_3 == 2)  c.decode();
            
            if (level_3 == 3)  c.choose();
            
            if (level_3 == 4)  c.main_memory();
            
            if (level_3 == 5)
            {
                int ret = c.writeBack();
                string[] a2 = new string[10];
                a2 = c.MEMWB.Split('#');
                registers[ret] = int.Parse(a2[0]);

            }
            if (level_4 == 1)   c.fetch();
            
            if (level_4 == 2)   c.decode();
            
            if (level_4 == 3)   c.choose();
            
            if (level_4 == 4)   c.main_memory();
            
            if (level_4 == 5)
            {
                int ret = c.writeBack();
                string[] a2 = new string[10];
                a2 = c.MEMWB.Split('#');
                registers[ret] = int.Parse(a2[0]);

            }

            if (level_5 == 1)   c.fetch();
            
            if (level_5 == 2)   c.decode();
            
            if (level_5 == 3)   c.choose();
            
            if (level_5 == 4)   c.main_memory();
            
            if (level_5 == 5)
            {
                int ret = c.writeBack();
                string[] a2 = new string[10];
                a2 = c.MEMWB.Split('#');
                registers[ret] = int.Parse(a2[0]);

            }

            DataTable t = new DataTable() ;
            t.Columns.Add("Register", typeof(string));
            t.Columns.Add("Value", typeof(string));
            for (int i = 0; i < 35; ++i)
                t.Rows.Add("$"+i, registers[i]);

                MemoryGrid.DataSource = t;      
                DataTable t2 = new DataTable();
                t2.Columns.Add("Register", typeof(string));
                t2.Columns.Add("Value", typeof(string));

            if (c.IFID.Length > 0)
            {
                string[] a2 = new string[10];
                a2 = c.IFID.Split('#');

                t2.Rows.Add("IF/ID", "PC= " + a2[0]);
                t2.Rows.Add("IF/ID", "Insturction= " + a2[1]);
            }
            if (c.IDEX.Length > 0)
            {
                string[] a2 = new string[10];
                a2 = c.IDEX.Split('#');
                t2.Rows.Add("ID/EX", "PC= " + a2[0]);
                t2.Rows.Add("ID/EX", "Read_Data1= " + a2[1]);
                t2.Rows.Add("ID/EX", "Read_Data2= " + a2[2]);
                t2.Rows.Add("ID/EX", "rt= " + a2[3]);
                t2.Rows.Add("ID/EX", "rd= " + a2[4]);
            }

            if (c.EXMEM.Length > 0)
            {
                string[] a2 = new string[10];
                a2 = c.EXMEM.Split('#');
                t2.Rows.Add("EX/MEM", "Result= " + a2[0]);
                t2.Rows.Add("EX/MEM", "Read_Data2= " + a2[1]);
                t2.Rows.Add("EX/MEM", "rd= " + a2[2]);
            }
            if (c.MEMWB.Length > 0)
            {
                string[] a2 = new string[10];
                a2 = c.MEMWB.Split('#');
                t2.Rows.Add("ME/MWB", "Read_Data= " + a2[0]);
                t2.Rows.Add("ME/MWB", "Result= " + a2[1]);
            }

                PiplineGrid.DataSource = t2;
            
        }
        /// <summary>
        /// /////////////////////////////////////////////////
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void UserCodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void inializeBtn_Click(object sender, EventArgs e)
        {

             string instruction1 = "";
             string instruction2 = "";
             string instruction3 = "";
             string instruction4 = "";
             string instruction5 = "";
             string inst = "";
             string instruction = "";

             DataTable t = new DataTable();
             t.Columns.Add("register", typeof(string));
             t.Columns.Add("value", typeof(int));
             t.Rows.Add("$"+0, 0);
             for(int i = 1; i < 32; i++)
             {                              
                 t.Rows.Add("$"+i, i+100);
             }
             MipsRegisterGrid.DataSource = t;

             instruction = UserCodetxt.Text;
             string[] a = instruction.Split('\n');

             for (int i = 0; i < a.Length; i++)
             {
                 a[i] = a[i].Trim('\r');
             }

             string s = "";
             s = a[0];
             for (int i = 0; i < s.Length; i++)
             {
                 if (s[i] != ' ' && s[i] != ':') inst += s[i];
             }
             instruction1 = inst;
             inst = "";
             s = "";
             s = a[1];
             for (int i = 0; i < s.Length; i++)
             {
                 if (s[i] != ' ' && s[i] != ':') inst += s[i];
             }
             instruction2 = inst;
             inst = "";
             s = "";
             s = a[2];
             for (int i = 0; i < s.Length; i++)
             {
                 if (s[i] != ' ' && s[i] != ':') inst += s[i];
             }
             instruction3 = inst;
             inst = "";
             s = "";
             s = a[3];
             for (int i = 0; i < s.Length; i++)
             {
                 if (s[i] != ' ' && s[i] != ':') inst += s[i];
             }
             instruction4 = inst;
             inst = "";
             s = "";
             s = a[4];
             for (int i = 0; i < s.Length; i++)
             {
                 if (s[i] != ' ' && s[i] != ':') inst += s[i];
             }
             instruction5 = inst;
             c.qu_fitch.Enqueue(instruction1); 
             c.qu_fitch.Enqueue(instruction2); 
             c.qu_fitch.Enqueue(instruction3); 
             c.qu_fitch.Enqueue(instruction4); 
             c.qu_fitch.Enqueue(instruction5);

             for (int i = 0; i < 40; ++i) registers[i] = 99;

            

        }
    }
}
