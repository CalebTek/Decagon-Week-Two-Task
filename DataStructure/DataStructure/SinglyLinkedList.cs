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
        public int listSize;


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
        
        public bool Remove(T Rvalue)
        {
            if (nodeHead == null)
            {  return false; }
            if (nodeHead.Tvalue.Equals(Rvalue))
            {
                nodeHead = nodeHead.nextNode;
                listSize--;
                return true;
            }
            var currentNode = nodeHead;
            while (!(currentNode.nextNode == null))
            {
                if (currentNode.nextNode.Tvalue.Equals(Rvalue))
                {
                    currentNode = currentNode.nextNode;
                    listSize--;
                    return true;
                }
                currentNode = currentNode.nextNode;
            }
            return false;
        }
        
        public bool Check(T Rvalue)
        {
            var currentNode = nodeHead;
            while (!(currentNode == null))
            {
                if (currentNode.Tvalue.Equals(Rvalue))
                {
                    return true;
                }
                currentNode = currentNode.nextNode;
            }
            return false;
        }

        public int Index(T Rvalue)
        {
            var nodeIndex = 0; var currentNode = nodeHead;
            while (!(currentNode == null))
            {
                if (currentNode.Tvalue.Equals(Rvalue))
                {
                    return nodeIndex;
                }
                nodeIndex++;
                currentNode = currentNode.nextNode;
            }
            return -1;
        }

    }
}
