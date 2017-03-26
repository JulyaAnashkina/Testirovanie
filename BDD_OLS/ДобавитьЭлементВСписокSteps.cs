using System;
using TechTalk.SpecFlow;

namespace BDD_OLS
{
    [Binding]
    public class ДобавитьЭлементВСписокSteps
    {
        [Given(@"я инициализирую список")]
        public void ДопустимЯИнициализируюСписок()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"добавляю в него элементы")]
        public void ДопустимДобавляюВНегоЭлементы()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"я добавляю элемент в голову списка")]
        public void ЕслиЯДобавляюЭлементВГоловуСписка()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"я добавляю элемент в хвост списка")]
        public void ЕслиЯДобавляюЭлементВХвостСписка()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"я добавляю элемент в список после заданного узла")]
        public void ЕслиЯДобавляюЭлементВСписокПослеЗаданногоУзла()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"в голове списка будет добавленный элемент")]
        public void ТоВГоловеСпискаБудетДобавленныйЭлемент()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"в хвосте списка будет добавленный элемент")]
        public void ТоВХвостеСпискаБудетДобавленныйЭлемент()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"после зданного узла будет добавленный элемент")]
        public void ТоПослеЗданногоУзлаБудетДобавленныйЭлемент()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
