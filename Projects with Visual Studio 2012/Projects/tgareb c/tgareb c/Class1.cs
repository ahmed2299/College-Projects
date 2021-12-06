using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace myNamespace
{
    class MyClass
    {
        public int age = 10;
        public string str;
        public MyClass()
        {
        }
         public string this[int index]
         {
             get {return  arr[index] ;}
         }
         public string[] arr = { "ahmed", "hossam", "eldeen" };
        
    }
}
