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
        public SecurityAssuranceLevel()
        {
            this.Overall = SAL_Overall.Low;
            this.Methodology = SAL_Methodology.Simple;
            this.Confidentiality = SAL_Confidentiality.Low;
            this.Integrity = SAL_Integrity.Low;
            this.Avaiability = SAL_Availability.Low;
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
