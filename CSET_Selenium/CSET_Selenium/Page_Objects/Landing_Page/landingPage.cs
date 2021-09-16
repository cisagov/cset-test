using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Landing_Page
{
    public class LandingPage
    {
        private IWebDriver driver;

        public LandingPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
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
