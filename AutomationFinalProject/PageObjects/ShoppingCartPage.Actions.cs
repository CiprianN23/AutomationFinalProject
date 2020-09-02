using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class ShoppingCartPage
    {
        private IWebDriver _driver;

        public ShoppingCartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickOnWishListButton()
        {
            SaveAsWishlistButton.Click();
        }
    }
}