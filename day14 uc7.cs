// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

namespace linked_list_day14
{
    public class LinkedList
    {

        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {

                    temp.next = node;
                }
                Console.WriteLine("{0} inserted into linked list", node.data)}
        }

        internal void SearchNode()
        {
            while (this.head ! = null)
{
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;
        }
    }
}
