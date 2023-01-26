using OpenQA.Selenium;
using ProvidenceWebAppQA.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidenceWebAppQA.pages
{
    class MyAccountPage
    {
        public MyAccountPage(IWebDriver d)
        {
            this.driver = d;
            util = new Util(d);
        }

        //########## Setup ############

        private IWebDriver driver = null;
        private Util util = null;


        //########### Element Definition #############

        private By payBillAsGuestLink = By.Id("payAsGuestLink");
        private By usernameTextBox = By.Id("signInName");
        private By passwordTextBox = By.Id("userSecretInput");
        private By forgotMyChartUsernameLink = By.Id("forgotUsernameLink");
        private By forgotPasswordLink = By.Id("forgotPasswordLink");
        private By cancelButton = By.Id("cancel");
        private By signInButton = By.Id("continue");
        private By signUpNowLink = By.Id("signUpLink");
        private By privacyPolicyLink = By.Id("privacypolicy");
        private By faqsLink = By.Id("faqs");
        private By termsAndConditionsLink = By.Id("termsandconditions");
        private By nonDiscriminationLink = By.Id("nondiscrimination");


        //######### Function Definition #################
        
        public void openHome(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.FullScreen();
            util.captureScreenshot("openHome");
        }

        /////

        public void enterUsername(string username)
        {
            util.enterText(usernameTextBox, username);
        }

        public void enterPassword(string password)
        {
            util.enterText(passwordTextBox, password);
        }

        public void clicksignIn()
        {
            util.ClickElement(signInButton);
            util.captureScreenshot("User logged in");
        }

    }
}