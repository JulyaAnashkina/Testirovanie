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

        Node<T> head; // голова
        Node<T> tail; // хвост
        int count;  // количество элементов в списке
    }
}
