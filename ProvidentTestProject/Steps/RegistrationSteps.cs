using NBehave.Narrator.Framework;
using NBehave.Narrator.Framework.Hooks;
using OpenQA.Selenium.Support.PageObjects;
using ProvidentProjects.Base;
using ProvidentProjects.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidentTestProject.Pages
{
    [ActionSteps]
    public class LoginSteps: BaseStep
    {
        private HomePage homePage;
        public LoginSteps()
        {
            homePage = new HomePage();
            PageFactory.InitElements(_driver, homePage);
        }
        [Given("I am logged in to provident website")]
        public void NavigateToSite()
        {
            OpenPage();
        }

        [Given("I click on my account link")]
        public void ClickMyAccountLink()
        {
            homePage.clickMyAccount();
        }

        [Given("I go home")]
        [Given("you go home")]
        public void DoNothing()
        {
            
        }
    }
}
