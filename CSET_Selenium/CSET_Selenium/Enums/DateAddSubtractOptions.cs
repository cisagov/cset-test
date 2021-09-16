using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums
{
    public enum DateAddSubtractOptions
    {
        [DateAddSubtractOptionsAttr("hh")] Hour,
        [DateAddSubtractOptionsAttr("mi")] Minute,
        [DateAddSubtractOptionsAttr("ss")] Second,
        [DateAddSubtractOptionsAttr("ms")] Millis,
        [DateAddSubtractOptionsAttr("dd")] Day,
        [DateAddSubtractOptionsAttr("ww")] Week,
        [DateAddSubtractOptionsAttr("mm")] Month,
        [DateAddSubtractOptionsAttr("qq")] Quarter,
        [DateAddSubtractOptionsAttr("yyyy")] Year,
        [DateAddSubtractOptionsAttr("bd")] BusinessDay
    }

    class DateAddSubtractOptionsAttr : Attribute
    {
        internal DateAddSubtractOptionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }

    public static class DateAddSubtractOptionsExtensions
    {
        public static String GetValue(this DateAddSubtractOptions enumChoice)
        {
            var attr = enumChoice.GetAttribute<DateAddSubtractOptionsAttr>();
            return attr.Value;
        }
    }
}