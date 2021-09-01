using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSET_Selenium.Repository.Login_Page;
using NUnit.Framework;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CSET_Selenium.Tests.Login
{

    public class Login
    {
        static void Main(string[] args)
        {
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver();
            // navigate to URL  
            driver.Navigate().GoToUrl("http://cset-tst.inl.gov");
            Assert.True(driver.Title.Contains("CSET")); 
            Thread.Sleep(2000);

            LoginPage loginPage = new LoginPage();
            loginPage.LoginToCSET("william.martin@inl.gov", "password123");

        }
        //IWebDriver webdriver;

        //[SetUp]
        //public void Setup()
        //{
        //    new DriverManager().SetUpDriver(new ChromeConfig());
        //    webdriver = new ChromeDriver();
        //}

        //[TearDown]
        //public void Teardown()
        //{
        //    webdriver.Quit();
        //}

        //[Test]

        //public void Test()
        //{
        //    webdriver.Navigate().GoToUrl("http://cset-tst.inl.gov");
        //    Assert.True(webdriver.Title.Contains("CSET"));

        //    LoginPage loginPage = new LoginPage();
        //    loginPage.LoginToCSET("william.martin@inl.gov", "password123");
        //}
    }
}
