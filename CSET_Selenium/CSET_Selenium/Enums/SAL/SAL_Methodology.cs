using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.SAL
{
    public enum SAL_Methodology
    {
        [SAL_MethodologyOptionsAttr("Simple")] Simple,
        [SAL_MethodologyOptionsAttr("GeneralRiskBased")] GeneralRiskBased,
        [SAL_MethodologyOptionsAttr("NIST-60 / FIPS-199")] NIST60_FIPS199
    }

    class SAL_MethodologyOptionsAttr : Attribute
    {
        internal SAL_MethodologyOptionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }
}
