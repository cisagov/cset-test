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

        public enum KeyNames
        {
            SystemProtection,
            Recovery,
            RiskManagement,
            AccountManagement,
            PhysicalSecurity
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public AnalysisDashboardPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ProcessData()
        {
            return false;
        }

        public int OverallScore { get; private set; }
        
        public int AssessmentCompliance { get; private set; }

        public Dictionary<KeyNames, RankedCategoryRecord> RankedCategories { get; private set; }

        public Dictionary<QuestionAnswers, StandardSummaryRecord> StandardsSummary { get; private set; }
    }
}
