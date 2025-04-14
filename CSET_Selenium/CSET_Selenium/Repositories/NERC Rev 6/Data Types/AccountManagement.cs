using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Enums;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    public class AccountManagement
    {
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_have_a_process_to_address_access_based_on_need_that_is_determined_by_the_responsible_entity_for_the_following_types_of_access)]
        public QuestionAnswers PersonnelAndTraining
        {
            get
            {
                return QuestionAnswers.YES;
            }
        }
    }

    public class ConfigurationManagement
    {
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_have_a_process_to_address_access_based_on_need_that_is_determined_by_the_responsible_entity_for_the_following_types_of_access)]
        public QuestionAnswers DevelopBaselineConfiguraiton
        {
            get
            {
                return QuestionAnswers.YES;
            }
        }
        public QuestionAnswers ExistingBaselineConfiguraiton
        {
            get
            {
                return QuestionAnswers.YES;
            }
        }
    }
}
