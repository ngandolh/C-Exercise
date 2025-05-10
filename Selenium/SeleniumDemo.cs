using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    internal class SeleniumDemo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\TESTER\\SeleniumC#");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void RunTest()
        {
            driver.Navigate().GoToUrl("https://anhtester.com/");

            Thread.Sleep(1000);
            driver.FindElement(By.Id("btn-login")).Click();

            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("autotest@mailinator.com");

            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("123456");

            driver.FindElement(By.Id("login")).Click();

            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("My Profile")).Click();

            Thread.Sleep(2000);
        }

        [TearDown]
        public void CloseTest()
        {
            driver.Quit();
        }
    }
}
