using AutomationFinalProject.PageObjects;
using NUnit.Framework;

namespace AutomationFinalProject
{
    public class Tests : Hooks
    {
        [Test]
        public void Test1()
        {
            HomePage myHomePage = new HomePage(Driver);
            myHomePage.InputTextInSearchBar("webcam");

            SearchedProductsPage searchedProductsPage = new SearchedProductsPage(Driver);
            //searchedProductsPage.SortProductsByText("Pret crescator");
            searchedProductsPage.ClickOnSpecifiedProductRatingByIndex(0);
            searchedProductsPage.ClickOnSpecifiedProductByIndex(2);
        }
    }
}