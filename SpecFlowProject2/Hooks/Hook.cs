
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;


namespace SpecFlowProject2.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario("wip")]
        public void BeforeScenario()
        {
            System.Console.WriteLine("BeforeScenario");
            //wait for one minute
            DriverManager.GetDriver().Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(60);
            //maximize the window
            DriverManager.GetDriver().Manage().Window.Maximize();
            //wait for one minute
            DriverManager.GetDriver().Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(60);
        }

        [AfterScenario("wip")]
        public void AfterScenario()
        {
            //implicit wait for one minute
            DriverManager.GetDriver().Quit();
        }
    }
}