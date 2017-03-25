using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_2_Testirovanie;

namespace BDD_OLS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Insert_Node_in_Head_List() //добавить узел в голову списка
        {
            OLS<string> list = new OLS<string>();
            list.Add_in_Tail("Мышкин");
            list.Add_in_Tail("Иванова");
            list.Add_in_Tail("Смирнов");
            list.Add_in_Tail("Кравчук");
            list.Add_in_Head("Петров");
            Assert.AreEqual(list.head.Data, "Петров");
        }

        [TestMethod]
        public void Insert_Node_in_Tail_List() //добавить узел в хвост списка
        {
            OLS<string> list = new OLS<string>();
            list.Add_in_Head("Мышкин");
            list.Add_in_Head("Иванова");
            list.Add_in_Head("Смирнов");
            list.Add_in_Tail("Кравчук");
            list.Add_in_Head("Петров");
            Assert.AreEqual(list.tail.Data, "Кравчук");
        }

        [TestMethod]
        public void Insert_Node_last_Specified_Node() // добавить узел после заданного узла
        {
            OLS<string> list = new OLS<string>();
            list.Add_in_Tail("Смирнов");
            list.Add_in_Head("Петров");
            list.Add_in_Head("Иванов");
            list.Add_in_Head("Васичкин");
            list.Add("Кузнецова", "Иванов");

            OLS<string>.Node<string> current = list.head;
            int i = 0;
            while (i != 3)
            {
                current = current.Next;
                i++;
            }
            Assert.AreNotEqual(current.Data, "Кузнецова");
        }

        [TestMethod]
        public void Remove_Specified_Node() // удалить заданный узел
        {
            OLS<string> list = new OLS<string>();
            list.Add_in_Tail("Смирнов");
            list.Add_in_Head("Петров");
            list.Add_in_Head("Иванов");
            list.Add_in_Head("Васичкин");
            list.Remove("Петров");

            Assert.AreEqual(list.count, 3);

            OLS<string>.Node<string> current = list.head;
            while (current != null)
            {
                Assert.AreNotEqual(current.Data, "Петров");
                current = current.Next;
            }
        }

        [TestMethod]
        public void Remove_the_Entire_List() //удалить весь список
        {
            OLS<string> list = new OLS<string>();
            list.Add_in_Tail("Смирнов");
            list.Add_in_Head("Петров");
            list.Add_in_Head("Иванов");
            list.Add_in_Head("Васичкин");
            list.Clear();

            OLS<string>.Node<string> current = list.head;
            while (current != null)
            {
                Assert.AreEqual(current.Data, null);
                current = current.Next;
            }
        }
    }
}
