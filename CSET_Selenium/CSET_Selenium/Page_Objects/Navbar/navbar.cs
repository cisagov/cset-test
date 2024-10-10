using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Navbar
{
    class Navbar : BasePage
    {
        private readonly IWebDriver driver;

        public Navbar(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement ButtonLandingPage
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(@class, 'btn btn-link navbar-brand')]"));
            }
        }

        private IWebElement DropdownHelp
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(),'Help')]"));
            }
        }

        private IWebElement TextLinkCSETUserGuide
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='User Guide']"));
            }
        }

        private IWebElement DropdownUserGuides
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'User Guides')]"));
            }
        }

        private IWebElement TextLinkCSETAcetUserGuide
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='ACET']"));
            }
        }

        private IWebElement TextLinkCSETCMMC2UserGuide
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='CMMC 2.0']"));
            }
        }

        private IWebElement TextLinkCSETCRRUserGuide
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='CRR']"));
            }
        }

        private IWebElement TextLinkCSETEDMUserGuide
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='EDM']"));
            }
        }

        private IWebElement TextLinkCSETRansomewareReadinessUserGuide
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Ransomware Readiness']"));
            }
        }


        //Interaction Methods

        private void ClickHelpDropdown()
        {
            DropdownHelp.Click();
        }

        private void ClickCSETUserGuideText()
        {
            TextLinkCSETUserGuide.Click();
        }


        //Aggregate Methods

        public void OpenCSETUserGuide()
        {
            ClickHelpDropdown();
            ClickCSETUserGuideText();
        }

    }
}
