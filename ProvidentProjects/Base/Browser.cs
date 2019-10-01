using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentProjects.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        } 
        
        public void OpenPage(String url)
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(url);
        }    

        public void Logout()
        {
            _driver.Close();
        }

    }
}
