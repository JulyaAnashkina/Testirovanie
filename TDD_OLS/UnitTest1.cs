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
        public void Insert_Node()
        {
            OLS<string> list = new OLS<string>();
            list.Add_in_Head("Смирнов");
            Assert.AreEqual(list.head.Data, "Смирнов");
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
    }
}
