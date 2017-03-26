using Lab_2_Testirovanie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BDD_OLS
{
    [Binding]
    public class ДобавитьЭлементВСписокSteps
    {
        private OLS<string> list;

        [Given(@"я инициализирую список")]
        public void ДопустимЯИнициализируюСписок()
        {
            list = new OLS<string>();
        }

        [Given(@"добавляю в него элементы")]
        public void ДопустимДобавляюВНегоЭлементы()
        {
            list.Add_in_Tail("Смирнов");
            list.Add_in_Head("Петров");
            list.Add_in_Head("Иванов");
            list.Add_in_Head("Васичкин");
        }

        [When(@"я добавляю элемент в голову списка")]
        public void ЕслиЯДобавляюЭлементВГоловуСписка()
        {
            list.Add_in_Head("Петров");
        }

        [When(@"я добавляю элемент в хвост списка")]
        public void ЕслиЯДобавляюЭлементВХвостСписка()
        {
            list.Add_in_Tail("Кравчук");
        }

        [When(@"я добавляю элемент в список после заданного узла")]
        public void ЕслиЯДобавляюЭлементВСписокПослеЗаданногоУзла()
        {
            list.Add("Кузнецова", "Иванов");
        }

        [Then(@"в голове списка будет добавленный элемент")]
        public void ТоВГоловеСпискаБудетДобавленныйЭлемент()
        {
            Assert.AreEqual(list.head.Data, "Петров");
        }

        [Then(@"в хвосте списка будет добавленный элемент")]
        public void ТоВХвостеСпискаБудетДобавленныйЭлемент()
        {
            Assert.AreEqual(list.tail.Data, "Кравчук");
        }

        [Then(@"после зданного узла будет добавленный элемент")]
        public void ТоПослеЗданногоУзлаБудетДобавленныйЭлемент()
        {
            OLS<string>.Node<string> current = list.head;
            int i = 0;
            while (i != 3)
            {
                current = current.Next;
                i++;
            }
            Assert.AreNotEqual(current.Data, "Кузнецова");
        }
    }
}
