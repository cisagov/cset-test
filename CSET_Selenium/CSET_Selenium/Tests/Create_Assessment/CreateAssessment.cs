using CSET_Selenium.DriverConfiguration;
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

                Landing_Page createNewAssessment = new Landing_Page(driver);
                createNewAssessment.CreateNewAssessment();
            }
        }
    }
}
