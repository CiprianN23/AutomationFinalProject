using System.Linq;
using AutomationFinalProject.PageObjects;
using NUnit.Framework;

namespace AutomationFinalProject
{
    public class Tests : Hooks
    {
        [Test]
        public void AddProductToCart()
        {
            HomePage myHomePage = new HomePage(Driver);
            SearchedProductsPage mySearchedProductsPage = new SearchedProductsPage(Driver);
            ProductOverviewPage myProductOverviewPage = new ProductOverviewPage(Driver);
            ShoppingCartPage myShoppingCartPage = new ShoppingCartPage(Driver);

            myHomePage.ClickOnProductSubCategory("Mobile", "Smartphone");
            mySearchedProductsPage.SortProductsByText("Rating clienti");
            mySearchedProductsPage.ClickOnSpecifiedProductByIndex(1);
            myProductOverviewPage.ClickOnAddToShoppingCartButton();
            Assert.IsTrue(myShoppingCartPage.EmptyShoppingCartButton.Displayed);
        }

        [Test]
        public void CreateWishlsitWithCartProducts()
        {
            HomePage myHomePage = new HomePage(Driver);
            SearchedProductsPage mySearchedProductsPage = new SearchedProductsPage(Driver);
            ProductOverviewPage myProductOverviewPage = new ProductOverviewPage(Driver);
            ShoppingCartPage myShoppingCartPage = new ShoppingCartPage(Driver);
            CreateWishlistPage myWishlistPage = new CreateWishlistPage(Driver);

            myHomePage.ClickOnProductSubCategory("Componente", "Placi video");
            mySearchedProductsPage.SortProductsByText("Rating clienti");
            mySearchedProductsPage.ClickOnSpecifiedProductByIndex(0);
            myProductOverviewPage.ClickOnAddToShoppingCartButton();
            
            myHomePage.ClickOnProductSubCategory("Componente", "Procesoare");
            mySearchedProductsPage.SortProductsByText("Numar vizualizari");
            mySearchedProductsPage.ClickOnSpecifiedProductByIndex(1);
            myProductOverviewPage.ClickOnAddToShoppingCartButton();

            myHomePage.ClickOnProductSubCategory("Componente", "Placi de baza");
            mySearchedProductsPage.SortProductsByText("Top vanzari");
            mySearchedProductsPage.ClickOnSpecifiedProductByIndex(0);
            myProductOverviewPage.ClickOnAddToShoppingCartButton();

            myShoppingCartPage.ClickOnWishListButton();

            myWishlistPage.CreateWishlist("Automation test", "This a wishlist create by automation testing", "Autoamtion", "C#", "automationc#@someemail.com");
            Assert.IsTrue(myWishlistPage.WishlistConfidentialityCheckBox.Displayed);
        }

        [Test]
        public void LoginWithInvalidData()
        {
            HomePage myHomePage = new HomePage(Driver);
            LoginRegisterPage myLoginRegisterPage = new LoginRegisterPage(Driver);

            myHomePage.GoToLoginPage();
            myLoginRegisterPage.LoginIntoApplication("automationtest@somemail.com", "gegegergaswe");
            Assert.IsTrue(myLoginRegisterPage.LoginInvalidError.Displayed);
        }

        [Test]
        public void RegisterWithoutClickingConfidentialityBox()
        {
            HomePage myHomePage = new HomePage(Driver);
            LoginRegisterPage myLoginRegisterPage = new LoginRegisterPage(Driver);

            myHomePage.GoToLoginPage();
            myLoginRegisterPage.RegisterIntoApplication("Test", "Test", "0711111111", "automation@someemail.com", "123456", "123456");
            Assert.IsTrue(myLoginRegisterPage.RegisterConfidentialityError.Displayed);
        }

        [Test]
        public void LoginWithValidData()
        {
            HomePage myHomePage = new HomePage(Driver);
            LoginRegisterPage myLoginRegisterPage = new LoginRegisterPage(Driver);

            myHomePage.GoToLoginPage();
            myLoginRegisterPage.LoginIntoApplication("automation2020@gmail.com", "123456");
            Assert.IsTrue(myLoginRegisterPage.LoginSuccessElement.Displayed);
        }

        [Test]
        public void CheckSpecificProductAvailability()
        {
            HomePage myHomePage = new HomePage(Driver);
            ProductOverviewPage myProductOverviewPage = new ProductOverviewPage(Driver);

            myHomePage.InputTextInSearchBar("Monitor LED ViewSonic VP3881 Curbat 37.5 inch 5ms Negru 60 Hz");
            Assert.IsTrue(myProductOverviewPage.ProductNotInStockError.Displayed);
        }

        [Test]
        public void EmptyShoppingCart()
        {
            HomePage myHomePage = new HomePage(Driver);
            SearchedProductsPage mySearchedProductsPage = new SearchedProductsPage(Driver);
            ProductOverviewPage myProductOverviewPage = new ProductOverviewPage(Driver);
            ShoppingCartPage myShoppingCartPage = new ShoppingCartPage(Driver);

            myHomePage.ClickOnProductSubCategory("Mobile", "Smartphone");
            mySearchedProductsPage.ClickOnSpecifiedProductByIndex(3);
            myProductOverviewPage.ClickOnAddToShoppingCartButton();
            myShoppingCartPage.ClickOnEmptyCartButton();
            Assert.IsTrue(myShoppingCartPage.EmptyShoppingCartMessage.Displayed);
        }

        [Test]
        public void ClickOnEveryProductCategoryButton()
        {
            HomePage myhHomePage = new HomePage(Driver);

            myhHomePage.ClickOnProductCategory("Laptop");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Mobile");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Sisteme Gaming & Office");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Componente");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Gaming");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Televizoare");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Periferice & Monitoare");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Software");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Printing");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Retelistica & UPS");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Audio/Video");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Casa & ingrijire");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Home Gadgets");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Sport & Sanatate");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Auto & Calatorii");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);

            myhHomePage.ClickOnProductCategory("Servicii");
            Assert.IsTrue(myhHomePage.CategoryNamElement.Displayed);
        }

        [Test]
        public void SearchInvalidWishList()
        {
            HomePage myHomePage = new HomePage(Driver);
            WishListPage myWishListPage = new WishListPage(Driver);

            myHomePage.GoToWishListPage();
            myWishListPage.SearchForWishList("euijgerugherhgkfwi914u8");
            Assert.IsTrue(myWishListPage.NoWishListFoundText.Displayed);
        }

        [Test]
        public void CheckFilters()
        {
            HomePage myHomePage = new HomePage(Driver);
            SearchedProductsPage mySearchedProductsPage = new SearchedProductsPage(Driver);

            myHomePage.ClickOnProductSubCategory("Mobile", "Smartphone");
            mySearchedProductsPage.ClickOnSpecifiedFilterByText("Pret", 0);
            mySearchedProductsPage.ClickOnSpecifiedFilterByText("Producator", 0);
            mySearchedProductsPage.ClickOnSpecifiedFilterByText("Garantie comerciala", 0);

            Assert.IsTrue(mySearchedProductsPage.SelectedFiltersList.Count() == 3);
        }
    }
}