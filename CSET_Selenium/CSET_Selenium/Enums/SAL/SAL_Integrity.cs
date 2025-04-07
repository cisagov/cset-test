using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.SAL
{
    public enum SAL_Integrity
    {
        [SAL_IntegrityOptionsAttr("Low")] Low,
        [SAL_IntegrityOptionsAttr("Modrate")] Moderate,
        [SAL_IntegrityOptionsAttr("High")] High,
        [SAL_IntegrityOptionsAttr("Very High")] VeryHigh
    }

    class SAL_IntegrityOptionsAttr : Attribute
    {
        internal SAL_IntegrityOptionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }
}
