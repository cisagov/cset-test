using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using System;

namespace CSET_Selenium.Repositories.NERC_Rev_6
{
    /// <summary>
    /// 
    /// </summary>
    public class NERCRev6Repository : IDisposable
    {
        StandardQuestions _questionsData;

        /// <summary>
        /// 
        /// </summary>
        public NERCRev6Repository() 
        { 
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="qa"></param>
        /// <returns></returns>
        public StandardQuestions AccessStandardQuestionsData(QuestionAnswers qa)
        {
            if (this._questionsData == null)
            {
                this._questionsData = new StandardQuestions();
                this._questionsData.Initialize(qa);
            }

            return this._questionsData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public StandardQuestions AccessStandardQuestionsData()
        {
            return this._questionsData;
        }
    }
}
