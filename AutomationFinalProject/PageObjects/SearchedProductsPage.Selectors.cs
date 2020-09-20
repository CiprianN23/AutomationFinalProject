using OpenQA.Selenium;
using System.Collections.Generic;
using SeleniumExtras.WaitHelpers;

namespace AutomationFinalProject.PageObjects
{
    public partial class SearchedProductsPage
    {
        private IEnumerable<IWebElement> SearchedProductsList => 
            _driverWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[@id='wrapper_listing_products']//div[@class='product_box_name']//a")));

        private IWebElement ProductSortDropDown => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("sortsel")));

        private IWebElement FilterCategoryButton(string filterCategoryName) => _driver.FindElement(By.XPath($"//span[@class='filters_name' and text()='{filterCategoryName}']"));
        private IEnumerable<IWebElement> FilterNameButton(string filterCategoryname) => 
            _driver.FindElements(By.XPath($"//span[@class='filters_name' and text()='{filterCategoryname}']//..//..//..//a[@class='filters_name_num']"));

        public IEnumerable<IWebElement> SelectedFiltersList => 
            _driver.FindElements(By.XPath("//div[@id='filters_standard']//ul[@class='list-unstyled filters-applied']//a[not(contains(text(), 'Sterge toate filtrele'))]"));
    }
}