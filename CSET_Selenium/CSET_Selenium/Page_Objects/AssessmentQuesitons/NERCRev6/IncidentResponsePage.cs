using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    /// <summary>
    /// 
    /// </summary>
    internal class IncidentResponsePage : BasePage
    {
        private IncidentResponse _incidentResponse;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="incidentResponse"></param>
        public IncidentResponsePage(IWebDriver driver, IncidentResponse incidentResponse) : base(driver)
        {
            this._incidentResponse = incidentResponse;

            // initialize page controls to backing object value
            this.IncidentResponsePlanReview = incidentResponse.IncidentResponseViews;

            // only update these controls if the value of the parent is yes or na
            if (incidentResponse.IncidentResponseViews.IsYESorALTorUNanswered())
            {
                this.NoLaterThan90CalendarDays = incidentResponse.NoLaterThan90CalendarDays;
                this.NoLaterThan60CalendarDays = incidentResponse.NoLaterThan60CalendarDays;
            }
        }

        #region Property Handlers
        public QuestionAnswers IncidentResponsePlanReview
        {
            get { return this._incidentResponse.IncidentResponseViews; }
            set
            {
                this._incidentResponse.IncidentResponseViews = value;

                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weIncidentResponsePlanReviewYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weIncidentResponsePlanReviewNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weIncidentResponsePlanReviewNA.Click();

                            break;
                        }
                }
            }
        }

        public QuestionAnswers NoLaterThan90CalendarDays
        {
            get { return this._incidentResponse.NoLaterThan90CalendarDays; }
            set
            {
                this._incidentResponse.NoLaterThan90CalendarDays = value;

                switch(value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weNoLaterThan90CalendarDaysYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weNoLaterThan90CalendarDaysNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weNoLaterThan90CalendarDaysNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weNoLaterThan90CalendarDaysAlt.Click();

                            break;
                        }
                }
            }
        }

        public QuestionAnswers NoLaterThan60CalendarDays
        {
            get { return this._incidentResponse.NoLaterThan60CalendarDays; }
            set
            {
                this._incidentResponse.NoLaterThan60CalendarDays = value;

                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weNoLaterThan60CalendarDaysYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weNoLaterThan60CalendarDaysNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weNoLaterThan60CalendarDaysNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weNoLaterThan60CalendarDaysAlt.Click();

                            break;
                        }
                }
            }
        }
        #endregion

        #region Incidence Reponse Web Elements
        // question Incident Response Plan Review
        private IWebElement weIncidentResponsePlanReviewYes
        {
            get {  return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[5]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]")); }
        }
        private IWebElement weIncidentResponsePlanReviewNo
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[5]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]")); }
        }
        private IWebElement weIncidentResponsePlanReviewNA
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[5]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]")); }
        }

        // question 1
        private IWebElement weNoLaterThan90CalendarDaysYes
        { 
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14575\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement weNoLaterThan90CalendarDaysNo
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14575\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement weNoLaterThan90CalendarDaysNA
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14575\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement weNoLaterThan90CalendarDaysAlt
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14575\"]/div[1]/div[2]/div/label[4]")); }
        }

        // question 2
        private IWebElement weNoLaterThan60CalendarDaysYes
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14579\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement weNoLaterThan60CalendarDaysNo
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14579\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement weNoLaterThan60CalendarDaysNA
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14579\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement weNoLaterThan60CalendarDaysAlt
        {
            get { return base.WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14579\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion
    }
}
