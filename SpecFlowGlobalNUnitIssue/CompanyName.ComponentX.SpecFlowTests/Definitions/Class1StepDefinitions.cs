using TechTalk.SpecFlow;

namespace CompanyName.ComponentX.SpecFlowTests.Definitions
{
    [Binding]
    public class Class1StepDefinitions
    {
        private Class1? _instance;

        [Given(@"The class 1 instance")]
        public void GivenTheClassInstance()
        {
            _instance = new Class1();
        }

        [Then(@"The foo returns (.*)")]
        public void ThenTheFooReturns(int p0)
        {
            Assert.That(_instance, Is.Not.Null);
            Assert.That(_instance.Foo(), Is.EqualTo(p0));
        }
    }
}
