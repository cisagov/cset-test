using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
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

namespace CSET_Selenium.Tests.TSA
{
    class TSAAssessmentCreation
    {
        [TestFixture]
        public class TSACreateAssessment : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void CreateTSAAssessment()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");
                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET-TSA"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateTSAAssessment("TSA", "Planet Express", "New New York", "New York");

                // Practices Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                // Standard Questions Page
                assessmentInfo.SetAssessmentInformation();

                // Analysis Dashboard Page
                assessmentInfo.SetAssessmentInformation();

                // Control Priorities Page
                assessmentInfo.SetAssessmentInformation();

                // Standards Summary Page
                assessmentInfo.SetAssessmentInformation();

                // Ranked Categories Page
                assessmentInfo.SetAssessmentInformation();

                // Results By Category Page
                assessmentInfo.SetAssessmentInformation();

                // High-Level Assessment Description Page
                assessmentInfo.SetAssessmentInformation();

                // Reports Page
                assessmentInfo.SetAssessmentInformation();

                // Assessment Complete Page
                
            }

            [Test]
            public void CreateVADRAssessment()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");
                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET-TSA"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateVADRAssessment("VADR", "Planet Express", "New New York", "New York");

                // Practices Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                // Standard Questions Page
                assessmentInfo.SetAssessmentInformation();

                // Analysis Dashboard Page
                assessmentInfo.SetAssessmentInformation();

            }

            [Test]
            public void CreateRRAAssessment()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");
                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET-TSA"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateRRAAssessment("RRA", "Planet Express", "New New York", "New York");

                // Practices Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                // Standard Questions Page
                assessmentInfo.SetAssessmentInformation();

                // Analysis Dashboard Page
                assessmentInfo.SetAssessmentInformation();

            }

            [Test]
            public void CreateCRRAssessment()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");
                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET-TSA"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateCRRAssessment("CRR", "Planet Express", "New New York", "New York");

                // Practices Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                // Standard Questions Page
                assessmentInfo.SetAssessmentInformation();

                // Analysis Dashboard Page
                assessmentInfo.SetAssessmentInformation();

            }

            [Test]
            public void CreateCSCAssessment()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");
                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET-TSA"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateCSCAssessment("CSC", "Planet Express", "New New York", "New York");

                // Standard Questions Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                // Analysis Dashboard Page
                assessmentInfo.SetAssessmentInformation();

                // Control Priorities Page
                assessmentInfo.SetAssessmentInformation();

                // Standards Summary Page
                assessmentInfo.SetAssessmentInformation();

                // Ranked Categories Page
                assessmentInfo.SetAssessmentInformation();

                // Results By Category Page
                assessmentInfo.SetAssessmentInformation();

                // High-Level Assessment Description Page
                assessmentInfo.SetAssessmentInformation();

                // Reports Page
                assessmentInfo.SetAssessmentInformation();

                assessmentInfo.SetAssessmentInformation();


            }

            [Test]
            public void CreateAPTAAssessment()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");
                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET-TSA"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateAPTAAssessment("APTA", "Planet Express", "New New York", "New York");

                // Standard Questions Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                // Analysis Dashboard Page
                assessmentInfo.SetAssessmentInformation();

                // Control Priorities Page
                assessmentInfo.SetAssessmentInformation();

                // Standards Summary Page
                assessmentInfo.SetAssessmentInformation();

                // Ranked Categories Page
                assessmentInfo.SetAssessmentInformation();

                // Results By Category Page
                assessmentInfo.SetAssessmentInformation();

                // High-Level Assessment Description Page
                assessmentInfo.SetAssessmentInformation();

                // Reports Page
                assessmentInfo.SetAssessmentInformation();

                assessmentInfo.SetAssessmentInformation();


            }
        }
    }
}
