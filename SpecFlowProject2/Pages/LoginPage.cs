using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject2.Utilities;

namespace SpecFlowProject2.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly By _usernameField = By.Id("user-name");
        private readonly By _passwordField = By.Id("password");
        private readonly By _loginButton = By.Id("login-button");
        private readonly By _errorMessage = By.CssSelector("[data-test='error']");
        private readonly string url = ConfigurationReader.GetAppSetting("url");

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
        }
        
        public void GoTo()
        {
            _driver.Navigate().GoToUrl(url);
        }
        

    public void EnterUsername(string username)
    {
        _driver.FindElement(_usernameField).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        _driver.FindElement(_passwordField).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        _driver.FindElement(_loginButton).Click();
    }

    public void VerifyErrorMessage(string expectedErrorMessage)
    {
        var actualErrorMessage = _driver.FindElement(_errorMessage).Text;
        Assert.AreEqual(expectedErrorMessage, actualErrorMessage);
    }

    }
}