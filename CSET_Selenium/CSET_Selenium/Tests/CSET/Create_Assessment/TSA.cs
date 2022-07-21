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

                // Assessment Information
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessInfo();

                // Standard Questions Page
                assessmentInfo.SetStandardQuestions();

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
                assessmentInfo.SetTSAReports();

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

                // Assessment Information Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessInfo();

                // Practices Page
                assessmentInfo.SetAssessmentInformation();

                // Reports Page
                assessmentInfo.SetVADRReports();

                // Assessment Complete Page

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

                // Assessment Information Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessInfo();

                // Practices Page
                assessmentInfo.SetAssessmentInformation();

                // Reports Page
                assessmentInfo.SetRRAReports();

                // Assessment Complete Page

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

                // Assessment Information Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessInfo();

                // Practices Page
                assessmentInfo.SetAssessmentInformation();

                // Reports Page
                assessmentInfo.SetCRRReports();

                // Assessment Complete Page

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


                // Assessment Information Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessInfo();

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
                assessmentInfo.SetCSCReports();

                // Assessment Complete Page

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

                // Assessment Information Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessInfo();

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
                assessmentInfo.SetAPTAReports();

                // Assessment Complete Page

            }
        }
    }
}
