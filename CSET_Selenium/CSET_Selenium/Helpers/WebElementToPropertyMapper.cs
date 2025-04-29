using CSET_Selenium.Repositories.Shared.Data_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

/*
[enum based attribute whose value corresponds with webelement text]
backing object property
boolean funtion(PropertyInfo backing object property, string webelement text)
bool isMatch = false
attribute = backing object property.GetAttributes()
for each attribute

isMatch = attribute.GetValue() == webElement.Text


return isMatch
 */
namespace CSET_Selenium.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class WebElementToPropertyMapper
    {
        /// <summary>
        // Point of this method is to find the property in the backing object that corresponds with the 
        // web element text, then return this property.
        // The caller can then decide to get the value from the property or set a value to the property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyObject"></param>
        /// <param name="webElementDisplayText"></param>
        /// <returns></returns>
        public static PropertyInfo MapToProperty<T>(T propertyObject, string webElementDisplayText)
            where T : BaseDTOData
        {
            PropertyInfo propInfo = null;

            // get collection of public, instance properties on this object
            PropertyInfo[] objectProperties = propertyObject.GetType().GetProperties();

            // for each property returned
            foreach (PropertyInfo propertyInfo in objectProperties)
            {
                // if property matches webelement
                if (MapToProperty(propertyInfo, webElementDisplayText))
                {
                    // set varaible to return to caller
                    propInfo = propertyInfo;

                    // we're done here
                    break;
                }
            }

            return propInfo;
        }

        /// <summary>
        /// The point of this method is to confirm whether a given property is a match for the web element text
        /// the idea being if it's a match, the caller can decide whether to set or get the property value
        /// </summary>
        /// <param name="objectProperty"></param>
        /// <param name="webElementDisplayText"></param>
        /// <returns></returns>
        public static bool MapToProperty(PropertyInfo objectProperty, string webElementDisplayText)
        {
            bool isMatch = false;

            // get collection of custom attributes on the property
            IEnumerable<Attribute> attrs = objectProperty.GetCustomAttributes();

            // if I have a custom attribute
            if (attrs != null && attrs.Count() > 0)
            {
                foreach (Attribute attr in attrs)
                {
                    // get member info on the attribute
                    MethodInfo getValueMethod = attr.GetType().GetMethod("GetValue");

                    // get text associated with enum attribute
                    string attrText = getValueMethod.Invoke(objectProperty, null).ToString();

                    // if I have attribute text
                    if (!string.IsNullOrWhiteSpace(attrText))
                    {
                        // if attribute value is in the display text
                        isMatch = webElementDisplayText.Equals(attrText);

                        break;
                    }
                }
            }

            return isMatch;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    static class StringPrep
    {
        /// <summary>
        /// This extension method serves as a preprocessor for the property attribute value, to prepare it
        /// for comparison to the web element text
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="charsToRemove"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public static string StripOff(this string sourceText, string charsToRemove, char delimiter)
        {
            string targetText = string.Empty;
            string[] keyChars = charsToRemove.Split(delimiter);

            foreach (string c in keyChars)
            {
                targetText += sourceText.Replace(c, string.Empty);
            }

            return targetText;
        }
    }
}
