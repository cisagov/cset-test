using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Helpers
{
    public class WebElementToPropertyMapper
    {
        public PropertyInfo ToProperty(string displayText)
        {
            string textToMap = displayText.StripOf(",|(|)|?");

            
            return null;
        }
    }

    static class StringPrep
    {
        public static string StripOf(this string sourceText, string charsToRemove)
        {
            string targetText = string.Empty;
            string[] keyChars = charsToRemove.Split('|');

            foreach (string c in keyChars)
            {
                targetText += sourceText.Replace(c, string.Empty);
            }

            return targetText;
        }
    }
}
