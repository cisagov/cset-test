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

        //Interaction Methods
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

        //Aggregate Methods

        public void NewTrend(String assessment1, String assessment2)
        {
            ClickNewTrend();
            ClickSelectAssessments();
            CheckboxAssessment(assessment1);
            CheckboxAssessment(assessment2);
            ClickNext();
            ClickGenerateTabReport();
        }
    }
}
