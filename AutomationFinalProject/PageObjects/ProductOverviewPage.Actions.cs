using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFinalProject.PageObjects
{
    public partial class ProductOverviewPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public ProductOverviewPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void ClickOnAddToShoppingCartButton()
        {
            ScrollHelper.ScrollToView(_driver, AddToCartButton);
            AddToCartButton.Click();
        }
    }
}