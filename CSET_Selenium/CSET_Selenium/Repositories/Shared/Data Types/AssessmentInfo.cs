using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public class AssessmentInfo : BaseDTOData
    {
        public string AssessmentName { get; set; }
        public string FacilityName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime AssessmentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override List<QuestionAnswers> SetAnswerList()
        {
            // allocate list
            List<QuestionAnswers> answers = new List<QuestionAnswers>();

            // return list to base class caller
            return answers;
        }
    }
}
