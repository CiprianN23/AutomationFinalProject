using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationFinalProject
{
    public class Hooks
    {
        protected IWebDriver Driver { get; init; }

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
            TakeScreenshot();
            Driver.Quit();
        }

        private void TakeScreenshot()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status != TestStatus.Failed)
                return;

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            string title = TestContext.CurrentContext.Test.MethodName;
            Screenshot image = ((ITakesScreenshot)Driver).GetScreenshot();
            image.SaveAsFile($"C:\\testscreenshot\\{title} {timestamp}.jpg", ScreenshotImageFormat.Jpeg);
        }
    }
}