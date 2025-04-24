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
    internal class RecoveryPage : BasePage
    {
        private Recovery _recovery;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="recovery"></param>
        public RecoveryPage(IWebDriver webDriver, Recovery recovery) : base(webDriver)
        {
            this._recovery = recovery;

            this.RecoveryPlanReviews = recovery.RecoveryPlanReviews;

            if (recovery.RecoveryPlanReviews.IsYYESorALT())
            {
                this.PerformWithin90Days = recovery.PerformWithin90Days;
                this.ChangeToRolesOrResponsibilitiesRespondersOrTechnology = recovery.ChangeToRolesOrResponsibilitiesRespondersOrTechnology;
            }
        }

        public QuestionAnswers RecoveryPlanReviews
        {
            get {  return this._recovery.RecoveryPlanReviews; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weRecoveryPlanReviewYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weRecoveryPlanReviewNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weRecoveryPlanReviewNA.Click();

                            break;
                        }
                }
            }
        }

        public QuestionAnswers PerformWithin90Days
        {
            get { return this._recovery.PerformWithin90Days; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.wePerformWithin90DaysYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.wePerformWithin90DaysNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.wePerformWithin90DaysNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.wePerformWithin90DaysAlt.Click();

                            break;
                        }
                }
            }
        }

        public QuestionAnswers ChangeToRolesOrResponsibilitiesRespondersOrTechnology
        {
            get { return this._recovery.ChangeToRolesOrResponsibilitiesRespondersOrTechnology; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weChangeToRolesOrResponsibilitiesRespondersOrTechnologyYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weChangeToRolesOrResponsibilitiesRespondersOrTechnologyNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weChangeToRolesOrResponsibilitiesRespondersOrTechnologyNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weChangeToRolesOrResponsibilitiesRespondersOrTechnologyAlt.Click();

                            break;
                        }
                }
            }
        }

        // Recovery Plan Review
        private IWebElement weRecoveryPlanReviewYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[8]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]")); }
        }

        private IWebElement weRecoveryPlanReviewNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[8]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]")); }
        }

        private IWebElement weRecoveryPlanReviewNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[8]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]")); }
        }

        // Question 1
        private IWebElement wePerformWithin90DaysYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14593\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement wePerformWithin90DaysNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14593\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement wePerformWithin90DaysNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14593\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement wePerformWithin90DaysAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14593\"]/div[1]/div[2]/div/label[4]")); }
        }

        // Question 2
        private IWebElement weChangeToRolesOrResponsibilitiesRespondersOrTechnologyYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14597\"]/div[1]/div[2]/div/label[1]")); }
        }
        private IWebElement weChangeToRolesOrResponsibilitiesRespondersOrTechnologyNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14597\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weChangeToRolesOrResponsibilitiesRespondersOrTechnologyNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14597\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weChangeToRolesOrResponsibilitiesRespondersOrTechnologyAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14593\"]/div[1]/div[2]/div/label[4]")); }
        }
    }
}
