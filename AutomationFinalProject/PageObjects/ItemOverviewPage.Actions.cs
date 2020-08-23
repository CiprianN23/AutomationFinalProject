using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class IttemOverviewPage
    {
        private IWebDriver _driver;

        public IttemOverviewPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}