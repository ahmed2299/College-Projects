using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Department
    {
        public int empNo_len;
        public int projNo_len;
        public string departmentName;
        public string departmentId;
        public char[] emploNo;
        public char[] projectNo;
        public Department()
        {
            empNo_len = 2;
            projNo_len = 2;
            emploNo = new char[empNo_len];
            projectNo = new char[projNo_len];
        }
        public bool ReadDataFromUser()
        {
            string str;
            Console.WriteLine("Enter ID : ");
            str = Console.ReadLine();
            departmentId = str ;
            Console.WriteLine("Enter Name : ");
            str = Console.ReadLine();
            departmentName = str ;

            Console.WriteLine("Enter Emp no : ");
            str = Console.ReadLine();
            if (str.Length > empNo_len)
            {
                Console.WriteLine("Empolyees number is too long !!!");
                return false;
            }
            str.CopyTo(0, emploNo, 0, str.Length);
            for (int i = str.Length; i < empNo_len; i++)
                emploNo[i] = '\0';

            Console.WriteLine("Enter Proj no : ");
            str = Console.ReadLine();
            if (str.Length > projNo_len)
            {
                Console.WriteLine("Projects number is too long !!!");
                return false;
            }
            str.CopyTo(0, projectNo, 0, str.Length);
            for (int i = str.Length; i < projNo_len; i++)
                emploNo[i] = '\0';
            return true ;
        }
        public void DisplayData()
        {
            //Console.Write("ID*Name*EmployeesNumberProjectsNumbers\n");
            Console.WriteLine(departmentId);
            Console.WriteLine(departmentName);
            Console.WriteLine(emploNo);
            Console.WriteLine(projectNo);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
           
            Department D1 = new Department();
            bool cont = true;
            char ch;
            while (cont)
            {
                
                Console.WriteLine("[1] To Add ");
                Console.WriteLine("[2] To Display ");
                Console.WriteLine("[3] To Exit ");
                Console.WriteLine("Enter Your Choice ");
                ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case '1':
                        { FileStream fs = new FileStream("t.txt", FileMode.Append);

                        while (true)
                        {
                            StreamWriter sw = new StreamWriter(fs);
                            if (D1.ReadDataFromUser())
                            {
                                sw.Write(D1.departmentId);
                                sw.Write('*');
                                sw.Write(D1.departmentName);
                                sw.Write('*');
                                sw.Write(D1.emploNo);
                                sw.WriteLine(D1.projectNo);
                            }
                            sw.Close();
                                fs.Close();
                            Console.Write("\t\t\t More Department (y/n) : ");
                            char choice = char.Parse(Console.ReadLine());

                            if (choice != 'y')
                                break;
                        }
                        break; }
                    case '2':

                        {
                            FileStream fs = new FileStream("t.txt", FileMode.OpenOrCreate);
                            StreamReader sr = new StreamReader(fs);
                            while (sr.Peek() != -1)
                            {
                                String s = sr.ReadLine();
                                String[] arr_str = s.Split('*');

                                D1.departmentId = arr_str[0];
                                D1.departmentName = arr_str[1];
                                
                                D1.emploNo = arr_str[2].Substring(0, 2).ToCharArray();
                                D1.projectNo = arr_str[2].Substring(2, 2).ToCharArray();
                                D1.DisplayData();
                            }
                            sr.Close();
                            fs.Close();
                        }
                        break; 
                    default :
                        cont = false;
                        break;
                }





            }

















        }
    }
}
