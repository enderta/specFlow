using OpenQA.Selenium;

using SpecFlowProject2.Drivers;
using SpecFlowProject2.Pages;

namespace SpecFlowProject2.Steps;

public static class Login
{
  public static void Demo()
  {
  var driver = DriverManager.GetDriver();
  var loginPage = new LoginPage(driver);
  loginPage.GoTo();
  loginPage.ClickLoginButton();
  loginPage.EnterUsername("standard_user");
  loginPage.EnterPassword("secret_sauce");
  loginPage.ClickLoginButton();
  loginPage.VerifyErrorMessage("Epic sadface: Username is required");
  
  }
  
}