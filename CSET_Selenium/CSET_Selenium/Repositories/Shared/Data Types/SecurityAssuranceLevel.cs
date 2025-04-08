using CSET_Selenium.Repositories.Shared.Data_Types;
using CSET_Selenium.Enums.SAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        public override bool IsValid()
        {
            return base.IsValid();
        }
    }
}
