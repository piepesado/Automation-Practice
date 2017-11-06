using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace Expedia_Testing
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.expedia.com/");
        }
        [Test]
        public void TestMethod1()
        {
            driver.Manage().Window.Maximize();
            Assert.IsTrue(driver.Title.Contains("Flight"));
            Thread.Sleep(5000);
        }
        [TearDown]
        public void FinishTest()
        {
            driver.Quit();
        }
    }
}
