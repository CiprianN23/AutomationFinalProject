using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class WishListPage
    {
        private readonly IWebDriver _driver;

        public WishListPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SearchForWishList(string wishListName)
        {
            WishListSearchBar.SendKeys(wishListName);
            ScrollHelper.ScrollToView(_driver, WishListSearchButton);
            WishListSearchButton.Click();
        }
    }
}