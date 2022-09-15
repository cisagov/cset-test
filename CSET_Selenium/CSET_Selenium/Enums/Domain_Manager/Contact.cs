using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.Domain_Manager
{
    public enum Contact

    {
        [ContactAttr("Test Automation")] General_Name,
        [ContactAttr("test@inl.gov")] Email,
        [ContactAttr("208-222-2222")] Phone,
        [ContactAttr("John")] First_Name,
        [ContactAttr("Tesla")] Last_Name,
        [ContactAttr("1955 Freeman St.")] Address1,
        [ContactAttr("Whatever")] Address2,
        [ContactAttr("Idaho")] State,
        [ContactAttr("83401")] ZIP,
        [ContactAttr("Idaho Falls")] City,
        [ContactAttr("Con-PCA-12345678")] Identifier,
        [ContactAttr("test-qa-customer.com")] Domain
    }

    class ContactAttr : Attribute
    {
        internal ContactAttr(String customer)
        {
            this.Value = customer;
        }
        public String Value { get; private set; }
    }

    public static class ContactExtensions
    {
        public static String GetValue(this Contact enumChoice)
        {
            var attr = enumChoice.GetAttribute<ContactAttr>();
            return attr.Value;
        }
    }

}
