using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class TaskQueue<T> : SinglyLinkedList<T>
    {
        //private SinglyNode<T> nodeHead;
        private SinglyNode<T> nodeTail;

        public void Enqueue(T Rvalue)
        {
            var node = new SinglyNode<T> { Tvalue = Rvalue };
            
            if (nodeHead == null )
            {
                nodeHead = node;
                nodeTail = node;
            }
            else
            {
                nodeTail.nextNode = node;
                nodeTail = node;
            }
        }
        
    }
}
