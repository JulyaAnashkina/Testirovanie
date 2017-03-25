using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Testirovanie
{
    public class OLS<T>
    {
        public class Node<I> //Узел
        {
            public Node(I data)
            {
                Data = data;
            }
            public I Data { get; set; }
            public Node<I> Next { get; set; }
        }

        public Node<T> head; // голова
        public Node<T> tail; // хвост
        public int count;  // количество элементов в списке

        // добвление в начало
        public void Add_in_Head(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        // добавление  в конец
        public void Add_in_Tail(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            count++;
        }
        
    }
}
