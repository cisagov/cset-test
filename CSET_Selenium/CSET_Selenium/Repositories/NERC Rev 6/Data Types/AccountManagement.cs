using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.Shared.Data_Types;
using OpenQA.Selenium.Internal;
using System.Collections.Generic;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountManagement : BaseDTOData
    {
        /// <summary>
        /// 
        /// </summary>
        public AccountManagement() : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public override void Initialize(QuestionAnswers questionAnswers)
        {
            this.PersonnelAndTraining = base.GetQuestionAnswers(questionAnswers);
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_have_a_process_to_address_access_based_on_need_that_is_determined_by_the_responsible_entity_for_the_following_types_of_access)]
        public QuestionAnswers PersonnelAndTraining
        {
            get;set;
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
            answers.Add(this.PersonnelAndTraining);

            // return list to base class caller
            return answers;
        }
    }
}
