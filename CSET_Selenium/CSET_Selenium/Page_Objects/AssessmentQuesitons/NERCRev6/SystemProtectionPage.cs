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
    internal class SystemProtectionPage : BasePage
    {
        private SystemProtection _systemProtection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="systemProtection"></param>
        public SystemProtectionPage(IWebDriver webDriver, SystemProtection systemProtection) : base(webDriver)
        {
            this._systemProtection = systemProtection;

            // initialize page controls to backing object value
            this.SecurityEventLogging = systemProtection.SecurityEventLogging;

            if (systemProtection.SecurityEventLogging.IsYYESorALT())
            {
                this.BESCyberSystemsLevelLogging = systemProtection.BESCyberSystemsLevelLogging;
                this.AlertsForSecurityEvents = systemProtection.AlertsForSecurityEvents;
            }
        }

        public QuestionAnswers SecurityEventLogging
        {
            get { return _systemProtection.SecurityEventLogging;}
            set 
            { 
                _systemProtection.SecurityEventLogging = value;

                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weSecurityEventLogingYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weSecurityEventLogingNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weSecurityEventLogingNA.Click();

                            break;
                        }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers BESCyberSystemsLevelLogging
        {
            get { return _systemProtection.BESCyberSystemsLevelLogging; }
            set 
            { 
                _systemProtection.BESCyberSystemsLevelLogging = value;

                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weBESCyberSystemsLevelLoggingYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weBESCyberSystemsLevelLoggingNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weBESCyberSystemsLevelLoggingNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weBESCyberSystemsLevelLoggingAlt.Click();

                            break;
                        }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers AlertsForSecurityEvents
        {
            get { return _systemProtection.AlertsForSecurityEvents; }
            set 
            { 
                _systemProtection.AlertsForSecurityEvents = value;

                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weAlertsForSecurityEventsYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weAlertsForSecurityEventsNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weAlertsForSecurityEventsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weAlertsForSecurityEventsAlt.Click();

                            break;
                        }
                }
            }
        }

        // Security Event Logging
        private IWebElement weSecurityEventLogingYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[10]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]")); }
        }
        private IWebElement weSecurityEventLogingNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[10]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]")); }
        }
        private IWebElement weSecurityEventLogingNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[10]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]")); }
        }

        // Question 1
        private IWebElement weBESCyberSystemsLevelLoggingYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14547\"]/div[1]/div[2]/div/label[1]")); }
        }
        private IWebElement weBESCyberSystemsLevelLoggingNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14547\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weBESCyberSystemsLevelLoggingNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14547\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weBESCyberSystemsLevelLoggingAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14547\"]/div[1]/div[2]/div/label[4]")); }
        }

        // Question 2
        private IWebElement weAlertsForSecurityEventsYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14551\"]/div[1]/div[2]/div/label[1]")); }
        }
        private IWebElement weAlertsForSecurityEventsNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14551\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weAlertsForSecurityEventsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14551\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weAlertsForSecurityEventsAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14551\"]/div[1]/div[2]/div/label[4]")); }
        }
    }
}
