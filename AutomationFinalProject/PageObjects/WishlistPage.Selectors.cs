using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class WishlistPage
    {
        private IWebElement WishlistNameTextField => _driver.FindElement(By.Id("wishlist_name"));
        private IWebElement WishlistCommentTextField => _driver.FindElement(By.Id("customer_comment"));
        private IWebElement WishlsitExtraInfoTextField => _driver.FindElement(By.Id("extra_info"));
        private IWebElement WishlistCustomerNameTextField => _driver.FindElement(By.Id("customer_name"));
        private IWebElement WishlistCustomerEmailTextField => _driver.FindElement(By.Id("email"));
        private IWebElement WishlistConfidentialityCheckBox => _driver.FindElement(By.CssSelector(".label-block"));
    }
}