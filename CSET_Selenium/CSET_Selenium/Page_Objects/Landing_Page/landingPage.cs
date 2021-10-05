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

        private IWebElement buttonNewAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'New Assessment')]/ancestor::button"));
            }
        }

        private IWebElement buttonImportAnExistingAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(),'Import')]"));
            }
        }

        //Interaction Methods

        private void ClickNewAssessmentButton()
        {
            buttonNewAssessment.Click();
        }

        private void ClickImportAnExistingAssessmentButton()
        {
            buttonImportAnExistingAssessment.Click();
        }


        //Aggregate Methods
        public void CreateNewAssessment()
        {
            ClickNewAssessmentButton();
        }
    }
}
