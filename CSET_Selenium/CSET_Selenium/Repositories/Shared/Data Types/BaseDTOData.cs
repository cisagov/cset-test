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
        private Random _random = new Random();

        public BaseDTOData()
        {
            this._random = new Random(0);
        }

        protected QuestionAnswers GetNextValue()
        {
            QuestionAnswers answer;
            int val = this._random.Next(3);
            Enum.TryParse<QuestionAnswers>(val.ToString(), out answer);

            System.Console.WriteLine("Enum value: ", answer.ToString());

            return answer;
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
}
