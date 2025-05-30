using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.Shared.Data_Types;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.ReportPages
{
    /// <summary>
    /// Base page class for both RankedCategory and ResultsByCategory pages
    /// </summary>
    internal abstract class CategoryBasePage : BasePage
    {
        protected readonly IWebDriver driver;

        public Dictionary<RankedCategoryKeyNames, RankedCategoryRecord> Categories { get; private set; } =
            new Dictionary<RankedCategoryKeyNames, RankedCategoryRecord>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public CategoryBasePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        abstract protected string CreateXPathRecord(int row, int col);

        /// <summary>
        /// 
        /// </summary>
        abstract public void ProcessData();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected RankedCategoryRecord CreateRankedCategoryRecord(string name, int rank, int failed, int total, float percent)
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
        protected RankedCategoryKeyNames NameToKeyName(string name)
        {
            RankedCategoryKeyNames keyName;

            switch (name)
            {
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xPath"></param>
        /// <returns></returns>
        protected int XPathToIntegerValue(string xPath)
        {
            string strValue0 = WaitUntilElementIsVisible(By.XPath(xPath)).Text;
            strValue0 = strValue0.Contains('%') ? strValue0.Replace('%', ' ').Trim() : strValue0;

            int value = 0;
            int.TryParse(strValue0, out value);

            return value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xPath"></param>
        /// <returns></returns>
        protected string XPathToStringValue(string xPath)
        {
            return WaitUntilElementIsVisible(By.XPath(xPath)).Text;
        }
    }
}
