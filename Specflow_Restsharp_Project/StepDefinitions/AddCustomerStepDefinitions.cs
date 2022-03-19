using OpenQA.Selenium;
using Specflow_Practice.Hooks;
using Specflow_Practice.Pages;
using System;
using TechTalk.SpecFlow;

namespace Specflow_UI_Project.StepDefinitions
{
    [Binding]
    public class AddCustomerStepDefinitions
    {
        IWebDriver driver = WebDriverClass.myDriver;
        
        [Then(@"User navigates to Customer Managment page")]
        public void ThenUserNavigatesToCustomerManagmentPage()
        {
            DashboardPage dashboardPage = new DashboardPage(driver);
            System.Threading.Thread.Sleep(1000);
            dashboardPage.accountsLink.Click();
            System.Threading.Thread.Sleep(1000);
            dashboardPage.customersLink.Click();
        }

        [When(@"User clicks on Add Customer Button")]
        public void WhenUserClicksOnAddCustomerButton()
        {
            CustomerManagementPage customerManagementPage = new CustomerManagementPage(driver);
            customerManagementPage.addButton.Click();
        }

        [Then(@"User should be on Add Customer page")]
        public void ThenUserShouldBeOnAddCustomerPage()
        {
            throw new PendingStepException();
        }

        [When(@"User enters Customer details Sunil Kamble sunit@gmail\.com (.*) India and Vasai")]
        public void WhenUserEntersCustomerDetailsSunilKambleSunitGmail_ComIndiaAndVasai(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"user enter details for settings (.*)")]
        public void WhenUserEnterDetailsForSettings(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"User clicks Update Settings button")]
        public void WhenUserClicksUpdateSettingsButton()
        {
            throw new PendingStepException();
        }

        [Then(@"Customer should get added")]
        public void ThenCustomerShouldGetAdded()
        {
            throw new PendingStepException();
        }
    }
}
