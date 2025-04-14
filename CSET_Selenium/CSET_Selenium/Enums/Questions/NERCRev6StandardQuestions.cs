using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.Questions
{
    /// <summary>
    /// 
    /// </summary>
    public enum NERCRev6StandardQuestions
    {
        [NERCRev6StandardQuestionsAttr("Do you have a process to address access based on need that is determined by the responsible entity for the following types of access")] 
        Do_you_have_a_process_to_address_access_based_on_need_that_is_determined_by_the_responsible_entity_for_the_following_types_of_access,

        [NERCRev6StandardQuestionsAttr("Does the organization have a configuration change management plan?")]
        Does_the_organization_have_a_configuration_change_management_plan,

        [NERCRev6StandardQuestionsAttr("Do you develop a baseline configuration, individually or by group, which include the following?")]
        Do_you_develop_a_baseline_configuration_individually_or_by_group_which_include_the_following,

        [NERCRev6StandardQuestionsAttr("For a change that deviates from the existing baseline do you implement the following")]
        For_a_change_that_deviates_from_the_existing_baseline_do_you_implement_the_following,

        [NERCRev6StandardQuestionsAttr("For each change that deviates from the existing baseline configuration do you perform the following")]
        For_each_change_that_deviates_from_the_existing_baseline_configuration_do_you_perform_the_following,

        [NERCRev6StandardQuestionsAttr("Does the organization maintain a configuration management inventory of and identify impact for BES Cyber systems")]
        Does_the_organization_maintain_a_configuration_management_inventory_of_and_identify_impact_for_BES_Cyber_systems,

        [NERCRev6StandardQuestionsAttr("Do you identify the impact of BES Cyber Systems according to Attachment 1, Section 1 for the following assets, specified in Applicability section 4.2.1")]
        Do_you_identify_the_impact_of_BES_Cyber_Systems_according_to_Attachment_1_Section_1_for_the_following_assets_specified_in_Applicability_section_4_2_1,

        [NERCRev6StandardQuestionsAttr("Does the organization implement a process that considers control centers and backup control centers")]
        Does_the_organization_implement_a_process_that_considers_control_centers_and_backup_control_centers,

        [NERCRev6StandardQuestionsAttr("Does the organization implement a process that considers transmission stations and substations")]
        Does_the_organization_implement_a_process_that_considers_transmission_stations_and_substations,

        [NERCRev6StandardQuestionsAttr("Does the organization implement a process that considers generation resources?")]
        Does_the_organization_implement_a_process_that_considers_generation_resources,

        [NERCRev6StandardQuestionsAttr("Does the organization implement a process that considers systems and facilities critical to system restoration, including blackstart resources and cranking paths and initial switching requirements?")]
        Does_the_organization_implement_a_process_that_considers_systems_and_facilities_critical_to_system_restoration_including_blackstart_resources_and_cranking_paths_and_initial_switching_requirements,

        [NERCRev6StandardQuestionsAttr("Does the organization implement a process that considers Special Protection Systems that support the reliable operation of the Bulk Electric System?")]
        Does_the_organization_implement_a_process_that_considers_Special_Protection_Systems_that_support_the_reliable_operation_of_the_Bulk_Electric_System,

        [NERCRev6StandardQuestionsAttr("Does the organization implement a process that consider distribution providers and protection systems?")]
        Does_the_organization_implement_a_process_that_consider_distribution_providers_and_protection_systems,

        [NERCRev6StandardQuestionsAttr("For questions 1-7 in this group have you identified the HIGH impact BES Cyber Systems according to attachment 1, section 1, if any, at each asset?")]
        For_questions_1_7_in_this_group_have_you_identified_the_HIGH_impact_BES_Cyber_Systems_according_to_attachment_1_section_1_if_any_at_each_asset,

        [NERCRev6StandardQuestionsAttr("For questions 1-7 in this group have you identified the MEDIUM impact BES Cyber Systems according to attachment 1, section 1, if any, at each asset?")]
        For_questions_1_7_in_this_group_have_you_identified_the_MEDIUM_impact_BES_Cyber_Systems_according_to_attachment_1_section_1_if_any_at_each_asset,

        [NERCRev6StandardQuestionsAttr("For questions 1-7 in this group have you identified the LOW impact BES Cyber Systems according to attachment 1, section 1, if any, at each asset?")]
        For_questions_1_7_in_this_group_have_you_identified_the_LOW_impact_BES_Cyber_Systems_according_to_attachment_1_section_1_if_any_at_each_asset,

        [NERCRev6StandardQuestionsAttr("Does the organization conduct incident response plan reviews")]
        Does_the_organization_conduct_incident_response_plan_reviews,

        [NERCRev6StandardQuestionsAttr("No later than 90 calendar days after completion of a Cyber Security Incident response plan(s) test or actual Reportable Cyber Security Incident response")]
        No_later_than_90_calendar_days_after_completion_of_a_Cyber_Security_Incident_response_plans_test_or_actual_Reportable_Cyber_Security_Incident_response,

        [NERCRev6StandardQuestionsAttr("No later than 60 calendar days after a change to the roles or responsibilities, Cyber Security Incident response groups or individuals, or technology that the Responsible Entity determines would impact the ability to execute the plan")]
        No_later_than_60_calendar_days_after_a_change_to_the_roles_or_responsibilities_Cyber_Security_Incident_response_groups_or_individuals_or_technology_that_the_Responsible_Entity_determines_would_impact_the_ability_to_execute_the_plan,

        [NERCRev6StandardQuestionsAttr("For primary control center(s) do you consider the following")]
        For_primary_control_centers_do_you_consider_the_following,

        [NERCRev6StandardQuestionsAttr("Does the organization have a physical security plan")]
        Does_the_organization_have_a_physical_security_plan,

        [NERCRev6StandardQuestionsAttr("Do you develop a physical security plan(s) within 120 days following the completion of Requirement R2 and execute according to the timeline specified in the plan")]
        Do_you_develop_a_physical_security_plans_within_120_days_following_the_completion_of_Requirement_R2_and_execute_according_to_the_timeline_specified_in_the_plan,

        [NERCRev6StandardQuestionsAttr("Does your physical security plan(s) include the following")]
        Does_your_physical_security_plans_include_the_following,

        [NERCRev6StandardQuestionsAttr("Does the organization's physical security plan(s) include resiliency or security measures designed collectively to deter, detect, delay, assess, communicate, and respond to potential physical threats and vulnerabilities identified during the evaluation conducted in Requirement R4")]
        Does_the_organizations_physical_security_plans_include_resiliency_or_security_measures_designed_collectively_to_deter_detect_delay_assess_communicate_and_respond_to_potential_physical_threats_and_vulnerabilities_identified_during_the_evaluation_conducted_in_Requirement_R4,

        [NERCRev6StandardQuestionsAttr("Does the organization's physical security plan(s) include law enforcement contact and coordination information")]
        Does_the_organizations_physical_security_plans_include_law_enforcement_contact_and_coordination_information,

        [NERCRev6StandardQuestionsAttr("Does the organization's physical security plan(s) include a timeline for executing the physical security enhancements and modifications specified in the physical security plan")]
        Does_the_organizations_physical_security_plans_include_a_timeline_for_executing_the_physical_security_enhancements_and_modifications_specified_in_the_physical_security_plan,

        [NERCRev6StandardQuestionsAttr("Does the organization's physical security plan(s) include provisions to evaluate evolving physical threats, and their corresponding security measures, to the Transmission station(s), Transmission substation(s), or primary control center(s)")]
        Does_the_organizations_physical_security_plans_include_provisions_to_evaluate_evolving_physical_threats_and_their_corresponding_security_measures_to_the_Transmission_stations_Transmission_substation_or_primary_control_centers,

        [NERCRev6StandardQuestionsAttr("Do you implement one or more documented security plan(s) including the sections in Attachment 1")]
        Do_you_implement_one_or_more_documented_security_plans_including_the_sections_in_Attachment,

        [NERCRev6StandardQuestionsAttr("Do you review and obtain CIP Senior Manager approval, in the last 15 calendar months, for cyber security policies that address the following topics (for low impact BES Cyber Systems)")]
        Do_you_review_and_obtain_CIP_Senior_Manager_approval_in_the_last_15_calendar_months_for_cyber_security_policies_that_address_the_following_topics_for_low_impact_BES_Cyber_Systems,

        [NERCRev6StandardQuestionsAttr("Do you perform the following no later than 90 days after the completion of a recovery plan test or actual recovery")]
        Do_you_perform_the_following_no_later_than_90_days_after_the_completion_of_a_recovery_plan_test_or_actual_recovery,

        [NERCRev6StandardQuestionsAttr("If there is a change to roles or responsibilities, responders, or technology do you complete the following in no later than 60 days")]
        If_there_is_a_change_to_roles_or_responsibilities_responders_or_technology_do_you_complete_the_following_in_no_later_than_60_days,

        [NERCRev6StandardQuestionsAttr("Does the organization perform risk assessments")]
        Does_the_organization_perform_risk_assessments,

        [NERCRev6StandardQuestionsAttr("Have you performed an initial risk assessment and subsequent risk assessments of transmission stations and substations (existing and planned to be in service in 24 months) that meet criteria described in Applicability Section 4.1.1")]
        Have_you_performed_an_initial_risk_assessment_and_subsequent_risk_assessments_of_transmission_stations_and_substations_existing_and_planned_to_be_in_service_in_24_months_that_meet_criteria_described_in_Applicability_Section_4_1_1,

        [NERCRev6StandardQuestionsAttr("Do you perform subsequent risk assessments:At least every 30 months if a Transmission Owner has identified the transmission stations and substations if rendered inoperable or damaged could result in instability, uncontrolled separation, or Cascading within an Interconnection?At least every 60 months if the stations have not been identified that if rendered inoperable or damaged could result in instability, uncontrolled separation, or Cascading within an Interconnection")]
        Do_you_perform_subsequent_risk_assessments_At_least_every_30_months_if_a_Transmission_Owner_has_identified_the_transmission_stations_and_substations_if_rendered_inoperable_or_damaged_could_result_in_instability_uncontrolled_separation_or_Cascading_within_an_Interconnection_At_least_every_60_months_if_the_stations_have_not_been_identified_that_if_rendered_inoperable_or_damaged_could_result_in_instability_uncontrolled_separation_or_Cascading_within_an_Interconnection,

        [NERCRev6StandardQuestionsAttr("Have you identified the primary control center that controls each transmission station or substation")]
        Have_you_identified_the_primary_control_center_that_controls_each_transmission_station_or_substation,

        [NERCRev6StandardQuestionsAttr("Does your organization implement any security event logging")]
        Does_your_organization_implement_any_security_event_logging,

        [NERCRev6StandardQuestionsAttr("Do you log events at the BES Cyber Systems level (per BES Cyber System capability) or at the Cyber Asset level (per Cyber Asset capability) for identification of, and after-the-fact investigations of, Cyber Security incidents that include, at a minimum, each of the following types of events")]
        Do_you_log_events_at_the_BES_Cyber_Systems_level_per_BES_Cyber_System_capability_or_at_the_Cyber_Asset_level_per_Cyber_Asset_capability_for_identification_of_and_after_the_fact_investigations_of_Cyber_Security_incidents_that_include_at_a_minimum_each_of_the_following_types_of_events,

        [NERCRev6StandardQuestionsAttr("Do you generate alerts for security events that the Responsible Entity determines is necessary and that include, at a minimum, each of the following events")]
        Do_you_generate_alerts_for_security_events_that_the_Responsible_Entity_determines_is_necessary_and_that_include_at_a_minimum_each_of_the_following_events,

        [NERCRev6StandardQuestionsAttr("Do you perform the following at least once every 36 months (where technically feasible)?")]
        Do_you_perform_the_following_at_least_once_every_36_months_where_technically_feasible
    }

    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class NERCRev6StandardQuestionsAttr : Attribute
    {
        public string Value = string.Empty;

        public NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions value)
        {
            this.Value = value.GetValue();
        }

        internal NERCRev6StandardQuestionsAttr(String type)
        {
            this.Value = type;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class NERCRev6StandardQuestionsExtensions
    {
        public static String GetValue(this NERCRev6StandardQuestions enumChoice)
        {
            var attr = enumChoice.GetValue();
            return attr;
        }
    }
}