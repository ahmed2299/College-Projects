using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace csharpexamples
{
    [Serializable]
    class friend
    {
        public string Name;
        public string Phone;

        public friend(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public void displayFriend()
        {
            Console.WriteLine("Name: " + Name + "\t Phone: " + Phone);
        }
    }

    class friendsInformation
    {
        public Dictionary<string, friend> oldFriendsList;

        public Dictionary<string, friend> newFriendsList;
        BinaryFormatter formatter;
        string fileName;

        public friendsInformation(String fileName)
        {
            oldFriendsList = new Dictionary<String, friend>();
            newFriendsList = new Dictionary<String, friend>();
            this.fileName = fileName;
            formatter = new BinaryFormatter();
            load();

        }

        public void addFriend(friend f)
        {
            if (!newFriendsList.ContainsKey(f.Name) && !oldFriendsList.ContainsKey(f.Name))
            {
                //write you code here
                newFriendsList.Add(f.Name, f);
            }
            else
            {
                Console.WriteLine("Already Exists");
            }
        }


        public void removeFriend(string name)
        {
            if (newFriendsList.ContainsKey(name))
            {
                newFriendsList.Remove(name);

            }

            else
            {
                Console.WriteLine("Doesn't Exist");
            }
        }
        public void load()
        {
            oldFriendsList.Clear();
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            while (stream.Position != stream.Length)
            {
                //write you code here
                //(Dictionary<String, friend>)formatter.Deserialize(stream);
                Dictionary<String, friend> temp = (Dictionary<String, friend>)formatter.Deserialize(stream);
                for (int i = 0; i < temp.Count; i++)
                {
                    oldFriendsList.Add(temp.ElementAt(i).Key, temp.ElementAt(i).Value);
                }
            }
            stream.Close();
        }

        public void save()
        {
            FileStream stream = new FileStream(fileName, FileMode.Append);
            formatter.Serialize(stream, newFriendsList);
            stream.Close();

        }

        public void PrintNew()
        {
            for (int i = 0; i < newFriendsList.Count; i++)
            {
                Console.WriteLine(newFriendsList.ElementAt(i).Key);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            friendsInformation fi = new friendsInformation("Friends.txt");
            while (true)
            {
                Console.WriteLine("Please Enter add to add some contacts or display to display the Phonebook contacts");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        {
                            while (true)
                            {
                                Console.WriteLine("Please Enter the Contact Name");
                                string Name = Console.ReadLine();
                                Console.WriteLine("Please Enter the Contact Phone Number");
                                string Phone = Console.ReadLine();
                                friend newFriend = new friend(Name, Phone);
                                fi.addFriend(newFriend);
                                Console.WriteLine("Would You like to add new Contacts Y/N");
                                char addMoreResponse = char.Parse(Console.ReadLine());

                                if (addMoreResponse.Equals('N'))
                                {
                                    Console.WriteLine("Would You Like to remove any of the Newly added Contacts before saving them: Y/N");
                                    char removeResponse = char.Parse(Console.ReadLine());

                                    if (removeResponse.Equals('N'))
                                    {
                                        fi.save();
                                        fi.newFriendsList.Clear();
                                        fi.oldFriendsList.Clear();
                                    }
                                    else if (removeResponse.Equals('Y'))
                                    {
                                        while (true)
                                        {
                                            Console.WriteLine("Please Select the Contact You need to Remove before Saving");
                                            fi.PrintNew();
                                            string contacttoRemove = Console.ReadLine();
                                            fi.removeFriend(contacttoRemove);
                                            Console.WriteLine("Remove More Y/N");
                                            removeResponse = char.Parse(Console.ReadLine());
                                            if (removeResponse.Equals('N'))
                                            {
                                                fi.save();
                                                fi.newFriendsList.Clear();
                                                fi.oldFriendsList.Clear();
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }

                    case "display":
                        {
                            fi.load();
                            foreach (friend f in fi.oldFriendsList.Values)
                            {
                                f.displayFriend();
                            }

                        }
                        break;

                    default:
                        Console.WriteLine("Command not found: " + command);
                        break;


                }


            }
        }
    }
}