using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        private readonly Actions actions;

        public LandingPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            this.actions = new Actions(driver);
        }

        //Element Locators
        private IWebElement ButtonNewAssessment
        {
            get
            {
                return base.ScrollToElementByXPath("//span[contains(text(),'New Assessment')]/ancestor::button", this.actions);
            }
        }

        private IWebElement TabMyAssessments
        {
            get
            {
                return base.ScrollToElementByXPath("//span[contains(text(),'My Assessments')]/ancestor::button", this.actions);
            }
        }

        private IWebElement ButtonImportAnExistingAssessment
        {
            get
            {
                return base.ScrollToElementByXPath("//label[contains(text(),'Import')]", this.actions);
            }
        }

        private IWebElement ToolsButton
        {
            get
            {
                return base.ScrollToElementByXPath("//span[@class='cset-icons-tools fs-base-4 mr-2 align-middle']", this.actions);
            }
        }

        private IWebElement ModuleBuilder
        {
            get
            {
                return base.ScrollToElementByXPath("//span[contains(text(), 'Module Builder')]", this.actions);
            }
        }

        private IWebElement ButtonExportAllAssessments
        {
            get
            {
                return base.ScrollToElementByXPath("//button[@mattooltip='Export a copy of all assessments to another location.']", this.actions);
            }
        }

        private IWebElement ButtonNERCRev6
        {
            get
            {
                return base.ScrollToElementByXPath("//div[contains(text(),'NERC CIP-002 through CIP-014 Revision 6')]", this.actions, 5);
            }
        }

        private IWebElement ButtonACETMaturityAssessment
        {
            get
            {
                return base.ScrollToElementByXPath("//div[contains(text(),'ACET Maturity Assessment')]", this.actions, 5);
            }
        }

        private IWebElement ButtonCRRAssessment
        {
            get
            {
                return base.ScrollToElementByXPath("//div[contains(text(),'CISA Cyber Resilience Review (CRR)')]", this.actions);
            }
        }

        private IWebElement ButtonEDMAssessment
        {
            get
            {
                return base.ScrollToElementByXPath("//div[contains(text(),'CISA External Dependencies Management (EDM)')]", this.actions);
            }
        }

        private IWebElement ButtonRRAAssessment
        {
            get
            {
                return base.ScrollToElementByXPath("//div[contains(text(),'CISA Ransomware Readiness Assessment (RRA)')]", this.actions);
            }
        }

        private IWebElement ButtonCMMC1Assessment
        {
            get
            {
                return base.ScrollToElementByXPath("//div[contains(text(),'Cybersecurity Capability Maturity Model (C2M2) V2.1')]", this.actions, 5);
            }
        }

        private IWebElement ButtonCMMC2Assessment
        {
            get
            {
                return base.ScrollToElementByXPath("//div[contains(text(),'Cybersecurity Capability Maturity Model (C2M2) V2.1')]", this.actions, 5);
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

        private void ClickButtonButtonNERCRev6()
        {
            ButtonNERCRev6.Click();
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
        public void NERCRev6CreateAssessment()
        {
            WaitUntilElementNotClickable(ButtonNewAssessment);
            // move to button new assessment button click
            ClickNewAssessmentButton();
            WaitUntilElementNotClickable(ButtonNERCRev6);
            ClickButtonButtonNERCRev6();
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
            WaitUntilElementNotClickable(ButtonNewAssessment);
            // move to button new assessment button click
            ClickNewAssessmentButton();
            //WaitUntilElementNotClickable(ButtonACETMaturityAssessment);
            //ClickButtonACETMaturityAssessment();

            WaitUntilElementNotClickable(ButtonCMMC1Assessment);
            ClickButtonCMMC1Assessment();
        }

        public void CMMC2CreateNewAssessment()
        {
            WaitUntilElementNotClickable(ButtonNewAssessment);
            // move to button new assessment button click
            ClickNewAssessmentButton();
            //WaitUntilElementNotClickable(ButtonACETMaturityAssessment);
            //ClickButtonACETMaturityAssessment();

            WaitUntilElementNotClickable(ButtonCMMC2Assessment);
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
