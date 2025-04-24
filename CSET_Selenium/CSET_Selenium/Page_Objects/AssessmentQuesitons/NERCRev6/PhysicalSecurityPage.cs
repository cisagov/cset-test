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
    internal class PhysicalSecurityPage : BasePage
    {
        private PhysicalSecurity _physicalSecurity;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webDriver"></param>
        public PhysicalSecurityPage(IWebDriver webDriver, PhysicalSecurity physicalSecurity) : base(webDriver)
        {
            this._physicalSecurity = physicalSecurity;

            // initialize page controls to backing object value
            // Physical Security
            this.ForPrimaryControlCenters = physicalSecurity.ForPrimaryControlCenters;

            // Physical Security Plans
            this.OrganizationHavePhysicalSecurityPlan = physicalSecurity.OrganizationHavePhysicalSecurityPlan;

            // only update these controls if the value of the parent is yes or na
            if (physicalSecurity.OrganizationHavePhysicalSecurityPlan.IsYYESorALT())
            {
                this.PhysicalSecurityPlanWithin120Days = physicalSecurity.PhysicalSecurityPlanWithin120Days;
                this.PhysicalSecurityIncludeTheFollowing = physicalSecurity.PhysicalSecurityIncludeTheFollowing;
                this.DoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasures = physicalSecurity.DoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasures;
                this.DoesPhysicialSeucityPlanIncludeLawEnforcement = physicalSecurity.DoesPhysicialSeucityPlanIncludeLawEnforcement;
                this.DoesPhysicalSecurityPlanIncludeTimeline = physicalSecurity.DoesPhysicalSecurityPlanIncludeTimeline;
                this.DoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreats = physicalSecurity.DoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreats;
            }
        }

        public QuestionAnswers ForPrimaryControlCenters
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weForPrimaryControlCentersYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weForPrimaryControlCentersNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weForPrimaryControlCentersNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weForPrimaryControlCentersALT.Click();

                            break;
                        }
                }
            }
        }

        IWebElement weForPrimaryControlCentersYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14642\"]/div[1]/div[2]/div/label[1]")); }
        }

        IWebElement weForPrimaryControlCentersNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14642\"]/div[1]/div[2]/div/label[2]")); }
        }

        IWebElement weForPrimaryControlCentersNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14642\"]/div[1]/div[2]/div/label[3]")); }
        }

        IWebElement weForPrimaryControlCentersALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14642\"]/div[1]/div[2]/div/label[4]")); }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers OrganizationHavePhysicalSecurityPlan
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weOrganizationHavePhysicalSecurityPlanYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weOrganizationHavePhysicalSecurityPlanNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weOrganizationHavePhysicalSecurityPlanNA.Click();

                            break;
                        }
                }
            }
        }

        IWebElement weOrganizationHavePhysicalSecurityPlanYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[6]/app-category-block/div[3]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]")); }
        }

        IWebElement weOrganizationHavePhysicalSecurityPlanNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[6]/app-category-block/div[3]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]")); }
        }

        IWebElement weOrganizationHavePhysicalSecurityPlanNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[6]/app-category-block/div[3]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]")); }
        }

        IWebElement weOrganizationHavePhysicalSecurityPlanALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[6]/app-category-block/div[3]/app-question-block/div/div[1]/div[2]/div[2]/div/label[4]")); }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers PhysicalSecurityPlanWithin120Days
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weBaselinePhysicalSecurityPlanWithin120DaysYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weBaselinePhysicalSecurityPlanWithin120DaysNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weBaselinePhysicalSecurityPlanWithin120DaysNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weBaselinePhysicalSecurityPlanWithin120DaysALT.Click();

                            break;
                        }
                }
            }
        }

        IWebElement weBaselinePhysicalSecurityPlanWithin120DaysYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14646\"]/div[1]/div[2]/div/label[1]")); }
        }

        IWebElement weBaselinePhysicalSecurityPlanWithin120DaysNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14646\"]/div[1]/div[2]/div/label[2]")); }
        }

        IWebElement weBaselinePhysicalSecurityPlanWithin120DaysNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14646\"]/div[1]/div[2]/div/label[3]")); }
        }

        IWebElement weBaselinePhysicalSecurityPlanWithin120DaysALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14646\"]/div[1]/div[2]/div/label[4]")); }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers IncidentResponseViews
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weIncidentResponseViewsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weIncidentResponseViewsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weIncidentResponseViewsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weIncidentResponseViewsALT.Click();

                            break;
                        }
                }
            }
        }

        IWebElement weIncidentResponseViewsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("")); }
        }

        IWebElement weIncidentResponseViewsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("")); }
        }

        IWebElement weIncidentResponseViewsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("")); }
        }

        IWebElement weIncidentResponseViewsALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("")); }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers PhysicalSecurityIncludeTheFollowing
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.wePhysicalSecurityIncludeTheFollowingYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.wePhysicalSecurityIncludeTheFollowingNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.wePhysicalSecurityIncludeTheFollowingNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.wePhysicalSecurityIncludeTheFollowingALT.Click();

                            break;
                        }
                }
            }
        }

        IWebElement wePhysicalSecurityIncludeTheFollowingYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14647\"]/div[1]/div[2]/div/label[1]")); }
        }

        IWebElement wePhysicalSecurityIncludeTheFollowingNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14647\"]/div[1]/div[2]/div/label[2]")); }
        }

        IWebElement wePhysicalSecurityIncludeTheFollowingNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14647\"]/div[1]/div[2]/div/label[3]")); }
        }

        IWebElement wePhysicalSecurityIncludeTheFollowingALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14647\"]/div[1]/div[2]/div/label[4]")); }
        }

        public QuestionAnswers DoesPhysicialSeucityPlanIncludeLawEnforcement
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weDoesPhysicialSeucityPlanIncludeLawEnforcementYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weDoesPhysicialSeucityPlanIncludeLawEnforcementNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weDoesPhysicialSeucityPlanIncludeLawEnforcementNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weDoesPhysicialSeucityPlanIncludeLawEnforcementALT.Click();

                            break;
                        }
                }
            }
        }

        public IWebElement weDoesPhysicialSeucityPlanIncludeLawEnforcementYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14649\"]/div[1]/div[2]/div/label[1]")); }
        }

        public IWebElement weDoesPhysicialSeucityPlanIncludeLawEnforcementNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14649\"]/div[1]/div[2]/div/label[2]")); }
        }

        public IWebElement weDoesPhysicialSeucityPlanIncludeLawEnforcementNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14649\"]/div[1]/div[2]/div/label[3]")); }
        }
        public IWebElement weDoesPhysicialSeucityPlanIncludeLawEnforcementALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14649\"]/div[1]/div[2]/div/label[4]")); }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers DoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasures
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weDoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasuresYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weDoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasuresNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weDoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasuresNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weDoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasuresALT.Click();

                            break;
                        }
                }
            }
        }

        IWebElement weDoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasuresYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14648\"]/div[1]/div[2]/div/label[1]")); }
        }

        IWebElement weDoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasuresNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14648\"]/div[1]/div[2]/div/label[2]")); }
        }

        IWebElement weDoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasuresNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14648\"]/div[1]/div[2]/div/label[3]")); }
        }

        IWebElement weDoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasuresALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14648\"]/div[1]/div[2]/div/label[4]")); }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers DoesPhysicalSecurityPlanIncludeTimeline
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weDoesPhysicalSecurityPlanIncludeTimelineYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weDoesPhysicalSecurityPlanIncludeTimelineNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weDoesPhysicalSecurityPlanIncludeTimelineNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weDoesPhysicalSecurityPlanIncludeTimelineALT.Click();

                            break;
                        }
                }
            }
        }

        IWebElement weDoesPhysicalSecurityPlanIncludeTimelineYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14650\"]/div[1]/div[2]/div/label[1]")); }
        }

        IWebElement weDoesPhysicalSecurityPlanIncludeTimelineNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14650\"]/div[1]/div[2]/div/label[2]")); }
        }

        IWebElement weDoesPhysicalSecurityPlanIncludeTimelineNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14650\"]/div[1]/div[2]/div/label[3]")); }
        }

        IWebElement weDoesPhysicalSecurityPlanIncludeTimelineALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14650\"]/div[1]/div[2]/div/label[4]")); }
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers DoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreats
        {
            get { return this.ForPrimaryControlCenters; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weDoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreatsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weDoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreatsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weDoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreatsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weDoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreatsALT.Click();

                            break;
                        }
                }
            }
        }

        IWebElement weDoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreatsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14651\"]/div[1]/div[2]/div/label[1]")); }
        }

        IWebElement weDoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreatsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14651\"]/div[1]/div[2]/div/label[2]")); }
        }

        IWebElement weDoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreatsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14651\"]/div[1]/div[2]/div/label[3]")); }
        }

        IWebElement weDoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreatsALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14651\"]/div[1]/div[2]/div/label[4]")); }
        }
    }
}
