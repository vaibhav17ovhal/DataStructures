using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} is inserted into Linkled List");
        }
    }
}
