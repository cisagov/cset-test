using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System.Collections.Generic;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class SystemProtection : BaseDTOData
    {
        /// <summary>
        /// 
        /// </summary>
        public SystemProtection() : base() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public override void Initialize(QuestionAnswers questionAnswers)
        {
            this.SecurityEventLogging = base.GetQuestionAnswers(questionAnswers);
            this.BESCyberSystemsLevelLogging = base.GetQuestionAnswers(questionAnswers);
            this.AlertsForSecurityEvents = base.GetQuestionAnswers(questionAnswers);
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Does_your_organization_implement_any_security_event_logging)]
        public QuestionAnswers SecurityEventLogging
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_log_events_at_the_BES_Cyber_Systems_level_per_BES_Cyber_System_capability_or_at_the_Cyber_Asset_level_per_Cyber_Asset_capability_for_identification_of_and_after_the_fact_investigations_of_Cyber_Security_incidents_that_include_at_a_minimum_each_of_the_following_types_of_events)]
        public QuestionAnswers BESCyberSystemsLevelLogging
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [NERCRev6StandardQuestionsAttr(NERCRev6StandardQuestions.Do_you_generate_alerts_for_security_events_that_the_Responsible_Entity_determines_is_necessary_and_that_include_at_a_minimum_each_of_the_following_events)]
        public QuestionAnswers AlertsForSecurityEvents
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
            answers.Add(this.SecurityEventLogging);
            answers.Add(this.BESCyberSystemsLevelLogging);
            answers.Add(this.AlertsForSecurityEvents);

            // return list to base class caller
            return answers;
        }
    }
}
