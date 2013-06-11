using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AddToHead(Node<T> node)
        {
            if (Head == null && Tail == null)
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

        public void AddToTail(Node<T> node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = null; // Make sure this new node does not point to other linked lists
                Tail.Next = node;
                Tail = node;
            }
            Count++;
        }

        public Node<T> RemoveFromHead()
        {
            Node<T> returnValue = null; 

            if (Head != null)
            {
                returnValue = Head;
                Head = Head.Next;
                Count--;
            }

            return returnValue;
        }

        public Node<T> RemoveFromTail()
        {
            Node<T> returnValue = null; 

            Node<T> previousNode = null;
            Node<T> currentNode = Head;
            while (currentNode != Tail)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }
            if (previousNode != null)
            {
                returnValue = Tail;
                Tail = previousNode;
                Tail.Next = null;
                Count--;
            }
            return returnValue;
        }

    }
}
