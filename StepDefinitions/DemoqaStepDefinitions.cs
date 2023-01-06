using OpenQA.Selenium;
using SpecFlowAssignmentProject1.Configurations;
using SpecFlowAssignmentProject1.Drivers;
using SpecFlowAssignmentProject1.Extensions;
using SpecFlowAssignmentProject1.Pages;

namespace SpecFlowAssignmentProject1.StepDefinitions
{
    [Binding]
    public class DemoqaStepDefinitions
    {
        private readonly driverHelper driverHelper;
        private IJavaScriptExecutor js;
        HomePage homePage;

        public DemoqaStepDefinitions(driverHelper driverHelper)
        {
            this.driverHelper = driverHelper;
            this.js = (IJavaScriptExecutor)driverHelper.driver!;
            this.homePage = new HomePage(driverHelper.driver!);
        }

        [Given(@"I am on demoqa site")]
        public void GivenIAmOnDemoqaSite() 
        {
            homePage.NavigateToSite(readfromJson.Getdemoqaurl());
        }
        
        [When(@"I Click on Elements")]
        public void WhenIClickOnElements()
        {
            homePage.ClickElements();
        }

        [When(@"I Click on text Box")]
        public void WhenIClickOnTextBox()
        {
        }

        [When(@"I Enter FirstName")]
        public void WhenIEnterFirstName()
        {
            
        }

        [When(@"I Enter Email")]
        public void WhenIEnterEmail()
        {
            
        }

        [When(@"I Enter Current Address")]
        public void WhenIEnterCurrentAddress()
        {
            
        }

        [When(@"I Enter Permanent Address")]
        public void WhenIEnterPermanentAddress()
        {
            
        }

        [When(@"I Click Submit")]
        public void WhenIClickSubmit()
        {
            
        }

        [Then(@"the form is submited")]
        public void ThenTheFormIsSubmited()
        {
            
        }
    }
}
