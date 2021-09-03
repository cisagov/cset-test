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

    public static class DateAddSubtractOption
    {
        public static String GetValue(this DateAddSubtractOptions enumChoice)
        {
            DateAddSubtractOptionsAttr attr = GetAttr(enumChoice);
            return attr.Value;
        }

        private static DateAddSubtractOptionsAttr GetAttr(DateAddSubtractOptions enumChoice)
        {
            return (DateAddSubtractOptionsAttr)Attribute.GetCustomAttribute(ForValue(enumChoice), typeof(DateAddSubtractOptionsAttr));
        }

        private static MemberInfo ForValue(DateAddSubtractOptions enumChoice)
        {
            return typeof(DateAddSubtractOptions).GetField(Enum.GetName(typeof(DateAddSubtractOptions), enumChoice));
        }

    }
}