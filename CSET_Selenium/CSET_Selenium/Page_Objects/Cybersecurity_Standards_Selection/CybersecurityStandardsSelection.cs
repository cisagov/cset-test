using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Cybersecurity_Standards_Selection
{
    class CybersecurityStandardsSelection : BasePage
    {
        private readonly IWebDriver driver;

        public CybersecurityStandardsSelection(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement checkboxNerc_CIP_Rev6
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'NERC_CIP_R6')]"));
            }
        }


        //Interaction Methods

        private void setNerc_CIP_Rev6()
        {
            checkboxNerc_CIP_Rev6.Click();
        }




        //Aggregate Methods

        public void SetNerc_CIP_Rev6()
        {
            setNerc_CIP_Rev6();
            ClickNext();
        }
    }
}
