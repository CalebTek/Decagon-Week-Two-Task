namespace DataStructure
{
    internal class SinglyNode<T>
    {
        internal T Tvalue { get; set; }
        internal SinglyNode<T> nextNode { get; set; }
        internal SinglyNode<T> nodeHead { get; set; }
        internal SinglyNode<T> nodeTail { get; set; }
    }
}
