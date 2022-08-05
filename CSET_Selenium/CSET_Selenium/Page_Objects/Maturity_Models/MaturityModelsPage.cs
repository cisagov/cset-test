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

        private IWebElement CardCIS
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h4[contains(text(),'CISA Cyber Infrastructure Survey')]"));
            }
        }

        private IWebElement Level5Cmmc1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Level 5')]"));
            }
        }

        private IWebElement Level2Cmmc2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Level 2')]"));
            }
        }
        
        private IWebElement CriticalServiceName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='criticalServiceName']")); 
            }
        }

        private IWebElement CriticalServicDescription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='criticalServiceDescription']"));
            }
        }

        private IWebElement ITICSName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='itIcsName']"));
            }
        }

        private IWebElement NetworksDescription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@id='networksDescription']"));
            }
        }

        private IWebElement ServicessDescription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@id='servicesDescription']"));
            }
        }

        private IWebElement ApplicationsDescription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@id='applicationsDescription']"));
            }
        }

        private IWebElement connectionsDescription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@id='connectionsDescription']"));
            }
        }

        private IWebElement personnelDescription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@name='personnelDescription']"));
            }
        }

        //Interaction Methods
        private void ClickCritialServiceName()
        {
            CriticalServiceName.Click();
        }

        private void ClickCritialServiceDescription()
        {
            CriticalServicDescription.Click();
        }

        private void ClickITICSName()
        {
            ITICSName.Click();
        }

        private void ClickCyberBudgetBasis()
        {
            driver.FindElements(By.XPath("//div[@id='budgetBasis']//label"));
        }

        private void ClickTotalITStaff()
        {
            driver.FindElements(By.XPath("//div[@id='totalITStaff']//label"));
        }

        private void ClickAuthOrgUserCount()
        {
            driver.FindElements(By.XPath("//div[@id='authorizedOrganizationalUserCount']//label"));
        }

        private void ClickNonAuthOrgUserCount()
        {
            driver.FindElements(By.XPath("//div[@id='authorizedNonOrganizationalUserCount']//label"));
        }

        private void ClickCustomerCount()
        {
            driver.FindElements(By.XPath("//div[@id='customersCount']"));
        }

        private void CriticalDefenseSystems()
        {
            driver.FindElements(By.XPath("//div//input[@type='checkbox']"));

        }

        private void CISQuestions()
        {
            driver.FindElements(By.XPath("//label"));
        }

        private void ClickLevel2Cmmc2()
        {
            Level2Cmmc2.Click();
        }

        private void ClickLevel5Cmmc1()
        {
            Level5Cmmc1.Click();
        }

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

        private void ClickCIS()
        {
            CardCIS.Click();
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
            ClickNext();
            ClickLevel5Cmmc1();
            ClickNext();
        }

        public void SelectCMMC2()
        {
            ClickCMMC2();
            ClickNext();
            ClickLevel2Cmmc2();
            ClickNext();
            ClickNext();
        }

        public void SelectEDM()
        {
            ClickEDM();
            ClickNext();
            ClickNext();
        }

        public void SelectCIS()
        {
            ClickCIS();
            ClickNext();
            ClickNext();
            ClickNext();
        }

        public void SelectCRR()
        {
            ClickCRR();
            ClickNext();
            ClickNext();
        }

        public void SelectRRA()
        {
            ClickRRA();
            ClickNext();
            ClickNext();
        }
    }
}

