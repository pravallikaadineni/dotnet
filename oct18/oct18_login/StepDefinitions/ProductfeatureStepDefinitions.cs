using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace oct18_login.StepDefinitions
{
    [Binding]
    public class ProductfeatureStepDefinitions
    {
        login cal = new login();
        string i;
        int j;
        bool ans;
        

        [Given(@"User gives prodname as '([^']*)'")]
        public void GivenUserGivesProdnameAs(string bat)
        { 
            i = bat;
           // throw new PendingStepException();
        }

        [Given(@"User gives qty as (.*)")]
        public void GivenUserGivesQtyAs(int p0)
        {
            j= p0;  
            //throw new PendingStepException();
        }

        [When(@"prodname not null or empty and qty >(.*)")]
        public void WhenProdnameNotNullOrEmptyAndQty(int p0)
        {
            Console.WriteLine($"{nameof(WhenProdnameNotNullOrEmptyAndQty)}");
            // throw new PendingStepException();
        }

        [Then(@"Successfully added")]
        public void ThenSuccessfullyAdded()
        {
            ans = cal.Logincart(i,j);
            Assert.AreEqual(ans, true);
            Console.WriteLine("Successfully added");
            //throw new PendingStepException();
        }
    }
}
