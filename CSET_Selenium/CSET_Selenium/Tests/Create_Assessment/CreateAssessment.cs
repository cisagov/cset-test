using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CSET_Selenium.Tests.Create_Assessment
{
    class CreateAssessment
    {
        public static void Main(string[] args)
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

            LandingPage createNewAssessment = new LandingPage(driver);
            createNewAssessment.CreateNewAssessment();

            //Assert.Pass();

            Thread.Sleep(10000);

            //close the browser  
            driver.Quit();
        }
    }
}
