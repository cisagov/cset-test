using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Security_Assurance_Level
{
    class SecurityAssuranceLevel : BasePage
    {
        private readonly IWebDriver driver;
        private Actions actions;
        public SecurityAssuranceLevel(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            actions = new Actions(driver);
        }

        
        //Element Locators
        private IWebElement SALAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(), 'SAL')]"));
            }
        }

        private IWebElement TextHeaderSimple
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='SimpleSalLevelSelector']"));
            }
        }

        private IWebElement TextHeaderGeneralRiskBased
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='GeneralRiskSalLevelSelector']"));
            }
        }

        private IWebElement TextHeaderNist
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='NistSalLevelSelector']"));
            }
        }


        private IWebElement TextHeaderOverallSalLow
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='OverallSALLow']"));
            }
        }

        private IWebElement TextHeaderOverallSalModerate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='OverallSALModerate']"));
            }
        }
        private IWebElement TextHeaderOverallSalHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='OverallSALHigh']"));
            }
        }
        private IWebElement TextHeaderOverallSalVeryHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='OverallSALVery High']"));
            }
        }

        //confidentiality
        private IWebElement TextHeaderConfidentialityLow
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='ConfidentialityLow']"));
            }
        }

        private IWebElement TextHeaderConfidentialityModerate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='ConfidentialityModerate']"));
            }
        }
        private IWebElement TextHeaderConfidentialityHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='ConfidentialityHigh']"));
            }
        }
        private IWebElement TextHeaderConfidentialityVeryHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='ConfidentialityVery High']"));
            }
        }
        //integrity
        private IWebElement TextHeaderIntegrityLow
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='IntegrityLow']"));
            }
        }

        private IWebElement TextHeaderIntegrityModerate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='IntegrityModerate']"));
            }
        }
        private IWebElement TextHeaderIntegrityHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='IntegrityHigh']"));
            }
        }
        private IWebElement TextHeaderIntegrityVeryHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='IntegrityVery High']"));
            }
        }

        //availability
        private IWebElement TextHeaderAvailabilityLow
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='AvailabilityLow']"));
            }
        }

        private IWebElement TextHeaderAvailabilityModerate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='AvailabilityModerate']"));
            }
        }
        private IWebElement TextHeaderAvailabilityHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='AvailabilityHigh']"));
            }
        }
        private IWebElement TextHeaderAvailabilityVeryHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='AvailabilityVery High']"));
            }
        }

        //General Risk Based Injuries On Site Slider
        private IWebElement GenRiskSliderInjuriesOnSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='On_Site_Physical_Injury']/span[@role='slider']"));
            }
        }

        private IWebElement GenRiskSliderInjuriesOffSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='Off_Site_Physical_Injury']/span[@role='slider']"));
            }
        }

        private IWebElement GenRiskSliderHospitalizationssOnSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='On_Site_Hospital_Injury']/span[@role='slider']"));
            }
        }
        private IWebElement GenRiskSliderHospitalizationsOffSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='Off_Site_Hospital_Injury']/span[@role='slider']"));
            }
        }
        private IWebElement GenRiskSliderDeathsOnSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='On_Site_Death']/span[@role='slider']"));
            }
        }
        private IWebElement GenRiskSliderDeathsOffSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='Off_Site_Death']/span[@role='slider']"));
            }
        }

        private IWebElement GenRiskSliderCapitalLossOnSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='On_Site_Capital_Assets']/span[@role='slider']"));
            }
        }

        private IWebElement GenRiskSliderCapitalLossOffSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='Off_Site_Capital_Assets']/span[@role='slider']"));
            }
        }

        private IWebElement GenRiskSliderEconomicImpactOnSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='On_Site_Economic_Impact']/span[@role='slider']"));
            }
        }
        private IWebElement GenRiskSliderEconomicImpactOffSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='Off_Site_Economic_Impact']/span[@role='slider']"));
            }
        }
        private IWebElement GenRiskSliderEnvironmentalOnSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='On_Site_Environmental_Cleanup']/span[@role='slider']"));
            }
        }
        private IWebElement GenRiskSliderEnvironmentalOffSite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//ngx-slider[@csetid='Off_Site_Environmental_Cleanup']/span[@role='slider']"));
            }
        }
        private IWebElement CheckboxNistAirTransportation
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxAir Transportation']"));
            }
        }
        private IWebElement CheckboxNistAssetLiabilityManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxAsset and Liability Management']"));
            }
        }

        private IWebElement CheckboxNistBudgetExecution
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxBudget Execution']"));
            }
        }

        private IWebElement CheckboxNistBudgetFormulation
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxBudget Formulation']"));
            }
        }

        private IWebElement CheckboxNistBudgetingPerformanceInt
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxBudgeting & Performance Integration']"));
            }
        }
        private IWebElement CheckboxNistCapitalPlan
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxCapital Planning']"));
            }
        }
        private IWebElement CheckboxNistCollectReceive
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxCollections & Receivables']"));
            }
        }
        private IWebElement CheckboxNistContingencyPlan
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxContingency Planning']"));
            }
        }
        private IWebElement CheckboxNistContinuityOfOps
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxContinuity of Operations']"));
            }
        }
        private IWebElement CheckboxNistCostAccount
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxCost Accounting/Performance Measurement']"));
            }
        }
        private IWebElement CheckboxNistCustomerServices
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxCustomer Services']"));
            }
        }
        private IWebElement CheckboxNistDisasterPrep
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxDisaster Preparedness & Planning']"));
            }
        }
        private IWebElement CheckboxNistEmergencyResponse
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxEmergency Response']"));
            }
        }
        private IWebElement CheckboxNistEnergyConservation
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxEnergy Conservation & Preparedness']"));
            }
        }
        private IWebElement CheckboxNistEnergyProduction
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxEnergy Production']"));
            }
        }
        private IWebElement CheckboxNistEnergyResourceManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxEnergy Resource Management']"));
            }
        }
        private IWebElement CheckboxNistEnergySupply
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxEnergy Supply']"));
            }
        }
        private IWebElement CheckboxNistEnterpriseArch
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxEnterprise Architecture']"));
            }
        }
        private IWebElement CheckboxNistGeneralPurpose
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxEnvironmental Monitoring & Forecasting']"));
            }
        }
        private IWebElement CheckboxNistEnvMonitor
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxEnvironmental Remediation']"));
            }
        }
        private IWebElement CheckboxNistEnvRemediation
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxFacilities Fleet & Equipment Management']"));
            }
        }
        private IWebElement CheckboxNistFacilitiesFleet
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxGeneral Purpose Data & Statistics']"));
            }
        }

        private IWebElement CheckboxNistGoodsAcquisition
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxGoods Acquisition']"));
            }
        }
        private IWebElement CheckboxNistGroundTransport
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxGround Transportation']"));
            }
        }
        private IWebElement CheckboxNistHelpDesk
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxHelp Desk Services']"));
            }
        }
        private IWebElement CheckboxNistInfoInfraManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxInformation Infrastructure Management']"));
            }
        }
        private IWebElement CheckboxNistInfoManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxInformation Management']"));
            }
        }
        private IWebElement CheckboxNistInfoSec
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxInformation Security']"));
            }
        }
        private IWebElement CheckboxNistInfoShare
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxInformation Sharing']"));
            }
        }
        private IWebElement CheckboxNistIntellectualProperty
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxIntellectual Property Protection']"));
            }
        }
        private IWebElement CheckboxNistInventoryControl
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxInventory Control']"));
            }
        }
        private IWebElement CheckboxNistKeyAsset
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxKey Asset & Critical Infrastructure Protection']"));
            }
        }
        private IWebElement CheckboxNistLaborRights
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxLabor Rights Management']"));
            }
        }
        private IWebElement CheckboxNistLifecycleChange
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxLifecycle/Change Management']"));
            }
        }
        private IWebElement CheckboxNistLogisticsManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxLogistics Management']"));
            }
        }
        private IWebElement CheckboxNistManagementImprovement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxManagement Improvement']"));
            }
        }
        private IWebElement CheckboxNistManufacturing
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxManufacturing']"));
            }
        }
        private IWebElement CheckboxNistOtherFinancial
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxOther Financial']"));
            }
        }
        private IWebElement CheckboxNistOtherInfoManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxOther Information Management']"));
            }
        }
        private IWebElement CheckboxNistOtherManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxOther Management']"));
            }
        }
        private IWebElement CheckboxNistOtherOps
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxOther Operations']"));
            }
        }
        private IWebElement CheckboxNistOtherRAndD
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxOther Research & Development']"));
            }
        }
        private IWebElement CheckboxNistOtherSecurity
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxOther Security']"));
            }
        }
        private IWebElement CheckboxNistOtherSupportFunc
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxOther Support Functions']"));
            }
        }
        private IWebElement CheckboxNistPayments
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxPayments']"));
            }
        }
        private IWebElement CheckboxNistPercentageInraMaint
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxPercentage Infrastructure Maintenance']"));
            }
        }
        private IWebElement CheckboxNistPermitsAndLicensing
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxPermits & Licensing']"));
            }
        }
        private IWebElement CheckboxNistPollutionPrevention
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxPollution Prevention & Control']"));
            }
        }
        private IWebElement CheckboxNistProductOutreach
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxProduct Outreach']"));
            }
        }
        private IWebElement CheckboxNistPropertyProtection
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxProperty Protection']"));
            }
        }
        private IWebElement CheckboxNistPR
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxPublic Relations']"));
            }
        }
        private IWebElement CheckboxNistRecordsRetention
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxRecords Retention']"));
            }
        }
        private IWebElement CheckboxNistReportingInfo
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxReporting Information']"));
            }
        }
        private IWebElement CheckboxNistRAndD
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxResearch & Development']"));
            }
        }
        private IWebElement CheckboxNistScientificAndTech
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxScientific & Technological Research & Innovation']"));
            }
        }
        private IWebElement CheckboxNistSecManagement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxSecurity Management']"));
            }
        }
        private IWebElement CheckboxNistServiceRecovery
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxService Recovery']"));
            }
        }
        private IWebElement CheckboxNistServicesAcquisition
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxServices Acquisition']"));
            }
        }
        private IWebElement CheckboxNistSystemAndNetMonitoring
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxSystem & Networking Monitoring']"));
            }
        }
        private IWebElement CheckboxNistSystemDev
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxSystem Development']"));
            }
        }
        private IWebElement CheckboxNistSystemMaintenance
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxSystem Maintenance']"));
            }
        }
        private IWebElement CheckboxNistTrainingAndEmployment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxTraining & Employment']"));
            }
        }
        private IWebElement CheckboxNistWaterResource
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxWater Resource Management']"));
            }
        }
        private IWebElement CheckboxNistWaterTransport
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxWater Transportation']"));
            }
        }
        private IWebElement CheckboxNistWorkForcePlanning
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxWork-Force Planning']"));
            }
        }
        private IWebElement CheckboxNistWorkerSafety
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxWorker Safety']"));
            }
        }
        private IWebElement CheckboxNistWorkplacePolicyDev
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@csetid='checkboxWorkplace Policy Development & Management']"));
            }
        }

        private IWebElement NistPleaseConfirmYes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@class='btn btn-primary m-0 mr-2']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorAirTransC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCAir Transportation']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorDPPC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCDisaster Preparedness & Planning']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorSpecialFactorERC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCEmergency Response']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorECPC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCEnergy Conservation & Preparedness']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnergyProdC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCEnergy Production']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnergySupplyC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCEnergy Supply']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnvMonitorForeC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCEnvironmental Monitoring & Forecasting']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorFacilitiesFleetEMC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCFacilities Fleet & Equipment Management']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorGPDSC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCGeneral Purpose Data & Statistics']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorGroundTransC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCGround Transportation']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorKeyAssetCIPC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCKey Asset & Critical Infrastructure Protection']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorPropertyProtectionC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCProperty Protection']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorSysNetMonitoringC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCSystem & Networking Monitoring']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorWaterTransC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorCWater Transportation']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorAirTransI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIAir Transportation']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorDPPI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIDisaster Preparedness & Planning']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorSpecialFactorERI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIEmergency Response']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorECPI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIEnergy Conservation & Preparedness']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnergyProdI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIEnergy Production']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnergySupplyI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIEnergy Supply']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnvMonitorForeI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIEnvironmental Monitoring & Forecasting']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorFacilitiesFleetEMI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIFacilities Fleet & Equipment Management']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorGPDSI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIGeneral Purpose Data & Statistics']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorGroundTransI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIGround Transportation']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorKeyAssetCIPI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIKey Asset & Critical Infrastructure Protection']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorPropertyProtectionI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIProperty Protection']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorSysNetMonitoringI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorISystem & Networking Monitoring']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorWaterTransI
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorIWater Transportation']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorAirTransA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAAir Transportation']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorDPPA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorADisaster Preparedness & Planning']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorSpecialFactorERA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAEmergency Response']"));
            }
        }

        private IWebElement NistTableLinkSpecialFactorECPA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAEnergy Conservation & Preparedness']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnergyProdA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAEnergy Production']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnergySupplyA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAEnergy Supply']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorEnvMonitorForeA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAEnvironmental Monitoring & Forecasting']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorFacilitiesFleetEMA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAFacilities Fleet & Equipment Management']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorGPDSA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAGeneral Purpose Data & Statistics']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorGroundTransA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAGround Transportation']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorKeyAssetCIPA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAKey Asset & Critical Infrastructure Protection']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorPropertyProtectionA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAProperty Protection']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorSysNetMonitoringA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorASystem & Networking Monitoring']"));
            }
        }
        private IWebElement NistTableLinkSpecialFactorWaterTransA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[@csetid='ConfidentialitySpecialFactorAWater Transportation']"));
            }
        }


        private IWebElement NistAnswerQuestions1Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does aggregation of information on this system reveal sensitive patterns and plans, or facilitate access to sensitive or critical systems?Yes']"));
            }
        }

        private IWebElement NistAnswerQuestions1No
        { 
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does aggregation of information on this system reveal sensitive patterns and plans, or facilitate access to sensitive or critical systems?No']"));
            }
        }
        private IWebElement NistAnswerQuestions2Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does/could access to this system result in some form of access to other more sensitive or critical systems (e.g., over a network)?Yes']"));
            }
        }
        private IWebElement NistAnswerQuestions2No
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does/could access to this system result in some form of access to other more sensitive or critical systems (e.g., over a network)?No']"));
            }
        }
        private IWebElement NistAnswerQuestions3Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Are there extenuating circumstances such as: The system provides critical process flow or security capability, the public visibility of the system, the sheer number of other systems reliant on its operation, or the overall cost of the systems replacement?Yes']"));
            }
        }
        private IWebElement NistAnswerQuestions3No
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Are there extenuating circumstances such as: The system provides critical process flow or security capability, the public visibility of the system, the sheer number of other systems reliant on its operation, or the overall cost of the systems replacement?No']"));
            }
        }
        private IWebElement NistAnswerQuestions4Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Would unauthorized modification or destruction of information affecting external communications (e.g., web pages, electronic mail) adversely affect operations or seriously damage mission function and/or public confidence?Yes']"));
            }
        }
        private IWebElement NistAnswerQuestions4No
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Would unauthorized modification or destruction of information affecting external communications (e.g., web pages, electronic mail) adversely affect operations or seriously damage mission function and/or public confidence?No']"));
            }
        }
        private IWebElement NistAnswerQuestions5Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Would either physical or logical destruction of the system result in very large expenditures to restore the system and/or require a long period of time for recovery?Yes']"));
            }
        }
        private IWebElement NistAnswerQuestions5No
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Would either physical or logical destruction of the system result in very large expenditures to restore the system and/or require a long period of time for recovery?No']"));
            }
        }
        private IWebElement NistAnswerQuestions6Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does the mission served by the system, or the information that the system processes, affect the security of critical infrastructures and key resources?Yes']"));
            }
        }
        private IWebElement NistAnswerQuestions6No
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does the mission served by the system, or the information that the system processes, affect the security of critical infrastructures and key resources?No']"));
            }
        }
        private IWebElement NistAnswerQuestions7Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does the system store, communicate, or process any privacy act information?Yes']"));
            }
        }
        private IWebElement NistAnswerQuestions7No
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does the system store, communicate, or process any privacy act information?No']"));
            }
        }
        private IWebElement NistAnswerQuestions8Yes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does the systems store, communicate, or process any trade secrets information?Yes']"));
            }
        }
        private IWebElement NistAnswerQuestions8No
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[@csetid='Does the systems store, communicate, or process any trade secrets information?No']"));
            }
        }
        //Interaction Methods
        private void MoveToElement(IWebElement element)
        {
            Actions action = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
        private void ClickSALAssessment()
        {
            SALAssessment.Click();
        }

        private void ClickHeaderSimple()
        {
            TextHeaderSimple.Click();
        }

        private void ClickHeaderGeneralRiskBased()
        {
            TextHeaderGeneralRiskBased.Click();
        }
        private void ClickHeaderNist()
        {
            TextHeaderNist.Click();
        }

        private void ClickHeaderOverallSalLow()
        {
            TextHeaderOverallSalLow.Click();
        }

        private void ClickHeaderOverallSalModerate()
        {
            TextHeaderOverallSalModerate.Click();
        }

        private void ClickHeaderOverallSalHigh()
        {
            TextHeaderOverallSalHigh.Click();
        }

        private void ClickHeaderOverallSalVeryHigh()
        {
            TextHeaderOverallSalVeryHigh.Click();
        }

        private void ClickHeaderConfidentialityLow()
        {
            TextHeaderConfidentialityLow.Click();
        }

        private void ClickHeaderConfidentialityModerate()
        {
            TextHeaderConfidentialityModerate.Click();
        }

        private void ClickHeaderConfidentialityHigh()
        {
            TextHeaderConfidentialityHigh.Click();
        }

        private void ClickHeaderConfidentialityVeryHigh()
        {
            TextHeaderConfidentialityVeryHigh.Click();
        }

        private void ClickHeaderIntegrityLow()
        {
            TextHeaderIntegrityLow.Click();
        }

        private void ClickHeaderIntegrityModerate()
        {
            TextHeaderIntegrityModerate.Click();
        }

        private void ClickHeaderIntegrityHigh()
        {
            TextHeaderIntegrityHigh.Click();
        }

        private void ClickHeaderIntegrityVeryHigh()
        {
            TextHeaderIntegrityVeryHigh.Click();
        }

        private void ClickHeaderAvailabilityLow()
        {
            TextHeaderAvailabilityLow.Click();
        }

        private void ClickHeaderAvailabilityModerate()
        {
            TextHeaderAvailabilityModerate.Click();
        }

        private void ClickHeaderAvailabilityHigh()
        {
            TextHeaderAvailabilityHigh.Click();
        }

        private void ClickHeaderAvailabilityVeryHigh()
        {
            TextHeaderAvailabilityVeryHigh.Click();
        }

        private void ClickSliderGenRiskInjuriesOnSite()
        {
            GenRiskSliderInjuriesOnSite.Click();
        }

        private void ClickSliderGenRiskInuriesOffSite()
        {
            GenRiskSliderInjuriesOffSite.Click();
        }
        private void ClickSliderGenRiskHospitalizationsOnSite()
        {
            GenRiskSliderHospitalizationssOnSite.Click();
        }
        private void ClickSliderGenRiskHospitalizationsOffSite()
        {
            GenRiskSliderHospitalizationsOffSite.Click();
        }
        private void ClickSliderGenRiskDeathsOnSite()
        {
            GenRiskSliderDeathsOnSite.Click();
        }
        private void ClickSliderGenRiskDeathsOffSite()
        {
            GenRiskSliderDeathsOffSite.Click();
        }
        private void ClickSliderGenRiskCapitalLossOnSite()
        {
            GenRiskSliderCapitalLossOnSite.Click();
        }
        private void ClickSliderGenRiskCapitalLossOffSite()
        {
            GenRiskSliderCapitalLossOffSite.Click();
        }
        private void ClickSliderGenRiskEconomicImpactOnSite()
        {
            GenRiskSliderEconomicImpactOnSite.Click();
        }
        private void ClickSliderGenRiskEconomicImpactOffSite()
        {
            GenRiskSliderEconomicImpactOffSite.Click();
        }
        private void ClickSliderGenRiskEnvironmentalOnSite()
        {
            GenRiskSliderEnvironmentalOnSite.Click();
        }
        private void ClickSliderGenRiskEnvironmentalOffSite()
        {
            GenRiskSliderEnvironmentalOffSite.Click();
        }
        private void SendKeysGenRiskInjuriesOnSite()
        {
            ClickSliderGenRiskInjuriesOnSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderInjuriesOnSite.SendKeys(Keys.ArrowRight);
            }
        }

        private void SendKeysGenRiskInuriesOffSite()
        {
            ClickSliderGenRiskInuriesOffSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderInjuriesOffSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskHospitalizationsOnSite()
        {
            ClickSliderGenRiskHospitalizationsOnSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderHospitalizationssOnSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskHospitalizationsOffSite()
        {
            ClickSliderGenRiskHospitalizationsOffSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderHospitalizationsOffSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskDeathsOnSite()
        {
            ClickSliderGenRiskDeathsOnSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderDeathsOnSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskDeathsOffSite()
        {
            ClickSliderGenRiskDeathsOffSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderDeathsOffSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskCapitalLossOnSite()
        {
            ClickSliderGenRiskCapitalLossOnSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderCapitalLossOnSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskCapitalLossOffSite()
        {
            ClickSliderGenRiskCapitalLossOffSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderCapitalLossOffSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskEconomicImpactOnSite()
        {
            ClickSliderGenRiskEconomicImpactOnSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderEconomicImpactOnSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskEconomicImpactOffSite()
        {
            ClickSliderGenRiskEconomicImpactOffSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderEconomicImpactOffSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskEnvironmentalOnSite()
        {
            ClickSliderGenRiskEnvironmentalOnSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderEnvironmentalOnSite.SendKeys(Keys.ArrowRight);
            }
        }
        private void SendKeysGenRiskEnvironmentalOffSite()
        {
            ClickSliderGenRiskEnvironmentalOffSite();
            for (int i = 0; i < 8; i++)
            {
                GenRiskSliderEnvironmentalOffSite.SendKeys(Keys.ArrowRight);
            }
        }


        private void ClickNistCheckAirTransportation()
        {
            CheckboxNistAirTransportation.Click();
        }

        private void ClickNistCheckAssetLM()
        {
            CheckboxNistAssetLiabilityManagement.Click();
        }

        private void ClickNistCheckBE()
        {
            CheckboxNistBudgetExecution.Click();
        }

        private void ClickNistCheckBF()
        {
            CheckboxNistBudgetFormulation.Click();
        }
        private void ClickNistCheckBPI()
        {
            CheckboxNistBudgetingPerformanceInt.Click();
        }
        private void ClickNistCheckCP()
        {
            CheckboxNistCapitalPlan.Click();
        }
        private void ClickNistCheckCR()
        {
            CheckboxNistCollectReceive.Click();
        }
        private void ClickNistCheckContingencyP()
        {
            CheckboxNistContingencyPlan.Click();
        }
        private void ClickNistCheckCOps()
        {
            CheckboxNistContinuityOfOps.Click();
        }
        private void ClickNistCheckCAPM()
        {
            CheckboxNistCostAccount.Click();
        }
        private void ClickNistCheckCS()
        {
            CheckboxNistCustomerServices.Click();
        }
        private void ClickNistCheckDPP()
        {
            CheckboxNistDisasterPrep.Click();
        }
        private void ClickNistCheckER()
        {
            CheckboxNistEmergencyResponse.Click();
        }
        private void ClickNistCheckECP()
        {
            CheckboxNistEnergyConservation.Click(); 
        }
        private void ClickNistCheckEP()
        {
            CheckboxNistEnergyProduction.Click();
        }
        private void ClickNistCheckERM()
        {
            CheckboxNistEnergyResourceManagement.Click();
        }
        private void ClickNistCheckESSSS()
        {
            CheckboxNistEnergySupply.Click();
        }
        private void ClickNistCheckEArch()
        {
            CheckboxNistEnterpriseArch.Click();
        }
        private void ClickNistCheckEnvMF()
        {
            CheckboxNistEnvMonitor.Click();
        }
        private void ClickNistCheckEnvR()
        {
            CheckboxNistEnvRemediation.Click(); 
        }
        private void ClickNistCheckFFEM()
        {
            CheckboxNistFacilitiesFleet.Click();
        }
        private void ClickNistCheckGPDS()
        {
            CheckboxNistGeneralPurpose.Click();
        }
        private void ClickNistCheckGoodsAcq()
        {
            CheckboxNistGoodsAcquisition.Click();
        }
        private void ClickNistCheckGroundTrans()
        {
            CheckboxNistGroundTransport.Click();
        }
        private void ClickNistCheckHDS()
        {
            CheckboxNistHelpDesk.Click();
        }
        private void ClickNistCheckIIM()
        {
            CheckboxNistInfoInfraManagement.Click();
        }
        private void ClickNistCheckInfoM()
        {
            CheckboxNistInfoManagement.Click();
        }
        private void ClickNistCheckInfoSec()
        {
            CheckboxNistInfoSec.Click();
        }
        private void ClickNistCheckInfoShare()
        {
            CheckboxNistInfoShare.Click();
        }
        private void ClickNistCheckIPP()
        {
            CheckboxNistIntellectualProperty.Click();
        }
        private void ClickNistCheckIC()
        {
            CheckboxNistInventoryControl.Click();
        }
        private void ClickNistCheckKACIP()
        {
            CheckboxNistKeyAsset.Click();
        }
        private void ClickNistCheckLRM()
        {
            CheckboxNistLaborRights.Click();
        }
        private void ClickNistCheckLCM()
        {
            CheckboxNistLifecycleChange.Click();
        }
        private void ClickNistCheckLogM()
        {
            CheckboxNistLogisticsManagement.Click();
        }
        private void ClickNistCheckMI()
        {
            CheckboxNistManagementImprovement.Click();
        }
        private void ClickNistCheckManufacturing()
        {
            CheckboxNistManufacturing.Click();
        }
        private void ClickNistCheckOtherFin()
        {
            CheckboxNistOtherFinancial.Click();
        }
        private void ClickNistCheckOtherInfoM()
        {
            CheckboxNistOtherInfoManagement.Click();
        }
        private void ClickNistCheckOtherM()
        {
            CheckboxNistOtherManagement.Click();
        }
        private void ClickNistCheckOtherOps()
        {
            CheckboxNistOtherOps.Click();
        }
        private void ClickNistCheckOtherRD()
        {
            CheckboxNistOtherRAndD.Click();
        }
        private void ClickNistCheckOtherSec()
        {
            CheckboxNistOtherSecurity.Click();
        }
        private void ClickNistCheckOtherSuppF()
        {
            CheckboxNistOtherSupportFunc.Click();
        }
        private void ClickNistCheckPayments()
        {
            CheckboxNistPayments.Click();
        }
        private void ClickNistCheckPIM()
        {
            CheckboxNistPercentageInraMaint.Click();
        }
        private void ClickNistCheckPL()
        {
            CheckboxNistPermitsAndLicensing.Click();
        }
        private void ClickNistCheckPPC()
        {
            CheckboxNistPollutionPrevention.Click();
        }
        private void ClickNistCheckPO()
        {
            CheckboxNistProductOutreach.Click();
        }
        private void ClickNistCheckPP()
        {
            CheckboxNistPropertyProtection.Click();
        }
        private void ClickNistCheckPR()
        {
            CheckboxNistPR.Click();
        }
        private void ClickNistCheckRR()
        {
            CheckboxNistRecordsRetention.Click();
        }
        private void ClickNistCheckRI()
        {
            CheckboxNistReportingInfo.Click();
        }
        private void ClickNistCheckRD()
        {
            CheckboxNistRAndD.Click();
        }
        private void ClickNistCheckSTRI()
        {
            CheckboxNistScientificAndTech.Click();
        }
        private void ClickNistCheckSM()
        {
            CheckboxNistSecManagement.Click();
        }
        private void ClickNistCheckSR()
        {
            CheckboxNistServiceRecovery.Click();
        }
        private void ClickNistCheckSAcq()
        {
            CheckboxNistServicesAcquisition.Click();
        }
        private void ClickNistCheckSNM()
        {
            CheckboxNistSystemAndNetMonitoring.Click();
        }
        private void ClickNistCheckSD()
        {
            CheckboxNistSystemDev.Click();
        }
        private void ClickNistCheckSysM()
        {
            CheckboxNistSystemMaintenance.Click();
        }
        private void ClickNistCheckTE()
        {
            CheckboxNistTrainingAndEmployment.Click();
        }
        private void ClickNistCheckWRM()
        {
            CheckboxNistWaterResource.Click();
        }
        private void ClickNistCheckWTrans()
        {
            CheckboxNistWaterTransport.Click();
        }
        private void ClickNistCheckWFP()
        {
            CheckboxNistWorkForcePlanning.Click();
        }
        private void ClickNistCheckWS()
        {
            CheckboxNistWorkerSafety.Click();
        }
        private void ClickNistCheckWPDM()
        {
            CheckboxNistWorkplacePolicyDev.Click();
        }
        private void ClickNistAirTransA()
        {
            NistTableLinkSpecialFactorAirTransA.Click();
        }
        private void ClickNistAirTransC()
        {
            NistTableLinkSpecialFactorAirTransC.Click();
        }
        private void ClickNistAirTransI()
        {
            NistTableLinkSpecialFactorAirTransI.Click();
        }
        private void ClickNistDPPA()
        {
            NistTableLinkSpecialFactorDPPA.Click();
        }
        private void ClickNistDPPC()
        {
            NistTableLinkSpecialFactorDPPC.Click();
        }
        private void ClickNistDPPI()
        {
            NistTableLinkSpecialFactorDPPI.Click();
        }
        private void ClickNistECPA()
        {
            NistTableLinkSpecialFactorECPA.Click();
        }
        private void ClickNistECPC()
        {
            NistTableLinkSpecialFactorECPC.Click(); 
        }
        private void ClickNistECPI()
        {
            NistTableLinkSpecialFactorECPI.Click();
        }
        private void ClickNistEnergyProdA()
        {
            NistTableLinkSpecialFactorEnergyProdA.Click();
        }
        private void ClickNistEnergyProdC()
        {
            NistTableLinkSpecialFactorEnergyProdC.Click();
        }
        private void ClickNistEnergyProdI()
        {
            NistTableLinkSpecialFactorEnergyProdI.Click();
        }
        private void ClickNistEnergySupplyA()
        {
            NistTableLinkSpecialFactorEnergySupplyA.Click();
        }
        private void ClickNistEnergySupplyC()
        {
            NistTableLinkSpecialFactorEnergySupplyC.Click();
        }
        private void ClickNistEnergySupplyI()
        {
            NistTableLinkSpecialFactorEnergySupplyI.Click();
        }
        private void ClickNistEnvMonitorForeA()
        {
            NistTableLinkSpecialFactorEnvMonitorForeA.Click();
        }
        private void ClickNistEnvMonitorForeC()
        {
            NistTableLinkSpecialFactorEnvMonitorForeC.Click();  
        }
        private void ClickNistEnvMonitorForeI()
        {
            NistTableLinkSpecialFactorEnvMonitorForeI.Click();
        }
        private void ClickNistFacilitiesFleetEMA()
        {
            NistTableLinkSpecialFactorFacilitiesFleetEMA.Click();
        }
        private void ClickNistFacilitiesFleetEMC()
        {
            NistTableLinkSpecialFactorFacilitiesFleetEMC.Click();
        }
        private void ClickNistFacilitiesFleetEMI()
        {
            NistTableLinkSpecialFactorFacilitiesFleetEMI.Click();
        }
        private void ClickNistGPDSA()
        {
            NistTableLinkSpecialFactorGPDSA.Click();
        }
        private void ClickNistGPDSC()
        {
            NistTableLinkSpecialFactorGPDSC.Click();
        }
        private void ClickNistGPDSI()
        {
            NistTableLinkSpecialFactorGPDSI.Click();
        }
        private void ClickNistGroundTransA()
        {
            NistTableLinkSpecialFactorGroundTransA.Click();
        }
        private void ClickNistGroundTransC()
        {
            NistTableLinkSpecialFactorGroundTransC.Click();
        }
        private void ClickNistGroundTransI()
        {
            NistTableLinkSpecialFactorGroundTransI.Click();
        }
        private void ClickNistKeyAssetCIPA()
        {
            NistTableLinkSpecialFactorKeyAssetCIPA.Click();
        }
        private void ClickNistKeyAssetCIPC()
        {
            NistTableLinkSpecialFactorKeyAssetCIPC.Click();
        }
        private void ClickNistKeyAssetCIPI()
        {
            NistTableLinkSpecialFactorKeyAssetCIPI.Click();
        }
        private void ClickNistPropertyProtectionA()
        {
            NistTableLinkSpecialFactorPropertyProtectionA.Click();
        }
        private void ClickNistPropertyProtectionC()
        {
            NistTableLinkSpecialFactorPropertyProtectionC.Click();
        }
        private void ClickNistPropertyProtectionI()
        {
            NistTableLinkSpecialFactorPropertyProtectionI.Click();
        }
        private void ClickNistERA()
        {
            NistTableLinkSpecialFactorSpecialFactorERA.Click();
        }
        private void ClickNistERC()
        {
            NistTableLinkSpecialFactorSpecialFactorERC.Click();
        }
        private void ClickNistERI()
        {
            NistTableLinkSpecialFactorSpecialFactorERI.Click();
        }
        private void ClickNistSysNetMonitoringA()
        {
            NistTableLinkSpecialFactorSysNetMonitoringA.Click();
        }
        private void ClickNistSysNetMonitoringC()
        {
            NistTableLinkSpecialFactorSysNetMonitoringC.Click();
        }
        private void ClickNistSysNetMonitoringI()
        {
            NistTableLinkSpecialFactorSysNetMonitoringI.Click();
        }
        private void ClickNistWaterTransA()
        {
            NistTableLinkSpecialFactorWaterTransA.Click();
        }
        private void ClickNistWaterTransC()
        {
            NistTableLinkSpecialFactorWaterTransC.Click();
        }
        private void ClickNistWaterTransI()
        {
            NistTableLinkSpecialFactorWaterTransI.Click();
        }
        private void ClickNistPleaseConfirmYes()
        {
            NistPleaseConfirmYes.Click();
        }
        private void ClickNistAnswerQ1No()
        {
            NistAnswerQuestions1No.Click();
        }
        private void ClickNistAnswerQ1Yes()
        {
            NistAnswerQuestions1Yes.Click();
        }
        private void ClickNistAnswerQ2No()
        {
            NistAnswerQuestions2No.Click();
        }
        private void ClickNistAnswerQ2Yes()
        {
            NistAnswerQuestions2Yes.Click();
        }
        private void ClickNistAnswerQ3No()
        {
            NistAnswerQuestions3No.Click();
        }
        private void ClickNistAnswerQ3Yes()
        {
            NistAnswerQuestions3Yes.Click();
        }
        private void ClickNistAnswerQ4No()
        {
            NistAnswerQuestions4No.Click();
        }
        private void ClickNistAnswerQ4Yes()
        {
            NistAnswerQuestions4Yes.Click();
        }
        private void ClickNistAnswerQ5No()
        {
            NistAnswerQuestions5No.Click();
        }
        private void ClickNistAnswerQ5Yes()
        {
            NistAnswerQuestions5Yes.Click();
        }
        private void ClickNistAnswerQ6No()
        {
            NistAnswerQuestions6No.Click();
        }
        private void ClickNistAnswerQ6Yes()
        {
            NistAnswerQuestions6Yes.Click();
        }
        private void ClickNistAnswerQ7No()
        {
            NistAnswerQuestions7No.Click();
        }
        private void ClickNistAnswerQ7Yes()
        {
            NistAnswerQuestions7Yes.Click();
        }
        private void ClickNistAnswerQ8No()
        {
            NistAnswerQuestions8No.Click();
        }
        private void ClickNistAnswerQ8Yes()
        {
            NistAnswerQuestions8Yes.Click();
        }

        //Aggregate methods
        public void SelectSALAssessment()
        {
            ClickSALAssessment();
        }
        public void SelectHeaderSimple()
        {
            ClickHeaderSimple();
        }

        public void SelectHeaderGeneralRiskBased()
        {
            MoveToElement(TextHeaderGeneralRiskBased);
            ClickHeaderGeneralRiskBased();
        }

        public void SelectHeaderNist()
        {
            MoveToElement(TextHeaderNist);
            ClickHeaderNist();
        }
        public void SALSimpleSelectorsTest()
        {
            ClickHeaderOverallSalLow();
            ClickHeaderOverallSalModerate();
            ClickHeaderOverallSalHigh();
            ClickHeaderOverallSalVeryHigh();
            ClickHeaderConfidentialityLow();
            ClickHeaderConfidentialityModerate();
            ClickHeaderConfidentialityHigh();
            ClickHeaderConfidentialityVeryHigh();
            ClickHeaderIntegrityLow();
            ClickHeaderIntegrityModerate();
            ClickHeaderIntegrityHigh();
            ClickHeaderIntegrityVeryHigh();
            ClickHeaderAvailabilityLow();
            ClickHeaderAvailabilityModerate();
            ClickHeaderAvailabilityHigh();
            ClickHeaderAvailabilityVeryHigh();
            System.Threading.Thread.Sleep(5000);
        }

        public void SALGeneralRiskSelectorsTest()
        {
            SendKeysGenRiskInjuriesOnSite();
            SendKeysGenRiskInuriesOffSite();
            SendKeysGenRiskHospitalizationsOnSite();
            SendKeysGenRiskHospitalizationsOffSite();
            SendKeysGenRiskDeathsOnSite();
            SendKeysGenRiskDeathsOffSite();
            SendKeysGenRiskCapitalLossOnSite();
            SendKeysGenRiskCapitalLossOffSite();
            SendKeysGenRiskEconomicImpactOnSite();
            SendKeysGenRiskEconomicImpactOffSite();
            SendKeysGenRiskEnvironmentalOnSite();
            SendKeysGenRiskEnvironmentalOffSite();
            System.Threading.Thread.Sleep(5000);
        }


        public void NISTOverallSALTest()
        {
            SelectHeaderOverallSalLow();
            SelectHeaderOverallSalModerate();
            SelectHeaderOverallSalHigh();
            SelectHeaderOverallSalVeryHigh();
        }

        public void NISTConfidentialityTest()
        {
            SelectHeaderConfidentialityLow();
            SelectHeaderConfidentialityModerate();
            SelectHeaderConfidentialityHigh();
            SelectHeaderConfidentialityVeryHigh();
        }

        public void NISTIntegrityTest()
        {
            SelectHeaderIntegrityLow();
            SelectHeaderIntegrityModerate();
            SelectHeaderIntegrityHigh();
            SelectHeaderIntegrityVeryHigh();
        }

        public void NISTAvailabilityTest()
        {
            SelectHeaderAvailabilityLow();
            SelectHeaderAvailabilityModerate();
            SelectHeaderAvailabilityHigh();
            SelectHeaderAvailabilityVeryHigh();
        }

        public void NISTCIAValuesCheckboxTest()
        {
            SelectNistCheckAirTransportation();
            SelectNistCheckAssetLM();
            SelectNistCheckBE();
            SelectNistCheckBF();
            SelectNistCheckBPI();
            SelectNistCheckCAPM();
            SelectNistCheckContingencyP();
            SelectNistCheckCOps();
            SelectNistCheckCP();
            SelectNistCheckCR();
            SelectNistCheckCS();
            SelectNistCheckDPP();
            SelectNistCheckEArch();
            SelectNistCheckECP();
            SelectNistCheckEnvMF();
            SelectNistCheckEnvR();
            SelectNistCheckEP();
            SelectNistCheckER();
            SelectNistCheckERM();
            SelectNistCheckESSSS();
            SelectNistCheckFFEM();
            SelectNistCheckGoodsAcq();
            SelectNistCheckGPDS();
            SelectNistCheckGroundTrans();
            SelectNistCheckHDS();
            SelectNistCheckIC();
            SelectNistCheckIIM();
            SelectNistCheckInfoM();
            SelectNistCheckInfoSec();
            SelectNistCheckInfoShare();
            SelectNistCheckIPP();
            SelectNistCheckKACIP();
            SelectNistCheckLCM();
            SelectNistCheckLogM();
            SelectNistCheckLRM();
            SelectNistCheckManufacturing();
            SelectNistCheckMI();
            SelectNistCheckOtherFin();
            SelectNistCheckOtherInfoM();
            SelectNistCheckOtherM();
            SelectNistCheckOtherOps();
            SelectNistCheckOtherRD();
            SelectNistCheckOtherSec();
            SelectNistCheckOtherSuppF();
            SelectNistCheckPayments();
            SelectNistCheckPIM();
            SelectNistCheckPL();
            SelectNistCheckPO();
            SelectNistCheckPP();
            SelectNistCheckPPC();
            SelectNistCheckPR();
            SelectNistCheckRD();
            SelectNistCheckRI();
            SelectNistCheckRR();
            SelectNistCheckSAcq();
            SelectNistCheckSD();
            SelectNistCheckSM();
            SelectNistCheckSNM();
            SelectNistCheckSR();
            SelectNistCheckSTRI();
            SelectNistCheckSysM();
            SelectNistCheckTE();
            SelectNistCheckWFP();
            SelectNistCheckWPDM();
            SelectNistCheckWRM();
            SelectNistCheckWS();
            SelectNistCheckWTrans();
        }

        public void SelectHeaderSimpleTest()
        {
            ClickHeaderSimple();
            ClickHeaderOverallSalLow();
            System.Threading.Thread.Sleep(5000);
        }





        public void SelectHeaderOverallSalLow()
        {
            ClickHeaderOverallSalLow();
        }

        public void SelectHeaderOverallSalModerate()
        {
            ClickHeaderOverallSalModerate();
        }
        public void SelectHeaderOverallSalHigh()
        {
            ClickHeaderOverallSalHigh();
        }
        public void SelectHeaderOverallSalVeryHigh()
        {
            ClickHeaderOverallSalVeryHigh();
        }

        public void SelectHeaderConfidentialityLow()
        {
            ClickHeaderConfidentialityLow();
        }

        public void SelectHeaderConfidentialityModerate()
        {
            ClickHeaderConfidentialityModerate();
        }

        public void SelectHeaderConfidentialityHigh()
        {
            ClickHeaderConfidentialityHigh();
        }

        public void SelectHeaderConfidentialityVeryHigh()
        {
            ClickHeaderConfidentialityVeryHigh();
        }

        public void SelectHeaderIntegrityLow()
        {
            ClickHeaderIntegrityLow();
        }

        public void SelectHeaderIntegrityModerate()
        {
            ClickHeaderIntegrityModerate();
        }

        public void SelectHeaderIntegrityHigh()
        {
            ClickHeaderIntegrityHigh();
        }

        public void SelectHeaderIntegrityVeryHigh()
        {
            ClickHeaderIntegrityVeryHigh();
        }

        public void SelectHeaderAvailabilityLow()
        {
            ClickHeaderAvailabilityLow();
        }

        public void SelectHeaderAvailabilityModerate()
        {
            ClickHeaderAvailabilityModerate();
        }

        public void SelectHeaderAvailabilityHigh()
        {
            ClickHeaderAvailabilityHigh();
        }

        public void SelectHeaderAvailabilityVeryHigh()
        {
            ClickHeaderAvailabilityVeryHigh();
        }

        //general risk based

        public void SelectGenRiskInjuriesOnSite()
        {
            SendKeysGenRiskInjuriesOnSite();

        }

        public void SelectGenRiskInuriesOffSite()
        {
            SendKeysGenRiskInuriesOffSite();
        }
        public void SelectGenRiskHospitalizationsOnSite()
        {
            SendKeysGenRiskHospitalizationsOnSite();
        }
        public void SelectGenRiskHospitalizationsOffSite()
        {
            SendKeysGenRiskHospitalizationsOffSite();
        }
        public void SelectGenRiskDeathsOnSite()
        {
            SendKeysGenRiskDeathsOnSite();
        }
        public void SelectGenRiskDeathsOffSite()
        {
            SendKeysGenRiskDeathsOffSite();
        }
        public void SelectGenRiskCapitalLossOnSite()
        {
            SendKeysGenRiskCapitalLossOnSite();
        }
        public void SelectGenRiskCapitalLossOffSite()
        {
            SendKeysGenRiskCapitalLossOffSite();
        }
        public void SelectGenRiskEconomicImpactOnSite()
        {
            SendKeysGenRiskEconomicImpactOnSite();
        }
        public void SelectGenRiskEconomicImpactOffSite()
        {
            SendKeysGenRiskEconomicImpactOffSite();
        }
        public void SelectGenRiskEnvironmentalOnSite()
        {
            SendKeysGenRiskEnvironmentalOnSite();
        }
        public void SelectGenRiskEnvironmentalOffSite()
        {
            SendKeysGenRiskEnvironmentalOffSite();
        }


            //nist
        public void SelectNistCheckAirTransportation()
        {
            ClickNistCheckAirTransportation();
        }

        public void SelectNistCheckAssetLM()
        {
            ClickNistCheckAssetLM();
        }

        public void SelectNistCheckBE()
        {
            ClickNistCheckBE();
        }

        public void SelectNistCheckBF()
        {
            ClickNistCheckBF();
        }
        public void SelectNistCheckBPI()
        {
            ClickNistCheckBPI();
        }
        public void SelectNistCheckCP()
        {
            ClickNistCheckCP();
        }
        public void SelectNistCheckCR()
        {
            ClickNistCheckCR();
        }
        public void SelectNistCheckContingencyP()
        {
            ClickNistCheckContingencyP();
        }
        public void SelectNistCheckCOps()
        {
            ClickNistCheckCOps();
        }
        public void SelectNistCheckCAPM()
        {
            ClickNistCheckCAPM();
        }
        public void SelectNistCheckCS()
        {
            ClickNistCheckCS();
        }
        public void SelectNistCheckDPP()
        {
            ClickNistCheckDPP();
        }
        public void SelectNistCheckER()
        {
            ClickNistCheckER();
        }
        public void SelectNistCheckECP()
        {
            ClickNistCheckECP();
        }
        public void SelectNistCheckEP()
        {
            ClickNistCheckEP();
        }
        public void SelectNistCheckERM()
        {
            ClickNistCheckERM();
        }
        public void SelectNistCheckESSSS()
        {
            ClickNistCheckESSSS();
        }
        public void SelectNistCheckEArch()
        {
            ClickNistCheckEArch();
        }
        public void SelectNistCheckEnvMF()
        {
            ClickNistCheckEnvMF();
        }
        public void SelectNistCheckEnvR()
        {
            ClickNistCheckEnvR();
        }
        public void SelectNistCheckFFEM()
        {
            ClickNistCheckFFEM();
        }
        public void SelectNistCheckGPDS()
        {
            ClickNistCheckGPDS();
        }
        public void SelectNistCheckGoodsAcq()
        {
            ClickNistCheckGoodsAcq();
        }
        public void SelectNistCheckGroundTrans()
        {
            ClickNistCheckGroundTrans();
        }
        public void SelectNistCheckHDS()
        {
            ClickNistCheckHDS();
        }
        public void SelectNistCheckIIM()
        {
            ClickNistCheckIIM();
        }
        public void SelectNistCheckInfoM()
        {
            ClickNistCheckInfoM();
        }
        public void SelectNistCheckInfoSec()
        {
            ClickNistCheckInfoSec();
        }
        public void SelectNistCheckInfoShare()
        {
            ClickNistCheckInfoShare();
        }
        public void SelectNistCheckIPP()
        {
            ClickNistCheckIPP();
        }
        public void SelectNistCheckIC()
        {
            ClickNistCheckIC();
        }
        public void SelectNistCheckKACIP()
        {
            ClickNistCheckKACIP();
        }
        public void SelectNistCheckLRM()
        {
            ClickNistCheckLRM();
        }
        public void SelectNistCheckLCM()
        {
            ClickNistCheckLCM();
        }
        public void SelectNistCheckLogM()
        {
            ClickNistCheckLogM();
        }
        public void SelectNistCheckMI()
        {
            ClickNistCheckMI();
        }
        public void SelectNistCheckManufacturing()
        {
            ClickNistCheckManufacturing();
        }
        public void SelectNistCheckOtherFin()
        {
            ClickNistCheckOtherFin();
        }
        public void SelectNistCheckOtherInfoM()
        {
            ClickNistCheckOtherInfoM();
        }
        public void SelectNistCheckOtherM()
        {
            ClickNistCheckOtherM();
        }
        public void SelectNistCheckOtherOps()
        {
            ClickNistCheckOtherOps();
        }
        public void SelectNistCheckOtherRD()
        {
            MoveToElement(CheckboxNistOtherRAndD);
            ClickNistCheckOtherRD();
        }
        public void SelectNistCheckOtherSec()
        {
            ClickNistCheckOtherSec();
        }
        public void SelectNistCheckOtherSuppF()
        {
            ClickNistCheckOtherSuppF();
        }
        public void SelectNistCheckPayments()
        {
            ClickNistCheckPayments();
        }
        public void SelectNistCheckPIM()
        {
            ClickNistCheckPIM();
        }
        public void SelectNistCheckPL()
        {
            ClickNistCheckPL();
        }
        public void SelectNistCheckPPC()
        {
            ClickNistCheckPPC();
        }
        public void SelectNistCheckPO()
        {
            ClickNistCheckPO();
        }
        public void SelectNistCheckPP()
        {
            ClickNistCheckPP();
        }
        public void SelectNistCheckPR()
        {
            ClickNistCheckPR();
        }
        public void SelectNistCheckRR()
        {
            ClickNistCheckRR();
        }
        public void SelectNistCheckRI()
        {
            ClickNistCheckRI();
        }
        public void SelectNistCheckRD()
        {
            ClickNistCheckRD();
        }
        public void SelectNistCheckSTRI()
        {
            ClickNistCheckSTRI();
        }
        public void SelectNistCheckSM()
        {
            ClickNistCheckSM();
        }
        public void SelectNistCheckSR()
        {
            ClickNistCheckSR();
        }
        public void SelectNistCheckSAcq()
        {
            ClickNistCheckSAcq();
        }
        public void SelectNistCheckSNM()
        {
            ClickNistCheckSNM();
        }
        public void SelectNistCheckSD()
        {
            ClickNistCheckSD();
        }
        public void SelectNistCheckSysM()
        {
            ClickNistCheckSysM();
        }
        public void SelectNistCheckTE()
        {
            ClickNistCheckTE();
        }
        public void SelectNistCheckWRM()
        {
            ClickNistCheckWRM();
        }
        public void SelectNistCheckWTrans()
        {
            ClickNistCheckWTrans();
        }
        public void SelectNistCheckWFP()
        {
            ClickNistCheckWFP();
        }
        public void SelectNistCheckWS()
        {
            ClickNistCheckWS();
        }
        public void SelectNistCheckWPDM()
        {
            ClickNistCheckWPDM();
        }
        public void SelectNistAirTransA()
        {
            MoveToElement(NistTableLinkSpecialFactorAirTransA);
            ClickNistAirTransA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistAirTransC()
        {
            ClickNistAirTransC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistAirTransI()
        {
            ClickNistAirTransI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistDPPA()
        {
            ClickNistDPPA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistDPPC()
        {
            ClickNistDPPC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistDPPI()
        {
            ClickNistDPPI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistECPA()
        {
            ClickNistECPA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistECPC()
        {
            ClickNistECPC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistECPI()
        {
            ClickNistECPI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnergyProdA()
        {
            ClickNistEnergyProdA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnergyProdC()
        {
            ClickNistEnergyProdC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnergyProdI()
        {
            ClickNistEnergyProdI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnergySupplyA()
        {
            ClickNistEnergySupplyA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnergySupplyC()
        {
            ClickNistEnergySupplyC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnergySupplyI()
        {
            ClickNistEnergySupplyI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnvMonitorForeA()
        {
            ClickNistEnvMonitorForeA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnvMonitorForeC()
        {
            ClickNistEnvMonitorForeC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistEnvMonitorForeI()
        {
            ClickNistEnvMonitorForeI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistFacilitiesFleetEMA()
        {
            ClickNistFacilitiesFleetEMA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistFacilitiesFleetEMC()
        {
            ClickNistFacilitiesFleetEMC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistFacilitiesFleetEMI()
        {
            ClickNistFacilitiesFleetEMI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistGPDSA()
        {
            ClickNistGPDSA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistGPDSC()
        {
            ClickNistGPDSC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistGPDSI()
        {
            ClickNistGPDSI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistGroundTransA()
        {
            ClickNistGroundTransA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistGroundTransC()
        {
            ClickNistGroundTransC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistGroundTransI()
        {
            ClickNistGroundTransI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistKeyAssetCIPA()
        {
            ClickNistKeyAssetCIPA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistKeyAssetCIPC()
        {
            ClickNistKeyAssetCIPC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistKeyAssetCIPI()
        {
            ClickNistKeyAssetCIPI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistPropertyProtectionA()
        {
            ClickNistPropertyProtectionA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistPropertyProtectionC()
        {
            ClickNistPropertyProtectionC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistPropertyProtectionI()
        {
            ClickNistPropertyProtectionI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistERA()
        {
            ClickNistERA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistERC()
        {
            ClickNistERC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistERI()
        {
            ClickNistERI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistSysNetMonitoringA()
        {
            ClickNistSysNetMonitoringA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistSysNetMonitoringC()
        {
            ClickNistSysNetMonitoringC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistSysNetMonitoringI()
        {
            ClickNistSysNetMonitoringI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistWaterTransA()
        {
            ClickNistWaterTransA();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistWaterTransC()
        {
            ClickNistWaterTransC();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistWaterTransI()
        {
            ClickNistWaterTransI();
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistPleaseConfirmYes()
        {
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistAnswerQ1No()
        {
            ClickNistAnswerQ1No();
        }
        public void SelectNistAnswerQ1Yes()
        {
            ClickNistAnswerQ1Yes();
        }
        public void SelectNistAnswerQ2No()
        {
            ClickNistAnswerQ2No();
        }
        public void SelectNistAnswerQ2Yes()
        {
            ClickNistAnswerQ2Yes();
        }
        public void SelectNistAnswerQ3No()
        {
            ClickNistAnswerQ3No();
        }
        public void SelectNistAnswerQ3Yes()
        {
            ClickNistAnswerQ3Yes();
        }
        public void SelectNistAnswerQ4No()
        {
            ClickNistAnswerQ4No();
        }
        public void SelectNistAnswerQ4Yes()
        {
            ClickNistAnswerQ4Yes();
        }
        public void SelectNistAnswerQ5No()
        {
            ClickNistAnswerQ5No();
        }
        public void SelectNistAnswerQ5Yes()
        {
            ClickNistAnswerQ5Yes();
        }
        public void SelectNistAnswerQ6No()
        {
            ClickNistAnswerQ6No();
        }
        public void SelectNistAnswerQ6Yes()
        {
            ClickNistAnswerQ6Yes();
        }
        public void SelectNistAnswerQ7No()
        {
            ClickNistAnswerQ7No();
        }
        public void SelectNistAnswerQ7Yes()
        {
            ClickNistAnswerQ7Yes();
        }
        public void SelectNistAnswerQ8No()
        {
            ClickNistAnswerQ8No();
        }
        public void SelectNistAnswerQ8Yes()
        {
            ClickNistAnswerQ8Yes();
        }
    }
}
