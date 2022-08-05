using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private IWebElement Next
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(), 'Next')]"));
            }
        }

        private IWebElement OK
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(), 'OK')]"));
            }
        }

        private IWebElement Tools
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Tools')]"));
            }
        }
        private IWebElement GoToCompare
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Compare')]"));
            }
        }

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

        //Interaction Methods
        private void ClickNextButton()
        {
            Next.Click();
        }

        private void ClickGoToCompare()
        {
            Tools.Click();
            GoToCompare.Click();
        }

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


        private void CheckboxAssessment(String str)
        {
            IWebElement el = WaitUntilElementIsVisible(By.XPath("//label[contains(text(), '" + str + "')]"));
            el.Click();
        }

        private void ClickGenerateCompareReport()
        {
            GenerateCompareReportButton.Click();
        }

        private void ClickCSET()
        {
            CSET.Click();
        }

        private void ClickYes()
        {
            YesButton.Click();
        }

        private void ClickOK()
        {
            OK.Click();
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


        public void NewCompare(String assessment1, String assessment2)
        {
            GoHome();
            ClickGoToCompare();
            ClickNewComparison();
            ClickSelectAssessments();
            CheckboxAssessment(assessment1);
            CheckboxAssessment(assessment2);
            ClickOK();
            Thread.Sleep(2000);
            ClickNextButton();
            ClickGenerateCompareReport();
        }
    }
}
