using OpenQA.Selenium;
using ProvidenceWebAppQA.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidenceWebAppQA.pages
{
    class HomePage
    {
        public HomePage(IWebDriver d)
        {
            this.driver = d;
            util = new Util(d);
        }

        //########## Setup ############

        private IWebDriver driver = null;
        private Util util = null;

        //########### Element Definition #############

        private By setYourLocation = By.XPath("//*[text() = 'Set Your Location']");
        private By myChart = By.XPath("//*[text() = 'MyChart']");
        private By payMyBill = By.XPath("//a[contains(text(), 'Pay My Bill') and @class = 'mobile-menu']");
        private By myAccount = By.Id("loginWithAzureB2c");
        private By providenceLogo = By.XPath("//*[@alt = 'Providence logo']");

        //######### Function Definition #################

        public bool isHomePageLoaded()
        {
            return util.IsElementVisible(providenceLogo);
        }

        public bool clickMyAccount()
        {
            return util.ClickElement(myAccount);
        }
        
        public void openHome(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.FullScreen();
            util.captureScreenshot("openHome");
        }
    }
}