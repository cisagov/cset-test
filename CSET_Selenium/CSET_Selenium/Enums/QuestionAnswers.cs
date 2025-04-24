using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums
{
    public enum QuestionAnswers
    {
        YES,
        NO,
        NA,
        ALT
    }

    /// <summary>
    /// 
    /// </summary>
    public static class QAExtentions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        /// <returns></returns>
        public static bool IsYESorALT(this QuestionAnswers questionAnswers)
        {
            return questionAnswers == QuestionAnswers.YES || questionAnswers == QuestionAnswers.ALT;
        }
    }
}
