using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System.Collections.Generic;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class RiskAssessment : BaseDTOData
    {
        /// <summary>
        /// 
        /// </summary>
        public RiskAssessment() 
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            this.RiskAssessments = base.GetNextValue();
            this.InitialRiskAssessment = base.GetNextValue();
            this.SubsequentRiskAssessments = base.GetNextValue();
            this.PrimaryControlCenter = base.GetNextValue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public override void Initialize(QuestionAnswers questionAnswers)
        {
            this.RiskAssessments = questionAnswers;
            this.InitialRiskAssessment = questionAnswers;
            this.SubsequentRiskAssessments = questionAnswers;
            this.PrimaryControlCenter = questionAnswers;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_perform_risk_assessments)]
        public QuestionAnswers RiskAssessments
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Have_you_performed_an_initial_risk_assessment_and_subsequent_risk_assessments_of_transmission_stations_and_substations_existing_and_planned_to_be_in_service_in_24_months_that_meet_criteria_described_in_Applicability_Section_4_1_1)]
        public QuestionAnswers InitialRiskAssessment
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_perform_subsequent_risk_assessments_At_least_every_30_months_if_a_Transmission_Owner_has_identified_the_transmission_stations_and_substations_if_rendered_inoperable_or_damaged_could_result_in_instability_uncontrolled_separation_or_Cascading_within_an_Interconnection_At_least_every_60_months_if_the_stations_have_not_been_identified_that_if_rendered_inoperable_or_damaged_could_result_in_instability_uncontrolled_separation_or_Cascading_within_an_Interconnection)]
        public QuestionAnswers SubsequentRiskAssessments
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Have_you_identified_the_primary_control_center_that_controls_each_transmission_station_or_substation)]
        public QuestionAnswers PrimaryControlCenter
        {
            get; set;
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
            answers.Add(this.RiskAssessments);
            answers.Add(this.InitialRiskAssessment);
            answers.Add(this.SubsequentRiskAssessments);
            answers.Add(this.PrimaryControlCenter);

            // return list to base class caller
            return answers;
        }
    }
}
