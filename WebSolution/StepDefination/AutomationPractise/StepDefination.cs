using TechTalk.SpecFlow;

namespace WebSolution.StepDefination.AutomationPractise
{
    [Binding]
    public class StepDefination
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I clicks on SignIn button")]
        public void WhenIClicksOnSignInButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enters username as  and password as abcdef")]
        public void WhenIEntersUsernameAsAndPasswordAsAbcdef()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click LogIn button")]
        public void WhenIClickLogInButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see (.*)")]
        public void ThenIShouldSee(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
