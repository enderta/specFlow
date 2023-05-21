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
       private readonly IWebDriver driver;

        public Hooks(IWebDriver driver)
        {
            this.driver = driver;
        }

        [BeforeScenario ("wip")]
        public void BeforeScenario()
        {
            var driver = DriverManager.GetDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario ("wip")]
        public void AfterScenario()
        {
            var driver = DriverManager.GetDriver();
            driver.Quit();
        }
    }
}