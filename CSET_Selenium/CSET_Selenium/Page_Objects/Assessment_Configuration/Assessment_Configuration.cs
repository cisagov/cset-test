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

        private IWebElement TextboxCreditUnion
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'creditUnion')]"));
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

        private IWebElement TextboxCharter
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'charter')]"));
            }
        }

        private IWebElement TextboxAssets
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'assets')]"));
            }
        }

        private IWebElement CheckboxMaturity
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'maturity')]/parent::div"));
            }
        }


        private IWebElement CheckboxTSA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@id,'TSA')]/parent::div"));
            }
        }

        private IWebElement CheckboxVADR
        {
            get
            {
                //return WaitUntilElementIsVisible(By.XPath("//input[contains(@id,'vadr')]/parent::div"));
                return WaitUntilElementIsVisible(By.XPath("//label[contains(@for,'VADR')]"));
            }
        }

        private IWebElement CheckboxRRA
        {
            get
            {
                //return WaitUntilElementIsVisible(By.XPath("//input[contains(@id,'rra')]/parent::div"));
                return WaitUntilElementIsVisible(By.XPath("//label[contains(@for,'RRA')]"));
            }
        }

        private IWebElement CheckboxCRR
        {
            get
            {
                //return WaitUntilElementIsVisible(By.XPath("//input[contains(@id,'crr')]/parent::div"));
                return WaitUntilElementIsVisible(By.XPath("//label[contains(@for,'CRR')]"));
            }
        }

        private IWebElement CheckboxCSC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@id,'CSC')]/parent::div"));
            }
        }

        private IWebElement CheckboxAPTA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@id,'APTA')]/parent::div"));
            }
        }

        private IWebElement CheckboxStandard
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'standard')]/parent::div"));
            }
        }

        private IWebElement CheckboxNetworkDiagram
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'diagram')]/parent::div"));
            }
        }


        //Interaction Methods

        private void SetAssessmentName(String assessmentName)
        {
            ClickWhenClickable(TextboxAssessmentName);
            TextboxAssessmentName.Clear();
            TextboxAssessmentName.SendKeys(assessmentName);
        }

        private void SetAssessmentCreditUnion(String assessmentCreditUnion)
        {
            ClickWhenClickable(TextboxCreditUnion);
            TextboxCreditUnion.Clear();
            TextboxCreditUnion.SendKeys(assessmentCreditUnion);
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

        private void SetCharter(String assessmentCharter)
        {
            ClickWhenClickable(TextboxCharter);
            TextboxCharter.Clear();
            TextboxCharter.SendKeys(assessmentCharter);
        }

        private void SetAssets(String assessmentAssets)
        {
            ClickWhenClickable(TextboxAssets);
            TextboxCharter.Clear();
            TextboxCharter.SendKeys(assessmentAssets);
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

        private void SetTSA()
        {
            CheckboxTSA.Click();
        }

        private void SetVADR()
        {
            CheckboxVADR.Click();
        }

        private void SetRRA()
        {
            CheckboxRRA.Click();
        }

        private void SetCRR()
        {
            CheckboxCRR.Click();
        }

        private void SetCSC()
        {
            CheckboxCSC.Click();
        }

        private void SetAPTA()
        {
            CheckboxAPTA.Click();
        }


        //Aggregate Methods

        public void CreateStandardAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
           // SetStandard();
            ClickNext();
        }

        public void CreateNetworkDiagramAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            //SetNetworkDiagram();
            ClickNext();
        }

        public void CreateMaturityModelAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            ClickNext();
        }

        public void CreateTSAAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            ClickNext();
        }

        public void CreateVADRAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
          //  SetTSA(); //unselecting TSA
           // SetVADR();
            ClickNext();
        }

        public void CreateRRAAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
           // SetTSA(); //unselecting TSA
          //  SetRRA();
            ClickNext();
        }

        public void CreateCRRAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
           // SetTSA(); //unselecting TSA
           // SetCRR();
            ClickNext();
        }

        public void CreateCSCAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            //SetTSA(); //unselecting TSA
            //SetCSC();
            ClickNext();
        }

        public void CreateAPTAAssessment(String assessmentName, String facilityName, String citySiteName, String stateProvRegion)
        {
            SetAssessmentName(assessmentName);
            //SetAssessmentDate(assessmentDate);
            SetFacilityName(facilityName);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            //SetTSA(); //unselecting TSA
            //SetAPTA();
            ClickNext();
        }

        public void CreateAcetBuildAssessment(String assessmentCreditUnion, String citySiteName, String stateProvRegion, String assessmentCharter, String assessmentAssets)
        {
            SetAssessmentCreditUnion(assessmentCreditUnion);
            //SetAssessmentDate(assessmentDate);
            SetCitySiteName(citySiteName);
            SetStateProvRegion(stateProvRegion);
            SetCharter(assessmentCharter);
            SetAssets(assessmentAssets);
            ClickNext();
        }

    }
}
