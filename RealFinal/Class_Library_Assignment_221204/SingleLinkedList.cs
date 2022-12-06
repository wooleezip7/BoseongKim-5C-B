using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_Assignment
{

    public class SingleLinkedList<T> :
        System.Collections.Generic.ICollection<T>

    {

        public SingleLinkedListNode<T> Head 
        {
            get;
            private set;
        }

        public SingleLinkedListNode<T> Tail 
        {
            get;
            private set;
        }

        public void AddFirst(T value) 
        {
            AddFirst(new SingleLinkedListNode<T>(value));
        }

        public void AddFirst(SingleLinkedListNode<T> node) 
        {
            SingleLinkedListNode<T> temp = Head;

            Head = node;
            Head.Next = temp;

            Count++;
            if(Count == 1) 
            {
                Tail = Head;
            }
        }

        public void AddLast(T value) 
        {
            AddLast(new SingleLinkedListNode<T>(value));
        }

        public void AddLast(SingleLinkedListNode<T> node) 
        {
            if(Count == 0) 
            {
                Head = node;
            }
            else 
            {
                Tail.Next = node;
            }
            Tail = node;
            Count++;
        }

        public void RemoveFirst() 
        {
            if(Count != 0) 
            {
                Head = Head.Next;
                Count--;

                if(Count == 0) 
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast() 
        {
            if(Count != 0) 
            {
                if(Count == 1) 
                {
                    Head = null;
                    Tail = null;
                }
                else 
                {
                    SingleLinkedListNode<T> current = Head;
                    while(current.Next != Tail) 
                    {
                        current = current.Next;
                    }

                    current.Next = null;
                    Tail = current;
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
            SingleLinkedListNode<T> curent = Head;
            while (curent != null) 
            {
                if (curent.Value.Equals(item)) 
                {
                    return true;
                }
                curent = curent.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex) 
        {
            SingleLinkedListNode<T> current = Head;
            while(current != null) 
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
            SingleLinkedListNode<T> previous = null;
            SingleLinkedListNode<T> current = Head;

            while(current != null) 
            {
                if (current.Value.Equals(item)) 
                {
                    if(previous != null) 
                    {
                        previous.Next = current.Next;

                        if(current.Next == null)
                        {
                            Tail = previous;
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
            SingleLinkedListNode<T> current = Head;
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





    }

}
