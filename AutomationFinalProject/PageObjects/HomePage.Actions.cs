using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Interactions;

namespace AutomationFinalProject.PageObjects
{
    public partial class HomePage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void InputTextInSearchBar(string searchCriteria)
        {
            SearchBar.SendKeys(searchCriteria);
            SearchBar.SendKeys(Keys.Enter);
        }

        public void ClickOnProductCategory(string category, string subCategory)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(ProductCategoryButton(category)).Perform();
            ProductSubCategoryButton(category, subCategory).Click();
        }

        public void GoToLoginPage()
        {
            MyAccountButton.Click();
        }
    }
}