using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.AssessmentInfo
{
    class AssessmentInfo : BasePage
    {
        private readonly IWebDriver driver;
        Random r = new Random();
        private Dictionary<string, string> infoMap = new Dictionary<string, string>();
        private List<IWebElement> infoList = new List<IWebElement>();

        public AssessmentInfo(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement DropdownSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'sector')]"));
            }
        }

        private IWebElement DropdownIndustry
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'industry')]"));
            }
        }


        private IWebElement DropdownAssetValue
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'assetValue')]"));
            }
        }

        private IWebElement DropdownExpectedEffort
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'size')]"));
            }
        }

        private IWebElement TextboxOrganizationName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'edmOrganizationName')]"));
            }
        }

        private IWebElement TextboxAgency
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'edmAgency')]"));
            }
        }

        private IWebElement DropdownOrganizationType
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'edmOrganizationType')]"));
            }
        }

        private IWebElement DropdownFacilitator
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'edmFacilitator')]"));
            }
        }

        private IWebElement TextboxCriticalService
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[contains(@name,'criticalService')]"));
            }
        }

        private IWebElement DropdownPointOfContact
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name,'critSvcPointOfContact')]"));
            }
        }

        private IWebElement CheckboxScoped
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'edmIsScoped')]"));
            }
        }

        //Sector Dropdown options
        private IWebElement OptionChemicalSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Chemical Sector')]"));
            }
        }

        private IWebElement OptionCommercialFacilitiesSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Commercial')]"));
            }
        }

        private IWebElement OptionCommunicationsSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Communications')]"));
            }
        }

        private IWebElement OptionCriticalManufacturingSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Critical')]"));
            }
        }

        private IWebElement OptionDamsSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Dams Sector')]"));
            }
        }

        private IWebElement OptionDefenseIndustrialBaseSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Defense Industrial')]"));
            }
        }

        private IWebElement OptionEmergencyServicesSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Emergency Services')]"));
            }
        }

        private IWebElement OptionEnergySector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Energy')]"));
            }
        }

        private IWebElement OptionFinancialServicesSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Financial')]"));
            }
        }

        private IWebElement OptionFoodAndAgricultureSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Food and')]"));
            }
        }

        private IWebElement OptionGovernmentFacilitiesSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Government Facilities')]"));
            }
        }

        private IWebElement OptionHealthcareandPublicHealthSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Healthcare')]"));
            }
        }

        private IWebElement OptionInformationTechnologySector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Information Technology Sector')]"));
            }
        }

        private IWebElement OptionNuclearReactorsSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Nuclear Reactors')]"));
            }
        }

        private IWebElement OptionTransportationSystemsSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Transportation')]"));
            }
        }

        private IWebElement OptionWaterandWastewaterSystemsSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Water and')]"));
            }
        }

        //Industry Dropdown Options
        private IWebElement OptionPublicWaterSystems
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Public Water')]"));
            }
        }

        private IWebElement OptionPubliclyOwnedTreatmentWorks
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Publicly')]"));
            }
        }

        private IWebElement OptionOther
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Other')]"));
            }
        }

        //Other Assessment Info
        private IWebElement OrgName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='edmOrganizationName']"));
            }
        }

        private IWebElement AgencyName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='edmAgency']"));
            }
        }

        //Standard Questions
        private IWebElement ExpandAll
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Expand')]"));
            }
        }

        private IWebElement StandardAnswerAccountManagementAllNo
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(@class,'btn btn-no form-check-label ng-star-inserted active')]"));
            }
        }

        private IWebElement StandardAnswerAudit1Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(@class,'btn btn-no form-check-label ng-star-inserted answer')]/parent::div"));
            }
        }

        private IWebElement ObservationsTearOutSheets
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Observations')]"));
            }
        }

        private IWebElement ExecutiveSummary
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Executive')]"));
            }
        }

        private IWebElement SiteSummaryReport
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Site Summary')]"));
            }
        }

        private IWebElement SiteCybersecurityPlan
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Site Cyber')]"));
            }
        }

        private IWebElement SiteDetail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Site Detail')]"));
            }
        }

        private IWebElement VADRDeficiencyReport
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'VADR')]"));
            }
        }

        private IWebElement CRRReport
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'CRR Report')]"));
            }
        }

        private IWebElement DropdownCRRConfidentiality
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'security')]"));
            }
        }

        private IWebElement OptionBusinessConfidential
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'Business')]"));
            }
        }

        private IWebElement OptionCUI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[contains(text(),'CUI')]"));
            }
        }

        private IWebElement CRRDeficiencyReport
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'CRR Deficiency')]"));
            }
        }

        private IWebElement CRRCommentsAndMarkedForReview
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'CRR Comments')]"));
            }
        }

        private IWebElement RRAReport
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'RRA Report')]"));
            }
        }

        private IWebElement RRADeficiencyReport
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'RRA Deficiency')]"));
            }
        }

        private IWebElement CommentsAndMarkedForReview
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Comments')]"));
            }
        }

        //Interaction Methods

        private void SetRandomSector()
        {
  
            List<IWebElement> sectorList = new List<IWebElement>
                {
                    OptionChemicalSector,
                    OptionCommercialFacilitiesSector,
                    OptionCommunicationsSector,
                    OptionCriticalManufacturingSector,
                    OptionDamsSector,
                    OptionDefenseIndustrialBaseSector,
                    OptionEmergencyServicesSector,
                    OptionEnergySector,
                    OptionFinancialServicesSector,
                    OptionFoodAndAgricultureSector,
                    OptionGovernmentFacilitiesSector,
                    OptionHealthcareandPublicHealthSector,
                    OptionInformationTechnologySector,
                    OptionNuclearReactorsSector,
                    OptionTransportationSystemsSector,
                    OptionWaterandWastewaterSystemsSector
                };
            var el = sectorList[r.Next(0, 16)];
            infoMap.Add(el.Text, "Sector");
            el.Click();
        }

        private void SetSectorChanged(string sector)
        {
               List<IWebElement> sectorList = new List<IWebElement>
                {
                    OptionChemicalSector,
                    OptionCommercialFacilitiesSector,
                    OptionCommunicationsSector,
                    OptionCriticalManufacturingSector,
                    OptionDamsSector,
                    OptionDefenseIndustrialBaseSector,
                    OptionEmergencyServicesSector,
                    OptionEnergySector,
                    OptionFinancialServicesSector,
                    OptionFoodAndAgricultureSector,
                    OptionGovernmentFacilitiesSector,
                    OptionHealthcareandPublicHealthSector,
                    OptionInformationTechnologySector,
                    OptionNuclearReactorsSector,
                    OptionTransportationSystemsSector,
                    OptionWaterandWastewaterSystemsSector
                };
            foreach(IWebElement el in sectorList)
            {
                if (el.Text.Equals(sector))
                {
                    el.Click();
                }
            }
        }

        private void SetRandomIndustry()
        {
            List<IWebElement> industryList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='industry']//option")));
            Console.WriteLine(industryList.Count());
            var el = WaitUntilElementIsVisible(industryList[r.Next(1, industryList.Count())]);
            infoMap.Add(el.Text, "Industry");
            el.Click();
        }

        private void SetIndustryChanged(string industry)
        {
            List<IWebElement> industryList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='industry']//option")));
            foreach (IWebElement el in industryList)
            {
                if (el.Text.Equals(industry))
                {
                    el.Click();
                }
            }
        }

        private void SetRandomGross()
        {
            List<IWebElement> grossList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='assetValue']//option")));
            var el = WaitUntilElementIsVisible(grossList[r.Next(1, grossList.Count())]);
            infoMap.Add(el.Text, "Gross");
            el.Click();
        }

        private void SetGrossChanged(string gross)
        {
            List<IWebElement> grossList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='assetValue']//option")));
            foreach (IWebElement el in grossList)
            {
                if (el.Text.Equals(gross))
                {
                    el.Click();
                }
            }
        }

        private void SetRandomExpectedEffort()
        {
            List<IWebElement> effortList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='size']//option")));
            var el = WaitUntilElementIsVisible(effortList[r.Next(1, effortList.Count())]);
            infoMap.Add(el.Text, "Effort");
            el.Click();
        }

        private void SetExpectedEffortChanged(string effort)
        {
            List<IWebElement> effortList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='size']//option")));
            foreach (IWebElement el in effortList)
            {
                if (el.Text.Equals(effort))
                {
                    el.Click();
                }
            }
        }

        private void SetOrgName(String name)
        {
            OrgName.SendKeys(name);
        }

        private void SetAgencyName(String name)
        {
            AgencyName.SendKeys(name);
        }

        private void SetOrgType()
        {
            List<IWebElement> orgTypeList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='edmOrganizationType']//option")));
            var el = WaitUntilElementIsVisible(orgTypeList[r.Next(1, orgTypeList.Count())]);
            infoMap.Add(el.Text, "OrgType");
            el.Click();
        }

        private void SetOrgTypeChanged(String orgtype)
        {
            List<IWebElement> orgTypeList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='edmOrganizationType']//option")));
            foreach (IWebElement el in orgTypeList)
            {
                if (el.Text.Equals(orgtype))
                {
                    el.Click();
                }
            }

        }

        private void SetFacilitator()
        {
            List<IWebElement> facilitatorList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='edmFacilitator']//option")));
            var el = WaitUntilElementIsVisible(facilitatorList[1]);
            infoMap.Add(el.Text, "Facilitator");
            el.Click();
        }

        private void SetFacilitatorChanged(String facilitator)
        {
            List<IWebElement> facilitatorList = new List<IWebElement>(driver.FindElements(By.XPath("//select[@id='edmFacilitator']//option")));
            foreach (IWebElement el in facilitatorList)
            {
                if (el.Text.Equals(facilitator))
                {
                    el.Click();
                }
            }

        }

        private void SetAssessmentName(String assessmentName)
        {
//            ClickWhenClickable(editBox_AssessmentName);
  //          editBox_AssessmentName.SendKeys(assessmentName);
        }

        private void SetAssessmentDate(DateTime assessmentDate)
        {
            //ClickWhenClickable(editBox_AssessmentDate);
            //editBox_AssessmentDate.SendKeys(assessmentDate.ToString());

        }


        //Aggregate Methods
        public void SetSALAssessmentInfo()
        {
            DropdownSector.Click();
            SetRandomSector();
            DropdownIndustry.Click();
            SetRandomIndustry();
            SetRandomGross();
            SetRandomExpectedEffort();
            SetOrgName("INL");
            infoMap.Add("INL", "OrgName");
            SetAgencyName("CSET Testing");
            infoMap.Add("CSET Testing", "AgencyName");
            SetOrgType();
            SetFacilitator();
            ClickNext();
        }

        public void SetChangedAssessmentInfo(Dictionary<string, string> statMap)
        {
            DropdownSector.Click();
            SetSectorChanged(statMap.FirstOrDefault(x => x.Value == "Sector").Key);
            DropdownIndustry.Click();
            SetIndustryChanged(statMap.FirstOrDefault(x => x.Value == "Industry").Key);
            SetGrossChanged(statMap.FirstOrDefault(x => x.Value == "Gross").Key);
            SetExpectedEffortChanged(statMap.FirstOrDefault(x => x.Value == "Effort").Key);
            SetOrgName("INL");
            SetAgencyName("CSET Testing");
            SetOrgTypeChanged(statMap.FirstOrDefault(x => x.Value == "OrgType").Key);
            SetFacilitatorChanged(statMap.FirstOrDefault(x => x.Value == "Facilitator").Key);
            ClickNext();
        }

        public void SetCyberAssessmentInfo()
        {

        }

        public void SetNetDiagramAssessmentInfo()
        {

        }

        public void SetAssessmentInformation()
        {
            ClickNext();
        }

        public void SetAssessInfo()
        {
            DropdownSector.Click();
            OptionChemicalSector.Click();
            OptionCommercialFacilitiesSector.Click();
            OptionCommunicationsSector.Click();
            OptionCriticalManufacturingSector.Click();
            OptionDamsSector.Click();
            OptionDefenseIndustrialBaseSector.Click();
            OptionEmergencyServicesSector.Click();
            OptionEnergySector.Click();
            OptionFinancialServicesSector.Click();
            OptionFoodAndAgricultureSector.Click();
            OptionGovernmentFacilitiesSector.Click();
            OptionHealthcareandPublicHealthSector.Click();
            OptionInformationTechnologySector.Click();
            OptionNuclearReactorsSector.Click();
            OptionTransportationSystemsSector.Click();
            OptionWaterandWastewaterSystemsSector.Click();

            DropdownIndustry.Click();
            OptionPublicWaterSystems.Click();
            OptionPubliclyOwnedTreatmentWorks.Click();
            OptionOther.Click();

            ClickNext();
        }

        public Dictionary<string, string> GetAssessmentInfo()
        {
            return infoMap;
        }
        public void SetStandardQuestions()
        {
            //ExpandAll.Click();
            //ClickWhenClickable(StandardAnswerAccountManagementAllNo);
            ClickNext();
        }

        public void SetTSAReports()
        {
            ObservationsTearOutSheets.Click();
            ExecutiveSummary.Click();
            SiteSummaryReport.Click();
            SiteCybersecurityPlan.Click();
            SiteDetail.Click();
            ClickNext();
        }

        public void SetVADRReports()
        {
            ObservationsTearOutSheets.Click();
            VADRDeficiencyReport.Click();
            ClickNext();
        }

        public void SetCRRReports()
        {
            ObservationsTearOutSheets.Click();
            CRRReport.Click();
            DropdownCRRConfidentiality.Click();
            OptionBusinessConfidential.Click();
            OptionCUI.Click();
            CRRDeficiencyReport.Click();
            CRRCommentsAndMarkedForReview.Click();
            ClickNext();
        }

        public void SetRRAReports()
        {
            ObservationsTearOutSheets.Click();
            RRAReport.Click();
            RRADeficiencyReport.Click();
            CommentsAndMarkedForReview.Click();
            ClickNext();
        }

        public void SetCSCReports()
        {
            ObservationsTearOutSheets.Click();
            ExecutiveSummary.Click();
            SiteSummaryReport.Click();
            SiteCybersecurityPlan.Click();
            SiteDetail.Click();
            ClickNext();
        }

        public void SetAPTAReports()
        {
            ObservationsTearOutSheets.Click();
            ExecutiveSummary.Click();
            SiteSummaryReport.Click();
            SiteCybersecurityPlan.Click();
            SiteDetail.Click();
            ClickNext();
        }

    }
}
