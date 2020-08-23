using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class IttemOverviewPage
    {
        private IWebElement AddToCartButton => _driver.FindElement(By.CssSelector(".btn.btn-md.button-green"));
        private IWebElement AddToWhishlistButton => _driver.FindElement(By.Id("addto_plus"));
        private IWebElement CreateWhishListButton => _driver.FindElement(By.XPath("//div[@id='addto_content']//a"));
    }
}