using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    /// <summary>
    /// 
    /// </summary>
    internal class ConfigurationManagementPage : BasePage
    {
        private ConfigurationManagement _configurationManagement;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="configurationManagement"></param>
        public ConfigurationManagementPage(IWebDriver driver, ConfigurationManagement configurationManagement) : base(driver)
        {
            this._configurationManagement = configurationManagement;

            // initialize page controls to backing object value

            // Configuration Change Management
            this.ConfiurationChangeManagementPlan = configurationManagement.ConfiurationChangeManagementPlan;

            // only update these controls if the value of the parent is yes or na
            if (configurationManagement.ConfiurationChangeManagementPlan.IsYESorALTorUNanswered())
            {
                this.DevelopBaselineConfiguation = configurationManagement.DevelopBaselineConfiguation;
                this.ChangeThatDeviatesFromExistingBaselineConfiguration = configurationManagement.ChangeThatDeviatesFromExistingBaselineConfiguration;
                this.ForEachChangeThatDeviatesFromExistingBaselineConfiguration = configurationManagement.ForEachChangeThatDeviatesFromExistingBaselineConfiguration;
            }

            // Inventory mangement
            this.ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems = configurationManagement.ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems;

            // only update these controls if the value of the parent is yes or na
            if (configurationManagement.ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems.IsYESorALTorUNanswered())
            {
                this.IdentifyImpactOfBESCyberSystemsAccordingToAttachement1 = configurationManagement.IdentifyImpactOfBESCyberSystemsAccordingToAttachement1;
                this.ProcessThatConsidersControlCentersAndBackupControlCenters = configurationManagement.ProcessThatConsidersControlCentersAndBackupControlCenters;
                this.OrganizationImplmentProcessTransmissionStationsAndSubStations = configurationManagement.OrganizationImplmentProcessTransmissionStationsAndSubStations; ;
                this.OrganizationImplmentProcessThatConsidersGenerationResources = configurationManagement.OrganizationImplmentProcessThatConsidersGenerationResources;
                this.ProcessThatConsidersGenerationResources = configurationManagement.ProcessThatConsidersGenerationResources;
                this.ProcessThatConsidersSpecialProtectionSystems = configurationManagement.ProcessThatConsidersSpecialProtectionSystems;
                this.ProcessThatConsidersDistributionProvidersAndProtectedSystems = configurationManagement.ProcessThatConsidersDistributionProvidersAndProtectedSystems;
                this.IdentifiedHIGHImactBESCyberSystems = configurationManagement.IdentifiedHIGHImactBESCyberSystems;
                this.IdentifiedMEDIUMImactBESCyberSystems = configurationManagement.IdentifiedMEDIUMImactBESCyberSystems;
                this.IdentifiedLOWImactBESCyberSystems = configurationManagement.IdentifiedLOWImactBESCyberSystems;
            }
        }        

        #region Configuration Change Management
        #region Does the organization have a configuration change management plan?
        public QuestionAnswers ConfiurationChangeManagementPlan
        {
            get { return this._configurationManagement.DevelopBaselineConfiguation; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.ConfigurationChangeManagementYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.ConfigurationChangeManagementNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.ConfigurationChangeManagementNA.Click();

                            break;
                        }
                }
            }
        }
        private IWebElement ConfigurationChangeManagementYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[4]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]")); }
        }

        private IWebElement ConfigurationChangeManagementNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[4]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]")); }
        }

        private IWebElement ConfigurationChangeManagementNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[4]/app-category-block/div[2]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]")); }
        }
        #endregion

        #region 1. Do you develop a baseline configuration, individually or by group, which include the following?
        public QuestionAnswers DevelopBaselineConfiguation
        {
            get { return this._configurationManagement.DevelopBaselineConfiguation; }
            set
            {
                switch(value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.DoYouDevelopBaselineConfigurationYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.DoYouDevelopBaselineConfigurationNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.DoYouDevelopBaselineConfigurationNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.DoYouDevelopBaselineConfigurationALT.Click();

                            break;
                        }
                }
            }
        }
        private IWebElement DoYouDevelopBaselineConfigurationYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14601\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement DoYouDevelopBaselineConfigurationNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14601\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement DoYouDevelopBaselineConfigurationNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14601\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement DoYouDevelopBaselineConfigurationALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14601\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 2. For a change that deviates from the existing baseline do you implement the following?
        public QuestionAnswers ChangeThatDeviatesFromExistingBaselineConfiguration
        {
            get { return this._configurationManagement.ChangeThatDeviatesFromExistingBaselineConfiguration; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.ForAChangeThatDeviatesYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.ForAChangeThatDeviatesNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.ForAChangeThatDeviatesNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.ForAChangeThatDeviatesAlt.Click();

                            break;
                        }
                }
            }
        }
        private IWebElement ForAChangeThatDeviatesYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14609\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement ForAChangeThatDeviatesNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14609\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement ForAChangeThatDeviatesNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14609\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement ForAChangeThatDeviatesAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14609\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 3 For each change that deviates from the existing baseline configuration do you perform the following(where technically feasible)?
        public QuestionAnswers ForEachChangeThatDeviatesFromExistingBaselineConfiguration
        {
            get { return this._configurationManagement.ForEachChangeThatDeviatesFromExistingBaselineConfiguration; }
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.ForEachChangeThatDeviatesYes.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.ForEachChangeThatDeviatesNo.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.ForEachChangeThatDeviatesNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.ForEachChangeThatDeviatesAlt.Click();

                            break;
                        }
                }
            }
        }
        private IWebElement ForEachChangeThatDeviatesYes
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14613\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement ForEachChangeThatDeviatesNo
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14613\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement ForEachChangeThatDeviatesNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14613\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement ForEachChangeThatDeviatesAlt
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14613\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion
        #endregion

        #region Inventory Management

        #region Does the organization maintain a configuration management inventory of and identify impact for BES Cyber systems?
        private QuestionAnswers ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems
        {
            set 
            { 
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystemsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystemsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystemsNA.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystemsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[4]/app-category-block/div[3]/app-question-block/div/div[1]/div[2]/div[2]/div/label[1]")); }
        }
        private IWebElement weConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystemsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[4]/app-category-block/div[3]/app-question-block/div/div[1]/div[2]/div[2]/div/label[2]")); }
        }
        private IWebElement weConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystemsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[4]/app-category-block/div[3]/app-question-block/div/div[1]/div[2]/div[2]/div/label[3]")); }
        }
        #endregion

        #region 4 Do you identify the impact of BES Cyber Systems according to Attachment 1, Section 1 for the following assets, specified in Applicability section 4.2.1?
        private QuestionAnswers IdentifyImpactOfBESCyberSystemsAccordingToAttachement1
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weIdentifyImpactOfBESCyberSystemsAccordingToAttachement1YES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weIdentifyImpactOfBESCyberSystemsAccordingToAttachement1NO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weIdentifyImpactOfBESCyberSystemsAccordingToAttachement1NA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weIdentifyImpactOfBESCyberSystemsAccordingToAttachement1ALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weIdentifyImpactOfBESCyberSystemsAccordingToAttachement1YES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14449\"]/div[1]/div[2]/div/label[1]")); }
        }
        private IWebElement weIdentifyImpactOfBESCyberSystemsAccordingToAttachement1NO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14449\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weIdentifyImpactOfBESCyberSystemsAccordingToAttachement1NA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14449\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weIdentifyImpactOfBESCyberSystemsAccordingToAttachement1ALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14449\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 5 Does the organization implement a process that considers control centers and backup control centers?
        private QuestionAnswers ProcessThatConsidersControlCentersAndBackupControlCenters
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weProcessThatConsidersControlCentersAndBackupControlCentersYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weProcessThatConsidersControlCentersAndBackupControlCentersNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weProcessThatConsidersControlCentersAndBackupControlCentersNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weProcessThatConsidersControlCentersAndBackupControlCentersALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weProcessThatConsidersControlCentersAndBackupControlCentersYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14450\"]/div[1]/div[2]/div/label[1]")); }
        }
        private IWebElement weProcessThatConsidersControlCentersAndBackupControlCentersNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14450\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weProcessThatConsidersControlCentersAndBackupControlCentersNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14450\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weProcessThatConsidersControlCentersAndBackupControlCentersALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14450\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 6 Does the organization implement a process that considers transmission stations and substations?
        private QuestionAnswers OrganizationImplmentProcessThatConsidersGenerationResources
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weOrganizationImplmentProcessThatConsidersGenerationResourcesYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weOrganizationImplmentProcessThatConsidersGenerationResourcesNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weOrganizationImplmentProcessThatConsidersGenerationResourcesNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weOrganizationImplmentProcessThatConsidersGenerationResourcesALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weOrganizationImplmentProcessThatConsidersGenerationResourcesYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14451\"]/div[1]/div[2]/div[1]/label[1]")); }
        }

        private IWebElement weOrganizationImplmentProcessThatConsidersGenerationResourcesNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14451\"]/div[1]/div[2]/div[1]/label[2]")); }
        }

        private IWebElement weOrganizationImplmentProcessThatConsidersGenerationResourcesNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14451\"]/div[1]/div[2]/div[1]/label[3]")); }
        }

        private IWebElement weOrganizationImplmentProcessThatConsidersGenerationResourcesALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14451\"]/div[1]/div[2]/div[1]/label[4]")); }
        }

        #endregion

        #region 7 Does the organization implement a process that considers generation resources?
        private QuestionAnswers OrganizationImplmentProcessTransmissionStationsAndSubStations
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weOrganizationImplmentProcessTransmissionStationsAndSubStationsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weOrganizationImplmentProcessTransmissionStationsAndSubStationsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weOrganizationImplmentProcessTransmissionStationsAndSubStationsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weOrganizationImplmentProcessTransmissionStationsAndSubStationsALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weOrganizationImplmentProcessTransmissionStationsAndSubStationsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14452\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement weOrganizationImplmentProcessTransmissionStationsAndSubStationsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14452\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement weOrganizationImplmentProcessTransmissionStationsAndSubStationsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14452\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement weOrganizationImplmentProcessTransmissionStationsAndSubStationsALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14452\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 8 Does the organization implement a process that considers systems and facilities critical to system restoration, including blackstart resources and cranking paths and initial switching requirements?
        private QuestionAnswers ProcessThatConsidersGenerationResources
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weProcessThatConsidersGenerationResourcesYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weProcessThatConsidersGenerationResourcesNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weProcessThatConsidersGenerationResourcesNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weProcessThatConsidersGenerationResourcesALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weProcessThatConsidersGenerationResourcesYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14453\"]/div[1]/div[2]/div/label[1]")); }
        }
        private IWebElement weProcessThatConsidersGenerationResourcesNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14453\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weProcessThatConsidersGenerationResourcesNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14453\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weProcessThatConsidersGenerationResourcesALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14453\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 9 Does the organization implement a process that considers Special Protection Systems that support the reliable operation of the Bulk Electric System?
        private QuestionAnswers ProcessThatConsidersSpecialProtectionSystems
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weProcessThatConsidersSystemsAndFacilitiesYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weProcessThatConsidersSystemsAndFacilitiesNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weProcessThatConsidersSystemsAndFacilitiesNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weProcessThatConsidersSystemsAndFacilitiesALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weProcessThatConsidersSystemsAndFacilitiesYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14454\"]/div[1]/div[2]/div/label[1]")); }
        }
        private IWebElement weProcessThatConsidersSystemsAndFacilitiesNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14454\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weProcessThatConsidersSystemsAndFacilitiesNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14454\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weProcessThatConsidersSystemsAndFacilitiesALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14454\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 10 Does the organization implement a process that consider distribution providers and protection systems?
        private QuestionAnswers ProcessThatConsidersDistributionProvidersAndProtectedSystems
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weProcessThatConsidersDistributionProvidersAndProtectedSystemsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weProcessThatConsidersDistributionProvidersAndProtectedSystemsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weProcessThatConsidersDistributionProvidersAndProtectedSystemsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weProcessThatConsidersDistributionProvidersAndProtectedSystemsALT.Click();

                            break;
                        }
                }
            }
        }

        IWebElement weProcessThatConsidersDistributionProvidersAndProtectedSystemsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14455\"]/div[1]/div[2]/div/label[1]")); }
        }
        IWebElement weProcessThatConsidersDistributionProvidersAndProtectedSystemsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14455\"]/div[1]/div[2]/div/label[2]")); }
        }
        IWebElement weProcessThatConsidersDistributionProvidersAndProtectedSystemsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14455\"]/div[1]/div[2]/div/label[3]")); }
        }
        IWebElement weProcessThatConsidersDistributionProvidersAndProtectedSystemsALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14455\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 11 For questions 1-7 in this group have you identified the HIGH impact BES Cyber Systems according to attachment 1, section 1, if any, at each asset?
        private QuestionAnswers IdentifiedHIGHImactBESCyberSystems
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weIdentifiedHIGHImactBESCyberSystemsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weIdentifiedHIGHImactBESCyberSystemsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weIdentifiedHIGHImactBESCyberSystemsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weIdentifiedHIGHImactBESCyberSystemsALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weIdentifiedHIGHImactBESCyberSystemsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14456\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement weIdentifiedHIGHImactBESCyberSystemsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14456\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement weIdentifiedHIGHImactBESCyberSystemsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14456\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement weIdentifiedHIGHImactBESCyberSystemsALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14456\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 12 For questions 1-7 in this group have you identified the MEDIUM impact BES Cyber Systems according to attachment 1, section 1, if any, at each asset?
        private QuestionAnswers IdentifiedMEDIUMImactBESCyberSystems
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weIdentifiedMEDIUMImactBESCyberSystemsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weIdentifiedMEDIUMImactBESCyberSystemsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weIdentifiedMEDIUMImactBESCyberSystemsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weIdentifiedMEDIUMImactBESCyberSystemsALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weIdentifiedMEDIUMImactBESCyberSystemsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14457\"]/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement weIdentifiedMEDIUMImactBESCyberSystemsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14457\"]/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement weIdentifiedMEDIUMImactBESCyberSystemsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14457\"]/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement weIdentifiedMEDIUMImactBESCyberSystemsALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14457\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion

        #region 13 For questions 1-7 in this group have you identified the LOW impact BES Cyber Systems according to attachment 1, section 1, if any, at each asset?
        private QuestionAnswers IdentifiedLOWImactBESCyberSystems
        {
            set
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.weIdentifiedLOWImactBESCyberSystemsYES.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.weIdentifiedLOWImactBESCyberSystemsNO.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.weIdentifiedLOWImactBESCyberSystemsNA.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.weIdentifiedLOWImactBESCyberSystemsALT.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement weIdentifiedLOWImactBESCyberSystemsYES
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14458\"]/div[1]/div[2]/div/label[1]")); }
        }
        private IWebElement weIdentifiedLOWImactBESCyberSystemsNO
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14458\"]/div[1]/div[2]/div/label[2]")); }
        }
        private IWebElement weIdentifiedLOWImactBESCyberSystemsNA
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14458\"]/div[1]/div[2]/div/label[3]")); }
        }
        private IWebElement weIdentifiedLOWImactBESCyberSystemsALT
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id=\"qq14458\"]/div[1]/div[2]/div/label[4]")); }
        }
        #endregion
        #endregion
    }
}
