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
using CSET_Selenium.Enums;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    class StandardQuestions : BasePage
    {
        private readonly IWebDriver driver;

        public StandardQuestions(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void SetQuestionsMode()
        {
            this.QuestionsMode.Click();
        }

        public void SetRequirementsMode()
        {
            this.RequirementsMode.Click();
        }

        public void ExpandAllQuestions()
        {
            this.ExpandAll.Click();
        }

        public void CompressAllQuestions()
        {
            this.CompressAll.Click();
        }


        public void SetQuestionValues(NERC6DT.StandardQuestions standardQuestions)
        {

        }

        //private IWebElement QuestionsMode
        //{
        //    get
        //    {
        //        return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[2]/div[1]/label[1]"));
        //    }
        //}

        //private IWebElement RequirementsMode
        //{
        //    get
        //    {
        //        return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[2]/div[1]/label[2]"));
        //    }
        //}

        //Element Locators

        private IWebElement RequirementsMode
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Requirements Mode')]"));
            }
        }

        private IWebElement QuestionsMode
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Questions Mode')]"));
            }
        }

        private IWebElement ExpandAll
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[2]/div[2]/div[2]/div[1]/button[2]"));
            }
        }

        private IWebElement CompressAll
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[2]/div[2]/div[2]/div[1]/button[1]"));
            }
        }
    }
}
