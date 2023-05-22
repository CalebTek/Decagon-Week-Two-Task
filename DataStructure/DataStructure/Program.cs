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
            node.Add(2);
            node.Add(3);
            Console.WriteLine(node.listSize);
            Console.ReadLine();
        }
    }
}
