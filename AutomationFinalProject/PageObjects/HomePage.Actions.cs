using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}