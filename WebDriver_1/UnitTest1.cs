using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver_1
{
       public class UnitTest1

    {
        IWebDriver driver;

       
            [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ukr.net");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Test]
        public void TestMethod1()
        {
            var windowHandle = driver.CurrentWindowHandle;

            IWebElement element = driver.FindElement(By.CssSelector("test css"));

            var elements = driver.FindElements(By.CssSelector("test css"));

            var allWinowhandlers = driver.WindowHandles;

            driver.SwitchTo().Window(windowHandle);

           
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        }
    }

