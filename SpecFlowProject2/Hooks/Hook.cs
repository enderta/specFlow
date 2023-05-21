using System;
using BoDi;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = DriverManager.GetDriver();
            objectContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = objectContainer.Resolve<IWebDriver>();
            driver.Quit();
        }
    }
}