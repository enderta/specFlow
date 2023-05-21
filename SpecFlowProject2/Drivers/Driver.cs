using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject2.Drivers
{
  public static class DriverManager
  {
    private static WebDriver driver;

    public static WebDriver GetDriver()
    {
      if (driver == null)
      {
        driver = new ChromeDriver();
      }

      return driver;
    }
  }
  
  
}