using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace assignment_2
{
    [Serializable]
    class Items
    {
        public String item_id;
        public String item_name;
        public int quantity;

        public Items(String item_id, String item_name, int quantity)
        {
            this.item_id = item_id;
            this.item_name = item_name;
            this.quantity = quantity;
        }

        public void display()
        {
            Console.WriteLine("Item id : " + item_id + "\t" + "user name : " + item_name + "\t" + "quantity : " + quantity);
        }
    }
}
