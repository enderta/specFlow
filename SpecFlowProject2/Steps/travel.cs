using OpenQA.Selenium;
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
       DriverManager.GetDriver().Manage().Timeouts().ImplicitWait.Seconds.
    }
    [When(@"I fill in the registration form with valid information")]
    public void WhenIFillInTheRegistrationFormWithValidInformation()
    {
       
    }
        
    [When(@"I submit the registration form")]
    public void WhenISubmitTheRegistrationForm()
    {
        _scenarioContext.Pending();
    }
        
    [Then(@"I should be redirected to the login page")]
    public void ThenIShouldBeRedirectedToTheLoginPage()
    {
        _scenarioContext.Pending();
    }
        
    [Then(@"I should see a success message")]
    public void ThenIShouldSeeASuccessMessage()
    {
        _scenarioContext.Pending();
    }
}