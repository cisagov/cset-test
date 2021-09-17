using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Landing_Page
{
    class Landing_Page : BasePage
    {
        private readonly IWebDriver driver;

        public Landing_Page(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement buttonNewAssessment
        {
            get
            {
                return this.driver.FindElement(By.XPath("//span[contains(text(),'New Assessment')]/ancestor::button"));
            }
        }

        private IWebElement buttonImportAnExistingAssessment
        {
            get
            {
                return this.driver.FindElement(By.XPath("//label[contains(text(),'Import')]"));
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
