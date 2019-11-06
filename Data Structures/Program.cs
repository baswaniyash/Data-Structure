using System;
using System.Collections.Generic; //linked list is defined in this library
namespace Data_Structures
{
    //doubly linked list program for find element in a linked list
    //data structure program
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.Write("Welcome to doubly linked list ");
            Console.Write("Enter name to search:");
            n = Console.ReadLine(); //input from user
            LinkedList<String> my_list = new LinkedList<String>(); //here creating linkedlist
            my_list.AddFirst("yash"); //here adding elements in linked list
            //Add is work like push and first last show which position to add
            my_list.AddLast("rohit");
            my_list.AddLast("nabeel");
            my_list.AddLast("ahmed");
            my_list.AddLast("satish");

            // Check if the given element 
            // is available or not 
            if (my_list.Contains(n) == true) //here we are checking name is in linked list or not
            {
                Console.WriteLine("Name Found");
            }
            else
            {
                Console.WriteLine("Name Not Found");
            }
        }
    }
}
