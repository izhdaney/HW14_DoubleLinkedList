using System;
using System.Collections.Generic;
using System.Text;

namespace HW14_DoubleLinkedList
{
    public interface IDoubleLinkedList<T>
    {

        void AddLast(T data);
        void AddFirst(T data);
        bool Remove(T data);

        bool Contains(T data);

        void Clear();

        int Count { get; }

        bool isEmpty { get; }

        IEnumerable<T> BackEnumeartor();


    }
}
