using CSET_Selenium.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.Con_PCA
{
    
    public enum Customer

    {   
        [CustomerAttr("ConPCA Automation")] Customer_Name,
        [CustomerAttr("test@inl.gov")] Customer_Email,
        [CustomerAttr("John")] First_Name,
        [CustomerAttr("Tesla")] Last_Name,
        [CustomerAttr("1955 Freeman St.")] Address1,
        [CustomerAttr("Whatever")] Address2,
        [CustomerAttr("Idaho")] State,
        [CustomerAttr("83401")] ZIP,
        [CustomerAttr("Idaho Falls")] City,
        [CustomerAttr("Con-PCA-12345678")] Customer_Identifier,
        [CustomerAttr("test-qa-customer.com")] Customer_Domain
    }

    class CustomerAttr : Attribute
    {
        internal CustomerAttr(String customer)
        {
            this.Value = customer;
        }
        public String Value { get; private set; }
    }

    public static class CustomerExtensions
    {
        public static String GetValue(this Customer enumChoice)
        {
            var attr = enumChoice.GetAttribute<CustomerAttr>();
            return attr.Value;
        }
    }

}
