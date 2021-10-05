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

namespace CSET_Selenium.Tests.Create_Assessment
{
    class NetworkDiagram
    {
        [TestFixture]
        public class CreateNetworkDiagramAssessment : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void Blank()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateNetworkDiagramAssessment("Network Diagram Assessment", "Lex Corp", "Metropolis  ", "New York");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //SAL Page
                assessmentInfo.SetAssessmentInformation();

                //Network Diagram Page
                assessmentInfo.SetAssessmentInformation();

                //Standards Questions Page
                assessmentInfo.SetAssessmentInformation();

                //Components Summary Page
                assessmentInfo.SetAssessmentInformation();

                //Ranked Components By Category Page
                assessmentInfo.SetAssessmentInformation();

                //Component Results By Category Page
                assessmentInfo.SetAssessmentInformation();

                //Components By Component Type Page
                assessmentInfo.SetAssessmentInformation();

                //Network Warning Page
                assessmentInfo.SetAssessmentInformation();

                //High-Level Assessment Description, Executive Summary & Comments Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page
                
            }
        }
    }
}
