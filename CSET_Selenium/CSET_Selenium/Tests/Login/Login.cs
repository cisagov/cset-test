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
            


        ////create the reference for the browser
        //IWebDriver driver;

        //[SetUp]
        //public void Setup()
        //{
        //    new DriverManager().SetUpDriver(new ChromeConfig());
        //    driver = new ChromeDriver();

        //    //Maximize the browser window  
        //    driver.Manage().Window.Maximize();
        //}

        //[TearDown]
        //public void Teardown()
        //{
        //    //close the browser  
        //    driver.Quit();
        //}

        [Test]
        public static void Test()
        {
            //create the reference for the browser
            IWebDriver driver;

            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //Maximize the browser window  
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("http://cset-tst.inl.gov");

            //Thread.Sleep(10000);
            Assert.True(driver.Title.Contains("CSET"));

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

            //Assert.Pass();

            //close the browser  
            driver.Quit();
        }


    }
}
