using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.Con_PCA
{
    public enum ProfileInterfaceType

    {
        [IFTypeAttr("SMTP")] SMTP,
        [IFTypeAttr("Mailgun")] Mailgun,
    }

    class IFTypeAttr : Attribute
    {
        internal IFTypeAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }

    public static class IFTypeExtensions
    {
        public static String GetValue(this ProfileInterfaceType enumChoice)
        {
            var attr = enumChoice.GetAttribute<IFTypeAttr>();
            return attr.Value;
        }
    }
}
