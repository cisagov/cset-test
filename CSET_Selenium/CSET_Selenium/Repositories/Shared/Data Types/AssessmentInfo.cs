using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.Shared.Data_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.Shared
{
    public class AssessmentInfo : BaseDTOData
    {
        public override bool IsValid()
        {
            return base.IsValid();
        }
        //protected override Dictionary<string, QuestionAnswers> BuildAnswerTable()
        //{
        //    Dictionary<string, QuestionAnswers> answersTable = new Dictionary<string, QuestionAnswers>();

        //    return answersTable;
        //}

        public string AssessmentName { get; set; }
        public string FacilityName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public DateTime AssessmentDate { get; set; }
    }
}
