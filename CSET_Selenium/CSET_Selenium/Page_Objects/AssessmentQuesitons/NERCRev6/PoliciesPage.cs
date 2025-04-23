using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using CSET_Selenium.Enums;
using OpenQA.Selenium;
using CSET_Selenium.Enums.Questions;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    /// <summary>
    /// 
    /// </summary>
    internal class PoliciesPage : BasePage
    {
        private Policies _policies;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="policies"></param>
        public PoliciesPage(IWebDriver webDriver, Policies policies) : base(webDriver)
        {
            _policies = policies;

            // initialize page controls to backing object value
            this.CyberSecurityPlan = policies.ProcessToAddressAccess;
            this.CyberSecurityPolicies = policies.CIPSeniorManagerApproval;
        }

        public QuestionAnswers CyberSecurityPlan
        {
            get { return this._policies.ProcessToAddressAccess; }
            set
            {
                this._policies.ProcessToAddressAccess = value;

                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weCyberSecurityPlanYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weCyberSecurityPlanNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weCyberSecurityPlanNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weCyberSecurityPlanAlt.Click();

                            break;
                        }
                }
            }
        }

        public QuestionAnswers CyberSecurityPolicies
        {
            get { return this._policies.CIPSeniorManagerApproval; }
            set
            {
                this._policies.CIPSeniorManagerApproval = value;

                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weCyberSecurityPoliciesYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weCyberSecurityPoliciesNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weCyberSecurityPoliciesNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weCyberSecurityPoliciesAlt.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weCyberSecurityPlanYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14477\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement weCyberSecurityPlanNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14477\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weCyberSecurityPlanNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14477\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weCyberSecurityPlanAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14477\"]/div[1]/div[2]/div/label[4]")); }
        }

        private IWebElement weCyberSecurityPoliciesYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14471\"]/div[1]/div[2]/div[1]/label[1]")); }
        }
        private IWebElement weCyberSecurityPoliciesNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14471\"]/div[1]/div[2]/div[1]/label[2]")); }
        }
        private IWebElement weCyberSecurityPoliciesNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14471\"]/div[1]/div[2]/div[1]/label[3]")); }
        }
        private IWebElement weCyberSecurityPoliciesAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14471\"]/div[1]/div[2]/div[1]/label[4]")); }
        }
    }
}
