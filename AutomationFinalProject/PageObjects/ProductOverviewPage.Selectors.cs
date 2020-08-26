using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomationFinalProject.PageObjects
{
    public partial class ProductOverviewPage
    {
        private IWebElement AddToCartButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".btn.btn-md.button-green")));
        private IWebElement AddToWhishlistButton => _driver.FindElement(By.Id("addto_plus"));
        private IWebElement CreateWhishListButton => _driver.FindElement(By.XPath("//div[@id='addto_content']//a"));
    }
}