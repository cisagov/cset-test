using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Login_Page
{
    class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        //Element Locators

        [FindsBy(How = How.XPath, Using = "//input[@name='email']")]
        private readonly IWebElement textboxEmail;

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement textboxPassword;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement buttonLogin;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Forgot Password')]")]
        private IWebElement textlinkForgotPassword;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Register New User Account')]")]
        private IWebElement textlinkRegisterNewUserAccount;


        //Interaction Methods

        private void SetEmail(String email)
        {
            SetText(textboxEmail, email);
        }

        private void SetPassword(String password)
        {
            SetText(textboxPassword, password);
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
