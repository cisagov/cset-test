using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.Shared.Data_Types;

namespace CSET_Selenium.Page_Objects.ReportPages
{
    /// <summary>
    /// 
    /// </summary>
    class StandardsSummaryPage : BasePage, IReportPage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public StandardsSummaryPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;

            this.StandardsSummary.Add(QuestionAnswers.YES, new StandardSummaryRecord(0));
            this.StandardsSummary.Add(QuestionAnswers.NO, new StandardSummaryRecord(0));
            this.StandardsSummary.Add(QuestionAnswers.NA, new StandardSummaryRecord(0));
            this.StandardsSummary.Add(QuestionAnswers.ALT, new StandardSummaryRecord(0));
            this.StandardsSummary.Add(QuestionAnswers.NOANSWER, new StandardSummaryRecord(0));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ProcessData()
        {
            return false;
        }

        public Dictionary<QuestionAnswers, StandardSummaryRecord> StandardsSummary { get; private set; } = new Dictionary<QuestionAnswers, StandardSummaryRecord>();
    }
}
