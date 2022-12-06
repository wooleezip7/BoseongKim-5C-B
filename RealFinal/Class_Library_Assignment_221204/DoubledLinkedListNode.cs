using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{
    public class DoubledLinkedListNode<T>
    {
        public DoubledLinkedListNode(T value) 
        {
            Value = value;
        }
        public T Value { get; set; }
        public DoubledLinkedListNode<T> Next { get; set; }
        public DoubledLinkedListNode<T> Previous { get; set; } 
    }
}
