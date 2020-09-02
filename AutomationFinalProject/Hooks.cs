using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFinalProject
{
    public class Hooks
    {
        protected IWebDriver Driver { get; private set; }

        [SetUp]
        public void SetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.pcgarage.ro/");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}