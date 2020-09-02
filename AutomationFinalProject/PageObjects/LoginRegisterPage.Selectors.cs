using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class LoginRegisterPage
    {
        private IWebElement LoginEmailTextField => _driver.FindElement(By.Id("email"));
        private IWebElement LoginPasswordTextField => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.XPath("//button[@class='btn button-custom-red' and contains(text(), 'Autentificare')]"));
        public IWebElement LoginInvalidError => _driver.FindElement(By.XPath("//div[@id='auth-login-wrapper']//p[@class='error-text']"));
    }
}
