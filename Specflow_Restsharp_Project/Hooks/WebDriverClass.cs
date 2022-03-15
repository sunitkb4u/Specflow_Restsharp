using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Specflow_Practice.Hooks
{
    public class WebDriverClass: BaseClass
    {
        IWebDriver driver;
        public void OpenApplication()
        {
            String browser = TestContext.Parameters.Get("browser");
            if (browser.Contains("Chrome"))
            {
                myDriver = new ChromeDriver();
                myDriver.Manage().Window.Maximize();
                TimeSpan pageLoad = myDriver.Manage().Timeouts().PageLoad;
                myDriver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));
            } else if (browser.Contains("Firefox"))
            {
                myDriver = new FirefoxDriver();
                myDriver.Manage().Window.Maximize();
                myDriver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));
            }
            else
            {
                myDriver = new EdgeDriver();
                myDriver.Manage().Window.Maximize();
                myDriver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));
            }
            
        }

        public void CloseBrowser(IWebDriver drive)
        {
            try
            {
                myDriver.Quit();
                Process[] chromeDriverProcess = Process.GetProcessesByName("chromedriver");
                foreach (var process in chromeDriverProcess)
                {
                    process.Kill();
                }

                Console.WriteLine("Test successfully completed");
            }
            catch (WebDriverException testClosingException)
            {

                Console.WriteLine("Driver failed to close process of browser: {0}", testClosingException.Message); 
            }
        }
    }
}
