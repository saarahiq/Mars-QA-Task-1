using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class LanguageFeatureStepDefinitions
    {
        [Given(@"I click on Add New button")]
        public void GivenIClickOnAddNewButton()
        {
            // Navigate to Url 
            // Login to the website
            
            throw new PendingStepException();
        }

        [When(@"I enter '([^']*)' and '([^']*)'")]
        public void WhenIEnterAnd(string english, string fluent)
        {
            throw new PendingStepException();
        }

        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see '([^']*)'")]
        public void ThenIShouldSee(string p0)
        {
            throw new PendingStepException();
        }
    }
}
