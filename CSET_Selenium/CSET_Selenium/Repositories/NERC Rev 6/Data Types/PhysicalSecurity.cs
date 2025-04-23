using CSET_Selenium.Repositories.Shared.Data_Types;
using CSET_Selenium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Enums.Questions;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class PhysicalSecurity : BaseDTOData
    {
        private QuestionAnswers _questionAnswers;

        public PhysicalSecurity()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public PhysicalSecurity(QuestionAnswers questionAnswers)
        {
            this._questionAnswers = questionAnswers;

            this.ForPrimaryControlCenters = questionAnswers;
            this.OrganizationHavePhysicalSecurityPlan = questionAnswers;
            this.PhysicalSecurityPlanWithin120Days = questionAnswers;
            this.IncidentResponseViews = questionAnswers;
            this.PhysicalSecurityIncludeTheFollowing = questionAnswers;
            this.DoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasures = questionAnswers;
            this.DoesPhysicialSeucityPlanIncludeLawEnforcement = questionAnswers;
            this.DoesPhysicalSecurityPlanIncludeTimeline = questionAnswers;
            this.DoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreats = questionAnswers;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.For_primary_control_centers_do_you_consider_the_following)]
        public QuestionAnswers ForPrimaryControlCenters
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_have_a_physical_security_plan)]
        public QuestionAnswers OrganizationHavePhysicalSecurityPlan
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_develop_a_physical_security_plans_within_120_days_following_the_completion_of_Requirement_R2_and_execute_according_to_the_timeline_specified_in_the_plan)]
        public QuestionAnswers PhysicalSecurityPlanWithin120Days
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_conduct_incident_response_plan_reviews)]
        public QuestionAnswers IncidentResponseViews
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_your_physical_security_plans_include_the_following)]
        public QuestionAnswers PhysicalSecurityIncludeTheFollowing
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organizations_physical_security_plans_include_resiliency_or_security_measures_designed_collectively_to_deter_detect_delay_assess_communicate_and_respond_to_potential_physical_threats_and_vulnerabilities_identified_during_the_evaluation_conducted_in_Requirement_R4)]
        public QuestionAnswers DoesPhysicalSeccurityPlanIncludeResiliencyOrSecurityMeasures
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organizations_physical_security_plans_include_law_enforcement_contact_and_coordination_information)]
        public QuestionAnswers DoesPhysicialSeucityPlanIncludeLawEnforcement
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organizations_physical_security_plans_include_a_timeline_for_executing_the_physical_security_enhancements_and_modifications_specified_in_the_physical_security_plan)]
        public QuestionAnswers DoesPhysicalSecurityPlanIncludeTimeline
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organizations_physical_security_plans_include_provisions_to_evaluate_evolving_physical_threats_and_their_corresponding_security_measures_to_the_Transmission_stations_Transmission_substation_or_primary_control_centers)]
        public QuestionAnswers DoesPhysicalSecurityPlanIncludeProvisionsToEvaluateEvolvingPhysicalThreats
        {
            get; set;
        }
    }
}
