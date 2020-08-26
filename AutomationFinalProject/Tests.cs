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

        [Test]
        public void AddMultipleProductsToCart()
        {
            HomePage myHomePage = new HomePage(Driver);
            SearchedProductsPage mySearchedProductsPage = new SearchedProductsPage(Driver);
            ProductOverviewPage myProductOverviewPage = new ProductOverviewPage(Driver);

            myHomePage.GoToSmartphoneCategory();
            mySearchedProductsPage.SortProductsByText("Rating clienti");
            mySearchedProductsPage.ClickOnSpecifiedProductByIndex(1);
            myProductOverviewPage.ClickOnAddToShoppingCartButton();

            myHomePage.GoToBluetoothEarphoneCategory();
            mySearchedProductsPage.SortProductsByText("Top vanzari");
            mySearchedProductsPage.ClickOnSpecifiedProductByIndex(2);
            myProductOverviewPage.ClickOnAddToShoppingCartButton();

            myHomePage.GoToGameConsoleCategory();
            mySearchedProductsPage.SortProductsByText("Stoc si disponibilitate");
            mySearchedProductsPage.ClickOnSpecifiedProductByIndex(0);
            myProductOverviewPage.ClickOnAddToShoppingCartButton();
        }
    }
}