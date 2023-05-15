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

            list.Add(56);
            list.Add(30);
            list.Add(70);

            list.Display();



            int position = list.Search(30);
            list.InsertAtParticularPosition(position + 1, 40);
            list.Display();
            Console.WriteLine();
            int searchDelete = list.Search(40);
            list.DeleteNodeAtParticularPosition(searchDelete);
            list.Display();
        }
    }
}
