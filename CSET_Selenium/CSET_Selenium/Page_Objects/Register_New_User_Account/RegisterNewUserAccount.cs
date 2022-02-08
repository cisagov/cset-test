using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Register_New_User_Account
{
    class RegisterNewUserAccount : BasePage
    {
        private readonly IWebDriver driver;

        public RegisterNewUserAccount(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement TextboxFirstName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='firstName']"));
            }
        }

        private IWebElement TextboxLastName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='lastName']"));
            }
        }

        private IWebElement TextboxEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='email']"));
            }
        }

        private IWebElement TextboxConfirmEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='confirmEmail']"));
            }
        }

        private IWebElement DropdownSecurityQustion1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='securityQustion1']"));
            }
        }

        private IWebElement TextboxSecurityAnswer1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='SecurityAnswer1']"));
            }
        }

        private IWebElement DropdownSecurityQustion2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='securityQustion2']"));
            }
        }

        private IWebElement TextboxSecurityAnswer2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='SecurityAnswer2']"));
            }
        }

        private IWebElement ButtonRegister
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Register')]"));
            }
        }

        private IWebElement TextlinkLogin
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(),'Login')]"));
            }
        }

        private IWebElement TextlinkForgotPassword
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(),'Forgot Password')]"));
            }
        }
    }
}
