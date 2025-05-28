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

            this.RankedCategories.Add(RankedCategoryKeyNames.SystemProtection, new RankedCategoryRecord(
                RankedCategoryKeyNames.SystemProtection.ToString(), 1, 0)
                );

            this.RankedCategories.Add(RankedCategoryKeyNames.Recovery, new RankedCategoryRecord(
                RankedCategoryKeyNames.Recovery.ToString(), 2, 0)
                );

            this.RankedCategories.Add(RankedCategoryKeyNames.RiskManagement, new RankedCategoryRecord(
                RankedCategoryKeyNames.RiskManagement.ToString(), 3, 0)
                );

            this.RankedCategories.Add(RankedCategoryKeyNames.AccountManagement, new RankedCategoryRecord(
                RankedCategoryKeyNames.AccountManagement.ToString(), 4, 0)
                );

            this.RankedCategories.Add(RankedCategoryKeyNames.PhysicalSecurity, new RankedCategoryRecord(
                RankedCategoryKeyNames.PhysicalSecurity.ToString(), 5, 0)
                );

            this.StandardsSummary.Add(QuestionAnswers.YES, new StandardSummaryRecord(0));
            this.StandardsSummary.Add(QuestionAnswers.NO, new StandardSummaryRecord(0));
            this.StandardsSummary.Add(QuestionAnswers.NA, new StandardSummaryRecord(0));
            this.StandardsSummary.Add(QuestionAnswers.ALT, new StandardSummaryRecord(0));
            this.StandardsSummary.Add(QuestionAnswers.NOANSWER, new StandardSummaryRecord(0));
        }

        /// <summary>
        /// Set the OverallScore, AssessmentCompliance, RankedCategories and StandardsSummary property values
        /// from the data contained in this page's controls
        /// </summary>
        /// <returns></returns>
        public void ProcessData()
        {
        }

        public int OverallScore { get; private set; }
        
        public int AssessmentCompliance { get; private set; }

        public Dictionary<RankedCategoryKeyNames, RankedCategoryRecord> RankedCategories { get; private set; } = new Dictionary<RankedCategoryKeyNames, RankedCategoryRecord>();

        public Dictionary<QuestionAnswers, StandardSummaryRecord> StandardsSummary { get; private set; } = new Dictionary<QuestionAnswers, StandardSummaryRecord>();
    }
}
