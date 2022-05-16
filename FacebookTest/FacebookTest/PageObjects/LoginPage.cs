using OpenQA.Selenium;
using FacebookTest.Base;
using SeleniumExtras.PageObjects;

namespace FacebookTest.PageObjects
{
    public class LoginPage : BaseTest
    {
        //[FindsBy(How = How.Id, Using = "email")]
        //private IWebElement usernameTextbox { get; set; }
        public IWebElement usernameTextbox = webDriver.FindElement(By.Id("email"));
        public IWebElement passwordTextbox = webDriver.FindElement(By.Id("pass"));
        public IWebElement loginButton = webDriver.FindElement(By.Name("Name"));

        //[FindsBy(How = How.Id, Using = "pass")]
        //private IWebElement passwordTextbox { get; set; }

        //[FindsBy(How = How.Name, Using = "login")]
        //private IWebElement loginButton { get; set; }

        public LoginPage()
        {
            PageFactory.InitElements(webDriver, this);
        }

        public void Login(string username, string password)
        {
            usernameTextbox.SendKeys(username);
            passwordTextbox.SendKeys(password);
            loginButton.Click();
        }
    }
}
