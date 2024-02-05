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
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.Trend;

namespace CSET_Selenium.Tests.Create_Assessment
{
    class CompareTest
    {
        [TestFixture]
        public class Compare_Test : BaseTest
        {
            private IWebDriver driver;

            Random r = new Random();

            [Test]
            public void SALCompareTest()
            {
                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);

                //Create the assessments to be compared
                AssessmentUtils assessment = new AssessmentUtils(driver);
                assessment.NewRandomStandard();

                //Analyze the Compares for the above assessments
                Compare compare = new Compare(driver);
                compare.GoHome();
                assessment.ChangedStandardAssessment(assessment.GetStats());
                compare.GoHome();
                compare.NewCompare("Standard Assessment (From Assessment Utils)", "Standard Assessment (From Assessment Utils) 2");
                Thread.Sleep(5000);
                var numQuestionsA = driver.FindElement(By.XPath("//table[@class='cset-table table-bordered assessment-summary']//td[contains(text(), 'A')]/following-sibling::td[2]"));
                var numQuestionsB = driver.FindElement(By.XPath("//table[@class='cset-table table-bordered assessment-summary']//td[contains(text(), 'B')]/following-sibling::td[2]"));
                Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));
            }

            [Test]
            public void MaturityModelCompareTest()
            {
                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);

                AssessmentUtils assessment = new AssessmentUtils(driver);
                // AssessmentUtils assessment2 = new AssessmentUtils(driver);
                assessment.NewRandomMaturityModel();
                assessment.ChangedMaturityModel(assessment.GetStats());
                Compare compare = new Compare(driver);
                compare.NewCompare("Cyber Assessment (From Assessment Utils)", "Cyber Assessment (From Assessment Utils) 2");
                Thread.Sleep(5000);
                var numQuestionsA = driver.FindElement(By.XPath("//table[@class='cset-table table-bordered assessment-summary']//td[contains(text(), 'A')]/following-sibling::td[2]"));
                var numQuestionsB = driver.FindElement(By.XPath("//table[@class='cset-table table-bordered assessment-summary']//td[contains(text(), 'B')]/following-sibling::td[2]"));

                if (assessment.GetStats().ContainsKey("ACET"))
                {
                    Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));
                    Console.WriteLine("Success");
                }
                if (assessment.GetStats().ContainsKey("CMMC1"))
                {
                    Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));
                    Console.WriteLine("Success");
                }
                if (assessment.GetStats().ContainsKey("CMMC2"))
                {
                    Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));
                    Console.WriteLine("Success");
                }
                if (assessment.GetStats().ContainsKey("CRR"))
                {
                    Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));
                    Console.WriteLine("Success");
                }
                if (assessment.GetStats().ContainsKey("EDM"))
                {
                    Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));
                    Console.WriteLine("Success");
                }
                if (assessment.GetStats().ContainsKey("CIS"))
                {
                    Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));
                    Console.WriteLine("Success");
                }
                if (assessment.GetStats().ContainsKey("RRA"))
                {
                    Assert.That(Int32.Parse(numQuestionsB.GetAttribute("value")) >= 2 * Int32.Parse(numQuestionsA.GetAttribute("value")));
                    Console.WriteLine("Success");
                }


            }

            [Test]
            public void NetDiagramCompareTest()
            {
                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                //Login and navigate to module builder
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();
                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateStandardAssessment("Net Diagram for Compare Test", "Wayne Tech", "Gotham City", "New Jersey");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetNetDiagramAssessmentInfo();

                Compare compare = new Compare(driver);
                compare.GoHome();
                createNewAssessment.ClickMyAssessments();
                Thread.Sleep(3000);
                compare.Yes();

            }
        }
    }
}
