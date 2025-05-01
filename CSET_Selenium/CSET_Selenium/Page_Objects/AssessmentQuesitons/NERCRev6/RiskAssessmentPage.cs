using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    /// <summary>
    /// 
    /// </summary>
    internal class RiskAssessmentPage : BasePage
    {
        private RiskAssessment _riskAssessment;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="riskAssessment"></param>
        public RiskAssessmentPage(IWebDriver webDriver, RiskAssessment riskAssessment) : base(webDriver)
        {
            this._riskAssessment = riskAssessment;

            this.RiskAssessments = riskAssessment.RiskAssessments;

            if (riskAssessment.RiskAssessments.IsYESorALTorUNanswered())
            {
                this.InitialRiskAssessment = riskAssessment.InitialRiskAssessment;
                this.SubsequentRiskAssessments = riskAssessment.SubsequentRiskAssessments;
                this.PrimaryControlCenter = riskAssessment.PrimaryControlCenter;
            }
        }

        public QuestionAnswers RiskAssessments
        {
            get { return this.RiskAssessments; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weRiskAssessmentYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weRiskAssessmentNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weRiskAssessmentNA.Click();

                            break;
                        }
                }
            }
        }

        public QuestionAnswers InitialRiskAssessment
        {
            get { return this.RiskAssessments; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weInitialRiskAssessmentYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weInitialRiskAssessmentNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weInitialRiskAssessmentNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weInitialRiskAssessmentAlt.Click();

                            break;
                        }
                }
            }
        }

        public QuestionAnswers SubsequentRiskAssessments
        {
            get { return this.RiskAssessments; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weSubsequentRiskAssessmentsYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weSubsequentRiskAssessmentsNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weSubsequentRiskAssessmentsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weSubsequentRiskAssessmentsAlt.Click();

                            break;
                        }
                }
            }
        }

        public QuestionAnswers PrimaryControlCenter
        {
            get { return this.RiskAssessments; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.wePrimaryControlCenterYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.wePrimaryControlCenterNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.wePrimaryControlCenterNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.wePrimaryControlCenterAlt.Click();

                            break;
                        }
                }
            }
        }


        // Risk Assessment
        public IWebElement weRiskAssessmentYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[9]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]")); }
        }
        public IWebElement weRiskAssessmentNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[9]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]")); }
        }
        public IWebElement weRiskAssessmentNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[9]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]")); }
        }

        // Question 1
        public IWebElement weInitialRiskAssessmentYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14631\"]/div[1]/div[2]/div/label[1]")); }
        }
        public IWebElement weInitialRiskAssessmentNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14631\"]/div[1]/div[2]/div/label[2]")); }
        }
        public IWebElement weInitialRiskAssessmentNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14631\"]/div[1]/div[2]/div/label[3]")); }
        }
        public IWebElement weInitialRiskAssessmentAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14631\"]/div[1]/div[2]/div/label[4]")); }
        }

        // Question 2
        public IWebElement weSubsequentRiskAssessmentsYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14632\"]/div[1]/div[2]/div/label[1]")); }
        }
        public IWebElement weSubsequentRiskAssessmentsNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14632\"]/div[1]/div[2]/div/label[2]")); }
        }
        public IWebElement weSubsequentRiskAssessmentsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14632\"]/div[1]/div[2]/div/label[3]")); }
        }
        public IWebElement weSubsequentRiskAssessmentsAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14632\"]/div[1]/div[2]/div/label[4]")); }
        }

        // Question 3
        public IWebElement wePrimaryControlCenterYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14633\"]/div[1]/div[2]/div/label[1]")); }
        }
        public IWebElement wePrimaryControlCenterNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14633\"]/div[1]/div[2]/div/label[2]")); }
        }
        public IWebElement wePrimaryControlCenterNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14633\"]/div[1]/div[2]/div/label[3]")); }
        }
        public IWebElement wePrimaryControlCenterAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14633\"]/div[1]/div[2]/div/label[4]")); }
        }
    }
}
