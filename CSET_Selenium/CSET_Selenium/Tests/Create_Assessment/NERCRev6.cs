using CSET_Selenium.Page_Objects.Maturity_Models;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using Shared = CSET_Selenium.Repositories.Shared;
using NERC6 = CSET_Selenium.Repositories.NERC_Rev_6;
using NERC6DT = CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using CSET_Selenium.Page_Objects.ReportPages;
using NERC6Pages = CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Helpers;
using FluentAssertions;
using CSET_Selenium.Page_Objects.Security_Assurance_Level;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium.DevTools.V130.Network;
using System.Collections.Generic;
using System;

namespace CSET_Selenium.Tests.Create_Assessment
{
    [TestFixture]
    class NERCRev6 : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void CreateAssessmentTest()
        {
            BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
            driver = BuildDriver(cf);
            Assert.That(driver.Title.Contains("CSET"));

            using (Shared.AssessmentRepository sharedRepo = new Shared.AssessmentRepository())
            {
                // this function handles login, landing page, config, info, and SAL pages
                SecurityAssuranceLevel levelPage = AssessmentCommonFunctions.InitilizeAssessment(driver, sharedRepo);

                if (levelPage != null)
                {
                    levelPage.ClickNext();
                }

                using (NERC6.NERCRev6Repository nercRepo = new NERC6.NERCRev6Repository())
                {
                    // STANDARD QUESTIONS
                    this.TestStandardQuestionsPage(driver, nercRepo);

                    // move to analysis dashboard page
                    this.TestAnalysisDashboardPage(driver, nercRepo);

                    // move to the Control Priorities page
                    this.TestControlPrioritiesPage(driver, nercRepo);

                    // move to Standards Summary page
                    this.TestStandardsSummaryPage(driver, nercRepo);

                    // move to Ranked Categories page
                    this.TestRankedCategoriesPage(driver, nercRepo);

                    // move to Results by Category page
                    this.TestResultsByCategoryPage(driver, nercRepo);

                    // move to Hight Level Asessment page
                    this.TestHighLevelAssessmentPage(driver, nercRepo);

                    // move to Reports page
                    this.TestReportsPage(driver, nercRepo);

                    //Feedback Page
                    this.TestFeebackPage(driver, nercRepo);
                }
            }
        }

        private void TestStandardQuestionsPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE

            // STANDARD QUESTIONS
            // allocate Standard Questions Page
            NERC6Pages.StandardQuestions questionsPage = new NERC6Pages.StandardQuestions(driver);

            // get data from repository
            StandardQuestions questionsData = nercRepo.AccessStandardQuestionsData();

            // ACT

            // if instance is valid
            if (questionsData.IsValid())
            {
                // go to questions mode
                questionsPage.SetQuestionsMode();

                // set question answers
                questionsPage.SetQuestionValues(questionsData);

                // expand all questions
                questionsPage.ExpandAllQuestions();
            }

            // ASSERT

            questionsPage.ClickNext();
        }

        private void TestAnalysisDashboardPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            AnalysisDashboardPage analysisDashBoard = new AnalysisDashboardPage(driver);

            analysisDashBoard.ClickNext();
        }

        // move to analysis dashboard page
        private void TestControlPrioritiesPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            ControlPrioritiesPage controlPrioritiesPage = new ControlPrioritiesPage(driver);

            controlPrioritiesPage.ClickNext();
        }

        // move to Standards Summary page
        private void TestStandardsSummaryPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            StandardsSummaryPage standardsSummaryPage = new StandardsSummaryPage(driver);

            standardsSummaryPage.ClickNext();
        }

        // move to Ranked Categories page
        private void TestRankedCategoriesPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            RankedCategoriesPage rankedCategoriesPage = new RankedCategoriesPage(driver);

            rankedCategoriesPage.ClickNext();
        }

        // move to Results by Category page
       
        private void TestResultsByCategoryPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            ResultsByCategoryPage resultsByCategoryPage = new ResultsByCategoryPage(driver);

            resultsByCategoryPage.ClickNext();
        }

        // move to Hight Level Asessment page
        private void TestHighLevelAssessmentPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            HighLevelAssessmentPage highLevelAssessmentPage = new HighLevelAssessmentPage(driver);

            highLevelAssessmentPage.ClickNext();
        }

        // move to Reports page
        private void TestReportsPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            ReportsPage reportsPage = new ReportsPage(driver);

            reportsPage.ClickNext();
        }

        //Feedback Page
        private void TestFeebackPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            FeedbackPage feedbackPage = new FeedbackPage(driver);
        }
    }
}
