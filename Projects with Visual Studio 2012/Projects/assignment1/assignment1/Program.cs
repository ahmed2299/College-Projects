using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter The file name : ");
            //String nme = Console.ReadLine();
            //if(File.Exists(nme))
            //{
            //    Mb3Reader m = new Mb3Reader(nme);
            //    Mb3Tag tag = m.getTag();
                Console.Write("Enter The file name : ");
                String name = Console.ReadLine();
                displayData(name);

           // }
            
        }
        static void displayData(String name)
        {
            FileStream fs = new FileStream("t.txt", FileMode.Open);
            StreamReader sr=new StreamReader(fs);
            String s;
            String[] str;
            bool found = false;
            while (sr.Peek() != -1)
            {
                s= sr.ReadLine();
                str = s.Split('@');
                if (str[0] == name)
                {
                    Console.WriteLine(str[0] + " age is " + str[1]);
                    Console.WriteLine(str[0] + " nationality is " + str[2]);
                    found = true;
                }

            }
            if (!found)
            {
                Console.WriteLine("No artist with this name : ");
            }
            sr.Close();
        }
    }
}
/*while (true)
            {

                Console.WriteLine("1-to add");
                Console.WriteLine("2-to display");
                Console.WriteLine("3-to close");
                Console.WriteLine("Enter ur choice");
                int n;
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    FileStream fs = new FileStream("t.txt",FileMode.Append);
                        StreamWriter sw = new StreamWriter(fs);
                        FileStream fs2 = new FileStream("index.txt", FileMode.Append);
                        StreamWriter idx = new StreamWriter(fs2);
                        Console.Write("Enter the id : ");
                        p.id = Console.ReadLine();
                        Console.Write("Enter the name : ");
                        p.name = Console.ReadLine();
                        Console.Write("Enter the address : ");
                        p.address = Console.ReadLine();
                        p.record += p.id + '@' + p.name+'@'+p.address;

                        int len = (int)sw.BaseStream.Length;

                        idx.WriteLine(len);
                        
                        sw.Write(p.record);
                        
                        sw.Close();
                        idx.Close();
                        p.record = null;
                       
                }
                else if (n == 2)
                {
                    FileStream fs = new FileStream("t.txt", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    FileStream fs2 = new FileStream("index.txt", FileMode.Open);
                    StreamReader idx = new StreamReader(fs2);
                    String s;
                    String[] str;
                    char[] data;
                    
                    bool finished=false;
                    int start = int.Parse(idx.ReadLine());
                    while (!finished)
                    {
                        try
                        {
                            
                            int last = int.Parse(idx.ReadLine());

                            int len = last - start;
                            start = last;
                            //int len=(int)idx.BaseStream.Length;
                            data = new char[len];
                            sr.Read(data, 0, len);
                            s = new String(data);
                        }
                        catch
                        {
                            finished = true;
                            s = sr.ReadToEnd();
                        }
                        str = s.Split('@');
                        p.id = str[0];
                        p.name = str[1];
                        p.address = str[2];
                        p.display();
                    }
                    idx.Close();
                    sr.Close();
                    
                   
                }
                else break;
            }*/