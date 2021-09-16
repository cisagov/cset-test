using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Login_Page
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
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
            textboxEmail.SendKeys(email);
        }

        private void SetPassword(String password)
        {
            textboxPassword.SendKeys(password);
        }

        private void ClickLoginButton()
        {
            buttonLogin.Click();
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
