using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class SinglyNode<T>
    {
        public T Tvalue { get; set; }
        public SinglyNode<T> nextNode { get; set; }
    }
    internal class SinglyLinkedList <T>
    {
        public SinglyNode<T> nodeHead;
        private int listSize;


        public int Add(T Rvalue)
        {
            var node = new SinglyNode<T> { Tvalue = Rvalue};
            if (nodeHead == null)
            {
                nodeHead = node;
            }
            else
            {
                var currentValue = nodeHead;
                while (!(currentValue.nextNode == null))
                {
                    currentValue = currentValue.nextNode;
                }
                currentValue.nextNode = node;
            }
            listSize++;
            return listSize;
        }
        
    }
}
