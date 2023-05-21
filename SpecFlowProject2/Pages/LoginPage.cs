using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject2.Drivers;
using SpecFlowProject2.Utilities;

namespace SpecFlowProject2.Pages
{
    public static class LoginPage
    {
        private static readonly WebDriver _driver;
        private static readonly By _usernameField = By.Id("user-name");
        private static readonly By _passwordField = By.Id("password");
        private static readonly By _loginButton = By.Id("login-button");
        private static readonly By _errorMessage = By.CssSelector("[data-test='error']");
        private static readonly string url = "https://www.saucedemo.com/";

       
           static LoginPage()
            {
                _driver = DriverManager.GetDriver();
            }
           
            public static void GoTo()
            {
                _driver.Navigate().GoToUrl(url);
            }
            
            public static void Login(string username, string password)
            {
                _driver.FindElement(_usernameField).SendKeys(username);
                _driver.FindElement(_passwordField).SendKeys(password);
                _driver.FindElement(_loginButton).Click();
            }
          
            
            public static void VerifyErrorMessage()
            {
                Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", _driver.FindElement(_errorMessage).Text);
            }
            
            public static void VerifyUserIsOnLoginPage()
            {
                Assert.AreEqual("https://www.saucedemo.com/", _driver.Url);
            }
            
            
           

    }
}