using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Enums;
using OpenQA.Selenium;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    public class AccountManagement : BaseDTOData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public AccountManagement(QuestionAnswers questionAnswers)
        {
            this.PersonnelAndTraining = questionAnswers;
        }

        /// <summary>
        /// 
        /// </summary>
        public AccountManagement() : base()
        {
            this.PersonnelAndTraining = base.GetNextValue();
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_have_a_process_to_address_access_based_on_need_that_is_determined_by_the_responsible_entity_for_the_following_types_of_access)]
        public QuestionAnswers PersonnelAndTraining
        {
            get;set;
        }
    }
}
