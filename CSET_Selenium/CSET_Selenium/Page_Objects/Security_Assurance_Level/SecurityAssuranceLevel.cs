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



        //Interaction Methods

        private void ClickHeaderSimple()
        {
            TextHeaderSimple.Click();
        }

        private void ClickHeaderGeneralRiskBased()
        {
            TextHeaderGeneralRiskBased.Click();
        }




        //Aggregate Methods

        public void SelectHeaderSimple()
        {
            ClickHeaderSimple();
        }

        public void SelectHeaderGeneralRiskBased()
        {
            ClickHeaderGeneralRiskBased();
        }

        
    }
}
