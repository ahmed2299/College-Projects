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
    class ShoppingCart
    {
        public String user_id;
        public Dictionary<String,Dictionary<String, Items>> oldItemList;
        public Dictionary<String,Dictionary<String, Items>> newItemList;
        Dictionary<String, Items> list;
       
        BinaryFormatter formatter;
        public String fileName;
        public ShoppingCart(String fileName)
        {
            this.fileName = fileName;
            oldItemList = new Dictionary<String, Dictionary<String, Items>>();
            newItemList = new Dictionary<String, Dictionary<String, Items>>();
            list = new Dictionary<String, Items>();
            formatter = new BinaryFormatter();
            
            //list = new Dictionary<String, Items>();
            load();
        }

        public void addItem(Items item,String user_id,String item_id)
        {
            try
            {
                if (!newItemList.ContainsKey(user_id)||!oldItemList.ContainsKey(user_id))
                {
                    list.Add(item_id, item);
                    newItemList.Add(user_id, list);
                }

            }

            catch
            {
                Console.WriteLine("ERROR! This user id is used before ");
            }

        }

        public void removeItem(String item_id)
        {
            try
            {
                if (newItemList[user_id].ContainsKey(item_id))
                {
                    newItemList[user_id].Remove(item_id);
                }
                else Console.WriteLine("Does not exist");
            }
            catch
            {
                Console.WriteLine("ERROR! This item id is used before ");
            }
        }

        public void save()
        {
            FileStream stream = new FileStream(fileName, FileMode.Append);
            formatter.Serialize(stream, newItemList);
            stream.Close();
        }

        public void load()
        {
            oldItemList.Clear();
            FileStream stream=new FileStream(fileName,FileMode.OpenOrCreate);
            while (stream.Position != stream.Length)
            {

                Dictionary<String, Dictionary<String, Items>> temp = (Dictionary<String, Dictionary<String, Items>>)formatter.Deserialize(stream);
                for (int i = 0; i < temp.Count; i++)
                {
                    oldItemList.Add(temp.ElementAt(i).Key, temp.ElementAt(i).Value);
                }

            }
            stream.Close();

        }

        public void showUsers()
        {
            load();
            for (int i = 0; i < oldItemList.Count; i++)
            {

                Console.WriteLine(oldItemList.ElementAt(i).Key);

            }
        }

        public void printUserData(String user_id)
        {

            if (oldItemList.ContainsKey(user_id))
            {
                for(int i=0;i<oldItemList[user_id].Count;i++)
                {
                    oldItemList[user_id].ElementAt(i).Value.display();
                }
            }

        }

    }
}
