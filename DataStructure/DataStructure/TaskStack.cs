using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class TaskStack<T> : SinglyLinkedList<T>
    {
        private int stackSize = 0;
        public void Push(T Rvalue)
        {
            var node = new SinglyNode<T>() { Tvalue = Rvalue };
            node.nextNode = nodeHead;
            nodeHead = node;
            stackSize++;
        }

        public T Pop()
        {
            if (nodeHead == null)
            {
                throw new InvalidOperationException("Empty stack");
            }
            var nodeValue = nodeHead.Tvalue;
            nodeHead = nodeHead.nextNode;
            stackSize--;
            return nodeValue;
        }

        public T Peek()
        {
            if (nodeHead == null)
            {
                throw new InvalidOperationException("Empty stack");
            }
            return nodeHead.Tvalue;
        }

        public bool IsEmpty() { return nodeHead == null; }

        public int Size() { return stackSize; }
    }
}
