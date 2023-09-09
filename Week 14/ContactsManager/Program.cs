using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store contact information
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        // Prompt the user for input and perform the requested operation
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Enter a command (add, view, remove, list, quit):");
            string command = Console.ReadLine() ?? "";

            if (command == "add")
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine() ?? "";
                
                Console.WriteLine("Enter phone number:");
                string number = Console.ReadLine() ?? "";

                contacts[name] = number;
                
                Console.WriteLine($"Contact \"{name}\" added with phone number \"{number}\"");
            }
            else if (command == "view")
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine() ?? "";

                bool exists = contacts.TryGetValue(name, out string number);

                if (!exists)
                {
                    Console.WriteLine("Contact not found");
                    continue;
                }
                
                Console.WriteLine($"Phone number: {number}");
            }
            else if (command == "remove")
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine() ?? "";

                bool exists = contacts.TryGetValue(name, out string number);

                if (!exists)
                {
                    Console.WriteLine("Contact not found");
                    continue;
                }

                contacts.Remove(name);
            }
            else if (command == "list")
            {
                foreach (KeyValuePair<string, string> contact in contacts)
                {
                    Console.WriteLine($"{contact.Key}: {contact.Value}");
                }
            }
            else if (command == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}