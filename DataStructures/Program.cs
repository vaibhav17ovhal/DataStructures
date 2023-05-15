using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures");

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

            Console.WriteLine("\n");

            queue.Dequeue();
            queue.Display();
        }
    }
}
