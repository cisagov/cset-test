using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using OpenQA.Selenium;

namespace CSET_Selenium.Repositories.Shared.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseDTOData
    {
        private QuestionAnswers _questionAnswers;

        public BaseDTOData()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual bool IsValid()
        {
            return true;
        }

        public bool IsYesOrAlt
        {
            get { return this._questionAnswers == QuestionAnswers.YES || this._questionAnswers == QuestionAnswers.ALT; }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class DataTypeValidation
    {
        public static bool IsValid(this BaseDTOData dataToValidate)
        {
            return dataToValidate.IsValid();
        }
    }
}
