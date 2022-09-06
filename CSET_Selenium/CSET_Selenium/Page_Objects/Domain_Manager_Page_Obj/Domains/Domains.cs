using System;
using System.Collections.Generic;
using CSET_Selenium.ConPCA_Repository.Con_PCA;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Helpers.Con_PCA;
using OpenQA.Selenium;


namespace CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.Domains
{
    class Domains : ConPCABase
    {
        private readonly IWebDriver driver;
        

        public Domains(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            //private TableUtils table = new TableUtils(driver);
    }

        //Element Locators

        private IWebElement ButtonAddNewDomains
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='  Add New Domains  ']"));
            }
        }

       
        private IWebElement ButtonAddNewDomainsSubmit
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h2[text()='Add New Domains']/following-sibling::mat-dialog-actions/button/span[text() = ' Submit ']"));
            }
        }

        private IWebElement TextboxAddNewDomainsDomainURL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h2[text()='Add New Domains']/following-sibling::form/div[2]//mat-form-field/div/div/div[3]/textarea"));
            }
        }

        

        //Interaction Methods
        private void ClickAddNewDomainsButton()
        {
            ButtonAddNewDomains.Click();
        }

        private void ClickAddNewDomainsSubmitButton()
        {
            ButtonAddNewDomainsSubmit.Click();
        }

        

        //Aggregate Methods
        

        public void SetAddNewDomainURL(String URL)
        {
            TextboxAddNewDomainsDomainURL.SendKeys(URL);
        }


        public bool FindLandingPageByName(String name)
        {
            TableUtils table = new TableUtils(driver);
            IList<IWebElement> rows = table.GetCommonTableRows();
            bool found = false;
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(name))
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public void AddNewDomain(String URL)
        {
            ClickAddNewDomainsSubmitButton();
            SetAddNewDomainURL(URL);
            ClickAddNewDomainsSubmitButton();
        }

        
    }
}
