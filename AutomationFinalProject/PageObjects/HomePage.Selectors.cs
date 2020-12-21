using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomationFinalProject.PageObjects
{
    public partial class HomePage
    {
        private IWebElement SearchBar => _driver.FindElement(By.Id("searchac"));

        private IWebElement ProductCategoryButton(string category) => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//ul[@id='top_menu']//a[text()='{category}']")));

        private IWebElement ProductSubCategoryButton(string category, string subCategory) => _driver.FindElement(By.XPath($"//ul[@id='top_menu']//a[contains(text(), '{category}')]/..//a[text()='{subCategory}']"));

        private IWebElement MyAccountButton => _driver.FindElement(By.Id("h_account_top"));
        private IWebElement WishListButton => _driver.FindElement(By.XPath("//nav[@id='topmenu']//a[contains(text(), 'Wishlist')]"));

        public IWebElement CategoryNamElement => _driver.FindElement(By.Id("category_name"));
    }
}