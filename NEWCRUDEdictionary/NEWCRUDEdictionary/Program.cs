
using System;

namespace NEWCRUDEdictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a new contact details. Eg STORE daniel 09034227044");
            var phonebook = new PhoneBook();

            while (true)
            {
                var input = Console.ReadLine();

                //STORE daniel 09034227044
                var split = input.Split();

                var command = split[0];
                if (command == "STORE")
                {
                    var name = split[1];
                    var num = split[2];
                    var res = phonebook.AddMethod(name, long.Parse(num));
                    if (res)
                    {
                        Console.WriteLine("Contact created successfully, contact is:");
                        phonebook.GetMethod(name);
                    }
                    else
                    {
                        Console.WriteLine("Contact exists already");
                    }
                }
                else if (command == "VIEW")
                {
                    var name = split[1];
                    var res = phonebook.GetMethod(name);
                    if (res)
                    {
                        Console.WriteLine("Requested contact is:");
                        phonebook.GetMethod(name);
                    }
                    else
                    {
                        Console.WriteLine("Contact name does not exist in phone book");
                    }
                }else if (command == "UPDATE")
                {
                    var name = split[1];
                    var num = split[2];
                    if(num == "")
                    {
                        Console.WriteLine("Error: Kindly enter updated number");
                    }
                    else
                    {
                        var res = phonebook.UpdateMethod(name, long.Parse(num));
                        if (res)
                        {
                            Console.WriteLine("Contact updated successfully, updated contact is:");
                            phonebook.GetMethod(name);
                        }
                        else
                        {
                            Console.WriteLine("Oops, sorry you cant update this contact because contact name cant be found");
                        }
                    }
                }else if(command == "DELETE")
                {
                    var name = split[1];
                    var res = phonebook.DeleteMethod(name);
                    if (res)
                    {
                        Console.WriteLine("Contact deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Contact name does not exist in phone book");
                    }
                }
                else
                {
                    Console.WriteLine("Command does not exist; command can either be STORE, VIEW, UPDATE or DELETE");
                }
            }

            Console.ReadKey();
        }
    }
}
