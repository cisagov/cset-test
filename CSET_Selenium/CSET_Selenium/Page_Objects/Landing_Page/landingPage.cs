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
        private IWebElement MyAssessmentButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@class='btn bgc-trans d-flex align-items-center flex-00a h-100']"));
            }
        }

        private IWebElement ButtonNewAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'New Assessment')]/ancestor::button"));
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


        //Interaction Methods

        private void ClickNewAssessmentButton()
        {
            ButtonNewAssessment.Click();
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
        
        private void ClickMyAssessmentsTab()
        {
            MyAssessmentButton.Click();
        }

        //Aggregate Methods
        public void CreateNewAssessment()
        {           
            ClickMyAssessmentsTab();
            ClickNewAssessmentButton();
        }

        public void NavigateToModuleBuilder()
        {
            ClickToolsButton();
            ClickModuleBuilder();
        }
    }
}
