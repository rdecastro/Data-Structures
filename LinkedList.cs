namespace DataStructures
{
    public class LinkedList<T> 
    {
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public Node<T> Head { get; private set; }

        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        // Performance: O(1)
        public void AddToHead(Node<T> node)
        {
            // This implementation only allows 1 node to be added, 
            // instead of a node that could potentially point to other nodes/linked lists
            node.Next = null; 
            
            if (Count == 0)
            {
                
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }

            Count++;
        }

        // Performance: O(1)
        public void AddToTail(Node<T> node)
        {
            // This implementation only allows 1 node to be added,
            // instead of a node that could potentially point to other nodes/linked lists
            node.Next = null;

            if (Count == 0)
            {

                Head = node;
                Tail = node;
            }
            else 
            {
                Tail.Next = node;
                Tail = node; 
            }

            Count++;
        }

        public void RemoveHead()
        {
            if (Count > 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                     Tail = null;
                }
            }
        }
    }
}