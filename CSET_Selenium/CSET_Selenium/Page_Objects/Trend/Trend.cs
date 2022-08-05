using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Trend
{
    class Trend : BasePage
    {
        private readonly IWebDriver driver;

        public Trend(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators
        private IWebElement CSET
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//app-logo-cset"));
            }
        }

        private IWebElement Remove
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(), 'Standard Assessment for Trend Test')]/ancestor::td/following-sibling::td//button[@mattooltip='Permanently remove this assessment.']"));
            }
        }

        private IWebElement YesButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(), 'Yes')]"));
            }
        }

        private IWebElement NewTrendButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@mattooltip='Create a new trend']"));
            }
        }

        private IWebElement SelectAssessmentsButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Select Assessments')]"));
            }
        }

        private IWebElement BackButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Back')]"));
            }
        }

        private IWebElement NextButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Next')]"));
            }
        }

        private IWebElement AssessmentCheckbox
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Back')]"));
            }
        }

        private IWebElement GenerateTrendReportButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Generate Trend Report')]"));
            }
        }
        
        private IWebElement GoToTrends
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Trend')]"));
            }
        }



        //Interaction Methods

        private void ClickCSET()
        {
            CSET.Click();
        }

        private void ClickYes()
        {
            YesButton.Click();
        }

        private void ClickNewTrend()
        {
            NewTrendButton.Click();
        }

        private void ClickSelectAssessments()
        {
            SelectAssessmentsButton.Click();
        }

        private void ClickBack()
        {
            BackButton.Click();
        }

        private void ClickNext()
        {
            NextButton.Click();
        }

        private void CheckboxAssessment(String str)
        {
            IWebElement el = WaitUntilElementIsVisible(By.XPath("//label[contains(text(), '" + str + "')]"));
            el.Click();
        }

        private void ClickGenerateTabReport()
        {
            GenerateTrendReportButton.Click();
        }

        private void ClickRemove()
        {
            Remove.Click();
        }

        private void ClickGoToTrends()
        {
            GoToTrends.Click();
        }


        //Aggregate Methods
        public void GoHome()
        {
            ClickCSET();
        }

        public void Yes()
        {
            ClickYes();
        }

        public void DeleteAssessment()
        {
            ClickRemove();
        }

        public void NewTrend(String assessment1, String assessment2)
        {
            ClickGoToTrends();
            ClickNewTrend();
            ClickSelectAssessments();
            CheckboxAssessment(assessment1);
            CheckboxAssessment(assessment2);
            ClickNext();
            ClickGenerateTabReport();
        }
    }
}
