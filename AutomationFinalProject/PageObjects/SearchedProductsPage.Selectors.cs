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

        private IWebElement AdvancedProductFilterButton =>
            _driverWait.Until(ExpectedConditions.ElementIsVisible(By.Id("filters_advanced_link")));

        private IEnumerable<IWebElement> ProductRatingList =>
            _driverWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[@class='panel panel-default']//b[contains(text(), 'Rating')]/ancestor::node()[3]//li")));
    }
}