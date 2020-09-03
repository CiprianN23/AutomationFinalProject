using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class ShoppingCartPage
    {
        private IWebElement SaveAsWishlistButton => _driver.FindElement(By.XPath("//form[@id='cart_form']//b[contains(text(), 'wishlist')]/.."));
        public IWebElement EmptyShoppingCartButton => _driver.FindElement(By.XPath("//form[@id='cart_form']//b[contains(text(), 'Goleste')]/.."));
        public IWebElement EmptyShoppingCartMessage => _driver.FindElement(By.XPath("//div[@id='cart_left']//b[contains(text(), 'Cosul tau de cumparaturi este gol')]"));
        private IWebElement UpdateQuantityButton => _driver.FindElement(By.XPath("//form[@id='cart_form']//b[contains(text(), 'Actualizeaza')]/.."));
        private IWebElement FirstQuanityTextField => _driver.FindElement(By.XPath("//td[@class='ct-quantity']//input[contains(@name, '[1][qty]')]"));
    }
}