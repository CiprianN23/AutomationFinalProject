using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class LoginRegisterPage
    {
        private IWebDriver _driver;
        public LoginRegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void LoginIntoApplication(string email, string password)
        {
            LoginEmailTextField.SendKeys(email);
            LoginPasswordTextField.SendKeys(password);
            LoginButton.Click();
        }
    }
}
