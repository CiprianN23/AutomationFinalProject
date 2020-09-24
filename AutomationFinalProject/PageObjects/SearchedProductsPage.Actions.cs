using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Threading;

namespace AutomationFinalProject.PageObjects
{
    public partial class SearchedProductsPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _driverWait;

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

            ScrollHelper.ScrollToView(_driver, SearchedProductsList.ElementAt(index));
            Thread.Sleep(1000);
            SearchedProductsList.ElementAt(index).Click();
        }

        public void SortProductsByText(string text)
        {
            SelectElement selectSort = new SelectElement(ProductSortDropDown);
            selectSort.SelectByText(text);
        }

        public void ClickOnSpecifiedFilterCategoryByText(string filterCategoryName)
        {
            ScrollHelper.ScrollToView(_driver, FilterCategoryButton(filterCategoryName));
            FilterCategoryButton(filterCategoryName).Click();
        }

        public void ClickOnSpecifiedFilterByText(string filterCategoryName, int filterIndex)
        {
            ClickOnSpecifiedFilterCategoryByText(filterCategoryName);

            if (FilterNameButton(filterCategoryName).Any() == false)
                return;

            if (filterIndex >= FilterNameButton(filterCategoryName).Count())
                return;

            FilterNameButton(filterCategoryName).ElementAt(filterIndex).Click();
        }

    }
}