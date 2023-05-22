using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject2.Drivers;


namespace SpecFlowProject2;

[Binding]
public class Travel
{
    [Given(@"I am on the home page")]
    public void GivenIAmOnTheHomePage()
    {
        DriverManager.GetDriver().Navigate().GoToUrl("https://phptravels.net");
        
    }

    [Given(@"I am on the registration page")]
    public void GivenIAmOnTheRegistrationPage()
    {
       DriverManager.GetDriver().FindElement(By.Id("ACCOUNT")).Click();
       DriverManager.GetDriver().FindElement(By.XPath("//a[.='Customer Login']")).Click();  
       DriverManager.GetDriver().Manage().Timeouts().ImplicitWait.Seconds.Equals(60);
       
    }
    [When(@"I fill in the registration form with valid information")]
    public void WhenIFillInTheRegistrationFormWithValidInformation()
    {
       DriverManager.GetDriver().FindElement(By.XPath("(//input[@name='email'])[1]")).SendKeys("et@gmail.com");
       DriverManager.GetDriver().FindElement(By.Name("password")).SendKeys("et");
       
       
    }
        
    [When(@"I submit the registration form")]
    public void WhenISubmitTheRegistrationForm()
    {
        DriverManager.GetDriver().FindElement(By.XPath("//button[.='Login']")).Click();
        
    }
 


    public void WaitForElementVisible(By locator, int timeoutInSeconds)
    {
        var wait = new WebDriverWait(DriverManager.GetDriver(), TimeSpan.FromSeconds(timeoutInSeconds));
        wait.Until(driver => driver.FindElement(locator).Displayed);
    }

        
    [Then(@"I should be redirected to the login page")]
    public void ThenIShouldBeRedirectedToTheLoginPage()
    {
        WaitForElementVisible(By.XPath("(//*[@id='fadein']/div[4]/div/div[2]/div[2]/div/div[1]/div[1])"), 10);
        string msg = DriverManager.GetDriver().FindElement(By.XPath("(//*[@id='fadein']/div[4]/div/div[2]/div[2]/div/div[1]/div[1])")).Text;
        Assert.AreEqual("Wrong credentials. try again!", msg);
    }

        
    [Then(@"I should see a success message")]
    public void ThenIShouldSeeASuccessMessage()
    {
        DriverManager.GetDriver().FindElement(By.XPath("//div[.='Invalid Email or Password']")).Displayed.Equals(false);
    }
}