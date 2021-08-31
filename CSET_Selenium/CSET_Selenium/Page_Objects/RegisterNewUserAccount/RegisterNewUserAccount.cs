using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.RegisterNewUserAccount
{
    class RegisterNewUserAccount
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='firstName']")]
        private readonly IWebElement textboxFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@name='lastName']")]
        private readonly IWebElement textboxLastName;

        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        private readonly IWebElement textboxEmail;

        [FindsBy(How = How.XPath, Using = "//input[@name='confirmEmail']")]
        private readonly IWebElement textboxConfirmEmail;

        [FindsBy(How = How.XPath, Using = "//input[@name='securityQustion1']")]
        private readonly IWebElement dropdownSecurityQustion1;

        [FindsBy(How = How.XPath, Using = "//input[@name='SecurityAnswer1']")]
        private readonly IWebElement textboxSecurityAnswer1;

        [FindsBy(How = How.XPath, Using = "//input[@name='securityQustion2']")]
        private readonly IWebElement dropdownSecurityQustion2;

        [FindsBy(How = How.XPath, Using = "//input[@name='SecurityAnswer2']")]
        private readonly IWebElement textboxSecurityAnswer2;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Register')]")]
        private readonly IWebElement buttonRegister;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        private readonly IWebElement textlinkLogin;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Forgot Password')]")]
        private readonly IWebElement textlinkForgotPassword;
    }
}
