using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Sidebar
{
    class Sidebar : BasePage
    {
        private readonly IWebDriver driver;

        public Sidebar(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement dropdownPrepare
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Prepare')]"));
            }
        }

        private IWebElement buttonAssessementConfiguration
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Assessment Configuration')]"));
            }
        }

        private IWebElement buttonAssessmentInformation
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Assessment Information')]"));
            }
        }

        private IWebElement buttonAssuranceLevel
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Security Assurance Level')]"));
            }
        }

        private IWebElement buttonCybersecurityStandards
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Cybersecurity Standards')]"));
            }
        }

        private IWebElement dropdownAssessment
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Assessment')]"));
            }
        }

        private IWebElement checkboxStandard
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'standard')]"));
            }
        }

        private IWebElement buttonStandardQuestions
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Standard Questions')]"));
            }
        }

        private IWebElement dropdownStandardsResults
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Standards Results')]"));
            }
        }

        private IWebElement buttonAnalysisDashboard
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Analysis Dashboard')]"));
            }
        }

        private IWebElement buttonControlPriorities
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Control Priorities')]"));
            }
        }

        private IWebElement buttonStandardsSummary
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Standards Summary')]"));
            }
        }

        private IWebElement buttonRankedCategories
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Ranked Categories')]"));
            }
        }

        private IWebElement buttonResultsByCategory
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Results By Category')]"));
            }
        }

        private IWebElement buttonHighLevelAssessement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'High-Level Assessment')]"));
            }
        }

        private IWebElement buttonReports
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Reports')]"));
            }
        }

        private IWebElement buttonFeedback
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Feedback')]"));
            }
        }
    }
}
