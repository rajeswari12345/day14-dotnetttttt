// See https://aka.ms/new-console-template for more information
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

        internal void InsertLast(LinkedList, LinkedList, int data)
        {
            Node newNode = new Node(data);
            if (LinkedList.head == null)
            {
                newNode.prev = null;
                LinkedList.head = newNode;
                return;
            }
            Node lastNode = GetLastNode(LinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
