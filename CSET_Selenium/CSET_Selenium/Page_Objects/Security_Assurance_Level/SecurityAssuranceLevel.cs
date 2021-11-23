using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Security_Assurance_Level
{
    class SecurityAssuranceLevel : BasePage
    {
        private readonly IWebDriver driver;

        public SecurityAssuranceLevel(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement DropdownPrepare
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Prepare')]"));
            }
        }

        private IWebElement TextAssessementConfiguration
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Assessment Configuration')]"));
            }
        }

        private IWebElement TextAssessmentInformation
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Assessment Information')]"));
            }
        }

        private IWebElement TextSecurityAssuranceLevel
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Security Assurance Level')]"));
            }
        }

        private IWebElement TextCybersecurityStandardsSelection
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),' Cybersecurity Standards Selection ')]"));
            }
        }

        private IWebElement DropdownAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Assessment')]"));
            }
        }

        private IWebElement TextStandardQuestions
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Standard Questions')]"));
            }
        }

        private IWebElement DropdownStandardsResults
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Standards Results')]"));
            }
        }

        private IWebElement TextAnalysisDashboard
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Analysis Dashboard')]"));
            }
        }

        private IWebElement TextControlPriorities
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Control Priorities')]"));
            }
        }

        private IWebElement TextStandardsSummary
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Standards Summary')]"));
            }
        }

        private IWebElement TextRankedCategories
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Ranked Categories')]"));
            }
        }

        private IWebElement TextResultsByCategory
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[(text()= ' Results By Category ')]"));
            }
        }

        private IWebElement TextHighLevelAssessement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button/span[contains(text(), 'High-Level Assessment')]"));
            }
        }

        private IWebElement TextReports
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Reports')]"));
            }
        }

        private IWebElement TextFeedback
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Feedback')]"));
            }
        }

        //Interaction Methods

        private void ClickPrepare()
        {
            DropdownPrepare.Click();
        }

        private void ClickAssessementConfiguration()
        {
            TextAssessementConfiguration.Click();
        }

        private void ClickAssessmentInformation()
        {
            TextAssessmentInformation.Click();
        }

        private void ClickSecurityAssuranceLevel()
        {
            TextSecurityAssuranceLevel.Click();
        }

        private void ClickCybersecurityStandardsSelection()
        {
            TextCybersecurityStandardsSelection.Click();
        }

        private void ClickAssessment()
        {
            DropdownAssessment.Click();
        }

        private void ClickStandardQuestions()
        {
            TextStandardQuestions.Click();
        }

        private void ClickStandardsResults()
        {
            DropdownStandardsResults.Click();
        }

        private void ClickAnalysisDashboard()
        {
            TextAnalysisDashboard.Click();
        }

        private void ClickControlPriorities()
        {
            TextControlPriorities.Click();
        }

        private void ClickStandardsSummary()
        {
            TextStandardsSummary.Click();
        }

        private void ClickRankedCategories()
        {
            TextRankedCategories.Click();
        }

        private void ClickResultsByCategory()
        {
            TextResultsByCategory.Click();
        }

        private void ClickHighLevelAssessement()
        {
            TextHighLevelAssessement.Click();
        }

        private void ClickReports()
        {
            TextReports.Click();
        }

        private void ClickFeedback()
        {
            TextFeedback.Click();
        }


        //Aggregate Methods

        public void SelectPrepare()
        {
            ClickPrepare();
        }

        public void SelectAssessementConfiguration()
        {
            ClickAssessementConfiguration();
        }

        public void SelectAssessmentInformation()
        {
            ClickAssessmentInformation();
        }

        public void SelectSecurityAssuranceLevel()
        {
            ClickSecurityAssuranceLevel();
        }

        public void SelectCybersecurityStandardsSelection()
        {
            ClickCybersecurityStandardsSelection();
        }

        public void SelectAssessment()
        {
            ClickAssessment();
        }

        public void Select()
        {
            ClickCybersecurityStandardsSelection();
        }

        public void SelectStandardQuestions()
        {
            ClickStandardQuestions();
        }

        public void SelectStandardsResults()
        {
            ClickStandardsResults();
        }

        public void SelectAnalysisDashboard()
        {
            ClickAnalysisDashboard();
        }

        public void SelectControlPriorities()
        {
            ClickControlPriorities();
        }

        public void SelectStandardsSummary()
        {
            ClickStandardsSummary();
        }

        public void SelectRankedCategories()
        {
            ClickRankedCategories();
        }

        public void SelectResultsByCategory()
        {
            ClickResultsByCategory();
        }

        public void SelectHighLevelAssessement()
        {
            ClickHighLevelAssessement();
        }

        public void SelectReports()
        {
            ClickReports();
        }

        public void SelectFeedback()
        {
            ClickFeedback();
        }
    }
}
