using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using NERC6 = CSET_Selenium.Repositories.NERC_Rev_6;
using CSET_Selenium.Repositories.Shared.Data_Types;
using CSET_Selenium.Enums;


namespace CSET_Selenium.Page_Objects.ReportPages
{
    /// <summary>
    /// 
    /// </summary>
    class AnalysisDashboardPage : BasePage, IReportPage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public AnalysisDashboardPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Set the StandardsSummary property values
        /// from the data contained in this page's controls
        /// </summary>
        /// <returns></returns>
        public void ProcessData()
        {
            // SCORE
            string scoreText = WaitUntilElementIsVisible(By.XPath("//*[@id=\"overall-score\"]/div[2]")).Text;
            int score;
            int.TryParse(scoreText, out score);
            this.OverallScore = score;

            // ASSESSMENT COMPLIANCE
            this.AssessmentCompliance = this.OverallScore;

            // RANKED CATEGORIES

            // category 1
            IWebElement canvas = WaitUntilElementIsVisible(By.XPath("//*[@id=\"canvasTopCategories\"]"));
            //string name = "";
            //int value = 0;
            //this.RankedCategories.Add(RankedCategoryKeyNames.SystemProtection, this.CreateRankedCategoryRecord(name, 1, value));

            //// category 2
            //name = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[1]/td[2]")).Text;
            //value = 0;
            //this.RankedCategories.Add(RankedCategoryKeyNames.Recovery, this.CreateRankedCategoryRecord(name, 2, value));

            //// category 3
            //name = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[1]/td[2]")).Text;
            //value = 0;
            //this.RankedCategories.Add(RankedCategoryKeyNames.RiskManagement, this.CreateRankedCategoryRecord(name, 3, value));

            //// category 4
            //name = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[1]/td[2]")).Text;
            //value = 0;
            //this.RankedCategories.Add(RankedCategoryKeyNames.AccountManagement, this.CreateRankedCategoryRecord(name, 4, value));

            //// category 5
            //name = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[1]/td[2]")).Text;
            //value = 0;
            //this.RankedCategories.Add(RankedCategoryKeyNames.PhysicalSecurity, this.CreateRankedCategoryRecord(name, 5, value));

            //// STANDARD SUMMARY
            //string totalQuestionCount = WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-results/app-standards-summary/div/div[2]/table/tbody/tr[1]/td[3]")).Text;
            //int nTotalQuestionCount = Convert.ToInt32(totalQuestionCount);

            //string yesCount = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[1]/td[2]")).Text;
            //this.StandardsSummary.Add(QuestionAnswers.YES, this.CreateStandardSummaryRecord(yesCount));

            //string noCount = WaitUntilElementIsVisible(By.XPath("//*[@id=\'sidenav-content\']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[2]/td[2]")).Text;
            //this.StandardsSummary.Add(QuestionAnswers.NO, this.CreateStandardSummaryRecord(noCount));

            //string naCount = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[3]/td[2]")).Text;
            //this.StandardsSummary.Add(QuestionAnswers.NA, this.CreateStandardSummaryRecord(naCount));

            //string altCount = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[4]/td[2]")).Text;
            //this.StandardsSummary.Add(QuestionAnswers.ALT, CreateStandardSummaryRecord(altCount));

            //string unAnsweredCount = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[5]/td[2]")).Text;
            //this.StandardsSummary.Add(QuestionAnswers.NOANSWER, CreateStandardSummaryRecord(unAnsweredCount));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private RankedCategoryRecord CreateRankedCategoryRecord(string name, int rank, int failed, int total, int percent)
        {
            RankedCategoryRecord newRecord = new RankedCategoryRecord(name, rank, failed, total, percent);

            return newRecord;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private StandardSummaryRecord CreateStandardSummaryRecord(string value)
        {
            int nUnAnsweredCount;
            int.TryParse(value, out nUnAnsweredCount);
            return new StandardSummaryRecord(nUnAnsweredCount);
        }

        public int OverallScore { get; private set; }
        
        public int AssessmentCompliance { get; private set; }

        //public Dictionary<RankedCategoryKeyNames, RankedCategoryRecord> RankedCategories { get; private set; } = new Dictionary<RankedCategoryKeyNames, RankedCategoryRecord>();

        //public Dictionary<QuestionAnswers, StandardSummaryRecord> StandardsSummary { get; private set; } = new Dictionary<QuestionAnswers, StandardSummaryRecord>();
    }
}
