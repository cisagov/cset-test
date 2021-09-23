using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using CSET_Selenium.Repository.Login_Page;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using CSET_Selenium.DriverConfiguration;

namespace CSET_Selenium.Tests.Login
{
    [TestFixture]
    public class Login : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void Test()
        {
            BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
            driver = driver = BuildDriver(cf);
            Assert.True(driver.Title.Contains("CSET"));
            
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToCSET("william.martin@inl.gov", "Password123");
        }
    }
}
