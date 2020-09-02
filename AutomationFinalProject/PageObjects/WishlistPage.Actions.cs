using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class WishlistPage
    {
        private IWebDriver _driver;

        public WishlistPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void CreateWishlist(string wishlistName, string wishlistComment, string extraInfo, string customerName, string customerEmail)
        {
            WishlistNameTextField.SendKeys(wishlistName);
            WishlistCommentTextField.SendKeys(wishlistComment);
            WishlsitExtraInfoTextField.SendKeys(extraInfo);
            ScrollHelper.ScrollToView(_driver, WishlistCustomerNameTextField);
            WishlistCustomerNameTextField.SendKeys(customerName);
            WishlistCustomerEmailTextField.SendKeys(customerEmail);
            WishlistConfidentialityCheckBox.Click();

            // Wishlist save disabled because is live app
            //WishListSaveButton.Click();
        }
    }
}