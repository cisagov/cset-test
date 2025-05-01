using CSET_Selenium.Repositories.Shared.Data_Types;
using CSET_Selenium.Enums.SAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Enums;

namespace CSET_Selenium.Repositories.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public class SecurityAssuranceLevel : BaseDTOData
    {
        public SAL_Overall Overall { get; set; }
        public SAL_Methodology Methodology { get; set; }
        public SAL_Confidentiality Confidentiality { get; set; }
        public SAL_Integrity Integrity { get; set; }
        public SAL_Availability Avaiability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="salOverall"></param>
        /// <param name="salMethdology"></param>
        /// <param name="salConfidentiality"></param>
        /// <param name="salIntegrity"></param>
        /// <param name="salAvailability"></param>
        public SecurityAssuranceLevel(
            SAL_Overall salOverall = SAL_Overall.Low,
            SAL_Methodology salMethdology = SAL_Methodology.Simple,
            SAL_Confidentiality salConfidentiality = SAL_Confidentiality.Low,
            SAL_Integrity salIntegrity = SAL_Integrity.Low,
            SAL_Availability salAvailability = SAL_Availability.Low
            )
        {
            this.Overall = salOverall;
            this.Methodology = salMethdology;
            this.Confidentiality = salConfidentiality;
            this.Integrity = salIntegrity;
            this.Avaiability = salAvailability;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override List<QuestionAnswers> SetAnswerList()
        {
            // allocate list
            List<QuestionAnswers> answers = new List<QuestionAnswers>();

            // add property values
            //answers.Add(this.PersonnelAndTraining);

            // return list to base class caller
            return answers;
        }
    }
}
