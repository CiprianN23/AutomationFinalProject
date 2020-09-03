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

        public void RegisterIntoApplication(string firstName, string lastName, string phoneNumber, string email, string password, string repeatPassword)
        {
            RegisterFirstNameTextField.SendKeys(firstName);
            RegisterLastNameTextField.SendKeys(lastName);
            RegisterPhoneNumberTextField.SendKeys(phoneNumber);
            RegisterEmailTextField.SendKeys(email);
            RegisterPasswordTextField.SendKeys(password);
            RegisterRepeatPasswordTextField.SendKeys(repeatPassword);
            ScrollHelper.ScrollToView(_driver, RegisterButton);
            RegisterButton.Click();
        }
    }
}
