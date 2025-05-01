using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System.Collections.Generic;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class Recovery : BaseDTOData
    {
        /// <summary>
        /// 
        /// </summary>
        public Recovery()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            this.RecoveryPlanReviews = base.GetNextValue();
            this.PerformWithin90Days = base.GetNextValue();
            this.ChangeToRolesOrResponsibilitiesRespondersOrTechnology = base.GetNextValue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public override void Initialize(QuestionAnswers questionAnswers)
        {
            this.RecoveryPlanReviews = questionAnswers;
            this.PerformWithin90Days = questionAnswers;
            this.ChangeToRolesOrResponsibilitiesRespondersOrTechnology = questionAnswers;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_the_organization_conduct_recovery_plan_reviews)]
        public QuestionAnswers RecoveryPlanReviews
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_perform_the_following_no_later_than_90_days_after_the_completion_of_a_recovery_plan_test_or_actual_recovery)]
        public QuestionAnswers PerformWithin90Days
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.If_there_is_a_change_to_roles_or_responsibilities_responders_or_technology_do_you_complete_the_following_in_no_later_than_60_days)]
        public QuestionAnswers ChangeToRolesOrResponsibilitiesRespondersOrTechnology
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
            answers.Add(this.RecoveryPlanReviews);
            answers.Add(this.PerformWithin90Days);

            // return list to base class caller
            return answers;
        }
    }
}
