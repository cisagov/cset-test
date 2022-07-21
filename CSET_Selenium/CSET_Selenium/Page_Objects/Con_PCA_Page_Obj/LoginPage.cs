using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.ConPCA_Repository.Login_Page
{
    class LoginPage : BasePage
    {
        private readonly IWebDriver driver;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

       
        private IWebElement TextboxUserName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@placeholder='Username']"));
            }
        }

        private IWebElement TextboxPassword
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@placeholder='Password']"));
            }
        }


        private IWebElement ButtonLogin
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@type = 'submit']"));
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

        //Interaction Methods

        //private void SetEmail(String email)
        //{
        //    ClickWhenClickable(TextboxEmail);
        //    TextboxEmail.SendKeys(email);
        //}

        private void SetUserName(String userName)
        {
            ClickWhenClickable(TextboxUserName);
            TextboxUserName.SendKeys(userName);
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


        //Aggregate Methods

        public void LoginToCSET(String userName, String password)
        {
            
            SetUserName(userName);
            SetPassword(password);
            ClickLoginButton();
        }
    }
}
