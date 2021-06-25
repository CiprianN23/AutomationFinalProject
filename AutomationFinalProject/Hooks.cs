using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationFinalProject
{
    public class Hooks
    {
        protected IWebDriver Driver { get; private set; }

        [SetUp]
        public void SetUp()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddExcludedArgument("enable-automation");
            chromeOptions.AddAdditionalOption("useAutomationExtension", false);
            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            chromeOptions.AddArgument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36");
            chromeOptions.AddArgument("--remote-debugging-port=9222");

            Driver = new ChromeDriver(chromeOptions);
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