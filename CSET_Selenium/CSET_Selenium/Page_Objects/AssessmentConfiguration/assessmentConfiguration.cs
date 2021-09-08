using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.AssessmentConfiguration
{
    class AssessmentConfiguration
    {
        [FindsBy(How = How.XPath, Using = "xpath=//input[contains(@id, 'name')]")]
        private readonly IWebElement textboxName;

        [FindsBy(How = How.XPath, Using = "xpath=//label[contains(text(), 'Assessment Date')]/parent::div/child::input']")]
        private readonly IWebElement dropdownDate;

        [FindsBy(How = How.XPath, Using = "xpath=//input[contains(@id, 'facility')]")]
        private readonly IWebElement textboxFacility;

        [FindsBy(How = How.XPath, Using = "xpath=//input[contains(@id, 'citySite')]")]
        private readonly IWebElement textboxCitySite;

        [FindsBy(How = How.XPath, Using = "xpath=//input[contains(@id, 'stateProvRegion')]")]
        private readonly IWebElement textboxStateProvRegion;

        [FindsBy(How = How.XPath, Using = "xpath=//input[contains(@id, 'maturity')]")]
        private readonly IWebElement checkboxMaturity;

        [FindsBy(How = How.XPath, Using = "xpath=//input[contains(@id, 'standard')]")]
        private readonly IWebElement checkboxStandard;

        [FindsBy(How = How.XPath, Using = "xpath=//input[contains(@id, 'diagram')]")]
        private readonly IWebElement checkboxDiagram;

        [FindsBy(How = How.XPath, Using = "xpath=////button[contains(text(), 'Next')]")]
        private readonly IWebElement buttonNext;
    }
}
