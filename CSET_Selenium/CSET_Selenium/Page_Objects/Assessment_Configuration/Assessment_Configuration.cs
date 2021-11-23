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

        private IWebElement textboxAssessmentName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'name')]"));
            }
        }

        private IWebElement textboxAssessmentDate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'date')]"));
            }
        }

        private IWebElement textboxFacilityName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'facility')]"));
            }
        }

        private IWebElement textboxCitySiteName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'citySite')]"));
            }
        }

        private IWebElement textboxStateProvRegion
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'stateProvRegion')]"));
            }
        }

        private IWebElement checkboxMaturity
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'maturity')]"));
            }
        }

        private IWebElement checkboxStandard
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'standard')]"));
            }
        }

        private IWebElement checkboxNetworkDiagram
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'diagram')]"));
            }
        }


        //Interaction Methods

        private void SetAssessmentName(String assessmentName)
        {
            ClickWhenClickable(textboxAssessmentName);
            textboxAssessmentName.Clear();            
            textboxAssessmentName.SendKeys(assessmentName);
        }

        private void SetAssessmentDate(String assessmentDate)
        {
            ClickWhenClickable(textboxAssessmentDate);
            //SendArbitraryKeys(Keys.Escape);
            //textboxAssessmentDate.Clear();
            //textboxAssessmentDate.SendKeys(Keys.Escape);
            SetText(textboxAssessmentDate, assessmentDate);
            SendArbitraryKeys(Keys.Escape);
            SendArbitraryKeys(Keys.Tab);
        }

        private void SetFacilityName(String facilityName)
        {
            ClickWhenClickable(textboxFacilityName);
            textboxFacilityName.SendKeys(facilityName);
        }

        private void SetCitySiteName(String citySiteName)
        {
            ClickWhenClickable(textboxCitySiteName);
            textboxCitySiteName.SendKeys(citySiteName);
        }

        private void SetStateProvRegion(String stateProvRegion)
        {
            ClickWhenClickable(textboxStateProvRegion);
            textboxStateProvRegion.SendKeys(stateProvRegion);
        }

        private void setStandard()
        {
            checkboxStandard.Click();
        }

        private void setNetworkDiagram()
        {
            checkboxNetworkDiagram.Click();
        }

        private void setMaturityModel()
        {
            checkboxMaturity.Click();
        }


        //Aggregate Methods

        public void CreateStandardAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            setStandard();
            ClickNext();
        }

        public void CreateNetworkDiagramAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            setNetworkDiagram();
            ClickNext();
        }

        public void CreateMaturityModelAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            setMaturityModel();
            ClickNext();
        }

    }
}
