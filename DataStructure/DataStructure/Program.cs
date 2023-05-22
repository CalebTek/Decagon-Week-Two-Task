using System;
using System.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node = new SinglyLinkedList<int>();
            node.Add(1);
            Console.WriteLine(node.Check(1));// should return True,1 exist
            node.Add(2);
            node.Add(3);
            Console.WriteLine(node.Count()); // should return 3, three element added 
            node.Remove(1);
            Console.WriteLine(node.Count()); // should return 2, 1st element was removed
            Console.WriteLine(node.Check(1)); // should return False, 1 no longer exist
            Console.WriteLine(node.Index(2)); // should return 0, 2 is now the 1st element

            var nodeStack = new TaskStack<int>();
            Console.WriteLine(nodeStack.IsEmpty()); // should return True, Stack is empty
            //Console.WriteLine(nodeStack.Pop()); // should throw an exception Empty stack
            nodeStack.Push(1);
            nodeStack.Push(2);
            nodeStack.Push(3);
            Console.WriteLine(nodeStack.Pop()); // should return 3, 3 is the last element
            Console.WriteLine(nodeStack.Peek()); // should return 2, 2 is now the last element
            Console.WriteLine(nodeStack.Size()); // should return 2, 2 elements is present
            Console.WriteLine(nodeStack.IsEmpty()); // should return False, Stack is not empty


            var nodeQueue = new TaskQueue<int>();
            Console.WriteLine(nodeQueue.IsEmpty()); // should return True, Queue is empty
            //Console.WriteLine(nodeQueue.Dequeue()); // should throw an exception Empty queue
            nodeQueue.Enqueue(1);
            nodeQueue.Enqueue(2);
            nodeQueue.Enqueue(3);
            Console.WriteLine(nodeQueue.Dequeue()); // should return 1, 1 is the 1st element
            Console.WriteLine(nodeQueue.Size()); // should return 2, 2 elements is present
            Console.WriteLine(nodeQueue.IsEmpty()); // should return False, queue is not empty
            nodeQueue.Enqueue(4);
            Console.WriteLine(nodeQueue.Size()); // should return 3, 3 elements now present

            Console.ReadLine();
        }
    }
}
