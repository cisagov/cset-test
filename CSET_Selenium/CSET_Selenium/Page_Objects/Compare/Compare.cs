using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Trend
{
    class Compare : BasePage
    {
        private readonly IWebDriver driver;

        public Compare(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators
        private IWebElement NewComparison
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@mattooltip='Create a new comparison']"));
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

        private IWebElement GenerateCompareReportButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Generate Compare Report')]"));
            }
        }

        //Interaction Methods
        private void ClickNewComparison()
        {
            NewComparison.Click();
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

        private void ClickGenerateCompareReport()
        {
            GenerateCompareReportButton.Click();
        }

        //Aggregate Methods

        public void NewTrend(String assessment1, String assessment2)
        {
            ClickNewComparison();
            ClickSelectAssessments();
            CheckboxAssessment(assessment1);
            CheckboxAssessment(assessment2);
            ClickNext();
            ClickGenerateCompareReport();
        }
    }
}
