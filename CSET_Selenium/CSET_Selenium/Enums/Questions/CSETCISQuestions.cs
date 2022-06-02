using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums
{
    public enum CSETCISQuestions 
    {
        /* naming convention is: 
         * - any space is replaced with '_'        
         * - all questions have the question number at the end (if the question text would have the question number in front, it is removed and put at the end)
         * - any other special character is removed with no replacement, except 
         * -- any '&', which is replaced with "and"
         * -- the '.' in question numbers, which is replaced with '_'
         */

        //1 Cybersecurity Architecture
        [CSETCISQuestionsAttr("1.1 Is there a manager/department in charge of day-to-day cybersecurity management?")] Is_there_a_managerdepartment_in_charge_of_daytoday_cybersecurity_management_1_1,
        [CSETCISQuestionsAttr("1.2 Are there any other cybersecurity leaders with cyber responsibilities?")] Are_there_any_other_cybersecurity_leaders_with_cyber_responsibilities_1_2,
        [CSETCISQuestionsAttr("If yes, where do they specialize?")] If_yes_where_do_they_specialize_1_2_1,
        [CSETCISQuestionsAttr("1.3 Is there a third-party contract arrangement for primary cyber management and/or operational functions for this Critical Services?")] Is_there_a_thirdparty_contract_arrangement_for_primary_cyber_management_andor_operational_functions_for_this_Critical_Services_1_3,
        [CSETCISQuestionsAttr("If yes, what do they manage?")] If_yes_what_do_they_manage_1_3_1,
        [CSETCISQuestionsAttr("1.4 Are cybersecurity contractors or vendors used for day-to-day work?")] Are_cybersecurity_contractors_or_vendors_used_for_daytoday_work_1_4,
        //2 Inventory
        [CSETCISQuestionsAttr("2.1 Is there an inventory of all critical cyber assets for this Critical Services?")] Is_there_an_inventory_of_all_critical_cyber_assets_for_this_Critical_Services_2_1,
        [CSETCISQuestionsAttr("Does the inventory include: (Check all that apply.)")] Does_the_inventory_include_Check_all_that_apply_2_1_1,
        [CSETCISQuestionsAttr("On what basis does the organization review, for the purpose of updating its inventory?")] On_what_basis_does_the_organization_review_for_the_purpose_of_updating_its_inventory_2_1_2,
        //3 System Architecture
        [CSETCISQuestionsAttr("3.1 Is the system architecture documented or is configuration monitoring used?")] Is_the_system_architecture_documented_or_is_configuration_monitoring_used_3_1,
        [CSETCISQuestionsAttr("Does the document include any of the following? (Check all that apply.)")] Does_the_document_include_any_of_the_following_Check_all_that_apply_3_1_1,
        [CSETCISQuestionsAttr("How frequently does the organization review/update this architecture?")] How_frequently_does_the_organization_reviewupdate_this_architecture_3_1_2,
        [CSETCISQuestionsAttr("Does the organization use system configuration management tools that will automatically enforce and redeploy configuration settings to services at scheduled intervals?")] Does_the_organization_use_system_configuration_management_tools_that_will_automatically_enforce_and_redeploy_configuration_settings_to_services_at_scheduled_intervals_3_1_3,
        [CSETCISQuestionsAttr("Does the organization use system configuration monitoring tools that measure secure configuration elements and vulnerability information?")] Does_the_organization_use_system_configuration_monitoring_tools_that_measure_secure_configuration_elements_and_vulnerability_information_3_1_4,
        //4 Security Architecture
        [CSETCISQuestionsAttr("4.1 Is there a documented security architecture that includes each of the identified Critical Services assets?")] Is_there_a_documented_security_architecture_that_includes_each_of_the_identified_Critical_Services_assets_4_1,
        [CSETCISQuestionsAttr("What protocol represents what the organization employs to manage the security architecture with respect to asset changes?")] What_protocol_represents_what_the_organization_employs_to_manage_the_security_architecture_with_respect_to_asset_changes_4_1_1,
        [CSETCISQuestionsAttr("Does the document include any of the following? (Check all that apply.)")] Does_the_document_include_any_of_the_following_Check_all_that_apply_4_1_2,
        [CSETCISQuestionsAttr("How frequently does the organization re-evaluate its security architecture for coverage or inclusion of Critical Services assets?")] How_frequently_does_the_organization_reevaluate_its_security_architecture_for_coverage_or_inclusion_of_Critical_Services_assets_4_1_3,
        //5 Change Management
        [CSETCISQuestionsAttr("5.1 Which option best describes the organization's approach to cyber change management (e.g., new hardware/software, employee access)? (Check one.)")] Which_option_best_describes_the_organizations_approach_to_cyber_change_management_eg_new_hardwaresoftware_employee_access_Check_one_5_1,
        [CSETCISQuestionsAttr("5.2 Does the organization use any distribution restrictions to validate software requests against an approved software list to allow installation on the Critical Services?")] Does_the_organization_use_any_distribution_restrictions_to_validate_software_requests_against_an_approved_software_list_to_allow_installation_on_the_Critical_Services_5_2,
        [CSETCISQuestionsAttr("5.3 Does the organization have a standard to establish and maintain a system configuration to include secure, build, image, or configure for the Critical Services?")] Does_the_organization_have_a_standard_to_establish_and_maintain_a_system_configuration_to_include_secure_build_image_or_configure_for_the_Critical_Services_5_3,
        [CSETCISQuestionsAttr("5.4 What measures does the organization employ to manage the configuration of this Critical Services? (Check all that apply.)")] What_measures_does_the_organization_employ_to_manage_the_configuration_of_this_Critical_Services_Check_all_that_apply_5_4,
        //6 Lifecycle Tracking
        [CSETCISQuestionsAttr("6.1 Does the organization address the security of Critical Services assets anywhere throughout their life cycle (inception through disposal)?")] Does_the_organization_address_the_security_of_Critical_Services_assets_anywhere_throughout_their_life_cycle_inception_through_disposal_6_1,
        [CSETCISQuestionsAttr("Which approach best describes the integration of cybersecurity policy into the organization's Critical Services asset life cycle?")] Which_approach_best_describes_the_integration_of_cybersecurity_policy_into_the_organizations_Critical_Services_asset_life_cycle_6_1_1,
        [CSETCISQuestionsAttr("6.2 Which documents does the organization retain that can demonstrate integration of cybersecurity into the Critical Services asset life cycle (Check all that apply)")] Which_documents_does_the_organization_retain_that_can_demonstrate_integration_of_cybersecurity_into_the_Critical_Services_asset_life_cycle_Check_all_that_apply_6_2,
        [CSETCISQuestionsAttr("6.3 Does the organization employ procurement and contracting measures to specify and enforce security requirements for third-party service providers and vendors? (if applicable)")] Does_the_organization_employ_procurement_and_contracting_measures_to_specify_and_enforce_security_requirements_for_thirdparty_service_providers_and_vendors_if_applicable_6_3,
        [CSETCISQuestionsAttr("Which approach best describes the procurement and contracting measures?")] Which_approach_best_describes_the_procurement_and_contracting_measures_6_3_1,
        [CSETCISQuestionsAttr("6.4 Does the organization employ any of the following security controls specific to the Critical Services to prevent exploitation of vulnerabilities?")] Does_the_organization_employ_any_of_the_following_security_controls_specific_to_the_Critical_Services_to_prevent_exploitation_of_vulnerabilities_6_4,
        [CSETCISQuestionsAttr("6.5 Approximately, what percentage of Critical Services systems are not or cannot be updated with respect to critical vulnerabilities? (e.g., legacy system or business reason- i.e., break software application)")] Approximately_what_percentage_of_Critical_Services_systems_are_not_or_cannot_be_updated_with_respect_to_critical_vulnerabilities_eg_legacy_system_or_business_reason_ie_break_software_application_6_5,
        [CSETCISQuestionsAttr("6.6 If the organization has Critical Services systems that are not or cannot be updated with respect to critical vulnerabilities, approximately what percentage of these systems have compensating security controls in place?")] If_the_organization_has_Critical_Services_systems_that_are_not_or_cannot_be_updated_with_respect_to_critical_vulnerabilities_approximately_what_percentage_of_these_systems_have_compensating_security_controls_in_place_6_6,
        //7 Assesment and Evaluations
        [CSETCISQuestionsAttr("7.1 Does your organization follow a cybersecurity standard(s) of practice?")] Does_your_organization_follow_a_cybersecurity_standards_of_practice_7_1,
        [CSETCISQuestionsAttr("Which standard(s) of practice do you follow? (Check all that apply.)")] Which_standards_of_practice_do_you_follow_Check_all_that_apply_7_1_1,
        [CSETCISQuestionsAttr("The standard of practice is required for/by: (Check all that apply.)")] The_standard_of_practice_is_required_forby_Check_all_that_apply_7_1_2,
        [CSETCISQuestionsAttr("Is an audit required against the standards?")] Is_an_audit_required_against_the_standards_7_1_3,
        [CSETCISQuestionsAttr("7.2 Does the organization conduct cybersecurity assessments/evaluations to identify potential security gaps or weaknesses to any Critical Services assets?")] Does_the_organization_conduct_cybersecurity_assessmentsevaluations_to_identify_potential_security_gaps_or_weaknesses_to_any_Critical_Services_assets_7_2,
        [CSETCISQuestionsAttr("Is this done to meet the standard of practice required above?")] Is_this_done_to_meet_the_standard_of_practice_required_above_7_2_1,
        [CSETCISQuestionsAttr("How often does the organization conduct these assessments?")] How_often_does_the_organization_conduct_these_assessments_7_2_2,
        [CSETCISQuestionsAttr("Who performs the assessment? (Check all that apply.)")] Who_performs_the_assessment_Check_all_that_apply_7_2_3,
        [CSETCISQuestionsAttr("Are cybersecurity assessment results reported to a broader segment of senior management other than manager(s) of cybersecurity?")] Are_cybersecurity_assessment_results_reported_to_a_broader_segment_of_senior_management_other_than_managers_of_cybersecurity_7_2_4,
        [CSETCISQuestionsAttr("Describe how:")] Describe_how_7_2_5,
        [CSETCISQuestionsAttr("In what ways are the Critical Services assets assessed? (Check all that apply.)")] In_what_ways_are_the_Critical_Services_assets_assessed_Check_all_that_apply_7_2_6,
        //8 Cybersecurity Plan
        [CSETCISQuestionsAttr("8.1 Does the organization have a defined, documented cybersecurity policy?")] Does_the_organization_have_a_defined_documented_cybersecurity_policy_8_1,
        [CSETCISQuestionsAttr("Does this policy require a cybersecurity plan?")] Does_this_policy_require_a_cybersecurity_plan_8_1_1,
        [CSETCISQuestionsAttr("8.2 Is there a Cybersecurity Plan covering this Critical Services?")] Is_there_a_Cybersecurity_Plan_covering_this_Critical_Services_8_2,
        [CSETCISQuestionsAttr("The plan is developed for: (Check all that apply.)")] The_plan_is_developed_for_Check_all_that_apply_8_2_1,
        [CSETCISQuestionsAttr("Do key cyber personnel participate in the review and update process of the plan?")] Do_key_cyber_personnel_participate_in_the_review_and_update_process_of_the_plan_8_2_2,
        [CSETCISQuestionsAttr("Has the plan been approved by a broader segment of senior management?")] Has_the_plan_been_approved_by_a_broader_segment_of_senior_management_8_2_3,
        [CSETCISQuestionsAttr("For the Critical Services, the following item/topics have been accounted for in the Cybersecurity Plan: (Check all that apply.)")] For_the_Critical_Services_the_following_itemtopics_have_been_accounted_for_in_the_Cybersecurity_Plan_Check_all_that_apply_8_2_4,
        [CSETCISQuestionsAttr("On what basis are these plans reviewed and revised? (Check all that apply.)")] On_what_basis_are_these_plans_reviewed_and_revised_Check_all_that_apply_8_2_5,
        //9 Cybersecurity Exercises
        [CSETCISQuestionsAttr("9.1 Does the organization conduct cybersecurity exercises?")] Does_the_organization_conduct_cybersecurity_exercises_9_1,
        [CSETCISQuestionsAttr("For what purpose(s)? (Check all that apply.)")] For_what_purposes_Check_all_that_apply_9_1_1,
        [CSETCISQuestionsAttr("These exercises are:")] These_exercises_are_9_1_2,
        [CSETCISQuestionsAttr("Are exercise results documented, approved and reported to a broader segment of senior management than cybersecurity management?")] Are_exercise_results_documented_approved_and_reported_to_a_broader_segment_of_senior_management_than_cybersecurity_management_9_1_3,
        [CSETCISQuestionsAttr("Who participates in these cybersecurity exercises?")] Who_participates_in_these_cybersecurity_exercises_9_1_3_1,
        [CSETCISQuestionsAttr("Does senior management participate in these cybersecurity exercises?")] Does_senior_management_participate_in_these_cybersecurity_exercises_9_1_3_2,
        [CSETCISQuestionsAttr("How often are exercises conducted?")] How_often_are_exercises_conducted_9_1_4,
        //10 External Information Sharing
        [CSETCISQuestionsAttr("10.1 Does the organization, specific to the Critical Services, share cybersecurity information with outside organizations?")] Does_the_organization_specific_to_the_Critical_Services_share_cybersecurity_information_with_outside_organizations_10_1,
        [CSETCISQuestionsAttr("What information is shared?")] What_information_is_shared_10_1_1,
        [CSETCISQuestionsAttr("10.2 For the purpose of securing the Critical Services, does the organization receive vulnerability information, cybersecurity-related bulletins, advisories, and/or alerts from an external source?")] For_the_purpose_of_securing_the_Critical_Services_does_the_organization_receive_vulnerability_information_cybersecurityrelated_bulletins_advisories_andor_alerts_from_an_external_source_10_2,
        [CSETCISQuestionsAttr("From whom?")] From_whom_10_2_1,
        [CSETCISQuestionsAttr("Is it sector-based (e.g., Industry ISACs)?")] Is_it_sectorbased_eg_Industry_ISACs_10_2_2,
        [CSETCISQuestionsAttr("How often do you receive and process this information (e.g., bulletins, advisories, technical indicators)?")] How_often_do_you_receive_and_process_this_information_eg_bulletins_advisories_technical_indicators_10_2_3,
        [CSETCISQuestionsAttr("For the purpose of the Critical Services, does the organization provide formal feedback or validation to the originating organization?")] For_the_purpose_of_the_Critical_Services_does_the_organization_provide_formal_feedback_or_validation_to_the_originating_organization_10_2_4,
        [CSETCISQuestionsAttr("10.3 For the purpose of securing the Critical Services, does the organization receive threat information, cybersecurity-related bulletins, advisories, and/or alerts from an external source?")] For_the_purpose_of_securing_the_Critical_Services_does_the_organization_receive_threat_information_cybersecurityrelated_bulletins_advisories_andor_alerts_from_an_external_source_10_3,
        [CSETCISQuestionsAttr("From whom?")] From_whom_10_3_1,
        [CSETCISQuestionsAttr("Which one(s)?")] Which_ones_10_3_2,
        [CSETCISQuestionsAttr("Is it sector based (e.g. Industry ISACs)?")] Is_it_sector_based_eg_Industry_ISACs_10_3_3,
        [CSETCISQuestionsAttr("Which one(s)?")] Which_ones_10_3_4,
        [CSETCISQuestionsAttr("How often does the organization receive and process this information?")] How_often_does_the_organization_receive_and_process_this_information_10_3_5,
        [CSETCISQuestionsAttr("Does the organization provide any feedback or validation to the originating organization?")] Does_the_organization_provide_any_feedback_or_validation_to_the_originating_organization_10_3_6,
        [CSETCISQuestionsAttr("10.4 Does the organization report cybersecurity incidents to outside organizations, specific to the Critical Services?")] Does_the_organization_report_cybersecurity_incidents_to_outside_organizations_specific_to_the_Critical_Services_10_4,
        [CSETCISQuestionsAttr("For what purpose(s) do you make such reports? (Check all that apply.)")] For_what_purposes_do_you_make_such_reports_Check_all_that_apply_10_4_1,
        [CSETCISQuestionsAttr("10.5 Does anyone from the organization actively participate in local or regional cybersecurity forums (e.g., exchange of lessons learned, best practices, training)?")] Does_anyone_from_the_organization_actively_participate_in_local_or_regional_cybersecurity_forums_eg_exchange_of_lessons_learned_best_practices_training_10_5,
        [CSETCISQuestionsAttr("Please list and describe:")] Please_list_and_describe_10_5_1,
        //11 Internal Information Sharing
        [CSETCISQuestionsAttr("11.1 For the purpose of the Critical Services, does the organization notify or communicate cybersecurity information to personnel?")] For_the_purpose_of_the_Critical_Services_does_the_organization_notify_or_communicate_cybersecurity_information_to_personnel_11_1,
        [CSETCISQuestionsAttr("What type of personnel?")] What_type_of_personnel_11_1_1,
        [CSETCISQuestionsAttr("What type of information? (Check all that apply.)")] What_type_of_information_Check_all_that_apply_11_1_2,
        [CSETCISQuestionsAttr("What methods are used to communicate? (Check all that apply.)")] What_methods_are_used_to_communicate_Check_all_that_apply_11_1_3,
        [CSETCISQuestionsAttr("For what purpose? (Check all that apply.)")] For_what_purpose_Check_all_that_apply_11_1_4,
        //12 Personnel
        [CSETCISQuestionsAttr("12.1 Are the following positions formalized? (Check all that apply.)")] Are_the_following_positions_formalized_Check_all_that_apply_12_1,
        [CSETCISQuestionsAttr("Within your organization,")] Within_your_organization_12_1_1,
        [CSETCISQuestionsAttr("Within the Critical Services environment,")] Within_the_Critical_Services_environment_12_1_2,
        [CSETCISQuestionsAttr("12.2 Do you have a policy that authorizes and holds accountable the personnel having these assignments?")] Do_you_have_a_policy_that_authorizes_and_holds_accountable_the_personnel_having_these_assignments_12_2,
        [CSETCISQuestionsAttr("12.3 Are background checks conducted for organizational and supporting personnel?")] Are_background_checks_conducted_for_organizational_and_supporting_personnel_12_3,
        [CSETCISQuestionsAttr("On whom are background checks conducted:")] On_whom_are_background_checks_conducted_12_3_1,
        [CSETCISQuestionsAttr("Organizational cybersecurity personnel?")] Organizational_cybersecurity_personnel_12_3_2,
        [CSETCISQuestionsAttr("Are recurring periodic background checks conducted?")] Are_recurring_periodic_background_checks_conducted_12_3_2_1,
        [CSETCISQuestionsAttr("Contract cybersecurity personnel?")] Contract_cybersecurity_personnel_12_3_3,
        [CSETCISQuestionsAttr("Are recurring periodic background checks conducted?")] Are_recurring_periodic_background_checks_conducted_12_3_3_1,
        [CSETCISQuestionsAttr("Cybersecurity Vendors?")] Cybersecurity_Vendors_12_3_4,
        [CSETCISQuestionsAttr("Are recurring periodic background checks conducted?")] Are_recurring_periodic_background_checks_conducted_12_3_4_1,
        //13 Cybersecurity Training
        [CSETCISQuestionsAttr("13.1 Do cybersecurity personnel involved in day-to-day Critical Services operations receive cybersecurity training?")] Do_cybersecurity_personnel_involved_in_daytoday_Critical_Services_operations_receive_cybersecurity_training_13_1,
        [CSETCISQuestionsAttr("The basis of the training programs are: (Check all that apply.)")] The_basis_of_the_training_programs_are_Check_all_that_apply_13_1_1,
        [CSETCISQuestionsAttr("How is training delivered?")] How_is_training_delivered_13_1_2,
        [CSETCISQuestionsAttr("Frequency of continuation/refresher training:")] Frequency_of_continuationrefresher_training_13_1_3,
        [CSETCISQuestionsAttr("Are personnel trained in the following areas? (Check all that apply.)")] Are_personnel_trained_in_the_following_areas_Check_all_that_apply_13_1_4,
        [CSETCISQuestionsAttr("13.2 Are cyber personnel trained on the cybersecurity plan?")] a,
        [CSETCISQuestionsAttr("13.3 Has the organization established and documented a minimum level of training, education and/or experience required for cybersecurity personnel related to the Critical Services?")] Has_the_organization_established_and_documented_a_minimum_level_of_training_education_andor_experience_required_for_cybersecurity_personnel_related_to_the_Critical_Services_13_3,
        [CSETCISQuestionsAttr("How are the training, education, and experience recorded (evidenced)? (Check all that apply.)")] How_are_the_training_education_and_experience_recorded_evidenced_Check_all_that_apply_13_3_1,
        [CSETCISQuestionsAttr("13.4 Does the organization manage skills management as part of the performance monitoring process related to the Critical Services?")] Does_the_organization_manage_skills_management_as_part_of_the_performance_monitoring_process_related_to_the_Critical_Services_13_4,
        //14 Authentication and Authorization Controls
        [CSETCISQuestionsAttr("14.1 Has the organization established a process for authentication and authorization (i.e., identity proofing, registration, role-management) to limit access to the Critical Services to only authorized persons?")] Has_the_organization_established_a_process_for_authentication_and_authorization_ie_identity_proofing_registration_rolemanagement_to_limit_access_to_the_Critical_Services_to_only_authorized_persons_14_1,
        [CSETCISQuestionsAttr("What is the basis for establishing authentication and authorization? (Check all that apply.)")] What_is_the_basis_for_establishing_authentication_and_authorization_Check_all_that_apply_14_1_1,
        [CSETCISQuestionsAttr("For whom has the organization implemented these specific authentication and authorization processes? (Check all that apply.)")] For_whom_has_the_organization_implemented_these_specific_authentication_and_authorization_processes_Check_all_that_apply_14_1_2,

        [CSETCISQuestionsAttr("14.2 Which of the following measures does the organization employ to control authorization? (Check all that apply.)")] Which_of_the_following_measures_does_the_organization_employ_to_control_authorization_Check_all_that_apply_14_2,
        [CSETCISQuestionsAttr("14.3 Which of the following measures does the organization employ to control administrator privileges (to include contractors performing administrative functions)? (Check all that apply.)")] Which_of_the_following_measures_does_the_organization_employ_to_control_administrator_privileges_to_include_contractors_performing_administrative_functions_Check_all_that_apply_14_3,
        [CSETCISQuestionsAttr("14.4 Does the organization practice the concept of least privileges (i.e., users are only granted access to the information, files, and applications required to fulfill their roles and responsibilities) within the Critical Services for all accounts?")] Does_the_organization_practice_the_concept_of_least_privileges_ie_users_are_only_granted_access_to_the_information_files_and_applications_required_to_fulfill_their_roles_and_responsibilities_within_the_Critical_Services_for_all_accounts_14_4,
        [CSETCISQuestionsAttr("14.5 Is username/password the primary means of user authentication to the Critical Services?")] Is_usernamepassword_the_primary_means_of_user_authentication_to_the_Critical_Services_14_5,
        [CSETCISQuestionsAttr("Which of the following password management policies are implemented for the Critical Services? (Check all that apply.)")] Which_of_the_following_password_management_policies_are_implemented_for_the_Critical_Services_Check_all_that_apply_14_5_1,
        [CSETCISQuestionsAttr("14.6 What additional properties of authentication are employed for the Critical Services?")] What_additional_properties_of_authentication_are_employed_for_the_Critical_Services_14_6,
        [CSETCISQuestionsAttr("14.7 If the primary means of authentication failed, has the organization determined that compensating controls would provide sufficient authentication?")] If_the_primary_means_of_authentication_failed_has_the_organization_determined_that_compensating_controls_would_provide_sufficient_authentication_14_7,
        [CSETCISQuestionsAttr("14.8 Does the organization have a protocol for removing, suspending or modifying user accounts upon change of employment?")] Does_the_organization_have_a_protocol_for_removing_suspending_or_modifying_user_accounts_upon_change_of_employment_14_8,
        [CSETCISQuestionsAttr("Following an adverse human resources action, when is an account modified, deleted, or de-activated?")] Following_an_adverse_human_resources_action_when_is_an_account_modified_deleted_or_deactivated_14_8_1,
        [CSETCISQuestionsAttr("Following a user's exit from the organization when is an account modified, deleted, or de-activated?")] Following_a_users_exit_from_the_organization_when_is_an_account_modified_deleted_or_deactivated_14_8_2,
        [CSETCISQuestionsAttr("Following a user's transfer into a new role, when is the account modified?")] Following_a_users_transfer_into_a_new_role_when_is_the_account_modified_14_8_3,
        [CSETCISQuestionsAttr("Does the organization test the account modification, deletion, and/or de-activation process as part of its security assessments and evaluations?")] Does_the_organization_test_the_account_modification_deletion_andor_deactivation_process_as_part_of_its_security_assessments_and_evaluations_14_8_4,
        [CSETCISQuestionsAttr("14.9 Does the organization have a protocol for monitoring user activity after changes in employment related to termination?")] Does_the_organization_have_a_protocol_for_monitoring_user_activity_after_changes_in_employment_related_to_termination_14_9,
        //15 Access Paths
        [CSETCISQuestionsAttr("15.1 Has the organization established a business requirement for every access path to/from the Critical Services?")] Has_the_organization_established_a_business_requirement_for_every_access_path_tofrom_the_Critical_Services_15_1,
        [CSETCISQuestionsAttr("15.2 Does the organization implement security controls to limit access across the documented boundaries (e.g., firewalls, IDS port security, or rules of behavior)?")] Does_the_organization_implement_security_controls_to_limit_access_across_the_documented_boundaries_eg_firewalls_IDS_port_security_or_rules_of_behavior_15_2,
        [CSETCISQuestionsAttr("Does the Critical Services benefit from access control device(s) that restrict incoming and/or outgoing connections between the Critical Services and the Internet? (Check all that apply.)")] Does_the_Critical_Services_benefit_from_access_control_devices_that_restrict_incoming_andor_outgoing_connections_between_the_Critical_Services_and_the_Internet_Check_all_that_apply_15_2_1,
        [CSETCISQuestionsAttr("15.3 Can a non-critical system act as a conduit (connection) between the Internet and Critical Services?")] Can_a_noncritical_system_act_as_a_conduit_connection_between_the_Internet_and_Critical_Services_15_3,
        // this has CCS in it, it'll need changed after bug CSET-1772 is done [CSETCISQuestionsAttr("Does the CCS benefit from access control device(s) that restrict incoming and/or outgoing connections between the CCS and a non-critical system that is connected to the Internet? (Check all that apply.)")] a,
        [CSETCISQuestionsAttr("15.4 Which of the following security measures does the organization employ for preventing exploitation of access paths? (Check all that apply.)")] Which_of_the_following_security_measures_does_the_organization_employ_for_preventing_exploitation_of_access_paths_Check_all_that_apply_15_4,
        //16 Remote Access Controls
        [CSETCISQuestionsAttr("16.1 Does the organization allow remote access to Critical Services assets?")] Does_the_organization_allow_remote_access_to_Critical_Services_assets_16_1,
        //17 Malicious Code Controls
        [CSETCISQuestionsAttr("17.1 Does the organization employ any of the following security controls to prevent malicious code from exploiting the Critical Services? (Check all that apply.)")] Does_the_organization_employ_any_of_the_following_security_controls_to_prevent_malicious_code_from_exploiting_the_Critical_Services_Check_all_that_apply_17_1,
        [CSETCISQuestionsAttr("")] blank_17_1_1,
        [CSETCISQuestionsAttr("Are these systems kept up to date?")] Are_these_systems_kept_up_to_date_17_1_2,
        [CSETCISQuestionsAttr("")] blank_17_2_1,
        [CSETCISQuestionsAttr("Are these systems kept up to date?")] Are_these_systems_kept_up_to_date_17_2_2,
        //18 Monitoring and Scanning
        [CSETCISQuestionsAttr("18.1 Which of the following cybersecurity measures does the organization employ for monitoring of networks related to the Critical Services? (Check all that apply.)")] Which_of_the_following_cybersecurity_measures_does_the_organization_employ_for_monitoring_of_networks_related_to_the_Critical_Services_Check_all_that_apply_18_1,
        [CSETCISQuestionsAttr("18.2 For what purpose does the organization perform monitoring? (Check all that apply.)")] For_what_purpose_does_the_organization_perform_monitoring_Check_all_that_apply_18_2,
        //19 Security and Event Log
        [CSETCISQuestionsAttr("19.1 Does the organization maintain security and event logs?")] Does_the_organization_maintain_security_and_event_logs_19_1,
        [CSETCISQuestionsAttr("If the organization maintains security and event logs:")] If_the_organization_maintains_security_and_event_logs_19_1_1,
        [CSETCISQuestionsAttr("Are the logs reviewed for anomalies either in an automated or manual fashion?")] Are_the_logs_reviewed_for_anomalies_either_in_an_automated_or_manual_fashion_19_1_2,
        [CSETCISQuestionsAttr("What types of logs are manually reviewed for security anomalies on a defined periodic basis? (Check all that apply.)")] What_types_of_logs_are_manually_reviewed_for_security_anomalies_on_a_defined_periodic_basis_Check_all_that_apply_19_1_2_1,
        [CSETCISQuestionsAttr("What is the defined review frequency?")] What_is_the_defined_review_frequency_19_1_2_1_1, //this repeats 6 more times, to 19_1_2_1_7
        [CSETCISQuestionsAttr("What types of logs are automatically reviewed for security anomalies?")] What_types_of_logs_are_automatically_reviewed_for_security_anomalies_19_1_2_2,
        [CSETCISQuestionsAttr("What is the defined review frequency?")] What_is_the_defined_review_frequency_19_1_2_2_1, //this repeats 6 more times, to 19_1_2_2_7
        [CSETCISQuestionsAttr("Are logs correlated with scans, assessments, audits, and other security controls?")] Are_logs_correlated_with_scans_assessments_audits_and_other_security_controls_19_1_3,
        [CSETCISQuestionsAttr("Describe:")] Describe_19_1_3_1,
        [CSETCISQuestionsAttr("Are formal reports generated from anomalies identified in logs?")] Are_formal_reports_generated_from_anomalies_identified_in_logs_19_1_4,
        [CSETCISQuestionsAttr("Describe:")] Describe_19_1_4_1,
        //20 Information Protection
        [CSETCISQuestionsAttr("20.1 Is operationally sensitive information (e.g., network diagrams, Critical Services inventories) identified and categorized for the Critical Services?")] Is_operationally_sensitive_information_eg_network_diagrams_Critical_Services_inventories_identified_and_categorized_for_the_Critical_Services_20_1,
        [CSETCISQuestionsAttr("How is operationally sensitive information managed? (Check all that apply.)")] How_is_operationally_sensitive_information_managed_Check_all_that_apply_20_1_1,
        [CSETCISQuestionsAttr("If sensitive information is archived and/or backed up, are data restores performed and verified (e.g., are backup data restored and checked to see if they work)?")] If_sensitive_information_is_archived_andor_backed_up_are_data_restores_performed_and_verified_eg_are_backup_data_restored_and_checked_to_see_if_they_work_20_1_1_1,
        [CSETCISQuestionsAttr("If sensitive information is archived and/or backed up offline, how often are backups performed?")] If_sensitive_information_is_archived_andor_backed_up_offline_how_often_are_backups_performed_20_1_1_2,
        [CSETCISQuestionsAttr("Is real-time replication occurring to a different site or storage solution?")] Is_realtime_replication_occurring_to_a_different_site_or_storage_solution_20_1_1_3,
        [CSETCISQuestionsAttr("20.2 Is there a security review before information is released outside of operations (partner sharing, public release, etc.)?")] Is_there_a_security_review_before_information_is_released_outside_of_operations_partner_sharing_public_release_etc_20_2,
        //21 User Training
        [CSETCISQuestionsAttr("21.1 Does the organization provide training on cybersecurity for Critical Services users/operators on a regular basis?")] Does_the_organization_provide_training_on_cybersecurity_for_Critical_Services_usersoperators_on_a_regular_basis_21_1,
        [CSETCISQuestionsAttr("How often?")] How_often_21_1_1,
        [CSETCISQuestionsAttr("When does the organization provide cybersecurity training? (Check one of the top 4, check all bottom 2)")] When_does_the_organization_provide_cybersecurity_training_Check_one_of_the_top_4_check_all_bottom_2_21_1_2,
        [CSETCISQuestionsAttr("Which of the following topics is included in Critical Services user training? (Check all that apply.)")] Which_of_the_following_topics_is_included_in_Critical_Services_user_training_Check_all_that_apply_21_1_3,
        //22 Defense Sophistication and Compensating Controls
        [CSETCISQuestionsAttr("22.1 Does your organization employ additional advanced tactics, strategies and/or specific layered defenses to compensate for a loss of primary controls?")] Does_your_organization_employ_additional_advanced_tactics_strategies_andor_specific_layered_defenses_to_compensate_for_a_loss_of_primary_controls_22_1,
        [CSETCISQuestionsAttr("Describe:")] Describe_22_1_1,
        //23 Incident Response Measures
        [CSETCISQuestionsAttr("23.1 Does the organization have predefined plans for responding to cybersecurity incidents specific to the Critical Services?")] Does_the_organization_have_predefined_plans_for_responding_to_cybersecurity_incidents_specific_to_the_Critical_Services_23_1,
        [CSETCISQuestionsAttr("The organization has a defined incident response plan for handling cyber incidents specific to the Critical Services, which (at a minimum) contains: (Check one.)")] The_organization_has_a_defined_incident_response_plan_for_handling_cyber_incidents_specific_to_the_Critical_Services_which_at_a_minimum_contains_Check_one_23_1_1,
        [CSETCISQuestionsAttr("The organization has defined incident response procedures for handling cyber- incidents for the Critical Services, which (at a minimum) contain: (Check all that apply.)")] The_organization_has_defined_incident_response_procedures_for_handling_cyber_incidents_for_the_Critical_Services_which_at_a_minimum_contain_Check_all_that_apply_23_1_2,
        [CSETCISQuestionsAttr("How often do you test cyber-incident response procedures/capabilities specific to the Critical Services?")] How_often_do_you_test_cyberincident_response_procedurescapabilities_specific_to_the_Critical_Services_23_1_3,
        [CSETCISQuestionsAttr("How do you test cyber-incident response procedures/capabilities specific to the Critical Services?")] How_do_you_test_cyberincident_response_procedurescapabilities_specific_to_the_Critical_Services_23_1_4,
        [CSETCISQuestionsAttr("How often do you review responses to actual cyber incidents to see if they are consistent with the incident response procedures/plan specific to the Critical Services?")] How_often_do_you_review_responses_to_actual_cyber_incidents_to_see_if_they_are_consistent_with_the_incident_response_proceduresplan_specific_to_the_Critical_Services_23_1_5,
        [CSETCISQuestionsAttr("23.2 Is there a written contract with entities other than emergency responders to perform incident response specific to the Critical Services (e.g. other organizations, other companies, contract response companies, industry response networks)?")] Is_there_a_written_contract_with_entities_other_than_emergency_responders_to_perform_incident_response_specific_to_the_Critical_Services_eg_other_organizations_other_companies_contract_response_companies_industry_response_networks_23_2,
        //24 Alternate Site and Disaster Recovery
        [CSETCISQuestionsAttr("24.1 Once the Critical Services is lost (without considering any redundant or alternative mode), what percentage of normal business functions are lost or degraded?")] Once_the_Critical_Services_is_lost_without_considering_any_redundant_or_alternative_mode_what_percentage_of_normal_business_functions_are_lost_or_degraded_24_1,
        [CSETCISQuestionsAttr("24.2 Once the Critical Services is lost (without considering any redundant or alternative mode), within what time period will the business be severely impacted?")] Once_the_Critical_Services_is_lost_without_considering_any_redundant_or_alternative_mode_within_what_time_period_will_the_business_be_severely_impacted_24_2,
        [CSETCISQuestionsAttr("24.3 Should your site become inoperable, do you have access to an alternative location?")] Should_your_site_become_inoperable_do_you_have_access_to_an_alternative_location_24_3,
        [CSETCISQuestionsAttr("How long does it take to fail over to the alternative site?")] How_long_does_it_take_to_fail_over_to_the_alternative_site_24_3_1,
        [CSETCISQuestionsAttr("24.4 Is there a contingency or business continuity agreement for recovery?")] Is_there_a_contingency_or_business_continuity_agreement_for_recovery_24_4,
        [CSETCISQuestionsAttr("How long does it take to recover the system at the primary site?")] How_long_does_it_take_to_recover_the_system_at_the_primary_site_24_4_1,
        [CSETCISQuestionsAttr("24.5 Does the organization employ measures to preserve cybersecurity of the Critical Services after a disruption or organization incident?")] Does_the_organization_employ_measures_to_preserve_cybersecurity_of_the_Critical_Services_after_a_disruption_or_organization_incident_24_5,
        [CSETCISQuestionsAttr("24.6 How often do you test your alternative-site procedures/capabilities?")] How_often_do_you_test_your_alternativesite_procedurescapabilities_24_6,
        [CSETCISQuestionsAttr("24.7 How do you test alternative-site procedures/capabilities?")] How_do_you_test_alternativesite_procedurescapabilities_24_7,
        [CSETCISQuestionsAttr("24.8 Which of the following disaster measures does the organization have? (Check all that apply.)")] Which_of_the_following_disaster_measures_does_the_organization_have_Check_all_that_apply_24_8,
        //25 Dependencies - Data at Rest
        [CSETCISQuestionsAttr("25.1 Is data storage (e.g., servers & HMI) required for the Critical Services?")] Is_data_storage_eg_servers_and_HMI_required_for_the_Critical_Services_25_1, //the word "and" is actually a '&', but is substituted for "and"
        [CSETCISQuestionsAttr("If the storage gear (SAN, NAS, etc.) becomes unavailable, within what time period will the Critical Services be severely impacted (i.e., lost connectivity, misconfiguration, device failure)?")] If_the_storage_gear_SAN_NAS_etc_becomes_unavailable_within_what_time_period_will_the_Critical_Services_be_severely_impacted_ie_lost_connectivity_misconfiguration_device_failure_25_1_1,
        [CSETCISQuestionsAttr("Once the storage gear (SAN, NAS, etc.) has become unavailable (without considering any redundant or alternative mode), what percentage of normal cyber functions are lost or degraded?")] Once_the_storage_gear_SAN_NAS_etc_has_become_unavailable_without_considering_any_redundant_or_alternative_mode_what_percentage_of_normal_cyber_functions_are_lost_or_degraded_25_1_2,
        [CSETCISQuestionsAttr("Does the organization have alternative or backup storage capabilities that can be used in case of loss of the primary storage?")] Does_the_organization_have_alternative_or_backup_storage_capabilities_that_can_be_used_in_case_of_loss_of_the_primary_storage_25_1_3,
        [CSETCISQuestionsAttr("Once the primary storage is restored, how long will it take before full resumption of operations?")] Once_the_primary_storage_is_restored_how_long_will_it_take_before_full_resumption_of_operations_25_1_4,
        //26 Dependencies - Data in Motion
        [CSETCISQuestionsAttr("26.1 Are communications required for the organization's cyber operations?")] Are_communications_required_for_the_organizations_cyber_operations_26_1,
        [CSETCISQuestionsAttr("External")] External_26_1_1,
        [CSETCISQuestionsAttr("Is the dependency provider required to notify the organization of an outage?")] Is_the_dependency_provider_required_to_notify_the_organization_of_an_outage_26_1_1_1,
        [CSETCISQuestionsAttr("Do you monitor this dependency?")] Do_you_monitor_this_dependency_26_1_1_2,
        [CSETCISQuestionsAttr("Who/what is the dependency on?")] Whowhat_is_the_dependency_on_26_1_1_3,
        [CSETCISQuestionsAttr("Once the functionality of the communication services (switches, network, firewalls, etc.) is lost (without considering any redundant or alternative mode), what percentage of normal cyber functions are lost or degraded?")] Once_the_functionality_of_the_communication_services_switches_network_firewalls_etc_is_lost_without_considering_any_redundant_or_alternative_mode_what_percentage_of_normal_cyber_functions_are_lost_or_degraded_26_1_1_4,
        [CSETCISQuestionsAttr("If the communication services functionality (switches, network, firewalls, etc.) is lost completely, within what time period will the Critical Services be severely impacted?")] If_the_communication_services_functionality_switches_network_firewalls_etc_is_lost_completely_within_what_time_period_will_the_Critical_Services_be_severely_impacted_26_1_1_5,
        [CSETCISQuestionsAttr("Is there a contingency/business continuity plan with the provider for restoration?")] Is_there_a_contingencybusiness_continuity_plan_with_the_provider_for_restoration_26_1_1_6,
        [CSETCISQuestionsAttr("Does the organization participate in the provider's priority plan for restoration?")] Does_the_organization_participate_in_the_providers_priority_plan_for_restoration_26_1_1_7,
        [CSETCISQuestionsAttr("If the primary mode of communication service is lost, is there a backup mode of communication?")] If_the_primary_mode_of_communication_service_is_lost_is_there_a_backup_mode_of_communication_26_1_1_8,
        [CSETCISQuestionsAttr("Once the primary mode is restored, how long will it take before full resumption of operations?")] Once_the_primary_mode_is_restored_how_long_will_it_take_before_full_resumption_of_operations_26_1_1_9,
        [CSETCISQuestionsAttr("Internal")] Internal_26_1_2,
        [CSETCISQuestionsAttr("Is the dependency provider required to notify the organization of an outage?")] Is_the_dependency_provider_required_to_notify_the_organization_of_an_outage_26_1_2_1,
        [CSETCISQuestionsAttr("Who/what is the dependency on?")] Whowhat_is_the_dependency_on_26_1_2_2,
        [CSETCISQuestionsAttr("Do you monitor this dependency?")] Do_you_monitor_this_dependency_26_1_2_3,
        [CSETCISQuestionsAttr("If the communication services functionality (switches, network, firewalls, etc.) is lost completely, within what time period will the Critical Services be severely impacted?")] If_the_communication_services_functionality_switches_network_firewalls_etc_is_lost_completely_within_what_time_period_will_the_Critical_Services_be_severely_impacted_26_1_2_4,
        [CSETCISQuestionsAttr("Once the functionality of the communication services (switches, network, firewalls, etc.) is lost (without considering any redundant or alternative mode), what percentage of normal cyber functions are lost or degraded?")] Once_the_functionality_of_the_communication_services_switches_network_firewalls_etc_is_lost_without_considering_any_redundant_or_alternative_mode_what_percentage_of_normal_cyber_functions_are_lost_or_degraded_26_1_2_5,
        [CSETCISQuestionsAttr("Is there a contingency/business continuity plan with the provider for restoration?")] Is_there_a_contingencybusiness_continuity_plan_with_the_provider_for_restoration_26_1_2_6,
        [CSETCISQuestionsAttr("Does the organization participate in the provider's priority plan for restoration?")] Does_the_organization_participate_in_the_providers_priority_plan_for_restoration_26_1_2_7,
        [CSETCISQuestionsAttr("If the primary mode of communication service is lost, is there a backup mode of communication?")] If_the_primary_mode_of_communication_service_is_lost_is_there_a_backup_mode_of_communication_26_1_2_8,
        [CSETCISQuestionsAttr("Once the primary mode is restored, how long will it take before full resumption of operations?")] Once_the_primary_mode_is_restored_how_long_will_it_take_before_full_resumption_of_operations_26_1_2_9,
        //27 Dependencies - Data in Process
        [CSETCISQuestionsAttr("27.1 Are data processing services (mainframes, server farms, cloud providers, etc.) required for the operation of the Critical Services?")] Are_data_processing_services_mainframes_server_farms_cloud_providers_etc_required_for_the_operation_of_the_Critical_Services_27_1,
        [CSETCISQuestionsAttr("If the processing service (mainframe, cluster, etc.) is lost completely, within what time period will the Critical Services be severely impacted?")] If_the_processing_service_mainframe_cluster_etc_is_lost_completely_within_what_time_period_will_the_Critical_Services_be_severely_impacted_27_1_1,
        [CSETCISQuestionsAttr("Once the availability of the processing service (mainframe, cluster, etc.) is lost (without considering any redundant or alternative mode), what percentage of normal cyber functions are lost or degraded?")] Once_the_availability_of_the_processing_service_mainframe_cluster_etc_is_lost_without_considering_any_redundant_or_alternative_mode_what_percentage_of_normal_cyber_functions_are_lost_or_degraded_27_1_2,
        [CSETCISQuestionsAttr("Is there a contingency/business continuity plan with the provider for restoration?")] Is_there_a_contingencybusiness_continuity_plan_with_the_provider_for_restoration_27_1_3,
        [CSETCISQuestionsAttr("Once service is restored, how long will it take before full resumption of operations?")] Once_service_is_restored_how_long_will_it_take_before_full_resumption_of_operations_27_1_4,
        [CSETCISQuestionsAttr("Does the organization depend on external data service providers?")] Does_the_organization_depend_on_external_data_service_providers_27_1_5,
        [CSETCISQuestionsAttr("Who/what is the dependency on: ")] Whowhat_is_the_dependency_on_27_1_5_1,
        [CSETCISQuestionsAttr("Is the dependency provider required to notify the organization of an outage?")] Is_the_dependency_provider_required_to_notify_the_organization_of_an_outage_27_1_5_2,
        [CSETCISQuestionsAttr("Do you monitor this dependency?")] Do_you_monitor_this_dependency_27_1_5_3,
        //28 Dependencies - End Point Systems
        [CSETCISQuestionsAttr("28.1 Are end point systems (desktops, laptops, tablets, etc.) required for the operation of the Critical Services?")] Are_end_point_systems_desktops_laptops_tablets_etc_required_for_the_operation_of_the_Critical_Services_28_1,
        [CSETCISQuestionsAttr("If the endpoint systems (desktops, laptops, tablets, etc.) are no longer available, within what time period would the Critical Services be severely impacted?")] If_the_endpoint_systems_desktops_laptops_tablets_etc_are_no_longer_available_within_what_time_period_would_the_Critical_Services_be_severely_impacted_28_1_1,
        [CSETCISQuestionsAttr("Once the endpoint systems (desktops, laptops, tablets, etc) are no longer available (without considering any redundant or alternative mode), what percentage of normal cyber functions are lost or degraded?")] Once_the_endpoint_systems_desktops_laptops_tablets_etc_are_no_longer_available_without_considering_any_redundant_or_alternative_mode_what_percentage_of_normal_cyber_functions_are_lost_or_degraded_28_1_2,
        [CSETCISQuestionsAttr("Is there a contingency/business continuity plan with the provider for restoration?")] Is_there_a_contingencybusiness_continuity_plan_with_the_provider_for_restoration_28_1_3,
        [CSETCISQuestionsAttr("Does the organization participate in the provider's priority plan for restoration?")] Does_the_organization_participate_in_the_providers_priority_plan_for_restoration_28_1_4,
        [CSETCISQuestionsAttr("Once the primary service is restored, how long will it take before full resumption of operations?")] Once_the_primary_service_is_restored_how_long_will_it_take_before_full_resumption_of_operations_28_1_5
    }

    class CSETCISQuestionsAttr : Attribute
    {
        internal CSETCISQuestionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }

    public static class CSETCISQuestionsExtensions
    {
        public static String GetValue(this CSETCISQuestions enumChoice)
        {
            var attr = enumChoice.GetAttribute<CSETCISQuestionsAttr>();
            return attr.Value;
        }
    }
}
