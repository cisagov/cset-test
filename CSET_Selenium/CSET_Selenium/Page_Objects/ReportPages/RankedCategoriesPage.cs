using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Repositories.Shared.Data_Types;

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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ProcessData()
        {
            return false;
        }

        public List<RankedCategoryRecord> RankedCategories { get; private set; } = new List<RankedCategoryRecord>();
    }
}
