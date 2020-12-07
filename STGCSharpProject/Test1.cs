using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestFixture]
    public class Test1
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(5000);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
