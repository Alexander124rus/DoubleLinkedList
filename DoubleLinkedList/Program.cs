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
            DubleList<string> list = new DubleList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.Delite("c");

            list.PrintList();
            Console.ReadKey();
        }
    }

    class Node<ITEM>
    {
        ITEM data;
        Node<ITEM> next;
        Node<ITEM> prev;
        public ITEM Data {
            get;
            set;}
        public Node<ITEM> Next {get;set;}
        public Node<ITEM> Prev {get;set;}
        public Node(ITEM data)
        {
            Data = data;
        }
    }
    class DubleList<T>
    {
        Node<T> first;
        Node<T> last;

        public DubleList(T data)
        {
            //first = null;
            //last = null;
        }

        public void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);
            if (first == null)
            {
                first = node;
            }
            else
            {
                last.Next = node; // делаем резервное место под след значение
                node.Prev = last; // кидаем указатель хвоста на пред элемент перед добавленым
            }
            last = node; // новый конец списка
        }
        public void Delite(T data)
        {
            Node<T> current = first;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (current == first)
                    {
                        first = current.Next;                        
                    }
                    else if (current == last)
                    {
                        last.Prev.Next = null;
                        last = current.Prev;
                    }
                    else
                    {
                        current.Prev.Next = current.Next;
                        current.Next.Prev = current.Prev;
                    }
                }
                current = current.Next;
            }
        }

        public void PrintList()
        {
            Node<T> current = first;
            while (current != null)
            {
                Console.WriteLine(current.Data); // вывод значения элемента
                current = current.Next; // переход к следующему узлу
            }
        }

    }
}
