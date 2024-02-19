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

        private IWebElement TextboxEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='email']"));
            }
        }

        private IWebElement TextboxPassword
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@name='password']"));
            }
        }


        private IWebElement ButtonLogin
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Login')]"));
            }
        }

        private IWebElement TextlinkForgotPassword
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(),'Forgot Password')]"));
            }
        }

        private IWebElement TextlinkRegisterNewUserAccount
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(),'Register New User Account')]"));
            }
        }

        private IWebElement ButtonOK
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'OK')]"));
            }
        }

        //Interaction Methods

        private void SetEmail(String email)
        {
            ClickWhenClickable(TextboxEmail);
            TextboxEmail.SendKeys(email);
        }

        private void SetPassword(String password)
        {
            ClickWhenClickable(TextboxPassword);
            TextboxPassword.SendKeys(password);
        }

        private void ClickLoginButton()
        {
            ClickWhenClickable(ButtonLogin);
        }

        private void ClickForgotPasswordButton()
        {
            ClickWhenClickable(TextlinkForgotPassword);
        }

        private void ClickRegisterNewUserButton()
        {
            ClickWhenClickable(TextlinkRegisterNewUserAccount);
        }

        private void ClickOKButton()
        {
            ClickWhenClickable(ButtonOK);
        }

        //Aggregate Methods

        public void LoginToCSET(String email, String password)
        {
            //ClickOKButton();
            SetEmail(email);
            SetPassword(password);
            ClickLoginButton();
        }
    }
}
