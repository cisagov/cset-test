using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.NERC_Rev_6
{
    /// <summary>
    /// 
    /// </summary>
    public class NERCRev6Repository : IDisposable
    {
        public NERCRev6Repository() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="qa"></param>
        /// <returns></returns>
        public StandardQuestions AccessStandardQuestionsData(QuestionAnswers qa)
        {
            StandardQuestions questionsData = new StandardQuestions(qa);

            return questionsData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public StandardQuestions AccessStandardQuestionsData()
        {
            StandardQuestions questionsData = new StandardQuestions();

            return questionsData;
        }

        public void Dispose()
        {
        }
    }
}
