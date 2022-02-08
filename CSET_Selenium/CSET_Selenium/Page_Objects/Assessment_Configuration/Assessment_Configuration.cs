using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Assessment_Configuration
{
    class AssessmentConfiguration : BasePage
    {
        private readonly IWebDriver driver;

        public AssessmentConfiguration(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement TextboxAssessmentName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'name')]"));
            }
        }

        private IWebElement TextboxAssessmentDate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'date')]"));
            }
        }

        private IWebElement TextboxFacilityName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'facility')]"));
            }
        }

        private IWebElement TextboxCitySiteName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'citySite')]"));
            }
        }

        private IWebElement TextboxStateProvRegion
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'stateProvRegion')]"));
            }
        }

        private IWebElement CheckboxMaturity
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'maturity')]"));
            }
        }

        private IWebElement CheckboxStandard
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'standard')]"));
            }
        }

        private IWebElement CheckboxNetworkDiagram
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'diagram')]"));
            }
        }


        //Interaction Methods

        private void SetAssessmentName(String assessmentName)
        {
            ClickWhenClickable(TextboxAssessmentName);
            TextboxAssessmentName.Clear();            
            TextboxAssessmentName.SendKeys(assessmentName);
        }

        private void SetAssessmentDate(String assessmentDate)
        {
            ClickWhenClickable(TextboxAssessmentDate);
            //SendArbitraryKeys(Keys.Escape);
            //textboxAssessmentDate.Clear();
            //textboxAssessmentDate.SendKeys(Keys.Escape);
            SetText(TextboxAssessmentDate, assessmentDate);
            SendArbitraryKeys(Keys.Escape);
            SendArbitraryKeys(Keys.Tab);
        }

        private void SetFacilityName(String facilityName)
        {
            ClickWhenClickable(TextboxFacilityName);
            TextboxFacilityName.SendKeys(facilityName);
        }

        private void SetCitySiteName(String citySiteName)
        {
            ClickWhenClickable(TextboxCitySiteName);
            TextboxCitySiteName.SendKeys(citySiteName);
        }

        private void SetStateProvRegion(String stateProvRegion)
        {
            ClickWhenClickable(TextboxStateProvRegion);
            TextboxStateProvRegion.SendKeys(stateProvRegion);
        }

        private void SetStandard()
        {
            CheckboxStandard.Click();
        }

        private void SetNetworkDiagram()
        {
            CheckboxNetworkDiagram.Click();
        }

        private void SetMaturityModel()
        {
            CheckboxMaturity.Click();
        }


        //Aggregate Methods

        public void CreateStandardAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            SetStandard();
            ClickNext();
        }

        public void CreateNetworkDiagramAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            SetNetworkDiagram();
            ClickNext();
        }

        public void CreateMaturityModelAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            SetMaturityModel();
            ClickNext();
        }

    }
}
