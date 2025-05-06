namespace CSET_Selenium.Enums
{
    public enum QuestionAnswers
    {
        NOANSWER,
        YES,
        NO,
        NA,
        ALT,
        RANDOM
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
        public static bool IsYESorALTorUNanswered(this QuestionAnswers questionAnswers)
        {
            return questionAnswers == QuestionAnswers.YES || 
                questionAnswers == QuestionAnswers.ALT ||
                questionAnswers == QuestionAnswers.NOANSWER;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionAnswers"></param>
        /// <returns></returns>
        public static bool IsAnswered(this QuestionAnswers questionAnswers)
        {
            return questionAnswers != QuestionAnswers.NOANSWER;
        }
    }
}
