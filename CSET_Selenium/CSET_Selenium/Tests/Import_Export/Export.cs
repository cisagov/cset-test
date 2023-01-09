using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Tests.Import_Export
{
    internal class Export
    {
        [TestFixture]
        public class ExportTests : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void CreateTSAAssessment()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");
                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage landingPage = new LandingPage(driver);
                landingPage.ClickExportAllAssessments();

                WaitUtils waitUtils = new WaitUtils(driver);
                waitUtils.WaitUntilElementIsClickable(By.XPath("//button[@mattooltip='Export a copy of all assessments to another location.']"));

            }

        }
    }
}
