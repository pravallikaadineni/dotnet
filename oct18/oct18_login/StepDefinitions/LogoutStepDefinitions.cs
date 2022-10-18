using System;
using TechTalk.SpecFlow;

namespace oct18_login.StepDefinitions
{
    [Binding]
    public class LogoutStepDefinitions
    {
        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
           Console.WriteLine($"nameof{(WhenUserLogOutFromTheApplication)}");
            //throw new PendingStepException();
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            Console.WriteLine($"nameof{(ThenSuccessfulLogOutMessageShouldDisplay)}");
            //throw new PendingStepException();
        }
    }
}
