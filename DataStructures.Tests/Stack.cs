using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Tests
{
    public class Stack<T>
    {
        private LinkedList<T> list;

        public Stack() {
            list = new LinkedList<T>();
        }

        public void Push(T item)
        {
            list.AddToHead(new Node<T>(item));
        }

        public T Peek()
        {
            return list.Head.Value;
        }

        public T Pop()
        {
            T returnValue = default(T);
            if (list.Count > 0)
            {
                returnValue = list.RemoveFromHead().Value;
            }

            return returnValue;
        }
    }
}
