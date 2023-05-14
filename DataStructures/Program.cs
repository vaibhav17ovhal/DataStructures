using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures");

            LinkedList list = new LinkedList();

            list.AddInReverseOrder(70);
            list.AddInReverseOrder(30);
            list.AddInReverseOrder(56);
            list.Display();


        }
    }
}
