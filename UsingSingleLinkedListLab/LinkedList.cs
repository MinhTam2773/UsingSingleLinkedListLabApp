using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSingleLinkedListLab
{
    public class SingleLinkedList<T>
    {
        public Node<T>? Head { get; private set; }

        public int Count { get; private set; }

        public SingleLinkedList() 
        {
            Head = null;
            Count = 0;
        }

        //methods
        public void AddFirst(string value)
        {
            T convertedValue = (T)Convert.ChangeType(value, typeof(T));
            Node<T> firstNode = new Node<T>(convertedValue);
            if (Head != null)
            {
                firstNode.Next = Head;
            }
            Head = firstNode;
            Count++;  
        }

        public void AddLast(string value)
        {
            T convertedValue = (T)Convert.ChangeType(value, typeof(T));
            Node<T> newNode = new Node<T>(convertedValue);
            Node<T>? current = Head;
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                while (current != null)
                {
                    if (current.Next  ==  null)
                    {
                        current!.Next = newNode;
                        break;
                    }
                    current = current.Next;
                }
            }
            Count++;
        }
        
        public void RemoveFirst()
        {
            if (Head == null)
            {
                throw new Exception("List is empty.");
            }
            else
            {
                Head = Head.Next;
                Count--;
            }
        }

        public void RemoveLast()
        {
            Node<T>? current = Head;
            if (current == null)
            {
                throw new Exception("List is empty.");
            }
            else
            {
                {
                    while (current != null)
                    {
                        if (current.Next!.Next == null)
                        {
                            current.Next = null!;
                            break;
                        }
                        current = current.Next;
                    }
                    Count--;
                }
            }
        }

        public string GetValue(int index)
        {
            Node<T>? current = Head;
            if (current == null)
            {
                throw new Exception("List is empty.");
            }
            else
            {
                for(int i = 0 ; i <= index; i++)
                {
                    if (i == index)
                    {
                        return current.Value!.ToString()!;
                    }
                    current = current.Next;
                }
            }
            throw new Exception("Index out of bounds.");
        }
    }
}
