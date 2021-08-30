using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Landing_Page
{
    class landingPage
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'New Assessment')]/ancestor::button")]
        private IWebElement buttonNewAssessment;

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Import')]")]
        private IWebElement buttonImportAnExistingAssessment;
    }
}
