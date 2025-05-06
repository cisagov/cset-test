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
    class ResultsByCategoryPage : BasePage, IReportPage
    {
        private readonly IWebDriver driver;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public ResultsByCategoryPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool ProcessData()
        {
            throw new NotImplementedException();
        }
    }
}
