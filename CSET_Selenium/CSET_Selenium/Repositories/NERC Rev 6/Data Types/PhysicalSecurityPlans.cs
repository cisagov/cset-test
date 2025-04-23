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
    public class PhysicalSecurityPlans : BaseDTOData
    {
        protected override Dictionary<string, QuestionAnswers> BuildAnswerTable()
        {
            Dictionary<string, QuestionAnswers> answersTable = new Dictionary<string, QuestionAnswers>();

            string enumAttrValue = base.GetEnumAttributeValue(NERCRev6StandardQuestions.Do_you_have_a_process_to_address_access_based_on_need_that_is_determined_by_the_responsible_entity_for_the_following_types_of_access);

            answersTable.Add(enumAttrValue, this.DevelopBaselineConfiguration);

            enumAttrValue = base.GetEnumAttributeValue(NERCRev6StandardQuestions.For_a_change_that_deviates_from_the_existing_baseline_do_you_implement_the_following);

            answersTable.Add(enumAttrValue, this.ExistingBaselineConfiguration);

            enumAttrValue = base.GetEnumAttributeValue(NERCRev6StandardQuestions.For_each_change_that_deviates_from_the_existing_baseline_configuration_do_you_perform_the_following);

            answersTable.Add(enumAttrValue, this.DeviatesFromExistingBaselineConfiguration);

            return answersTable;
        }
    }
}
