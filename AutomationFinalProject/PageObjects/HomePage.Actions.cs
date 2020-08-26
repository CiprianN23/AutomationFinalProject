using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

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

        public void GoToSmartphoneCategory()
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(PhoneCategoryButton).Perform();
            SmartphoneButton.Click();
        }

        public void GoToBluetoothEarphoneCategory()
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(PhoneCategoryButton).Perform();
            BluetoothEarphonesButton.Click();
        }

        public void GoToGameConsoleCategory()
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(GamingCategoryButton).Perform();
            GameConsoleButton.Click();
        }
    }
}