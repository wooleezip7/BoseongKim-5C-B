using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{
    public class DoublyLinkedList<T> :
        System.Collections.Generic.ICollection<T>
    {
        public DoubledLinkedListNode<T> Head 
        {
            get;
            private set;
        }
        public DoubledLinkedListNode<T> Tail 
        {
            get;
            private set;
        }

        public void AddFirst(T value) 
        {
            AddFirst(new DoubledLinkedListNode<T>(value));
        }

        public void AddFirst(DoubledLinkedListNode<T> node) 
        {
            DoubledLinkedListNode<T> temp = Head;

            Head = node;

            Head.Next = temp;

            if (Count == 0)
            {
                Tail = Head;
            }
            else 
            {
                temp.Previous = Head;
            }
            Count++;
        }
        public void AddLast(T value)
        {
            AddLast(new DoubledLinkedListNode<T>(value));
        }

        public void AddLast(DoubledLinkedListNode<T> node) 
        {
            if (Count == 0) 
            {
                Head = node;
            }
            else 
            {
                Tail.Next = node;

                node.Previous = Tail;
            }
            Tail = node;
            Count++;
        }
        
        public void RemoveFirst()
        {
            if (Count != 0) 
            {
                Head = Head.Next;
                Count--;

                if (Count == 0) 
                {
                    Tail = null;
                }
                else 
                {
                    Head.Previous = null;
                }
            }
        }

        public void RemoveLast() 
        {
            if(Count != 0) 
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else 
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                }

                Count--;
            }
        }

        public int Count 
        {
            get;
            private set;
        }

        public void Add(T item) 
        {
            AddFirst(item);
        }

        public bool Contains(T item) 
        {
            DoubledLinkedListNode<T> current = Head;
            while(current != null) 
            {
                if (current.Value.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex) 
        {
            DoubledLinkedListNode<T> current = Head;
            while (current != null) 
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public bool IsReadOnly 
        {
            get 
            {
                return false;
            }
        }

        public bool Remove(T item) 
        {
            DoubledLinkedListNode<T> previous = null;
            DoubledLinkedListNode<T> current = Head;
            while(current != null) 
            {
                if (current.Value.Equals(item)) 
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            Tail = previous;
                        }
                        else
                        {
                            current.Next.Previous = previous;
                        }
                        Count--;

                    }
                    else 
                    {
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() 
        {
            DoubledLinkedListNode<T> current = Head;
            while (current != null) 
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() 
        {
            return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
        }


        public void Clear() 
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        //Topic 14 Lab 05  Part1 1.1

    }

}
