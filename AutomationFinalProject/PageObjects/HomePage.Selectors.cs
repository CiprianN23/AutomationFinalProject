using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class HomePage
    {
        private IWebElement SearchBar => _driver.FindElement(By.Id("searchac"));
        private IWebElement ShoppingCartButton => _driver.FindElement(By.Id("shopping_cart_no"));
        private IWebElement SaveAsWhishlistButton => _driver.FindElement(By.Id("shopping-cart-save-whishlist"));
    }
}