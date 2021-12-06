using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archi_Template
{
    class Cycle
    {
        public string instruction = "";
        public int pc_adder;
        public int funct;
        public int op;
        public int immediate;
        public int readData1;
        public int readData2;
        public int res;
        public int WData;
        public int rs;
        public int rt;
        public int rd;
        public Hashtable instruction_memory = new Hashtable();
        public Hashtable Data_memory = new Hashtable();
        public Queue<string> qu_fitch = new Queue<string>();
        public Queue<string> qu_decode = new Queue<string>();
        public Queue<string> qu_excute = new Queue<string>();
        public Queue<string> qu_datamem = new Queue<string>();
        public Queue<string> qu_writeBack = new Queue<string>();

        public string IFID = "";
           
        public   void fetch()
        {

            instruction = qu_fitch.Dequeue();
            string x = instruction.Substring(0, 4);
            int adder = int.Parse(x);
            instruction_memory.Add(adder, instruction.Substring(4));
            qu_decode.Enqueue(instruction.Substring(4));
            pc_adder = adder + 4;
            op = Convert.ToInt32(instruction.Substring(4, 6),2);
            IFID = pc_adder.ToString()+ '#';
            IFID += instruction.Substring(4)+ '#'; 

        

        }


        public string IDEX = "";
        public   void decode()
        {
            string[] arr = new string[10];
            arr = IFID.Split('#');

            
            instruction = arr[1];
            string temp = instruction.Substring(0, 6);
            op = Convert.ToInt32(temp,2);

            rs = Convert.ToInt32(instruction.Substring(6, 5),2);
            rt = Convert.ToInt32(instruction.Substring(11, 5),2);
            rd = Convert.ToInt32(instruction.Substring(16, 5),2);
            

            readData1 = rs + 100;
            readData2 = rt + 100;
            if (readData2 == 100) readData2 = 0;
            if (readData1 == 100) readData1 = 0;

            IDEX = arr[0] + '#';
            IDEX += readData1;
            IDEX += '#';
            IDEX += readData2;
            IDEX += '#';
            IDEX += rt.ToString();
            IDEX += '#';

            if (op == 0)
            {
               // string alpha = Reg_File(rs, rt, 0, 0, 0);
               
                
                IDEX += rd.ToString();
                IDEX += '#';
            }
            else
            {               
                    IDEX += instruction.Substring(16, 16);
                    IDEX += '#';
                
            }


           /* DataTable table2 = new DataTable();
            table2.Columns.Add("Register", typeof(string));
            table2.Columns.Add("Value", typeof(string));

            string[] alos = new string[10];
            alos = IDEX.Split('#');
            table2.Rows.Add("IDEX", "PC= " + alos[0]);
            table2.Rows.Add("IDEX", "Read_Data1= " + alos[1]);
            table2.Rows.Add("IDEX", "Read_Data2= " + alos[2]);
            table2.Rows.Add("IDEX", "rt= " + alos[3]);
            table2.Rows.Add("IDEX", "rd= " + alos[4]);*/

        }
        
        public   void choose()
        {
            instruction = qu_decode.Dequeue();
            op = Convert.ToInt32(instruction.Substring(0, 6),2);
            if (op == 0)
            {
                ALU(instruction);
            }
            else
            {
                branchEqual(instruction);
            }
        }

        public string EXMEM = "";
        
        public   void ALU(string inst)
        {
            instruction = inst;
            funct = Convert.ToInt32(instruction.Substring(26, 6),2);
            
            string[] arr = new string[10];
            arr=IDEX.Split('#');
            int write1 = int.Parse(arr[1]);
            int write2 = int.Parse(arr[2]);

           
            if (funct == 37)  res = write1 | write2;
            
            if (funct == 36)   res = write1 & write2;
            
            if (funct == 32)   res = write1 + write2;
                        
            if (funct == 34)  res = write1 - write2;

            qu_excute.Enqueue(instruction);
            EXMEM = res.ToString();
            EXMEM += '#';
            EXMEM += write2.ToString();
            EXMEM += '#';
            EXMEM += arr[4];
            EXMEM += '#';
        }

        public void branchEqual(string inst)
        {
            instruction = inst;
            string[] a = new string[10];
            a = IDEX.Split('#');
            string x_2 = a[0];

            pc_adder = int.Parse(x_2);

            string x = a[3];

            int out1 = Convert.ToInt32(x, 2);
            res = pc_adder + 4 * out1;
            qu_excute.Enqueue(instruction);

            EXMEM = res.ToString();
            EXMEM += '#';
        }

        public string MEMWB="";
        public   void main_memory()
        {
            //int ret = 0;
            instruction = qu_excute.Dequeue();
            
            op = Convert.ToInt32(instruction.Substring(0, 6),2);
            if (op == 0)
            {
                string[] arr = new string[10];
                arr = EXMEM.Split('#');
                MEMWB = arr[0]+'#';
                MEMWB += arr[1]+'#';
                MEMWB += arr[2]+'#';
            }
            
            qu_datamem.Enqueue(instruction);
        }
        public   int writeBack()
        {
            instruction = qu_datamem.Dequeue();
            op = Convert.ToInt32(instruction.Substring(0, 6),2);
            string[] a = new string[10];
            a = MEMWB.Split('#');

            if (op == 0)
            {
                WData = MEMWB[0];
                rd = int.Parse(a[2]);
                WData = int.Parse(a[0]);
         
                return rd;
            }
            return -1;
            
            
        }

    }
}
