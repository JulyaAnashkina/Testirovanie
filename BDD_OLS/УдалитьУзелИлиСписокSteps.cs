using Lab_2_Testirovanie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BDD_OLS
{
    [Binding]
    public class УдалитьУзелИлиСписокSteps
    {
        private OLS<string> list;

        [Given(@"инициализирую список")]
        public void ДопустимИнициализируюСписок()
        {
            list = new OLS<string>();
        }

        [Given(@"я добавляю в него элементы")]
        public void ДопустимЯДобавляюВНегоЭлементы()
        {
            list.Add_in_Tail("Смирнов");
            list.Add_in_Head("Петров");
            list.Add_in_Head("Иванов");
            list.Add_in_Head("Васичкин");
        }

        [When(@"удаляю заданный узел")]
        public void ЕслиУдаляюЗаданныйУзел()
        {
            list.Remove("Петров");
        }

        [When(@"удаляю список")]
        public void ЕслиУдаляюСписок()
        {
            list.Clear();
        }

        [Then(@"данный узел удален")]
        public void ТоДанныйУзелУдален()
        {
            Assert.AreEqual(list.count, 3);

            OLS<string>.Node<string> current = list.head;
            while (current != null)
            {
                Assert.AreNotEqual(current.Data, "Петров");
                current = current.Next;
            }
        }

        [Then(@"список удален")]
        public void ТоСписокУдален()
        {
            OLS<string>.Node<string> current = list.head;
            while (current != null)
            {
                Assert.AreEqual(current.Data, null);
                current = current.Next;
            }
        }
    }
}
