using TechTalk.SpecFlow;

namespace ReqResAPI
{
    [Binding]
    public class AsAUserIWantToRegisterToSiteSteps
    {
        [Given(@"I register a new User with '(.*)' Username and '(.*)' Password")]
        public void GivenIRegisterANewUserWithUsernameAndPassword(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"registration is( not)? sucessfull")]
        public void ThenRegistrationIsSucessfull()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the response code is '(.*)'")]
        public void ThenTheResponseCodeIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"token is generated")]
        public void ThenTokenIsGenerated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
