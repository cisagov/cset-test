using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Page_Objects.Maturity_Models;
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
    class MaturityModel
    {
        [TestFixture]
        public class CreateMaturityModelAssessment : BaseTest
        {
            private IWebDriver driver;



            [Test]
            public void ACET()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("ACET", "S.T.A.R. Labs", "Star City", "Washington");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //Maturity Models Page
                MaturityModelsPage maturityModelsPage = new MaturityModelsPage(driver);
                maturityModelsPage.SelectACET();

                //Inherent Risk Profiles
                assessmentInfo.SetAssessmentInformation();

                //Inherent Risk Profile Summary
                assessmentInfo.SetAssessmentInformation();

                //Statements Page
                assessmentInfo.SetAssessmentInformation();

                //ACET Maturity Results Page
                assessmentInfo.SetAssessmentInformation();

                //ACET Dashboard Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page

            }

            [Test]
            public void CMMCVer1()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("CMMC Ver 1", "Planet Express", "New New York", "New York");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //Maturity Models Page
                MaturityModelsPage maturityModelsPage = new MaturityModelsPage(driver);
                maturityModelsPage.SelectCMMC1();

                //CMMC Tutorial Page
                assessmentInfo.SetAssessmentInformation();

                //CMMC Target Level Selection Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Target and Achieved Levels Page
                assessmentInfo.SetAssessmentInformation();

                //Level Drill Down Page
                assessmentInfo.SetAssessmentInformation();

                //Compliance Score Page
                assessmentInfo.SetAssessmentInformation();

                //Detailed Gaps List Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page

            }

            [Test]
            public void CMMCVer2()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("CMMC Ver 2", "Planet Express", "New New York", "New York");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //Maturity Models Page
                MaturityModelsPage maturityModelsPage = new MaturityModelsPage(driver);
                maturityModelsPage.SelectCMMC2();

                //CMMC Tutorial Page
                assessmentInfo.SetAssessmentInformation();

                //CMMC Target Level Selection Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Performance by Level Page
                assessmentInfo.SetAssessmentInformation();

                //Performance by Domain Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page

            }

            [Test]
            public void CRR()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("CRR", "S.T.A.R. Labs", "Star City", "Washington");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //Maturity Models Page
                MaturityModelsPage maturityModelsPage = new MaturityModelsPage(driver);
                maturityModelsPage.SelectCRR();

                //CRR Tutorial Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Summary Page
                assessmentInfo.SetAssessmentInformation();

                //Assesst Management Page
                assessmentInfo.SetAssessmentInformation();

                //Controls Management Page
                assessmentInfo.SetAssessmentInformation();

                //Configuration and Change Management Page
                assessmentInfo.SetAssessmentInformation();

                //Vulnerability Management Page
                assessmentInfo.SetAssessmentInformation();

                //Incident Management Page
                assessmentInfo.SetAssessmentInformation();

                //Service Continuity Management Page
                assessmentInfo.SetAssessmentInformation();

                //Risk Management Page
                assessmentInfo.SetAssessmentInformation();

                //External Dependencies Management Page
                assessmentInfo.SetAssessmentInformation();

                //Training and Awareness Page
                assessmentInfo.SetAssessmentInformation();

                //Situatinal Awareness Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page

            }


            [Test]
            public void EDM()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("EDM", "S.T.A.R. Labs", "Star City", "Washington");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //Maturity Models Page
                MaturityModelsPage maturityModelsPage = new MaturityModelsPage(driver);
                maturityModelsPage.SelectEDM();

                //EDM Tutorial Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Summary Results Page
                assessmentInfo.SetAssessmentInformation();

                //Relationship Formation Page
                assessmentInfo.SetAssessmentInformation();

                //Relationship Management and Governance Page
                assessmentInfo.SetAssessmentInformation();

                //Service Protection and Sustainment Page
                assessmentInfo.SetAssessmentInformation();

                //Maturity Indicator Levels Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page

            }

            [Test]
            public void RRA()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("RRA", "Curtis Farms", "Shady Sands", "New California");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //Maturity Models Page
                MaturityModelsPage maturityModelsPage = new MaturityModelsPage(driver);
                maturityModelsPage.SelectRRA();

                //Ransomeware Readiness Tutorial Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Goal Performance Page
                assessmentInfo.SetAssessmentInformation();

                //Assessment Tiers Page
                assessmentInfo.SetAssessmentInformation();

                //Performance Summary Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page

            }
        }
    }
}
