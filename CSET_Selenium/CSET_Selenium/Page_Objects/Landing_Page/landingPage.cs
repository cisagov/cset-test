using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Landing_Page
{
    class LandingPage : BasePage
    {
        private readonly IWebDriver driver;

        public LandingPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators
        private IWebElement ButtonNewAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'New Assessment')]/ancestor::button"));
                //return WaitUntilElementIsVisible(By.XPath("//button[@mattooltip='Start a new and empty assessment.']"));
            }
        }

        private IWebElement TabMyAssessments
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'My Assessments')]/ancestor::button"));
            }
        }

        private IWebElement ButtonImportAnExistingAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(),'Import')]"));
            }
        }

        private IWebElement ToolsButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[@class='cset-icons-tools fs-base-4 mr-2 align-middle']"));
            }
        }

        private IWebElement ModuleBuilder
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Module Builder')]"));
            }
        }

        private IWebElement ButtonExportAllAssessments
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@mattooltip='Export a copy of all assessments to another location.']"));
            }
        }

        private IWebElement ButtonACETMaturityAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='cf8fa1cdc-63ac-4076-b00d-1f5dcb34e3a9']/div[2]"));
                // eturn WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'ACET Maturity Assessment')]"));
            }
        }

        private IWebElement ButtonCRRAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'CISA Cyber Resilience Review (CRR)')]"));
            }
        }

        private IWebElement ButtonEDMAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'CISA External Dependencies Management (EDM)')]"));
            }
        }

        private IWebElement ButtonRRAAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'CISA Ransomware Readiness Assessment (RRA)')]"));
            }
        }

        private IWebElement ButtonCMMC1Assessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Cybersecurity Maturity Model Certification 1.02')]"));
            }
        }

        //Interaction Methods

        private void ClickNewAssessmentButton()
        {
            
            ButtonNewAssessment.Click();
        }

        private void ClickMyAssessmentsTab()
        {
            TabMyAssessments.Click();
        }

        private void ClickImportAnExistingAssessmentButton()
        {
            ButtonImportAnExistingAssessment.Click();
        }

        private void ClickToolsButton()
        {
            ToolsButton.Click();
        }

        private void ClickModuleBuilder()
        {
            ModuleBuilder.Click();
        }

        private void ClickButtonExportAllAssessments()
        {
            ButtonExportAllAssessments.Click();
        }

        private void ClickButtonACETMaturityAssessment()
        {
            
            ButtonACETMaturityAssessment.Click();
        }

        private void ClickButtonCRRAssessment()
        {

            ButtonCRRAssessment.Click();
        }

        private void ClickButtonEDMAssessment()
        {

            ButtonEDMAssessment.Click();
        }

        private void ClickButtonRRAAssessment()
        {

            ButtonRRAAssessment.Click();
        }

        private void ClickButtonCMMC1Assessment()
        {

            ButtonCMMC1Assessment.Click();
        }

        //Aggregate Methods
        public void ClickMyAssessments()
        {
            ClickMyAssessmentsTab();
        }
        public void OpenNewAssessment()
        {           
            ClickMyAssessmentsTab();
            ClickNewAssessmentButton();
        }

        public void ACETCreateNewAssessment()
        {
            WaitUntilElementNotClickable(ButtonNewAssessment);
            // move to button new assessment button click
            ClickNewAssessmentButton();
            WaitUntilElementNotClickable(ButtonACETMaturityAssessment);
            ClickButtonACETMaturityAssessment();
        }

        public void CRRCreateNewAssessment()
        {
            WaitUntilElementNotClickable(ButtonCRRAssessment);
            ClickButtonCRRAssessment();
        }

        public void EDMCreateNewAssessment()
        {
            WaitUntilElementNotClickable(ButtonEDMAssessment);
            ClickButtonEDMAssessment();
        }

        public void RRACreateNewAssessment()
        {
            WaitUntilElementNotClickable(ButtonRRAAssessment);
            ClickButtonRRAAssessment();
        }

        public void CMMC1CreateNewAssessment()
        {
            WaitUntilElementNotClickable(ButtonCMMC1Assessment);
            ClickButtonCMMC1Assessment();
        }

        public void NavigateToModuleBuilder()
        {
            ClickToolsButton();
            ClickModuleBuilder();
        }
        public void ClickImportAssessment()
        {
            ClickImportAnExistingAssessmentButton();
        }
        public void ClickExportAllAssessments()
        {
            ClickButtonExportAllAssessments();
        }
    }
}
