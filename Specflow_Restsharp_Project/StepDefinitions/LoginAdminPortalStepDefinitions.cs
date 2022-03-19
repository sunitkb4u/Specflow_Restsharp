using NUnit.Framework;
using Specflow_Practice.Hooks;
using Specflow_Practice.Pages;
using System;
using TechTalk.SpecFlow;

namespace Specflow_Restsharp_Project.StepDefinitions
{
    [Binding]
    public class LoginAdminPortalStepDefinitions:BaseClass
    {
        [Given(@"User is on admin portal login page")]
        public void GivenUserIsOnAdminPortalLoginPage()
        {
            WebDriverClass webDriverClass = new WebDriverClass();
            webDriverClass.OpenApplication();
        }

        [When(@"User enters credential (.*) and (.*)")]
        public void WhenUserEntersCredential(string username, string password)
        {
            LoginPage loginPage = new LoginPage(myDriver);
            loginPage.usernameTextField.SendKeys(TestContext.Parameters.Get(username));
            loginPage.passwordTextField.SendKeys(TestContext.Parameters.Get(password));
        }

        [When(@"user clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            LoginPage login = new LoginPage(myDriver);
            login.loginButton.Click();
        }

        [Then(@"User should be logged in successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            DashboardPage dashboardPage = new DashboardPage(myDriver);
            System.Threading.Thread.Sleep(1000);
            Assert.IsTrue(dashboardPage.dasboardTesxt.Displayed, " User was not logged in successfully");
            WebDriverClass webDriverClass = new WebDriverClass();
            webDriverClass.CloseBrowser(myDriver);
        }


        [Then(@"User should get (.*)")]
        public void ThenUserShouldGet(string error)
        {
            throw new PendingStepException();
        }
    }
}
