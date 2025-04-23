using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using CSET_Selenium.Enums;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    /// <summary>
    /// 
    /// </summary>
    internal class VulerabilityAssementAndManagementPage : BasePage
    {
        private VulnerabilityAssementAndManagement _vulnerabilityAssementAndManagement;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="vulnerabilityAssessmentAndManagement"></param>
        public VulerabilityAssementAndManagementPage(IWebDriver webDriver, VulnerabilityAssementAndManagement vulnerabilityAssessmentAndManagement) : base(webDriver)
        {
            this._vulnerabilityAssementAndManagement = vulnerabilityAssessmentAndManagement;

            // initialize page controls to backing object value
            this.PerformOncePer36Months = vulnerabilityAssessmentAndManagement.PerformOncePer36Months;
        }

        public QuestionAnswers PerformOncePer36Months
        {
            get {  return this._vulnerabilityAssementAndManagement.PerformOncePer36Months; }
            set 
            { 
                switch(value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.wePerformOncePer36MonthsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.wePerformOncePer36MonthsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.wePerformOncePer36MonthsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.wePerformOncePer36MonthsALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement wePerformOncePer36MonthsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14620\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement wePerformOncePer36MonthsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14620\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement wePerformOncePer36MonthsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14620\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement wePerformOncePer36MonthsALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14620\"]/div[1]/div[2]/div/label[4]")); }
        }
    }
}
