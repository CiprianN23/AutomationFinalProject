using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void InputTextInSearchBar(string searchCriteria)
        {
            SearchBar.SendKeys(searchCriteria);
            SearchBar.SendKeys(Keys.Enter);
        }
    }
}