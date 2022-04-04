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
            }
        }

        private IWebElement ButtonImportAnExistingAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(),'Import')]"));
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


        //Aggregate Methods
        public void CreateNewAssessment()
        {
            ClickNewAssessmentButton();
        }
    }
}
