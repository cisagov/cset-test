using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.RegisterNewUserAccount
{
    class RegisterNewUserAccount : BasePage
    {
        private readonly IWebDriver driver;

        public RegisterNewUserAccount(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement textboxFirstName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='firstName']"));
            }
        }

        private IWebElement textboxLastName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='lastName']"));
            }
        }

        private IWebElement textboxEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='email']"));
            }
        }

        private IWebElement textboxConfirmEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='confirmEmail']"));
            }
        }

        private IWebElement dropdownSecurityQustion1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='securityQustion1']"));
            }
        }

        private IWebElement textboxSecurityAnswer1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='SecurityAnswer1']"));
            }
        }

        private IWebElement dropdownSecurityQustion2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='securityQustion2']"));
            }
        }

        private IWebElement textboxSecurityAnswer2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='SecurityAnswer2']"));
            }
        }

        private IWebElement buttonRegister
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Register')]"));
            }
        }

        private IWebElement textlinkLogin
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(),'Login')]"));
            }
        }

        private IWebElement textlinkForgotPassword
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(),'Forgot Password')]"));
            }
        }
    }
}
