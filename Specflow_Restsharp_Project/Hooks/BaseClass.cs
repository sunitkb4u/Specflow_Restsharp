using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Specflow_Practice.Hooks
{
    public class BaseClass
    {
        public static IWebDriver myDriver;
        public void EnterText(IWebElement element, string text)
        {
            element.Click();
            element.Clear();
            element.Submit();   
        }

        public void SelectDropdownByValue(IWebElement element, string value)
        {
             
        }


        public void SelectDropdownByVisibleText(IWebElement element, String visibleText)
        {

        }


        public void SelectDropdownByIndex(IWebElement element, String index)
        {

        }
    }
}
