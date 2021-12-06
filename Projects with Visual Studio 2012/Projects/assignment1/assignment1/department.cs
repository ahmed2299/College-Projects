using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace assignment1
{

   public class department
{
     public  String id;
     public  String name;
     public String address;
      
    
    public void enterDataToFile()
    {
        Console.WriteLine("Enter the id : ");
        id = Console.ReadLine();
        Console.WriteLine("Enter the name : ");
        name = Console.ReadLine();
        Console.WriteLine("Enter the address : ");
        address = Console.ReadLine();
        FileStream fs = new FileStream("data.txt", FileMode.Open);
        StreamWriter dataa = new StreamWriter(fs);
        FileStream fs2 = new FileStream("index.txt", FileMode.Open);

        StreamWriter indexx = new StreamWriter(fs2);
        dataa.Write(id);
        dataa.Write('@');
        dataa.Write(name);
        dataa.Write('@');
        dataa.Write(address);
        dataa.Write('@');
        int len = (int)dataa.BaseStream.Length;
        indexx.WriteLine(len);
        dataa.Close();
        indexx.Close();
        fs.Close();
        fs2.Close();
    }
     public void display()
     {
         Console.WriteLine("id\tname\taddress");
         Console.WriteLine("-------\t---------\t---------");
         Console.Write(id);
         Console.Write("\t");
         Console.Write(name);
         Console.Write("\t");
         Console.WriteLine(address);
     }
}
}
/*
public bool acceptedLength()
     {
         
         Console.WriteLine("Enter the id : ");
         String str;
         str = Console.ReadLine();
         if (str.Length > id_length)
         {
             Console.WriteLine("Error id is too long enter it again : ");
             return false;
         }
         str.CopyTo(0, id, 0, str.Length);
      
         Console.WriteLine("Enter the name : ");
         str = Console.ReadLine();
         if (str.Length > id_length)
         {
             Console.WriteLine("Error name is too long enter it again : ");
             return false;
         }
         str.CopyTo(0, name, 0, str.Length);
         return true;
     }
*/