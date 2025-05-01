using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System.Collections.Generic;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class Policies : BaseDTOData
    {
        /// <summary>
        /// 
        /// </summary>
        public Policies()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override void Initialize()
        {
            this.CIPSeniorManagerApproval = base.GetNextValue();
            this.CIPSeniorManagerApproval = base.GetNextValue();
            this.ProcessToAddressAccess = base.GetNextValue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public override void Initialize(QuestionAnswers questionAnswers)
        {
            this.CIPSeniorManagerApproval = questionAnswers;
            this.CIPSeniorManagerApproval = questionAnswers;
            this.ProcessToAddressAccess = questionAnswers;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_have_a_process_to_address_access_based_on_need_that_is_determined_by_the_responsible_entity_for_the_following_types_of_access)]
        public QuestionAnswers ProcessToAddressAccess
        {
            get; set;
        }
        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_review_and_obtain_CIP_Senior_Manager_approval_in_the_last_15_calendar_months_for_cyber_security_policies_that_address_the_following_topics_for_low_impact_BES_Cyber_Systems)]
        public QuestionAnswers CIPSeniorManagerApproval
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
            answers.Add(this.CIPSeniorManagerApproval);
            answers.Add(this.CIPSeniorManagerApproval);
            answers.Add(this.ProcessToAddressAccess);

            // return list to base class caller
            return answers;
        }
    }
}
