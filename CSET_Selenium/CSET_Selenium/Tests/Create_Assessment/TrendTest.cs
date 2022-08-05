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
using CSET_Selenium.Helpers;

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

                //Create the assessments to be compared
                AssessmentUtils assessment1 = new AssessmentUtils(driver);
                assessment1.NewRandomStandard();

                //Analyze the trends for the above assessments
                Trend trend = new Trend(driver);
                trend.GoHome();
                assessment1.ChangedStandardAssessment(assessment1.GetStats());
                trend.GoHome();
                trend.NewTrend("Standard Assessment (From Assessment Utils)", "Standard Assessment (From Assessment Utils) 2");
                var numQuestionsA = driver.FindElement(By.XPath("//table[@class='cset-table table-bordered assessment-summary']//td[contains(text(), 'A')]/following-sibling::td[2]"));
                var numQuestionsB = driver.FindElement(By.XPath("//table[@class='cset-table table-bordered assessment-summary']//td[contains(text(), 'B')]/following-sibling::td[2]"));
                Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));


            }

            [Test]
            public void MaturityModelTrendTest()
            {
                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);

                AssessmentUtils assessment1 = new AssessmentUtils(driver);
               // AssessmentUtils assessment2 = new AssessmentUtils(driver);
                assessment1.NewMaturityModel();
               // assessment2.NewStandard();

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
