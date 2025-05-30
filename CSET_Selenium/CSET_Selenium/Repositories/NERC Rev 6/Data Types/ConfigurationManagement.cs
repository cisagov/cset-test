using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System.Collections.Generic;

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
        public ConfigurationManagement() : base() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public override void Initialize(QuestionAnswers questionAnswers)
        {
            this.ConfiurationChangeManagementPlan = base.GetQuestionAnswers(questionAnswers);
            this.DevelopBaselineConfiguation = base.GetQuestionAnswers(questionAnswers);
            this.ChangeThatDeviatesFromExistingBaselineConfiguration = base.GetQuestionAnswers(questionAnswers);
            this.ForEachChangeThatDeviatesFromExistingBaselineConfiguration = base.GetQuestionAnswers(questionAnswers);

            this.ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems = base.GetQuestionAnswers(questionAnswers);
            this.IdentifyImpactOfBESCyberSystemsAccordingToAttachement1 = base.GetQuestionAnswers(questionAnswers);
            this.ProcessThatConsidersControlCentersAndBackupControlCenters = base.GetQuestionAnswers(questionAnswers);
            this.OrganizationImplmentProcessTransmissionStationsAndSubStations = base.GetQuestionAnswers(questionAnswers);
            this.OrganizationImplmentProcessThatConsidersGenerationResources = base.GetQuestionAnswers(questionAnswers);
            this.ProcessThatConsidersGenerationResources = base.GetQuestionAnswers(questionAnswers);
            this.ProcessThatConsidersSpecialProtectionSystems = base.GetQuestionAnswers(questionAnswers);
            this.ProcessThatConsidersDistributionProvidersAndProtectedSystems = base.GetQuestionAnswers(questionAnswers);
            this.IdentifiedHIGHImactBESCyberSystems = base.GetQuestionAnswers(questionAnswers);
            this.IdentifiedMEDIUMImactBESCyberSystems = base.GetQuestionAnswers(questionAnswers);
            this.IdentifiedLOWImactBESCyberSystems = base.GetQuestionAnswers(questionAnswers);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override List<QuestionAnswers> SetAnswerList()
        {
            // allocate list
            List<QuestionAnswers> answers = base.SetAnswerList();

            // add property values
            answers.Add(this.ConfiurationChangeManagementPlan);
            answers.Add(this.DevelopBaselineConfiguation);
            answers.Add(this.ChangeThatDeviatesFromExistingBaselineConfiguration);
            answers.Add(this.ForEachChangeThatDeviatesFromExistingBaselineConfiguration);

            answers.Add(this.ConfigurationManagementOfInventoryOfAndIdentityOfBESCyberSystems);
            answers.Add(this.IdentifyImpactOfBESCyberSystemsAccordingToAttachement1);
            answers.Add(this.ProcessThatConsidersControlCentersAndBackupControlCenters);
            answers.Add(this.OrganizationImplmentProcessTransmissionStationsAndSubStations);
            answers.Add(this.OrganizationImplmentProcessThatConsidersGenerationResources);
            answers.Add(this.ProcessThatConsidersGenerationResources);
            answers.Add(this.ProcessThatConsidersSpecialProtectionSystems);
            answers.Add(this.ProcessThatConsidersDistributionProvidersAndProtectedSystems);
            answers.Add(this.IdentifiedHIGHImactBESCyberSystems);
            answers.Add(this.IdentifiedMEDIUMImactBESCyberSystems);
            answers.Add(this.IdentifiedLOWImactBESCyberSystems);

            // return list to base class caller
            return answers;
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
