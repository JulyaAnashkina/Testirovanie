using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_2_Testirovanie;

namespace TDD_OLS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Create_OLS()
        {
            OLS<string> list = new OLS<string>();

            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void Insert_Two_Node()
        {
            OLS<string> list = new OLS<string>();
            list.Add_in_Tail("Смирнов");
            list.Add_in_Head("Петров");
            Assert.AreEqual(list.tail.Data, "Смирнов");
            Assert.AreEqual(list.head.Data, "Петров");
        }

        [TestMethod]
        public void Insert_Node()
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
        public void Remove_Node()
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
        public void Remove_OLS()
        {
            OLS<string> list = new OLS<string>();
            list.Add_in_Tail("Смирнов");
            list.Add_in_Head("Петров");
            list.Add_in_Head("Иванов");
            list.Add_in_Head("Васичкин");
            list.Clear(list);

            OLS<string>.Node<string> current = list.head;
            while (current != null)
            {
                Assert.AreEqual(current.Data, null);
                current = current.Next;
            }
        }
    }
}
