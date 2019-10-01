using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehave.Narrator.Framework.Hooks;
using log4net;
using NBehave.Narrator.Framework;
using Ninject;
using ProvidentProjects.Config;
using ProvidentProjects.Base;
using ProvidentProjects.Helpers;

namespace ProvidentProjects.generalSteps
{
    [Hooks]
    public class GeneralSteps:BaseStep
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(GeneralSteps));

        public GeneralSteps()
        {
            Factory.Instance.Inject(this);
        }

        [NBehave.Narrator.Framework.Hooks.BeforeStep]
        public void BeforeStep()
        {
            // TODO: can we tell if a step has failed here??? If so, don't log the step.
            logger.Info(StepContext.Current.Step);
        }

        [NBehave.Narrator.Framework.Hooks.BeforeScenario]
        public void BeforeScenario()
        {  
           // LogHelpers.Write("Opened the browser !!!");
        }

        [NBehave.Narrator.Framework.Hooks.AfterScenario]
        public void AfterScenario()
        {
            try
            {
                logger.InfoFormat("Scenario execution complete: {0}", ScenarioContext.Current.ScenarioTitle);
                 Logout();
                // SignedOutPage.WaitUntilSignedOut();

            }
            catch (Exception e)
            {
                logger.Error("An exception occurred attempting to logout:", e);
            }
        }

    }
}
