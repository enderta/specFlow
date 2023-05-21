using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject2.Drivers
{
  public static class DriverManager
  {
    private static IWebDriver driver;

    public static IWebDriver GetDriver()
    {
      if (driver == null)
      {
        // Initialize the driver here
        driver = new ChromeDriver();
      }
      return driver;
    }
  }
  
  
}