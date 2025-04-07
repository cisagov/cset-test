using OpenQA.Selenium.DevTools.V130.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.SAL
{
    public enum SAL_Overall
    {
        [SAL_OverallOptionsAttr("Low")] Low,
        [SAL_OverallOptionsAttr("Moderate")] Moderate,
        [SAL_OverallOptionsAttr("High")] High,
        [SAL_OverallOptionsAttr("Very High")] VeryHigh
    }

    class SAL_OverallOptionsAttr : Attribute
    {
        internal SAL_OverallOptionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }
}