using CSET_Selenium.ConPCA_Repository.Con_PCA;
using CSET_Selenium.Enums.Domain_Manager;
using CSET_Selenium.Helpers.Con_PCA;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.Applications
{
    class Applications : ConPCABase
    {
        private readonly IWebDriver driver;
        private TableUtils table;

        public Applications(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            table = new TableUtils(driver);
        }

        //Element Locators

        private IWebElement ButtonAddNewApplication
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Add New Application ']"));
            }
        }

        private IWebElement ButtonCreateAndClose
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Create & Close ']"));
            }
        }


        private IWebElement TextboxAddNewApplicationName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@placeholder = ' The name of the new application']"));
            }
        }

        private IWebElement TextboxProgramLeadName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname = 'contactName']"));
            }
        }

        private IWebElement TextboxProgramLeadEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname = 'contactEmail']"));
            }
        }

        private IWebElement TextboxProgramLeadPhone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname = 'contactPhone']"));
            }
        }

        private IWebElement ButtonEdit
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Edit ']"));
            }
        }

        private IWebElement ButtonSave
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Save ']"));
            }
        }


        //Interaction Methods
        private void ClickAddNewApplicationButton()
        {
            ButtonAddNewApplication.Click();
        }

        private void ClickCreateAndCloseButton()
        {
            ButtonCreateAndClose.Click();
        }

        private void SetNewApplicationName(String name)
        {
            TextboxAddNewApplicationName.Clear();
            TextboxAddNewApplicationName.SendKeys(name);
        }

        //Aggregate Methods
        public void CreateNewApplication(String name)
        {
            ClickAddNewApplicationButton();
            SetNewApplicationName(name);
            ClickCreateAndCloseButton();
        }

        public IList<IWebElement> GetDomainsTableRows()
        {
            WaitUntilElementIsClickable(table.GetCommonTable(), 15);
            return table.GetCommonTableRows();
        }

        public bool FindApplicationByName(String name)
        {
            bool found = false;
            WaitUntilElementIsNotVisible(By.XPath(".//span[text()= 'Close']"));
            RefreshPage();
            WaitUntilElementIsNotVisible(By.XPath("//mat-spinner"));
            IWebElement theTable = table.GetCommonTable();
            if (CheckIfElementExists(theTable, 10))
            {

                IList<IWebElement> rows = GetDomainsTableRows();
                
                for (var i = 0; i < rows.Count; i++)
                {
                    
                    if (rows[i].Text.Contains(name))
                    {
                        found = true;
                        break;
                    }
                }
            }
            return found;
        }

        public void ClickApplicationsTableRowByName(String name)
        {
            table.GetCommonTable().FindElement(By.XPath(".//mat-row/mat-cell[text() = '" + name + "']")).Click();
        }

        public void ClickEditButton()
        {
            ButtonEdit.Click();
        }

        public void ClickSaveButton()
        {
            ButtonSave.Click();
        }

        public void SetProgramLeadName(String name)
        {
            TextboxProgramLeadName.Clear();
            TextboxProgramLeadName.SendKeys(name);
        }

        public void SetProgramLeadEmail(String email)
        {
            TextboxProgramLeadEmail.Clear();
            TextboxProgramLeadEmail.SendKeys(email);
        }

        public void SetProgramLeadPhone(String phone)
        {
            TextboxProgramLeadPhone.Clear();
            TextboxProgramLeadPhone.SendKeys(phone);
        }

        public String GetApplicationSummaryValue(String applicationName)
        {
            return Find(By.XPath("//div[text() = '" + applicationName + "']/following-sibling::div")).Text;
        }

        public void DeleteApplication(String applicationName)
        {
            table.GetCommonTable().FindElement(By.XPath(".//mat-cell[contains(text(), '" + applicationName + "')]/following-sibling::mat-cell[2]/button/span/mat-icon[text() = 'delete']")).Click();
            ClickConfirmFromPopup();
            WaitUntilSpinnerNotShowing();
        }
    }
}
