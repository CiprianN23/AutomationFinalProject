using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace AutomationFinalProject.PageObjects
{
    public partial class SearchedProductsPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;

        public SearchedProductsPage(IWebDriver driver)
        {
            _driver = driver;
            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        public void ClickOnSpecifiedProductByIndex(int index)
        {
            if (SearchedProductsList.Any() == false)
                return;

            if (index >= SearchedProductsList.Count())
                return;

            SearchedProductsList.ElementAt(index).Click();
        }

        public void SortProductsByText(string text)
        {
            SelectElement selectSort = new SelectElement(ProductSortDropDown);
            selectSort.SelectByText(text);
        }

        public void ClickOnSpecifiedProductRatingByIndex(int index)
        {
            if (ProductRatingList.Any() == false)
                return;

            if (index >= ProductRatingList.Count())
                return;

            // Button not clicked
            AdvancedProductFilterButton.Click();

            ProductRatingList.ElementAt(index).Click();
        }
    }
}