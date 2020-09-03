using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomationFinalProject.PageObjects
{
    public partial class ProductOverviewPage
    {
        private IWebElement AddToCartButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".btn.btn-md.button-green")));
        public IWebElement ProductNotInStockError => _driver.FindElement(By.XPath("//p[@id='pi_availability']//b[contains(text(), 'Nu este in stoc')]"));
    }
}