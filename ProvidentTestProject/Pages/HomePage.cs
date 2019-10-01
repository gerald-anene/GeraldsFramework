using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using ProvidentProjects.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentTestProject.Pages
{
   public class HomePage: BasePage
    {
        [FindsBy(How =How.LinkText,Using = "Get a quote")]
        IWebElement lnkGetQuote { get; set; }

        [FindsBy(How = How.LinkText, Using = "My Account")]
        IWebElement lnkMyAccount { get; set; }
        
        public void clickGetAQuote()
        {
            lnkGetQuote.Click();
        }

        public void clickMyAccount()
        {
            lnkMyAccount.Click();
        }
    }
}
