using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.Questions
{
    public enum NERCRev6StandardQuestions
    {
    }

    class NERCRev6StandardQuestionsAttr : Attribute
    {
        internal NERCRev6StandardQuestionsAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }

    public static class NERCRev6StandardQuestionsExtensions
    {
        public static String GetValue(this NERCRev6StandardQuestions enumChoice)
        {
            var attr = enumChoice.GetAttribute<NERCRev6StandardQuestionsAttr>();
            return attr.Value;
        }
    }
}
