// See https://aka.ms/new-console-template for more information
using System;
namespace DataStructuredemo
{
    class program
{
    static void main(string[] args)
    {
        Console.WriteLine("welcome to the Linked List operations");
        LinkedList List = new LinkedList();
        List.Add(56);
        List.Add(30);
        List.Add(70);
        List = display();
        Console.WriteLine("search element" = List.search(30));
    }


}

}