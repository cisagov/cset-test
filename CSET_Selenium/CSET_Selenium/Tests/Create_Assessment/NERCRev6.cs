using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.ReportPages;
using CSET_Selenium.Page_Objects.Security_Assurance_Level;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using NUnit.Framework;
using OpenQA.Selenium;
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
                    this.TestStandardQuestionsPage(driver, nercRepo, QuestionAnswers.YES);

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
        [Test]
        public void CreateAssessmentTestAllNO()
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
                    this.TestStandardQuestionsPage(driver, nercRepo, QuestionAnswers.NO);

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
        [Test]
        public void CreateAssessmentTestAllNA()
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
                    this.TestStandardQuestionsPage(driver, nercRepo, QuestionAnswers.NA);

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
        [Test]
        public void CreateAssessmentTestAllAlt()
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
                    this.TestStandardQuestionsPage(driver, nercRepo, QuestionAnswers.ALT);

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
        [Test]
        public void CreateAssessmentTestRandomAnswers()
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestStandardQuestionsPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            // STANDARD QUESTIONS
            StandardQuestions standardQuestions = nercRepo.AccessStandardQuestionsData();

            // allocate Standard Questions Page
            NERC6Pages.StandardQuestionsPage questionsPage = new NERC6Pages.StandardQuestionsPage(driver, standardQuestions);

            questionsPage.ClickNext();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        /// <param name="questionAnswers"></param>
        private void TestStandardQuestionsPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo, QuestionAnswers questionAnswers )
        {
            // STANDARD QUESTIONS
            StandardQuestions standardQuestions = nercRepo.AccessStandardQuestionsData(questionAnswers);

            // allocate Standard Questions Page
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
            AnalysisDashboardPage analysisDashBoard = new AnalysisDashboardPage(driver);

            analysisDashBoard.ClickNext();
        }

        /// <summary>
        /// move to analysis dashboard page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestControlPrioritiesPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            ControlPrioritiesPage controlPrioritiesPage = new ControlPrioritiesPage(driver);

            controlPrioritiesPage.ClickNext();
        }

        /// <summary>
        /// move to Standards Summary page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestStandardsSummaryPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            StandardsSummaryPage standardsSummaryPage = new StandardsSummaryPage(driver);

            standardsSummaryPage.ClickNext();
        }

        /// <summary>
        /// move to Ranked Categories page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestRankedCategoriesPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            RankedCategoriesPage rankedCategoriesPage = new RankedCategoriesPage(driver);

            rankedCategoriesPage.ClickNext();
        }

        /// <summary>
        /// move to Results by Category page     
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestResultsByCategoryPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            ResultsByCategoryPage resultsByCategoryPage = new ResultsByCategoryPage(driver);

            resultsByCategoryPage.ClickNext();
        }

        /// <summary>
        /// move to Hight Level Asessment page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestHighLevelAssessmentPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            HighLevelAssessmentPage highLevelAssessmentPage = new HighLevelAssessmentPage(driver);

            highLevelAssessmentPage.ClickNext();
        }

        /// <summary>
        /// move to Reports page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestReportsPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            ReportsPage reportsPage = new ReportsPage(driver);

            reportsPage.ClickNext();
        }

        /// <summary>
        /// Feedback Page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="nercRepo"></param>
        private void TestFeebackPage(IWebDriver driver, NERC6.NERCRev6Repository nercRepo)
        {
            FeedbackPage feedbackPage = new FeedbackPage(driver);
        }
    }
}
