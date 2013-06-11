using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        public Node()
        {

        }

        public Node(T value)
        {
            Value = value;
            Next = null;
        }

        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
