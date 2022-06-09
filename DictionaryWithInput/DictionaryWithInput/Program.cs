// See https://aka.ms/new-console-template for more information

Dictionary<string, string> myPhoneBook = new Dictionary<string, string>();

while (true)
{
    Console.WriteLine("What would you like to do? SAVE, VIEW, UPDATE, DELETE");
    string action = Console.ReadLine();
    if(action == "SAVE")
    {
        Console.WriteLine("Enter contact name");
        string contactName = Console.ReadLine();
        Console.WriteLine("Enter contact phone number");
        string contactPhone = Console.ReadLine();

        myPhoneBook.Add(contactName, contactPhone);

        Console.WriteLine(myPhoneBook[contactName] + " added successfully");
    }
    else if (action == "VIEW")
    {
        Console.WriteLine("Enter contact name to view number");
        string contactName = Console.ReadLine();
        
        if (myPhoneBook.ContainsKey(contactName))
        {
            Console.WriteLine("Number is: " + myPhoneBook[contactName]);
        }
        else
        {
            Console.WriteLine("Contact does not exist in phoonebook");
        }
    }
    else if (action == "UPDATE")
    {
        Console.WriteLine("Enter contact name to update");
        string contactName = Console.ReadLine();
        Console.WriteLine("Enter new phone number");
        string contactPhone = Console.ReadLine();
        myPhoneBook[contactName] = contactPhone;
        Console.WriteLine("Updated number is: " + myPhoneBook[contactName]);
    }
    else if (action == "DELETE")
    {
        Console.WriteLine("Enter contact name to delete");
        string contactName = Console.ReadLine();
        myPhoneBook.Remove(contactName);
        Console.WriteLine("Contact deleted succesfully!");
    }
}