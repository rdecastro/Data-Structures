using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Tests
{
    public class Queue<T>
    {
        private LinkedList<T> list;

        public Queue()
        {
            list = new LinkedList<T>();
        }
        public void Enqueue(T item)
        {
            list.AddToTail(new Node<T>(item));
        }

        public T Dequeue()
        {
            if (Count > 0)
            {
                return list.RemoveFromHead().Value;
            }
            return default(T);
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }
    }
}
