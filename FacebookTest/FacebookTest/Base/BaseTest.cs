using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using FacebookTest.Utilities;

namespace FacebookTest.Base
{
    public class BaseTest
    {
        public static IWebDriver webDriver;
        //public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public static void CreateBrowserInstance()
        {
            switch (Properties.GetPropertry(Property.BrowserType))
            {
                case "chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "IE":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }

            //CustomEventFiringWebDriver customEventFiringWebDriver = new CustomEventFiringWebDriver(webDriver);
            //webDriver = customEventFiringWebDriver.eventFiringWebDriver;

            webDriver.Manage().Cookies.DeleteAllCookies();
            webDriver.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 30);
            webDriver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl(Properties.GetPropertry(Property.Url));
        }

        public enum BrowserType
        {
            Chrome,
            IE,
            Firefox
        }
    }
}
