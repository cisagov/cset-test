using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.SAL
{
    public enum SAL_Availability
    {
        [SAL_AvaiabilityOptionsAttr("Low")] Low,
        [SAL_AvaiabilityOptionsAttr("Modrate")] Moderate,
        [SAL_AvaiabilityOptionsAttr("High")] High,
        [SAL_AvaiabilityOptionsAttr("Very High")] VeryHigh
    }

    class SAL_AvaiabilityOptionsAttr : Attribute
    {
        internal SAL_AvaiabilityOptionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }
}
