using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace assignment1
{
   public class Person
    {
        public String record;
        public int record_length;
        public String id;
        public String name;
        public String address;
      /* public bool check()
        {
            Console.Write("Enter the id : ");
            id = Console.ReadLine();
            id += '@';
            Console.Write("Enter the name : ");
            name = Console.ReadLine();
            name += '@';
            if (id.Length + name.Length < record_length)
            {
                
                return true;
            }
            else return false;
        }*/
       public void display()
       {
           Console.WriteLine("ID\tName\t address");
           Console.WriteLine(id + '\t' + name+'\t'+address);
       }
    }
}
