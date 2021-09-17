using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Landing_Page
{
    class Landing_Page : BasePage
    {
        public Landing_Page(IWebDriver driver) : base(driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        //Element Locators
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'New Assessment')]/ancestor::button")]
        private readonly IWebElement buttonNewAssessment;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Import')]")]
        private readonly IWebElement buttonImportAnExistingAssessment;

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
