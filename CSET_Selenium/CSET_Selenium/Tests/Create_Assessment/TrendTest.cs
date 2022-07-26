using CSET_Selenium.Repository.Login_Page;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Page_Objects.Cybersecurity_Standards_Selection;
using CSET_Selenium.Page_Objects.Sidebar;
using CSET_Selenium.Repository.Landing_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using CSET_Selenium.Page_Objects.Trend;
using CSET_Selenium.Page_Objects.Security_Assurance_Level;

namespace CSET_Selenium.Tests.Create_Assessment
{
    class TrendTest
    {
        [TestFixture]
        public class Trend_Test : BaseTest
        {
            private IWebDriver driver;
           
            Random r = new Random();

            [Test]
            public void SALTrendTest()
            {
                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                //Login and navigate to module builder
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("kyle.hanson@inl.gov", "Nitocket14$");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();
                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateStandardAssessment("Standard Assessment for Trend Test", "Wayne Tech", "Gotham City", "New Jersey");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetSALAssessmentInfo();

                SecurityAssuranceLevel sal = new SecurityAssuranceLevel(driver);
                var generalRiskNum = r.Next(9);
                sal.SelectHeaderGeneralRiskBased();
                sal.SetRandomGeneralRisk(generalRiskNum);
                sal.SelectHeaderNist();
                Thread.Sleep(3000);
                for(int i = 0; i < 5; i++)
                {
                    sal.SetRandomNistCheck();
                }
                sal.SetRandomNistQuestion();
                sal.ClickNext();
/*              Trend trend = new Trend(driver);
                trend.GoHome();
                createNewAssessment.ClickMyAssessments();
                Thread.Sleep(3000);
                trend.DeleteAssessment();
                trend.Yes();*/
            }

            [Test]
            public void CyberAssessmentTrendTest()
            {
                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                //Login and navigate to module builder
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();
                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateStandardAssessment("Cyber Assessment for Trend Test", "Wayne Tech", "Gotham City", "New Jersey");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetCyberAssessmentInfo();

                Trend trend = new Trend(driver);
                trend.GoHome();
                createNewAssessment.ClickMyAssessments();
                Thread.Sleep(3000);
               // trend.DeleteAssessment();
               // trend.Yes();

            }

            [Test]
            public void NetDiagramTrendTest()
            {
                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                //Login and navigate to module builder
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();
                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateStandardAssessment("Net Diagram for Trend Test", "Wayne Tech", "Gotham City", "New Jersey");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetNetDiagramAssessmentInfo();

                Trend trend = new Trend(driver);
                trend.GoHome();
                createNewAssessment.ClickMyAssessments();
                Thread.Sleep(3000);
                trend.DeleteAssessment();
                trend.Yes();

            }
        }
    }
}
