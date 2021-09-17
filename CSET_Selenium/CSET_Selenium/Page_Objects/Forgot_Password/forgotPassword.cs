using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Forgot_Password
{
    class ForgotPassword : BasePage
    {
        public ForgotPassword(IWebDriver driver) : base(driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        private readonly IWebElement textboxEmail;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Next')]")]
        private readonly IWebElement buttonNext;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        private readonly IWebElement textlinkLogin;

        [FindsBy(How = How.XPath, Using = "//input[@name='questionAnswer']")]
        private readonly IWebElement textboxSecurityQuestionAnswer;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Reset Password')]")]
        private readonly IWebElement buttonResetPassword;
    }
}
