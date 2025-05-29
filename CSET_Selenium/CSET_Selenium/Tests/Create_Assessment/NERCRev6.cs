using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.ReportPages;
using CSET_Selenium.Page_Objects.Security_Assurance_Level;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Web;
using NERC6 = CSET_Selenium.Repositories.NERC_Rev_6;
using NERC6Pages = CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6;
using Shared = CSET_Selenium.Repositories.Shared;

namespace CSET_Selenium.Tests.Create_Assessment
{
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    class NERCRev6 : BaseTest
    {
        private readonly string csetacURL = "http://csetac:5777";
        private IWebDriver driver;

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void CreateAssessmentTestAllYes()
        {
            this.RunAssessmentTest(QuestionAnswers.YES);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void CreateAssessmentTestAllNO()
        {
            this.RunAssessmentTest(QuestionAnswers.NO);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void CreateAssessmentTestAllNA()
        {
            this.RunAssessmentTest(QuestionAnswers.NA);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void CreateAssessmentTestAllAlt()
        {
            this.RunAssessmentTest(QuestionAnswers.ALT);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void CreateAssessmentTestRandomAnswers()
        {
            this.RunAssessmentTest(QuestionAnswers.RANDOM);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnsers"></param>
        public void RunAssessmentTest(QuestionAnswers questionAnsers)
        {
            BaseConfiguration cf = new BaseConfiguration(csetacURL);
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
                    // invoke with QuestionAnswers parameter
                    this.TestStandardQuestionsPage(driver, nercRepo, questionAnsers);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        /// <param name="questionAnswers"></param>
        private void TestStandardQuestionsPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo, QuestionAnswers questionAnswers)
        {
            // STANDARD QUESTIONS
            StandardQuestions standardQuestions = nercRepo.AccessStandardQuestionsData(questionAnswers);

            // allocate Standard Questions Page and answer all Assessment questions
            NERC6Pages.StandardQuestionsPage questionsPage = new NERC6Pages.StandardQuestionsPage(driver, standardQuestions);

            questionsPage.ClickNext();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestAnalysisDashboardPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            AnalysisDashboardPage analysisDashBoard = new AnalysisDashboardPage(driver);

            // ACT
            analysisDashBoard.ProcessData();

            // ASSERT

            // Score
            //Debug.Assert(standardQuestionsData.OverallScore == analysisDashBoard.OverallScore);

            //// assessment compliance
            //Debug.Assert(standardQuestionsData.AssessmentCompliance == analysisDashBoard.AssessmentCompliance);

            //// ranked categories
            //Debug.Assert(standardQuestionsData.SystemProtection.YesCount == analysisDashBoard.RankedCategories[RankedCategoryKeyNames.SystemProtection].Value);
            //Debug.Assert(standardQuestionsData.Recovery.YesCount == analysisDashBoard.RankedCategories[RankedCategoryKeyNames.Recovery].Value);
            //Debug.Assert(standardQuestionsData.RiskAssessment.YesCount == analysisDashBoard.RankedCategories[RankedCategoryKeyNames.RiskManagement].Value);
            //Debug.Assert(standardQuestionsData.AccountManagement.YesCount == analysisDashBoard.RankedCategories[RankedCategoryKeyNames.AccountManagement].Value);
            //Debug.Assert(standardQuestionsData.PhysicalSecurity.YesCount == analysisDashBoard.RankedCategories[RankedCategoryKeyNames.PhysicalSecurity].Value);

            // standards summary
            //Debug.Assert(standardQuestionsData.YesCount == analysisDashBoard.StandardsSummary[QuestionAnswers.YES].Value);
            //Debug.Assert(standardQuestionsData.NoCount == analysisDashBoard.StandardsSummary[QuestionAnswers.NO].Value);
            //Debug.Assert(standardQuestionsData.NACount == analysisDashBoard.StandardsSummary[QuestionAnswers.NA].Value);
            //Debug.Assert(standardQuestionsData.ALTCount == analysisDashBoard.StandardsSummary[QuestionAnswers.ALT].Value);
            //Debug.Assert(standardQuestionsData.UnansweredCount == analysisDashBoard.StandardsSummary[QuestionAnswers.NOANSWER].Value);

            // continue to the next page
            analysisDashBoard.ClickNext();
        }

        /// <summary>
        /// move to analysis dashboard page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestControlPrioritiesPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            ControlPrioritiesPage controlPrioritiesPage = new ControlPrioritiesPage(driver);

            // ACT
            controlPrioritiesPage.ProcessData();

            // ASSERT
            // standardQuestionsData.YesCount == analysisDashBoard...

            controlPrioritiesPage.ClickNext();
        }

        /// <summary>
        /// move to Standards Summary page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestStandardsSummaryPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            StandardsSummaryPage standardsSummaryPage = new StandardsSummaryPage(driver);

            // ACT
            standardsSummaryPage.ProcessData();

            // ASSERT

            // standards summary
            //Debug.Assert(standardQuestionsData.YesCount == standardsSummaryPage.StandardsSummary[QuestionAnswers.YES].Value);
            //Debug.Assert(standardQuestionsData.NoCount == standardsSummaryPage.StandardsSummary[QuestionAnswers.NO].Value);
            //Debug.Assert(standardQuestionsData.NACount == standardsSummaryPage.StandardsSummary[QuestionAnswers.NA].Value);
            //Debug.Assert(standardQuestionsData.ALTCount == standardsSummaryPage.StandardsSummary[QuestionAnswers.ALT].Value);
            //Debug.Assert(standardQuestionsData.UnansweredCount == standardsSummaryPage.StandardsSummary[QuestionAnswers.NOANSWER].Value);

            standardsSummaryPage.ClickNext();
        }

        /// <summary>
        /// move to Ranked Categories page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestRankedCategoriesPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            RankedCategoriesPage rankedCategoriesPage = new RankedCategoriesPage(driver);

            // ACT
            rankedCategoriesPage.ProcessData();

            // ASSERT

            // standards summary
            //Debug.Assert(standardQuestionsData.YesCount == rankedCategoriesPage.RankedCategories[QuestionAnswers.YES].Value);
            //Debug.Assert(standardQuestionsData.NoCount == rankedCategoriesPage.RankedCategories[QuestionAnswers.NO].Value);
            //Debug.Assert(standardQuestionsData.NACount == rankedCategoriesPage.RankedCategories[QuestionAnswers.NA].Value);
            //Debug.Assert(standardQuestionsData.ALTCount == rankedCategoriesPage.RankedCategories[QuestionAnswers.ALT].Value);
            //Debug.Assert(standardQuestionsData.UnansweredCount == rankedCategoriesPage.RankedCategories[QuestionAnswers.NOANSWER].Value);

            rankedCategoriesPage.ClickNext();
        }

        /// <summary>
        /// move to Results by Category page     
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestResultsByCategoryPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            ResultsByCategoryPage resultsByCategoryPage = new ResultsByCategoryPage(driver);

            // ACT
            resultsByCategoryPage.ProcessData();

            // ASSERT
            // standardQuestionsData.YesCount == analysisDashBoard...

            resultsByCategoryPage.ClickNext();
        }

        /// <summary>
        /// move to Hight Level Asessment page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestHighLevelAssessmentPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            HighLevelAssessmentPage highLevelAssessmentPage = new HighLevelAssessmentPage(driver);

            // ACT
            highLevelAssessmentPage.ProcessData();

            // ASSERT
            // standardQuestionsData.YesCount == analysisDashBoard...

            highLevelAssessmentPage.ClickNext();
        }

        /// <summary>
        /// move to Reports page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestReportsPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            ReportsPage reportsPage = new ReportsPage(driver);

            // ACT
            reportsPage.ProcessData();

            // ASSERT
            // standardQuestionsData.YesCount == analysisDashBoard...

            reportsPage.ClickNext();
        }

        /// <summary>
        /// Feedback Page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestFeebackPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // ARRANGE
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            FeedbackPage feedbackPage = new FeedbackPage(driver);

            // ACT
            feedbackPage.ProcessData();

            // ASSERT
            // standardQuestionsData.YesCount == analysisDashBoard...
        }
    }
}
