using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomationFinalProject.PageObjects
{
    public partial class HomePage
    {
        private IWebElement SearchBar => _driver.FindElement(By.Id("searchac"));
        private IWebElement ShoppingCartButton => _driver.FindElement(By.Id("shopping_cart_no"));
        private IWebElement ProductCategoryButton(string category) => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//ul[@id='top_menu']//a[text()='{category}']")));
        private IWebElement ProductSubCategoryButton(string category, string subCategory) => _driver.FindElement(By.XPath($"//ul[@id='top_menu']//a[contains(text(), '{category}')]/..//a[text()='{subCategory}']"));
    }
}