using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Repositories.Shared.Data_Types;
using CSET_Selenium.Enums;
using static CSET_Selenium.Page_Objects.ReportPages.AnalysisDashboardPage;

namespace CSET_Selenium.Page_Objects.ReportPages
{
    /// <summary>
    /// 
    /// </summary>
    class RankedCategoriesPage : BasePage, IReportPage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public RankedCategoriesPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;

            this.RankedCategories.Add(QuestionAnswers.YES, new RankedCategoryRecord(
                RankedCategoryKeyNames.SystemProtection.ToString(), 1, 0)
                );

            this.RankedCategories.Add(QuestionAnswers.NO, new RankedCategoryRecord(
                RankedCategoryKeyNames.Recovery.ToString(), 2, 0)
                );

            this.RankedCategories.Add(QuestionAnswers.NA, new RankedCategoryRecord(
                RankedCategoryKeyNames.RiskManagement.ToString(), 3, 0)
                );

            this.RankedCategories.Add(QuestionAnswers.ALT, new RankedCategoryRecord(
                RankedCategoryKeyNames.AccountManagement.ToString(), 4, 0)
                );

            this.RankedCategories.Add(QuestionAnswers.NOANSWER, new RankedCategoryRecord(
                RankedCategoryKeyNames.PhysicalSecurity.ToString(), 5, 0)
                );
        }

        /// <summary>
        /// Set the RankedCategories property value
        /// from the data contained in this page's controls
        /// </summary>
        /// <returns></returns>
        public void ProcessData()
        {
        }

        public Dictionary<QuestionAnswers, RankedCategoryRecord> RankedCategories { get; private set; } = new Dictionary<QuestionAnswers, RankedCategoryRecord>();
    }
}
