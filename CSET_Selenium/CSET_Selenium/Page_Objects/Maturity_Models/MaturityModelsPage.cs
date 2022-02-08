using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Maturity_Models
{
    class MaturityModelsPage : BasePage
    {
        private readonly IWebDriver driver;

        public MaturityModelsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement CardACET
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'ACET')] | //input[contains(@id, 'acet')]"));
            }
        }

        private IWebElement CardCMMCVer1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'(CMMC) 1')] | //input[contains(@id, 'cmmc')]"));
            }
        }

        private IWebElement CardCMMCVer2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'CMMC 2')]"));
            }
        }

        private IWebElement CardEDM
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'EDM')] | //input[contains(@id, 'edm')]"));
            }
        }

        private IWebElement CardCRR
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'CRR')]"));
            }
        }

        private IWebElement CardRRA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'Ransomware Readiness Assessment')] | //input[contains(@id, 'rra')]"));
            }
        }

        //Interaction Methods

        private void ClickACET()
        {
            CardACET.Click();
        }

        private void ClickCMMC1()
        {
            CardCMMCVer1.Click();
        }

        private void ClickCMMC2()
        {
            CardCMMCVer2.Click();
        }

        private void ClickEDM()
        {
            CardEDM.Click();
        }

        private void ClickCRR()
        {
            CardCRR.Click();
        }

        private void ClickRRA()
        {
            CardRRA.Click();
        }


        //Aggregate Methods

        public void SelectACET()
        {
            ClickACET();
            ClickNext();
        }

        public void SelectCMMC1()
        {
            ClickCMMC1();
            ClickNext();
        }

        public void SelectCMMC2()
        {
            ClickCMMC2();
            ClickNext();
        }

        public void SelectEDM()
        {
            ClickEDM();
            ClickNext();
        }

        public void SelectCRR()
        {
            ClickCRR();
            ClickNext();
        }

        public void SelectRRA()
        {
            ClickRRA();
            ClickNext();
        }
    }
}

