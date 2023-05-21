using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject2.Steps;


namespace SpecFlowProject2;

public class Demo
{
    [Test]
    public void Test1()
    {
       Login.Demo();
    }
}