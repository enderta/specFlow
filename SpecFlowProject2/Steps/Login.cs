using OpenQA.Selenium;
using SpecFlowProject2.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class SauceSteps
    {
        private readonly LoginPage _loginPage;
        private readonly WebDriver _driver;
        
        public SauceSteps(IWebDriver driver)
        {
            _driver = (WebDriver) driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given("user is on the sauce labs page")]
        public void GivenUserIsOnTheSauceLabsPage()
        {
            _loginPage.GoTo();
        }

        [When("user enters username and password")]
        public void WhenUserEntersUsernameAndPassword()
        {
           

            _loginPage.EnterUsername("standard_user");
            _loginPage.EnterPassword("secret_sauce");
        }

        [Then("user should be able to login")]
        public void ThenUserShouldBeAbleToLogin()
        {
            _loginPage.ClickLoginButton();
        }
    }
}