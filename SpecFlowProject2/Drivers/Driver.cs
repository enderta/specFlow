using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject2.Drivers
{
    public static class DriverManager
    {
        private static WebDriver driver;

        public static WebDriver GetDriver()
        {
            if (driver == null)
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
            }

            return driver;
        }
    }
  
  
}