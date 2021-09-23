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
        private readonly IWebDriver driver;

        public Assessment_Configuration(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement textboxEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'email')]"));
            }
        }

        private IWebElement textboxDate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'date')]"));
            }
        }

        private IWebElement textboxFacility
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'facility')]"));
            }
        }

        private IWebElement textboxCitySite
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'citySite')]"));
            }
        }

        private IWebElement textboxStateProvRegion
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'stateProvRegion')]"));
            }
        }

        private IWebElement checkboxMaturity
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'maturity')]"));
            }
        }

        private IWebElement checkboxStandard
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'standard')]"));
            }
        }

        private IWebElement checkboxDiagram
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'diagram')]"));
            }
        }
    }
}
