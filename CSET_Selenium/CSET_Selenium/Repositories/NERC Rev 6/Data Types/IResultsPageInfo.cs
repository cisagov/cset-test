using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.NERC_Rev_6.Data_Types
{
    internal interface IResultsPageInfo
    {
        int TotalQuestionsCount { get; }
        int AnsweredCount { get; }
        int UnansweredCount { get; }
        int YesCount { get; }
        int NoCount { get; }
        int NACount { get; }
        int ALTCount { get; }
    }
}
