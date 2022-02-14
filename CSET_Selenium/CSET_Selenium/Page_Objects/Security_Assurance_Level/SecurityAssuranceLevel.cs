using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Security_Assurance_Level
{
    class SecurityAssuranceLevel : BasePage
    {
        private readonly IWebDriver driver;

        public SecurityAssuranceLevel(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement TextHeaderSimple
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(),'Simple')]"));
            }
        }

        private IWebElement TextHeaderGeneralRiskBased
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(),'General Risk Based')]"));
            }
        }

        private IWebElement TextHeaderNist
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(),'NIST-60 / FIPS-199')]"));
            }
        }


        private IWebElement TextHeaderOverallSalLow
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Overall SAL')]/..//label[contains(text(),'Low')]"));
            }
        }

        private IWebElement TextHeaderOverallSalModerate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Overall SAL')]/..//label[contains(text(),'Moderate')]"));
            }
        }
        private IWebElement TextHeaderOverallSalHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Overall SAL')]/..//label[not(contains(text(), 'Very')) and contains(text(),'High')]"));
            }
        }
        private IWebElement TextHeaderOverallSalVeryHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Overall SAL')]/..//label[contains(text(),'Very High')]"));
            }
        }
        //confidentiality
        private IWebElement TextHeaderConfidentialityLow
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Confidentiality')]/..//label[contains(text(),'Low')]"));
            }
        }

        private IWebElement TextHeaderConfidentialityModerate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Confidentiality')]/..//label[contains(text(),'Moderate')]"));
            }
        }
        private IWebElement TextHeaderConfidentialityHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Confidentiality')]/..//label[not(contains(text(), 'Very')) and contains(text(),'High')]"));
            }
        }
        private IWebElement TextHeaderConfidentialityVeryHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Confidentiality')]/..//label[contains(text(),'Very High')]"));
            }
        }
        //integrity
        private IWebElement TextHeaderIntegrityLow
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Integrity')]/..//label[contains(text(),'Low')]"));
            }
        }

        private IWebElement TextHeaderIntegrityModerate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Integrity')]/..//label[contains(text(),'Moderate')]"));
            }
        }
        private IWebElement TextHeaderIntegrityHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Integrity')]/..//label[not(contains(text(), 'Very')) and contains(text(),'High')]"));
            }
        }
        private IWebElement TextHeaderIntegrityVeryHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Integrity')]/..//label[contains(text(),'Very High')]"));
            }
        }

        //availability
        private IWebElement TextHeaderAvailabilityLow
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Availability')]/..//label[contains(text(),'Low')]"));
            }
        }

        private IWebElement TextHeaderAvailabilityModerate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Availability')]/..//label[contains(text(),'Moderate')]"));
            }
        }
        private IWebElement TextHeaderAvailabilityHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Availability')]/..//label[not(contains(text(), 'Very')) and contains(text(),'High')]"));
            }
        }
        private IWebElement TextHeaderAvailabilityVeryHigh
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Availability')]/..//label[contains(text(),'Very High')]"));
            }
        }


        //Interaction Methods

        private void ClickHeaderSimple()
        {
            TextHeaderSimple.Click();
        }

        private void ClickHeaderGeneralRiskBased()
        {
            TextHeaderGeneralRiskBased.Click();
        }
        private void ClickHeaderNist()
        {
            TextHeaderNist.Click();
        }

        private void ClickHeaderOverallSalLow()
        {
            TextHeaderOverallSalLow.Click();
        }

        private void ClickHeaderOverallSalModerate()
        {
            TextHeaderOverallSalModerate.Click();
        }

        private void ClickHeaderOverallSalHigh()
        {
            TextHeaderOverallSalHigh.Click();
        }

        private void ClickHeaderOverallSalVeryHigh()
        {
            TextHeaderOverallSalVeryHigh.Click();
        }

        private void ClickHeaderConfidentialityLow()
        {
            TextHeaderConfidentialityLow.Click();
        }

        private void ClickHeaderConfidentialityModerate()
        {
            TextHeaderConfidentialityModerate.Click();
        }

        private void ClickHeaderConfidentialityHigh()
        {
            TextHeaderConfidentialityHigh.Click();
        }

        private void ClickHeaderConfidentialityVeryHigh()
        {
            TextHeaderConfidentialityVeryHigh.Click();
        }

        private void ClickHeaderIntegrityLow()
        {
            TextHeaderIntegrityLow.Click();
        }

        private void ClickHeaderIntegrityModerate()
        {
            TextHeaderIntegrityModerate.Click();
        }

        private void ClickHeaderIntegrityHigh()
        {
            TextHeaderIntegrityHigh.Click();
        }

        private void ClickHeaderIntegrityVeryHigh()
        {
            TextHeaderIntegrityVeryHigh.Click();
        }

        private void ClickHeaderAvailabilityLow()
        {
            TextHeaderAvailabilityLow.Click();
        }

        private void ClickHeaderAvailabilityModerate()
        {
            TextHeaderAvailabilityModerate.Click();
        }

        private void ClickHeaderAvailabilityHigh()
        {
            TextHeaderAvailabilityHigh.Click();
        }

        private void ClickHeaderAvailabilityVeryHigh()
        {
            TextHeaderAvailabilityVeryHigh.Click();
        }

        //Aggregate Methods

        public void SelectHeaderSimple()
        {
            ClickHeaderSimple();
            SelectHeaderOverallSalLow();
            SelectHeaderOverallSalModerate();
            SelectHeaderOverallSalHigh();
            SelectHeaderOverallSalVeryHigh();
            SelectHeaderConfidentialityLow();
            SelectHeaderConfidentialityModerate();
            SelectHeaderConfidentialityHigh();
            SelectHeaderConfidentialityVeryHigh();
            SelectHeaderIntegrityLow();
            SelectHeaderIntegrityModerate();
            SelectHeaderIntegrityHigh();
            SelectHeaderIntegrityVeryHigh();
            SelectHeaderAvailabilityLow();
            SelectHeaderAvailabilityModerate();
            SelectHeaderAvailabilityHigh();
            SelectHeaderAvailabilityVeryHigh();
            ClickNext();
        }

        public void SelectHeaderGeneralRiskBased()
        {
            ClickHeaderGeneralRiskBased();
        }

        public void SelectHeaderNist()
        {
            ClickHeaderNist();
        }

        public void SelectHeaderOverallSalLow()
        {
            ClickHeaderOverallSalLow();
        }

        public void SelectHeaderOverallSalModerate()
        {
            ClickHeaderOverallSalModerate();
        }
        public void SelectHeaderOverallSalHigh()
        {
            ClickHeaderOverallSalHigh();
        }
        public void SelectHeaderOverallSalVeryHigh()
        {
            ClickHeaderOverallSalVeryHigh();
        }

        public void SelectHeaderConfidentialityLow()
        {
            ClickHeaderConfidentialityLow();
        }

        public void SelectHeaderConfidentialityModerate()
        {
            ClickHeaderConfidentialityModerate();
        }

        public void SelectHeaderConfidentialityHigh()
        {
            ClickHeaderConfidentialityHigh();
        }

        public void SelectHeaderConfidentialityVeryHigh()
        {
            ClickHeaderConfidentialityVeryHigh();
        }

        public void SelectHeaderIntegrityLow()
        {
            ClickHeaderIntegrityLow();
        }

        public void SelectHeaderIntegrityModerate()
        {
            ClickHeaderIntegrityModerate();
        }

        public void SelectHeaderIntegrityHigh()
        {
            ClickHeaderIntegrityHigh();
        }

        public void SelectHeaderIntegrityVeryHigh()
        {
            ClickHeaderIntegrityVeryHigh();
        }

        public void SelectHeaderAvailabilityLow()
        {
            ClickHeaderAvailabilityLow();
        }

        public void SelectHeaderAvailabilityModerate()
        {
            ClickHeaderAvailabilityModerate();
        }

        public void SelectHeaderAvailabilityHigh()
        {
            ClickHeaderAvailabilityHigh();
        }

        public void SelectHeaderAvailabilityVeryHigh()
        {
            ClickHeaderAvailabilityVeryHigh();
        }
    }
}
