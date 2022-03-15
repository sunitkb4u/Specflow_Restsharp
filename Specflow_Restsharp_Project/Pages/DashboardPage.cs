using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specflow_Practice.Pages
{
    public class DashboardPage
    {
        IWebDriver driver;
        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement accountsLink => driver.FindElement(By.XPath("//*[contains(text(),'Accounts')]"));
        public IWebElement customersLink => driver.FindElement(By.XPath("//a[text()='Customers']"));
        public IWebElement dasboardTesxt => driver.FindElement(By.XPath("//div[contains(text(),'Dashboard')]"));

        public IWebElement logoutButton => driver.FindElement(By.XPath("//*[@id='logout']/a"));
    }
}
