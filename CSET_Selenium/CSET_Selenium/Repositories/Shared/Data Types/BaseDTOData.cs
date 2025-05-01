using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Enums;
using CSET_Selenium.Enums.Questions;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium;

namespace CSET_Selenium.Repositories.Shared.Data_Types
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseDTOData : IResultsPageInfo, IDisposable
    {
        private Random _random = new Random();
        protected List<QuestionAnswers> _anwsers;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answers"></param>
        public BaseDTOData(QuestionAnswers answers)
        {
            // have derived object initialize their data properties
            this.Initialize(answers);

        }

        /// <summary>
        /// 
        /// </summary>
        public BaseDTOData()
        {
            this._random = new Random(0);
            this.Initialize();
            this._anwsers = this.SetAnswerList();
        }

        public void Dispose()
        {
            this._anwsers.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected QuestionAnswers GetNextValue()
        {
            QuestionAnswers answer;
            int val = this._random.Next(4);
            Enum.TryParse<QuestionAnswers>(val.ToString(), out answer);

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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual List<QuestionAnswers> SetAnswerList()
        {
            return new List<QuestionAnswers>();
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Initialize()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        public virtual void Initialize(QuestionAnswers questionAnswers)
        {
            // collect the values of those data properties into a list for reporting
            this.Initialize();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="answerList"></param>
        protected void PopulateAnswerList(List<QuestionAnswers> answerList)
        {
            this._anwsers = this.SetAnswerList();
        }

        public List<QuestionAnswers> AnswerList { get => this._anwsers; }

        public virtual int TotalQuestionsCount => this._anwsers.Count();

        public virtual int AnsweredCount => this._anwsers.Sum(a => a.IsAnswered() ? 1 : 0);

        public virtual int UnansweredCount => this._anwsers.Sum(a => !a.IsAnswered() ? 1 : 0);

        public virtual int YesCount => this._anwsers.Sum(a => a == QuestionAnswers.YES ? 1 : 0);

        public virtual int NoCount => this._anwsers.Sum(a => a == QuestionAnswers.NO ? 1 : 0);

        public virtual int NACount => this._anwsers.Sum(a => a == QuestionAnswers.NA ? 1 : 0);

        public virtual int ALTCount => this._anwsers.Sum(a => a == QuestionAnswers.ALT ? 1 : 0);
    }
}
