using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.Con_PCA
{
    public enum CustomerTypes
    {
        [CustomerTypesAttr("Government - Federal")] Federal,
        [CustomerTypesAttr("Government - State")] State,
        [CustomerTypesAttr("Government - Local")] Local,
        [CustomerTypesAttr("Government - Tribal")] Tribal,
        [CustomerTypesAttr("Government - Territorial")] Territorial,
        [CustomerTypesAttr("Private")] Private
    }

    class CustomerTypesAttr : Attribute
    {
        internal CustomerTypesAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }

    public static class CustomerTypesExtensions
    {
        public static String GetValue(this CustomerTypes enumChoice)
        {
            var attr = enumChoice.GetAttribute<CustomerTypesAttr>();
            return attr.Value;
        }
    }
}
