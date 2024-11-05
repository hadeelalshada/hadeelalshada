using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linckedlist_and_generics
{
    public class Node<T>
    {
        private int count;
        private Node<T> head;
        private object tail;

        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public int Count { get; private set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public class LinkedList<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public int count { get; private set; }
            public LinkedList()
            {
                head = null;
                tail = null;
                count = 0;
            }
            public void AddFirst(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (head == null)
                {
                    head = tail = newNode;
                }
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }
                count++;
            }
            public void AddLast(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (tail == null)
                {
                    head = tail = newNode;

                }
                else
                {
                    tail.Next = newNode;
                    tail = newNode;
                }
                count++;
            }
        }
        public void AddAt(int index, T data)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            if (index == 0)
            {
                AddFirst(data);
                return;
            }
            if (index == count)
            {
                AddLast(data);
                return;
            }
            Node<T> newnode = new Node<T>(data);
            Node<T> current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newnode.Next = current.Next;
            current.Next = newnode;
            count++;


        }

        private void AddLast(T data)
        {
            throw new NotImplementedException();
        }

        private void AddFirst(T data)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirst()
        {
            if (head == null) throw new InvalidOperationException("List is empty.");
            head = head.Next;
            if (head == null) tail = null;
            Count--;
        }
        public void RemoveLast()
        {
            if (head == null) throw new InvalidOperationException("list is empty.");
            if (head == tail)
            {
                head = (Node<T>)(tail = null);
            }
            else
            {
                Node<T> current = head;
                while (current.Next != tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                tail = current;
            }
            count--;


        }
        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + "->");
                current = current.Next;

            }
            Console.WriteLine("null");
        }
    }
}
