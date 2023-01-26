using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using ProvidenceWebAppQA.util;
using System.Runtime;
using ProvidenceWebAppQA.pages;
using FluentAssertions;

namespace ProvidenceWebAppQA.tests
{
    class sampleTestClass
    {
        IWebDriver driver = null;
        TestDataManager testData = null;
        DriverManager dm = new DriverManager();
        HomePage homePage = null;
        MyAccountPage myAccountPage = null;

        public static void Main(string[] args)
        {
            Console.WriteLine("Main");
        }

        [OneTimeSetUp]
        public void initialize()
        {
            testData = TestDataManager.GetInstance;
            driver = dm.getDriver(testData.browserConfig);
            homePage = new HomePage(driver);
            myAccountPage= new MyAccountPage(driver);
        }

        [Test]
        public void testHomePage()
        {
            TestContext.WriteLine(String.Format("Launching App {0}", testData.AppURL));
            homePage.openHome(testData.AppURL);
            homePage.isHomePageLoaded().Should().BeTrue();
            TestContext.WriteLine("App is launched successfully");
        }

        [Test]
        public void testGoToFeaturePage()
        {
            homePage.openHome(testData.AppURL);
            TestContext.WriteLine("App is launched successfully");
            homePage.clickMyAccount();
            TestContext.WriteLine("Clicked on My Account");
            myAccountPage.enterUsername("hello");
            TestContext.WriteLine("Entered the username");
            myAccountPage.enterPassword("world");
            TestContext.WriteLine("Entered the password");
            myAccountPage.clicksignIn();
            TestContext.WriteLine("Clicked Sign In");
        }

        [OneTimeTearDown]
        public void cleanUp()
        {
            driver.Quit();
        }
    }
}