using NUnit.Framework;
using SpecFlowProject2.Drivers;

namespace SpecFlowProject2.Steps;

public class Demo
{
  [Test]
  public void Test()
  {
    var driver = DriverManager.GetDriver();
    driver.Navigate().GoToUrl("https://www.google.com");
    
}
}