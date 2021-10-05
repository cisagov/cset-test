using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Page_Objects.Cybersecurity_Standards_Selection;
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
    class StandardAssessment
    {
        [TestFixture]
        public class CreateStandardAssessments : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void NERC2Rev6()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateStandardAssessment("Standard Assessment NERC2 Rev6", "Wayne Tech", "Gotham City", "New Jersey");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //SAL Page
                assessmentInfo.SetAssessmentInformation();

                //Cybersecurity Standards Selection Page
                CybersecurityStandardsSelection cybersecurityStandardsSelection = new CybersecurityStandardsSelection(driver);
                cybersecurityStandardsSelection.SetNerc_CIP_Rev6();

                //Standards Questions Page
                assessmentInfo.SetAssessmentInformation();

                //Analysis Dashboard Page
                assessmentInfo.SetAssessmentInformation();

                //Control Priorities Page
                assessmentInfo.SetAssessmentInformation();

                //Standards Summary Page
                assessmentInfo.SetAssessmentInformation();

                //Ranked Categories Page
                assessmentInfo.SetAssessmentInformation();

                //Results By Category Page
                assessmentInfo.SetAssessmentInformation();
            }
        }
    }
}
