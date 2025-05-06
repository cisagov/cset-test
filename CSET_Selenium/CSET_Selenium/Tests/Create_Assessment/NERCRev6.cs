using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.ReportPages;
using CSET_Selenium.Page_Objects.Security_Assurance_Level;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using NUnit.Framework;
using OpenQA.Selenium;
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
            // arrange
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            AnalysisDashboardPage analysisDashBoard = new AnalysisDashboardPage(driver);

            // act
            analysisDashBoard.ProcessData();

            // assert

            // Score
            bool flag = standardQuestionsData.OverallScore == analysisDashBoard.OverallScore;

            // assessment compliance
            flag = standardQuestionsData.AssessmentCompliance == analysisDashBoard.AssessmentCompliance;

            // ranked categories

            // standards summary

            analysisDashBoard.ClickNext();
        }

        /// <summary>
        /// move to analysis dashboard page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestControlPrioritiesPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // arrange
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            ControlPrioritiesPage controlPrioritiesPage = new ControlPrioritiesPage(driver);

            // act
            controlPrioritiesPage.ProcessData();

            // assert
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
            // arrange
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            StandardsSummaryPage standardsSummaryPage = new StandardsSummaryPage(driver);

            // act
            standardsSummaryPage.ProcessData();

            // assert
            // standardQuestionsData.YesCount == analysisDashBoard...

            standardsSummaryPage.ClickNext();
        }

        /// <summary>
        /// move to Ranked Categories page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestRankedCategoriesPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // arrange
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            RankedCategoriesPage rankedCategoriesPage = new RankedCategoriesPage(driver);

            // act
            rankedCategoriesPage.ProcessData();

            // assert
            // standardQuestionsData.YesCount == analysisDashBoard...

            rankedCategoriesPage.ClickNext();
        }

        /// <summary>
        /// move to Results by Category page     
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestResultsByCategoryPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // arrange
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            ResultsByCategoryPage resultsByCategoryPage = new ResultsByCategoryPage(driver);

            // act
            resultsByCategoryPage.ProcessData();

            // assert
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
            // arrange
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            HighLevelAssessmentPage highLevelAssessmentPage = new HighLevelAssessmentPage(driver);

            // act
            highLevelAssessmentPage.ProcessData();

            // assert
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
            // arrange
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            ReportsPage reportsPage = new ReportsPage(driver);

            // act
            reportsPage.ProcessData();

            // assert
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
            // arrange
            StandardQuestions standardQuestionsData = nercRepo.AccessStandardQuestionsData();
            FeedbackPage feedbackPage = new FeedbackPage(driver);

            // act
            feedbackPage.ProcessData();

            // assert
            // standardQuestionsData.YesCount == analysisDashBoard...
        }
    }
}
