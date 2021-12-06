using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace assignment_2
{

    [Serializable]

    class Program
    {


        static void Main(string[] args)
        {

            ShoppingCart cart = new ShoppingCart("items.txt");

            while (true)
            {
                Console.WriteLine("please enter add to add or display to display");
                String command = Console.ReadLine();

                if (command.Equals("add"))
                {
                    while (true)
                    {
                        Console.WriteLine("please enter the item id");
                        String item_id = Console.ReadLine();

                        Console.WriteLine("please enter the item name");
                        String item_name = Console.ReadLine();

                        Console.WriteLine("please enter the item quantity");
                        int quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("please enter the user id");
                        String user_id = Console.ReadLine();

                        Items item = new Items(item_id, item_name, quantity);

                        cart.addItem(item, user_id,item_id);

                        Console.WriteLine("would you like to add new item Y/N");
                        Char opinion = char.Parse(Console.ReadLine());
                        if (opinion.Equals('N')) break;
                    }

                    Console.WriteLine("would you like to remove any item before saving ? Y/N");
                    char opinion2 = char.Parse(Console.ReadLine());

                    if (opinion2.Equals('Y'))
                    {
                        while (true)
                        {

                            Console.WriteLine("Please select the item u want to remove before saving ");
                            cart.showUsers();
                            String id = Console.ReadLine();
                            cart.removeItem(id);
                            Console.WriteLine("remove more?Y/N ");
                            char remove = char.Parse(Console.ReadLine());

                            if (remove.Equals('N'))
                            {
                                cart.save();
                                cart.newItemList.Clear();
                                cart.oldItemList.Clear();
                            }
                        }
                    }

                    else if (opinion2.Equals('N'))
                    {
                        cart.save();
                        cart.newItemList.Clear();
                        cart.oldItemList.Clear();

                    }

                }



                else if (command.Equals("display"))
                {

                    cart.showUsers();
                    Console.WriteLine("Please enter user id to display of this user id");
                    String user_id = Console.ReadLine();
                    cart.printUserData(user_id);

                }

            }


        }

    }

}
