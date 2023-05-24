using System;

namespace DataStructure
{
    internal class TaskQueue<T> : SinglyNode<T>
    {
        private int queueSize = 0;
        public void Enqueue(T Rvalue)
        {
            var node = new SinglyNode<T> { Tvalue = Rvalue };

            switch (nodeHead)
            {
                case null:
                    nodeHead = node;
                    nodeTail = node;
                    break;
                default:
                    nodeTail.nextNode = node;
                    nodeTail = node;
                    break;
            }
            queueSize++;
        }

        public T Dequeue()
        {
            if ( nodeHead == null )
            {
                throw new InvalidOperationException("Empty queue");
            }
            var nodeValue = nodeHead.Tvalue;
            nodeHead = nodeHead.nextNode;
            queueSize--;
            return nodeValue;
        }

        public bool IsEmpty() { return nodeHead == null;  }
        
        public int Size() { return queueSize; }
        
    }
}
