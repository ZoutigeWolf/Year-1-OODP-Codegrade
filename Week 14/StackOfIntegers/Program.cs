using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        //int to switch on
        int choice;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add integer to stack");
            Console.WriteLine("2. Remove integer from stack");
            Console.WriteLine("3. View top integer on stack");
            Console.WriteLine("4. View all integers on stack");
            Console.WriteLine("5. Exit program");
            Console.Write("Enter the number of your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    int n = int.Parse(Console.ReadLine());
                    stack.Push(n);
                    
                    Console.WriteLine($"Added {n} to the stack");
                    break;
                }
                case 2:
                {
                    int n = stack.Pop();
                    
                    Console.WriteLine($"Removed {n} from the stack");
                    break;
                }
                case 3:
                {
                    int n = stack.Peek();
                    
                    Console.WriteLine($"Top integer on stack: {n}");
                    break;
                }
                case 4:
                {
                    Console.WriteLine("All integers on stack:");
                    stack.ToList().ForEach(Console.WriteLine);
                    break;
                }
            }

        } while (choice != 5);
    }
}