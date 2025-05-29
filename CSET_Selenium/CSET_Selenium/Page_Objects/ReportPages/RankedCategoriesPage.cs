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

        public Dictionary<RankedCategoryKeyNames, RankedCategoryRecord> RankedCategories { get; private set; } =
            new Dictionary<RankedCategoryKeyNames, RankedCategoryRecord>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public RankedCategoriesPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Set the RankedCategories property value
        /// from the data contained in this page's controls
        /// </summary>
        /// <returns></returns>
        public void ProcessData()
        {
            // RANKED CATEGORIES

            // category 1
            int row = 0;
            int col = 0;
            string name = base.XPathToStringValue(this.CreateXPathRecord(++row, ++col));
            int rank = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            int failed = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            int total = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            float percent = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            this.RankedCategories.Add(this.NameToKeyName(name), this.CreateRankedCategoryRecord(name, 1, failed, total, percent));

            // category 2
            row +=1 ;
            col = 0;
            name = base.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            rank = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            failed = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            this.RankedCategories.Add(this.NameToKeyName(name), this.CreateRankedCategoryRecord(name, 2, failed, total, percent));

            // category 3
            row += 1;
            col = 0;
            name = base.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            rank = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            failed = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            this.RankedCategories.Add(this.NameToKeyName(name), this.CreateRankedCategoryRecord(name, 3, failed, total, percent));

            // category 4
            row += 1;
            col = 0;
            name = base.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            rank = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            failed = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            this.RankedCategories.Add(this.NameToKeyName(name), this.CreateRankedCategoryRecord(name, 4, failed, total, percent));

            // category 5
            row += 1;
            col = 0;
            name = base.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            rank = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            failed = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            this.RankedCategories.Add(this.NameToKeyName(name), this.CreateRankedCategoryRecord(name, 5, failed, total, percent));

            // category 6
            row += 1;
            col = 0;
            name = base.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            rank = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            failed = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            this.RankedCategories.Add(this.NameToKeyName(name), this.CreateRankedCategoryRecord(name, 6, failed, total, percent));

            // category 7
            row += 1;
            col = 0;
            name = base.XPathToStringValue(this.CreateXPathRecord(row, ++col));
            rank = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            failed = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            total = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            percent = base.XPathToIntegerValue(this.CreateXPathRecord(row, ++col));
            this.RankedCategories.Add(this.NameToKeyName(name), this.CreateRankedCategoryRecord(name, 7, failed, total, percent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private string CreateXPathRecord(int row, int col)
        {
            string xPathRecord = string.Format($"//*[@id=\"sidenav-content\"]/app-results/app-standards-ranked/div/div/div[2]/table/tbody/tr[{row}]/td[{col}]", row, col);

            return xPathRecord;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private RankedCategoryRecord CreateRankedCategoryRecord(string name, int rank, int failed, int total, float percent)
        {
            RankedCategoryRecord newRecord = new RankedCategoryRecord(name, rank, failed, total, percent);

            return newRecord;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        private RankedCategoryKeyNames NameToKeyName(string name)
        {
            RankedCategoryKeyNames keyName;

            switch (name) {
                case "System Protection":
                    {
                        keyName = RankedCategoryKeyNames.SystemProtection;

                        break;
                    }
                case "Recovery":
                    {
                        keyName = RankedCategoryKeyNames.Recovery;

                        break;
                    }
                case "Risk Management":
                case "Risk Assessment":
                    {
                        keyName = RankedCategoryKeyNames.RiskManagement;

                        break;
                    }
                case "Account Management":
                    {
                        keyName = RankedCategoryKeyNames.AccountManagement;

                        break;
                    }
                case "Physical Security":
                    {
                        keyName = RankedCategoryKeyNames.PhysicalSecurity;

                        break;
                    }
                case "Incident Response":
                    {
                        keyName = RankedCategoryKeyNames.IncidentResponse;

                        break;
                    }
                case "Policies":
                    {
                        keyName = RankedCategoryKeyNames.Policies;

                        break;
                    }
                case "Vulerability Assessment And Management":
                    {
                        keyName = RankedCategoryKeyNames.VulnerabilityAssessmentAndManagement;

                        break;
                    }
                case "Configuration Management":
                    {
                        keyName = RankedCategoryKeyNames.ConfigurationManagement;

                        break;
                    }
                default:
                    {
                        throw new ApplicationException(
                            string.Format("No such ranked category name => {0}", name)
                            );
                    }
            }

            return keyName;
        }
    }
}
