using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class WishlistPage
    {
        private IWebDriver _driver;

        public WishlistPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}