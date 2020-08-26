using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomationFinalProject.PageObjects
{
    public partial class HomePage
    {
        private IWebElement SearchBar => _driver.FindElement(By.Id("searchac"));
        private IWebElement ShoppingCartButton => _driver.FindElement(By.Id("shopping_cart_no"));
        private IWebElement SaveAsWhishlistButton => _driver.FindElement(By.Id("shopping-cart-save-whishlist"));
        private IWebElement PhoneCategoryButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("cat_1")));
        private IWebElement SmartphoneButton => _driver.FindElement(By.XPath("//li[@id='cat_1']//a[text()='Smartphone']"));
        private IWebElement BluetoothEarphonesButton => _driver.FindElement(By.XPath("//li[@id='cat_1']//a[text()='Casti Bluetooth']"));
        private IWebElement GamingCategoryButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("cat_4")));
        private IWebElement GameConsoleButton => _driver.FindElement(By.XPath("//li[@id='cat_4']//a[text()='Console jocuri']"));

    }
}