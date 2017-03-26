using System;
using TechTalk.SpecFlow;

namespace BDD_OLS
{
    [Binding]
    public class УдалитьУзелИлиСписокSteps
    {
        [Given(@"инициализирую список")]
        public void ДопустимИнициализируюСписок()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"я добавляю в него элементы")]
        public void ДопустимЯДобавляюВНегоЭлементы()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"удаляю заданный узел")]
        public void ЕслиУдаляюЗаданныйУзел()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"удаляю список")]
        public void ЕслиУдаляюСписок()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"данный узел удален")]
        public void ТоДанныйУзелУдален()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"список удален")]
        public void ТоСписокУдален()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
