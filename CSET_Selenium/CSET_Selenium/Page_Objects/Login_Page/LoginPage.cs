using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Login_Page
{
    class LoginPage : BasePage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement textboxEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='email']"));
            }
        }

        private IWebElement textboxPassword
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='password']"));
            }
        }


        private IWebElement buttonLogin
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Login')]"));
            }
        }

        private IWebElement textlinkForgotPassword
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(),'Forgot Password')]"));
            }
        }

        private IWebElement textlinkRegisterNewUserAccount
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(),'Register New User Account')]"));
            }
        }

        //Interaction Methods

        private void SetEmail(String email)
        {
            ClickWhenClickable(textboxEmail);
            textboxEmail.SendKeys(email);
        }

        private void SetPassword(String password)
        {
            ClickWhenClickable(textboxPassword);
            textboxPassword.SendKeys(password);
        }

        private void ClickLoginButton()
        {
            ClickWhenClickable(buttonLogin);
        }

        private void ClickForgotPasswordButton()
        {
            ClickWhenClickable(textlinkForgotPassword);
        }

        private void ClickRegisterNewUserButton()
        {
            ClickWhenClickable(textlinkRegisterNewUserAccount);
        }


        //Aggregate Methods
        public void LoginToCSET(String email, String password)
        {
            SetEmail(email);
            SetPassword(password);
            ClickLoginButton();
        }
    }
}
