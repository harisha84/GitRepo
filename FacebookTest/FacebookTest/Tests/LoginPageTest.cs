using System;
using System.Collections.Generic;
using System.IO;
using FacebookTest.Base;
using FacebookTest.PageObjects;
using FacebookTest.TestDataObjects;
using FacebookTest.Utilities;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace FacebookTest.Tests
{
    public class LoginPageTest
    {
        ExtentHtmlReporter htmlReporter;
        ExtentReports reports;
        ExtentTest test;

        //[OneTimeSetUp]
        //public void SetupReports()
        //{
            //htmlReporter = new ExtentHtmlReporter(Properties.GetPropertry(Property.ReportsFolder) + "Report.html");
            //htmlReporter.Config.Theme = Theme.Standard;
            //htmlReporter.Config.DocumentTitle = "Login Test Report";
            //htmlReporter.Config.ReportName = "LoginTestReport";

            //reports = new ExtentReports();
            //reports.AttachReporter(htmlReporter);
        //}
        [SetUp]
        public void CreateInstance()
        {
            BaseTest.CreateBrowserInstance();

            //TestUtils.XMLSerializer<LoginPageData>(new LoginPageData(), Properties.GetPropertry(Property.TestDataXmlFolder) + "LoginData.xml");
        }
        public static IEnumerable<LoginPageData> GetLoginPageData()
        {
            yield return TestUtils.XmlDeserialize<LoginPageData>(Properties.GetPropertry(Property.TestDataXmlFolder) + "LoginData.xml");
        }

        //[TestCaseSource(nameof(GetLoginPageData))]
        [Test]
        public void LoginToFacebook()
        {
            //test = reports.CreateTest("Facebook Login Test");
            try
            {
                //BaseTest.log.Info("*******Inside Login test");
                LoginPage loginPage = new LoginPage();
                loginPage.Login("admin", "admin");
            }
            catch(Exception e)
            {
                //test.Fail(e.StackTrace);
                Console.WriteLine(e.StackTrace);
            }
        }
        
        //[TearDown]
        //public void TearDown()
        //{
            //if (BaseTest.webDriver != null)
            //{
                //BaseTest.webDriver.SwitchTo().Window(BaseTest.webDriver.WindowHandles[0]);
               //Remote.Eval()
                    
                //BaseTest.webDriver.Quit();
            //}
        //}
    }
}
