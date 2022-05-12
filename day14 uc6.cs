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

        internal void RemoveLastNode()
        { 

         if(head == null)
          {
            return null;
           }
          if(head.next == null);
            {
                return null;
            }
            while(NewNode.next.next != null)
            { 
                 NewNode = NewNode.next;
             }
            
                   newNode.next = null;

                  return head;
         }




