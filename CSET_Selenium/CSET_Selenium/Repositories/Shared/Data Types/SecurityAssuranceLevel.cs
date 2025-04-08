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
            SAL_Overall salOverall,
            SAL_Methodology salMethdology,
            SAL_Confidentiality salConfidentiality,
            SAL_Integrity salIntegrity,
            SAL_Availability salAvailability
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
