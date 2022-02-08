using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Target_Level_Selection
{
    class TargetLevelSelectionCMMC2 : BasePage
    {
        private readonly IWebDriver driver;

        public TargetLevelSelectionCMMC2(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement CardLevel1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(),'Level 1')]"));
            }
        }

        private IWebElement CardLevel2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(),'Level 2')]"));
            }
        }

        //Interaction Methods

        private void ClickLevel1()
        {
            CardLevel1.Click();
        }

        private void ClickLevel2()
        {
            CardLevel2.Click();
        }

        //Aggregate Methods

        public void SelectLevel1()
        {
            ClickLevel1();
            ClickNext();
        }

        public void SelectLevel2()
        {
            ClickLevel2();
            ClickNext();
        }
    }
}
