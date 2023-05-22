using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node = new SinglyLinkedList<int>();
            node.Add(1);
            Console.WriteLine(node.Check(1));
            node.Add(2);
            node.Add(3);
            Console.WriteLine(node.Count());
            node.Remove(1);
            Console.WriteLine(node.Count());
            Console.WriteLine(node.Check(1));
            Console.WriteLine(node.Index(2));

            var nodeStack = new TaskStack<int>();
            Console.WriteLine(nodeStack.IsEmpty());
            nodeStack.Push(1);
            nodeStack.Push(2);
            nodeStack.Push(3);
            Console.WriteLine(nodeStack.Pop());
            Console.WriteLine(nodeStack.Peek());
            Console.WriteLine(nodeStack.Size());
            Console.WriteLine(nodeStack.IsEmpty());


            var nodeQueue = new TaskQueue<int>();
            Console.WriteLine(nodeQueue.IsEmpty());
            nodeQueue.Enqueue(1);
            nodeQueue.Enqueue(2);
            nodeQueue.Enqueue(3);
            Console.WriteLine(nodeQueue.Dequeue());
            Console.WriteLine(nodeQueue.Size());
            Console.WriteLine(nodeQueue.IsEmpty());
            nodeQueue.Add(1);
            Console.WriteLine(nodeQueue.Size());

            Console.ReadLine();
        }
    }
}
