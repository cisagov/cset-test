using Shared = CSET_Selenium.Repositories.Shared;
using NERC6 = CSET_Selenium.Repositories.NERC_Rev_6;
using NERC6DT = CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    class StandardQuestions : BasePage
    {
        private readonly IWebDriver driver;

        public StandardQuestions(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void SetQuestionValues(NERC6DT.StandardQuestions standardQuestions)
        {

        }

        public BasePage SelectNextPage()
        {
            return null;
        }
    }
}
