using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using ProvidentProjects.Config;
using ProvidentProjects.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProvidentProjects.Base
{
    public class BaseStep : Base
    {
        protected static IWebDriver _driver = new ChromeDriver();
        private Browser browser;

        public BaseStep()
        {
            
            browser = new Browser(_driver);
        }
        public virtual void OpenPage()
        {
            browser.OpenPage("https://www.providentinsurance.co.uk/");
            
        }

        public virtual void Logout()
        {
            browser.Logout();
        }
    }
}
