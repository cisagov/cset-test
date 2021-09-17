using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Assessment_Configuration
{
    class Assessment_Configuration : BasePage
    {
        public Assessment_Configuration(IWebDriver driver) : base(driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'email')]")]
        private readonly IWebElement textboxEmail;

        [FindsBy(How = How.XPath, Using = "//input[contains(@name, 'date')]")]
        private readonly IWebElement textboxDate;

        [FindsBy(How = How.XPath, Using = "//input[contains(@name, 'facility')]")]
        private readonly IWebElement textboxFacility;

        [FindsBy(How = How.XPath, Using = "//input[contains(@name, 'citySite')]")]
        private readonly IWebElement textboxCitySite;

        [FindsBy(How = How.XPath, Using = "//input[contains(@name, 'stateProvRegion')]")]
        private readonly IWebElement textboxStateProvRegion;

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'maturity')]")]
        private readonly IWebElement checkboxMaturity;

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'standard')]")]
        private readonly IWebElement checkboxStandard;

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'diagram')]")]
        private readonly IWebElement checkboxDiagram;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Next')]")]
        private readonly IWebElement buttonNext;
    }
}
