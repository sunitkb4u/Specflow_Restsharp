using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specflow_Restsharp_Project.Hooks
{
    public class AssertClass
    {
        public bool IfElementExist(IWebElement element)
        {
            bool present;
            
                try
                {
                present = element.Displayed;
                }
                catch (Exception ex)
                {
                    present = false;
                }
                return present;
            
        }
    }
}
