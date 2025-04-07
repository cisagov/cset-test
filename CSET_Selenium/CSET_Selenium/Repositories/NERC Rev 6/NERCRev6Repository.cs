using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.NERC_Rev_6
{
    public class NERCRev6Repository : IDisposable
    {
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
