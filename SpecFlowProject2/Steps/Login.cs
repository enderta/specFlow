using SpecFlowProject2.Pages;

namespace SpecFlowProject2;

[Binding]
public class Login
{
    [Given(@"user is on the sauce labs page")]
    public void GivenUserIsOnTheSauceLabsPage()
    {
       LoginPage.GoTo();
    }

    [When(@"user enters username and password")]
    public void WhenUserEntersUsernameAndPassword()
    {
        LoginPage.Login("user", "password");
    }

    [Then(@"user should be able to login")]
    public void ThenUserShouldBeAbleToLogin()
    {
        LoginPage.VerifyUserIsOnLoginPage();
    }
}