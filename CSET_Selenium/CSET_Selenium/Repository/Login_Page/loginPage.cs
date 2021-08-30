using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Login_Page
{
    class loginPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        private IWebElement textboxEmail;

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement textboxPassword;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement buttonLogin;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Forgot Password')]")]
        private IWebElement textlinkForgotPassword;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Register New User Account')]")]
        private IWebElement textlinkRegisterNewUserAccount;
    }
}
