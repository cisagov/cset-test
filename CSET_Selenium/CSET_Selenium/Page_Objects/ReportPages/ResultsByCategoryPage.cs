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
    /// </summary>
    class ResultsByCategoryPage : CategoryBasePage, IReportPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public ResultsByCategoryPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Set the RankedCategories property value
        /// from the data contained in this page's controls
        /// </summary>
        /// <returns></returns>
        public override void ProcessData()
        {
            // RANKED CATEGORIES

            // category 1
            int row = 0;
            int col = 0;
            string category = this.XPathToStringValue(this.CreateXPathRecord(++row, ++col));
            int passed = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            int total = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            float percent = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            base.Categories.Add(this.NameToKeyName(category), this.CreateRankedCategoryRecord(category, 1, passed, total, percent));

            // category 2
            row += 1;
            col = 0;
            category = this.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            passed = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            base.Categories.Add(this.NameToKeyName(category), this.CreateRankedCategoryRecord(category, 2, passed, total, percent));

            // category 3
            row += 1;
            col = 0;
            category = this.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            passed = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            base.Categories.Add(this.NameToKeyName(category), this.CreateRankedCategoryRecord(category, 3, passed, total, percent));

            // category 4
            row += 1;
            col = 0;
            category = this.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            passed = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            base.Categories.Add(this.NameToKeyName(category), this.CreateRankedCategoryRecord(category, 4, passed, total, percent));

            // category 5
            row += 1;
            col = 0;
            category = this.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            passed = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            base.Categories.Add(this.NameToKeyName(category), this.CreateRankedCategoryRecord(category, 5, passed, total, percent));

            // category 6
            row += 1;
            col = 0;
            category = this.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            passed = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            base.Categories.Add(this.NameToKeyName(category), this.CreateRankedCategoryRecord(category, 6, passed, total, percent));

            // category 7
            row += 1;
            col = 0;
            category = this.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            passed = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = this.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            base.Categories.Add(this.NameToKeyName(category), this.CreateRankedCategoryRecord(category, 7, passed, total, percent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        protected override string CreateXPathRecord(int row, int col)
        {
            string xPathRecord = string.Format($"//*[@id=\"sidenav-content\"]/app-results/app-standards-results/div/div[2]/table/tbody/tr[{row}]/td[{col}]", row, col);

            return xPathRecord;
        }
    }
}
