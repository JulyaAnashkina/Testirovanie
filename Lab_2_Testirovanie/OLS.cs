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

        // вставка элемента

        // удаление элемента
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)  // Если узел в середине или в конце
                    {
                        previous.Next = current.Next;  // убираем узел current
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {  // если удаляется первый элемент
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }
    }
}
