using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures");

            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            stack.Peak();
            stack.Pop();
            stack.Display();
        }
    }
}
