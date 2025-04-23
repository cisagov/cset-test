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
    public class IncidentResponse : BaseDTOData
    {
        private QuestionAnswers _questionAnswers;

        /// <summary>
        /// 
        /// </summary>
        public IncidentResponse()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public IncidentResponse(QuestionAnswers questionAnswers)
        {
            this._questionAnswers = questionAnswers;

            this.IncidentResponseViews = questionAnswers;
            this.NoLaterThan90CalendarDays = questionAnswers;
            this.NoLaterThan60CalendarDays = questionAnswers;
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
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.No_later_than_90_calendar_days_after_completion_of_a_Cyber_Security_Incident_response_plans_test_or_actual_Reportable_Cyber_Security_Incident_response)]
        public QuestionAnswers NoLaterThan90CalendarDays
        {
            get; set;
        }

        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.No_later_than_60_calendar_days_after_a_change_to_the_roles_or_responsibilities_Cyber_Security_Incident_response_groups_or_individuals_or_technology_that_the_Responsible_Entity_determines_would_impact_the_ability_to_execute_the_plan)]
        public QuestionAnswers NoLaterThan60CalendarDays
        {
            get; set;
        }
    }
}
