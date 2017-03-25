using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Lab_2_Testirovanie;

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
    }
}
