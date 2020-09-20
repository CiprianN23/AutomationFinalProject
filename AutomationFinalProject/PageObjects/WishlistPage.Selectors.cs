using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class WishListPage
    {
        private IWebElement WishListSearchBar => _driver.FindElement(By.Id("wish_name"));
        private IWebElement WishListSearchButton => _driver.FindElement(By.Id("wishlist_search_button"));

        public IWebElement NoWishListFoundText => _driver.FindElement(By.XPath("//div[@id='content_wrapper']//p[@class='error-text']"));
    }
}
