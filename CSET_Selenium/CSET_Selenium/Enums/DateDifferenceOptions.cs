using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums
{
    public enum DateDifferenceOptions
    {
        [DateDifferenceOptionsAttr("hh")] Hour,
        [DateDifferenceOptionsAttr("mi")] Minute,
        [DateDifferenceOptionsAttr("ss")] Second,
        [DateDifferenceOptionsAttr("ms")] Millis,
        [DateDifferenceOptionsAttr("dd")] Day,
        [DateDifferenceOptionsAttr("ww")] Week,
        [DateDifferenceOptionsAttr("mm")] Month,
        [DateDifferenceOptionsAttr("yyyy")] Year
    }

    class DateDifferenceOptionsAttr : Attribute
    {
        internal DateDifferenceOptionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }

    public static class DateDifferenceOption
    {
        public static String GetValue(this DateDifferenceOptions enumChoice)
        {
            DateDifferenceOptionsAttr attr = GetAttr(enumChoice);
            return attr.Value;
        }

        private static DateDifferenceOptionsAttr GetAttr(DateDifferenceOptions enumChoice)
        {
            return (DateDifferenceOptionsAttr)Attribute.GetCustomAttribute(ForValue(enumChoice), typeof(DateDifferenceOptionsAttr));
        }

        private static MemberInfo ForValue(DateDifferenceOptions enumChoice)
        {
            return typeof(DateDifferenceOptions).GetField(Enum.GetName(typeof(DateDifferenceOptions), enumChoice));
        }

    }
}