using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.SAL
{
    public enum SAL_Confidentiality
    {
        [SAL_ConfidentialityOptionsAttr("Low")] Low,
        [SAL_ConfidentialityOptionsAttr("Modrate")] Moderate,
        [SAL_ConfidentialityOptionsAttr("High")] High,
        [SAL_ConfidentialityOptionsAttr("Very High")] VeryHigh
    }

    class SAL_ConfidentialityOptionsAttr : Attribute
    {
        internal SAL_ConfidentialityOptionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }
}
