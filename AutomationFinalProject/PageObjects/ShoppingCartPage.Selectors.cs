using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class ShoppingCartPage
    {
        private IWebElement SaveAsWishlistButton => _driver.FindElement(By.XPath("//form[@id='cart_form']//b[contains(text(), 'wishlist')]/.."));
        private IWebElement EmptyShoppingCartButton => _driver.FindElement(By.XPath("//form[@id='cart_form']//b[contains(text(), 'Goleste')]/.."));
        private IWebElement UpdateQuantityButton => _driver.FindElement(By.XPath("//form[@id='cart_form']//b[contains(text(), 'Actualizeaza')]/.."));
        private IWebElement FirstQuanityTextField => _driver.FindElement(By.Id("//td[@class='ct-quantity']//input[contains(@name, '[1][qty]')]"));
    }
}