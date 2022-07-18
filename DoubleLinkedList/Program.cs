using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DubleList<int> list = new DubleList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list.Print();
            Console.ReadKey();
        }
    }

    class Node<ITEM>
    {
        private ITEM data;
        private Node<ITEM> next;
        private Node<ITEM> prev;
        public ITEM Data
        {
            get;
            set;
        }
        public Node<ITEM> Next
        {
            get;
            set;
        }
        public Node<ITEM> Prev
        {
            get;
            set;
        }
        public Node(ITEM data)
        {
            Data = data;
        }
    }
    class DubleList<T>
    {
        private Node<T> first;

        public DubleList()
        {
            first = null;
        }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            
            if (first == null)
            {
                first = node;
            }
            else
            {
                first.Next = node.Prev;
                node.Next = null;
                node.Prev = first.Next;
                //first.Next = node;
                //node.Prev = first;
                //first = node;
                //Node<T> current = first;
                //while (current.Next != null)
                //{
                //    //first.Next = node;
                //    //node.Prev = first;
                //    //current = current.Next;
                //}
            }
        }

        public void Print()
        {
            Node<T> current = first;
            int k = 0;
            while (k<1)
            {
                Console.WriteLine(current.Data);
                current = current.Next; // переход к следующему узлу
                k++;
            }
        }

    }
}
