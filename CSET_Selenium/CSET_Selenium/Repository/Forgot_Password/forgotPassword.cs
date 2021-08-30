using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Forgot_Password
{
    class forgotPassword
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        private IWebElement textboxEmail;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Next')]")]
        private IWebElement buttonNext;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        private IWebElement textlinkLogin;

        [FindsBy(How = How.XPath, Using = "//input[@name='questionAnswer']")]
        private IWebElement textboxSecurityQuestionAnswer;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Reset Password')]")]
        private IWebElement buttonResetPassword;
    }
}
