using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class CreateWishlistPage
    {
        private IWebElement WishlistNameTextField => _driver.FindElement(By.Id("wishlist_name"));
        private IWebElement WishlistCommentTextField => _driver.FindElement(By.Id("customer_comment"));
        private IWebElement WishlsitExtraInfoTextField => _driver.FindElement(By.Id("extra_info"));
        private IWebElement WishlistCustomerNameTextField => _driver.FindElement(By.Id("customer_name"));
        private IWebElement WishlistCustomerEmailTextField => _driver.FindElement(By.Id("email"));
        public IWebElement WishlistConfidentialityCheckBox => _driver.FindElement(By.CssSelector(".label-block"));

        // Elements to check if wishlist is saved/ to save wishlist
        // Unused because is live app
        private IWebElement WishListSaveButton => _driver.FindElement(By.XPath("//button[@type='submit'][contains(text(), 'Salveaza wishlist')]"));

        public IWebElement WishListIsSaved => _driver.FindElement(By.XPath("//p[contains(text(), 'Puteti vizualiza wishlist-ul creat')]"));
    }
}