using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class Policies : BaseDTOData
    {
        private QuestionAnswers _questionAnswers;

        /// <summary>
        /// 
        /// </summary>
        public Policies()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public Policies(QuestionAnswers questionAnswers)
        {
            this._questionAnswers = questionAnswers;

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
    }
}
