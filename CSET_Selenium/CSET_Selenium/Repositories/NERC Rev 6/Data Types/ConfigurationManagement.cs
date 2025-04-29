using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.Shared.Data_Types;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    ///
    /// </summary>
    public class ConfigurationManagement : BaseDTOData
    {
        /// <summary>
        /// 
        /// </summary>
        public ConfigurationManagement()
        {
            this.ConfiurationChangeManagementPlan = base.GetNextValue();
            this.DevelopBaselineConfiguation = base.GetNextValue();
            this.ChangeThatDeviatesFromExistingBaselineConfiguration = base.GetNextValue();
            this.ForEachChangeThatDeviatesFromExistingBaselineConfiguration = base.GetNextValue();

            this.ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems = base.GetNextValue();
            this.IdentifyImpactOfBESCyberSystemsAccordingToAttachement1 = base.GetNextValue();
            this.ProcessThatConsidersControlCentersAndBackupControlCenters = base.GetNextValue();
            this.OrganizationImplmentProcessTransmissionStationsAndSubStations = base.GetNextValue();
            this.OrganizationImplmentProcessThatConsidersGenerationResources = base.GetNextValue();
            this.ProcessThatConsidersGenerationResources = base.GetNextValue();
            this.ProcessThatConsidersSpecialProtectionSystems = base.GetNextValue();
            this.ProcessThatConsidersDistributionProvidersAndProtectedSystems = base.GetNextValue();
            this.IdentifiedHIGHImactBESCyberSystems = base.GetNextValue();
            this.IdentifiedMEDIUMImactBESCyberSystems = base.GetNextValue();
            this.IdentifiedLOWImactBESCyberSystems = base.GetNextValue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public ConfigurationManagement(QuestionAnswers questionAnswers)
        {
            this.ConfiurationChangeManagementPlan = questionAnswers;
            this.DevelopBaselineConfiguation = questionAnswers;
            this.ChangeThatDeviatesFromExistingBaselineConfiguration = questionAnswers;
            this.ForEachChangeThatDeviatesFromExistingBaselineConfiguration = questionAnswers;

            this.ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems = questionAnswers;
            this.IdentifyImpactOfBESCyberSystemsAccordingToAttachement1 = questionAnswers;
            this.ProcessThatConsidersControlCentersAndBackupControlCenters = questionAnswers;
            this.OrganizationImplmentProcessTransmissionStationsAndSubStations = questionAnswers;
            this.OrganizationImplmentProcessThatConsidersGenerationResources = questionAnswers;
            this.ProcessThatConsidersGenerationResources = questionAnswers;
            this.ProcessThatConsidersSpecialProtectionSystems = questionAnswers;
            this.ProcessThatConsidersDistributionProvidersAndProtectedSystems = questionAnswers;
            this.IdentifiedHIGHImactBESCyberSystems = questionAnswers;
            this.IdentifiedMEDIUMImactBESCyberSystems = questionAnswers;
            this.IdentifiedLOWImactBESCyberSystems = questionAnswers;
        }

        // Configuration Change Management
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_have_a_physical_security_plan)]
        public QuestionAnswers ConfiurationChangeManagementPlan
        {
            get;set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_develop_a_baseline_configuration_individually_or_by_group_which_include_the_following)]
        public QuestionAnswers DevelopBaselineConfiguation
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_develop_a_baseline_configuration_individually_or_by_group_which_include_the_following)]
        public QuestionAnswers ChangeThatDeviatesFromExistingBaselineConfiguration
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.For_a_change_that_deviates_from_the_existing_baseline_do_you_implement_the_following)]
        public QuestionAnswers ForEachChangeThatDeviatesFromExistingBaselineConfiguration
        {
            get; set;
        }

        // Inventory

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_maintain_a_configuration_management_inventory_of_and_identify_impact_for_BES_Cyber_systems)]
        public QuestionAnswers ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_identify_the_impact_of_BES_Cyber_Systems_according_to_Attachment_1_Section_1_for_the_following_assets_specified_in_Applicability_section_4_2_1)]
        public QuestionAnswers IdentifyImpactOfBESCyberSystemsAccordingToAttachement1
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_implement_a_process_that_considers_control_centers_and_backup_control_centers)]
        public QuestionAnswers ProcessThatConsidersControlCentersAndBackupControlCenters
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_implement_a_process_that_considers_transmission_stations_and_substations)]
        public QuestionAnswers OrganizationImplmentProcessTransmissionStationsAndSubStations
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_implement_a_process_that_considers_generation_resources)]
        public QuestionAnswers OrganizationImplmentProcessThatConsidersGenerationResources
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_implement_a_process_that_considers_systems_and_facilities_critical_to_system_restoration_including_blackstart_resources_and_cranking_paths_and_initial_switching_requirements)]
        public QuestionAnswers ProcessThatConsidersGenerationResources
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_implement_a_process_that_considers_Special_Protection_Systems_that_support_the_reliable_operation_of_the_Bulk_Electric_System)]
        public QuestionAnswers ProcessThatConsidersSpecialProtectionSystems
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_implement_a_process_that_considers_Special_Protection_Systems_that_support_the_reliable_operation_of_the_Bulk_Electric_System)]
        public QuestionAnswers ProcessThatConsidersDistributionProvidersAndProtectedSystems
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.For_questions_1_7_in_this_group_have_you_identified_the_HIGH_impact_BES_Cyber_Systems_according_to_attachment_1_section_1_if_any_at_each_asset)]
        public QuestionAnswers IdentifiedHIGHImactBESCyberSystems
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.For_questions_1_7_in_this_group_have_you_identified_the_MEDIUM_impact_BES_Cyber_Systems_according_to_attachment_1_section_1_if_any_at_each_asset)]
        public QuestionAnswers IdentifiedMEDIUMImactBESCyberSystems
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.For_questions_1_7_in_this_group_have_you_identified_the_LOW_impact_BES_Cyber_Systems_according_to_attachment_1_section_1_if_any_at_each_asset)]
        public QuestionAnswers IdentifiedLOWImactBESCyberSystems
        {
            get; set;
        }
    }
}
