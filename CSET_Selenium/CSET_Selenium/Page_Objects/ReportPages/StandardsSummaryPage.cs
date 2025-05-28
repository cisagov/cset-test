using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.Shared.Data_Types;
using CSET_Selenium.Page_Objects.Sidebar;

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
        }

        /// <summary>
        /// Set the StandardsSummary property values
        /// from the data contained in this page's controls
        /// </summary>
        /// <returns></returns>
        public void ProcessData()
        {
            string totalQuestionCount = WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-results/app-standards-summary/div/div[2]/table/tbody/tr[1]/td[3]")).Text;
            int nTotalQuestionCount = Convert.ToInt32(totalQuestionCount);

            string yesCount = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[1]/td[2]")).Text;
            this.StandardsSummary.Add(QuestionAnswers.YES, this.CreateRecord(yesCount));

            string noCount = WaitUntilElementIsVisible(By.XPath("//*[@id=\'sidenav-content\']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[2]/td[2]")).Text;
            this.StandardsSummary.Add(QuestionAnswers.NO, this.CreateRecord(noCount));

            string naCount = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[3]/td[2]")).Text;
            this.StandardsSummary.Add(QuestionAnswers.NA, this.CreateRecord(naCount));

            string altCount = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[4]/td[2]")).Text;
            this.StandardsSummary.Add(QuestionAnswers.ALT, CreateRecord(altCount));

            string unAnsweredCount = WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-results/app-standards-summary/div/div[2]/table/tbody/tr[5]/td[2]")).Text;
            this.StandardsSummary.Add(QuestionAnswers.NOANSWER, CreateRecord(unAnsweredCount));
        }

        private StandardSummaryRecord CreateRecord(string value)
        {
            int nUnAnsweredCount;
            int.TryParse(value, out nUnAnsweredCount);
            return new StandardSummaryRecord(nUnAnsweredCount);
        }

        public Dictionary<QuestionAnswers, StandardSummaryRecord> StandardsSummary { get; private set; } = new Dictionary<QuestionAnswers, StandardSummaryRecord>();
    }
}
