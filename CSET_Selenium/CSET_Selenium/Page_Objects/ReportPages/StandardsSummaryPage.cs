using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;

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
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ProcessData()
        {
            return false;
        }
    }
}
