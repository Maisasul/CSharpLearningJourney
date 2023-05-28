using System.Diagnostics;

namespace LinkedListGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Display();
        }
    }

    public class MyLinkedList<T>
    {
        class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }
        private Node head;
        private Node tail;

        public MyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void Add(T data) 
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else 
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }
        public void Display()
        {
            Node curr = head;
            while (curr != null) 
            {
                Console.WriteLine(curr.Data + " ");
                curr = curr.Next;
            }
            Console.WriteLine();
        }
    }

}