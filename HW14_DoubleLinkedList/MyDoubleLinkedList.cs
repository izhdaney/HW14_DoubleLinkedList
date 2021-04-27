using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW14_DoubleLinkedList
{
    public class MyDoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;

        public MyDoubleLinkedList()
        {
            count = 0;
            head = null;
            tail = null;
        }

        public MyDoubleLinkedList(T data)
        {
            count = 1;
            head = new Node<T>(data);
            head.Next = null;
            head.Previous = null;
            tail = head;
        }

        public MyDoubleLinkedList(T[] data)
        {

            
            if (data.Length != 0)
            {
                count = data.Length;
                head = new Node<T>(data[0]);
                head.Next = null;
                head.Previous = null;
                tail = head;

                for (int i = 1; i < data.Length; i++)
                {
                    Node<T> newNode = new Node<T>(data[i]);
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }
            }
            else
            {
                head = null;
                tail = null;
            }
        }


        public int Count
        {
            get { return count; } 
        }

        public bool isEmpty
        {
            get { return count == 0; }
        }

        public void AddFirst(T data)
        {
            if (head == null)
            {
                count = 1;
                head = new Node<T>(data);
                head.Next = null;
                head.Previous = null;
                tail = head;
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                head.Previous = newNode;
                newNode.Next = head;
                head = newNode;
                count++;
            }

            
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                count = 1;
                head = new Node<T>(data);
                head.Next = null;
                head.Previous = null;
                tail = head;
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
                count++;
            }
            
        }

        public IEnumerable<T> BackEnumeartor()
        {
            Node<T> current = tail;

            do
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Previous;
                }
            }
            while (current != null);

            //var current = tail;
            //while (current != null)
            //{
            //    yield return current.Data;
            //    current = current.Previous;
            //};
        }

        public void Clear()
        {
            count = 0;
            head = null;
            tail = null;
        }

        public bool Contains(T data)
        {
            Node<T> temp = head;

            for (int i = 0; i < count; i++)
            {
                if (temp.Data.Equals(data))
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }


        public bool Remove(T data)
        {
            Node<T> firstItem = head;
            Node<T> indexItem = head;
            Node<T> lastItem = tail;

            var index = 0;

            if (firstItem == null)
            {
                throw new InvalidOperationException();
            }

            for (int i = 1; i < count + 1; i++)
            {
                if (indexItem.Data.Equals(data))
                {
                    index = i;
                    break;
                }
                indexItem = indexItem.Next;
            }

            if (index == 1)
            {
                if (head.Next != null)
                {
                    head.Next.Previous = null;
                }
                head = head.Next;
                count--;
                return true;
            }
            else if (index == count)
            {
                if (lastItem.Previous != null)
                {
                    lastItem.Previous.Next = null;
                    tail = lastItem.Previous;
                }
                lastItem = lastItem.Previous;
                count--;
                return true;
            }
            else if (index != 0 && index != 1 && index != count)
            {
                for (int i = 1; i < count; i++)
                {
                    if (firstItem.Data.Equals(data))
                    {
                        firstItem.Previous.Next = firstItem.Next;
                        firstItem.Next.Previous = firstItem.Previous;
                        count--;
                        return true;
                    }
                    firstItem = firstItem.Next;
                }
            }

            return false;


        }


        public void PrintReverse()
        {
            var item = tail;
            while (item != null)
            {
                Console.Write($"{item.Data}\t");
                item = item.Previous;
            }
        }

        public void Print()
        {
            var item = head;
            while (item != null)
            {
                Console.Write($"{item.Data}\t");
                item = item.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            };
        }
    }
}
