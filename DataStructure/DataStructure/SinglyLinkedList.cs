
namespace DataStructure
{
    internal class SinglyLinkedList <T> : SinglyNode<T>
    {
        private int listSize;


        public int Add(T Rvalue)
        {
            var node = new SinglyNode<T> { Tvalue = Rvalue};
            switch (nodeHead)
            {
                case null:
                    nodeHead = node;
                    break;
                default:
                    {
                        var currentNode = nodeHead;
                        while (!(currentNode.nextNode == null))
                        {
                            currentNode = currentNode.nextNode;
                        }
                        currentNode.nextNode = node;
                        break;
                    }
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

        public int Count() { return listSize; }

    }
}
