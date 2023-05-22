
namespace DataStructure
{
    internal class SinglyNode<T>
    {
        public T Tvalue { get; set; }
        public SinglyNode<T> nextNode { get; set; }
        public SinglyNode<T> nodeHead { get; set; }
        public SinglyNode<T> nodeTail { get; set; }
    }
}
