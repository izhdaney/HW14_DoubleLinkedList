using System;
using System.Collections.Generic;

namespace HW14_DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] word = { "1", "2", "3", "4" };

            MyDoubleLinkedList<int> firstList = new MyDoubleLinkedList<int>();

            MyDoubleLinkedList<string> secondList = new MyDoubleLinkedList<string>("text");

            MyDoubleLinkedList<string> massList = new MyDoubleLinkedList<string>(word);


            Console.WriteLine("FIRST LIST\n");

            firstList.AddFirst(3);
            firstList.AddFirst(2);
            firstList.AddFirst(1);

            firstList.AddLast(4);
            firstList.AddLast(5);
            firstList.AddLast(6);

            Console.WriteLine($"Remove 6 is - {firstList.Remove(6)}");
            Console.WriteLine($"Remove 1 is - {firstList.Remove(1)}");
            Console.WriteLine($"Remove 3 is - {firstList.Remove(3)}");
            Console.WriteLine($"Remove 98 is - {firstList.Remove(98)}");

            Console.WriteLine($"Contains 4 - is {firstList.Contains(4)}");
            Console.WriteLine($"Contains 8 - is {firstList.Contains(8)}");

            Console.WriteLine($"Count is {firstList.Count}");
            Console.WriteLine($"IsEmpty is {firstList.isEmpty}");


            Console.Write("Print all list\t");

            foreach (var el in firstList)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();

            Console.Write("Print all list reverse\t");

            foreach (var el in firstList.BackEnumeartor())
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();

            Console.WriteLine("\nSECOND LIST\n");

            secondList.AddFirst("3");
            secondList.AddFirst("2");
            secondList.AddFirst("1");

            secondList.AddLast("4");
            secondList.AddLast("5");
            secondList.AddLast("6");

            Console.WriteLine($"Remove 6 is - {secondList.Remove("6")}");
            Console.WriteLine($"Remove 1 is - {secondList.Remove("1")}");
            Console.WriteLine($"Remove 3 is - {secondList.Remove("3")}");
            Console.WriteLine($"Remove 98 is - {secondList.Remove("98")}");

            Console.WriteLine($"Contains 4 - is {secondList.Contains("4")}");
            Console.WriteLine($"Contains 8 - is {secondList.Contains("8")}");

            Console.WriteLine($"Count is {secondList.Count}");
            Console.WriteLine($"IsEmpty is {secondList.isEmpty}");


            Console.Write("Print all list\t");

            foreach (var el in secondList)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();

            Console.Write("Print all list reverse\t");

            foreach (var el in secondList.BackEnumeartor())
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();


            Console.WriteLine("\nMASS LIST\n");

            massList.AddFirst("3");
            massList.AddFirst("2");
            massList.AddFirst("1");

            massList.AddLast("4");
            massList.AddLast("5");
            massList.AddLast("6");

            Console.WriteLine($"Remove 6 is - {massList.Remove("6")}");
            Console.WriteLine($"Remove 1 is - {massList.Remove("1")}");
            Console.WriteLine($"Remove 3 is - {massList.Remove("3")}");
            Console.WriteLine($"Remove 98 is - {massList.Remove("98")}");

            Console.WriteLine($"Contains 4 - is {massList.Contains("4")}");
            Console.WriteLine($"Contains 8 - is {massList.Contains("8")}");

            Console.WriteLine($"Count is {massList.Count}");
            Console.WriteLine($"IsEmpty is {massList.isEmpty}");


            Console.Write("Print all list\t");

            foreach (var el in massList)
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();

            Console.Write("Print all list reverse\t");

            foreach (var el in massList.BackEnumeartor())
            {
                Console.Write($"{el}\t");
            }
            Console.WriteLine();


        }
    }
}

            