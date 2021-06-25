using OpenQA.Selenium;

namespace AutomationFinalProject.PageObjects
{
    public partial class LoginRegisterPage
    {
        private IWebElement LoginEmailTextField => _driver.FindElement(By.Id("email"));
        private IWebElement LoginPasswordTextField => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.XPath("//button[@class='btn button-custom-red' and contains(text(), 'Autentificare')]"));
        public IWebElement LoginInvalidError => _driver.FindElement(By.XPath("//div[@id='auth-login-wrapper']//p[@class='error-text']"));
        public IWebElement LoginSuccessElement => _driver.FindElement(By.XPath("//div//h4[contains(text(), 'Este necesara confirmarea autentificarii!')]"));

        private IWebElement RegisterFirstNameTextField => _driver.FindElement(By.Id("newfirstname"));
        private IWebElement RegisterLastNameTextField => _driver.FindElement(By.Id("newlastname"));
        private IWebElement RegisterPhoneNumberTextField => _driver.FindElement(By.Id("telephone"));
        private IWebElement RegisterEmailTextField => _driver.FindElement(By.Id("newemail"));
        private IWebElement RegisterPasswordTextField => _driver.FindElement(By.Id("newpassword"));
        private IWebElement RegisterRepeatPasswordTextField => _driver.FindElement(By.Id("newpasswordretype"));
        public IWebElement RegisterConfidentialityError => _driver.FindElement(By.Id("confidentialitate-error"));
        private IWebElement RegisterButton => _driver.FindElement(By.XPath("//button[@class='btn button-custom-red' and contains(text(), 'Creeaza cont')]"));
    }
}