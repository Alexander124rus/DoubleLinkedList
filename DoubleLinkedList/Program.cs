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

            list.PrintList();
            Console.ReadKey();
        }
    }

    class Node<ITEM>
    {
        public ITEM data;
        public Node<ITEM> next;
        public Node<ITEM> prev;
        //public ITEM Data
        //{
        //    get;
        //    set;
        //}
        //public Node<ITEM> Next
        //{
        //    get;
        //    set;
        //}
        //public Node<ITEM> Prev
        //{
        //    get;
        //    set;
        //}
        public Node(ITEM data)
        {
            this.data = data;
        }
    }
    class DubleList<T>
    {
        public Node<T> first;
        public Node<T> tail;

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
                tail.next = node; // делаем резервное место под след значение
                node.prev = tail; // кидаем указатель хвоста на пред элемент перед добавленым
            }
            tail = node; // новый конец списка
            


            //if (first == null)
            //{
            //    first = node;
            //}
            //else
            //{

                
            //    first.next = current;
            //    current.prev = first;
            //    //while (current.next != null)
            //    //{
            //    //    current.prev = first;
            //    //    current.next = first.next;
            //    //    first.next.prev = current;
            //    //    first.next = current;
            //    //}


            //}
            //current = node;
        }

        public void PrintList()
        {
            Node<T> current = first;
            while (current != null)
            {
                Console.WriteLine(current.data); // вывод значения элемента
                current = current.next; // переход к следующему узлу
            }
        }

    }
}
