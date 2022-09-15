using System;
using System.Collections.Generic;
using System.Threading;
using CSET_Selenium.ConPCA_Repository.Con_PCA;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Helpers.Con_PCA;
using OpenQA.Selenium;


namespace CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.Domains
{
    class Domains : ConPCABase
    {
        private readonly IWebDriver driver;
        private TableUtils table;

        public Domains(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            //private TableUtils table = new TableUtils(driver);
             table = new TableUtils(driver);
        }

        //Element Locators

        private IWebElement ButtonAddNewDomains
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Add New Domains ']"));
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

        private IWebElement TabTemplate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@class = 'mat-tab-labels']/div/div[contains(text(), 'Template')]"));
            }
        }

        private IWebElement RadioButtonSelectFromTemplate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), ' Select from templates ')]"));
            }
        }

        private IWebElement TableTemplate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-table[@class = 'mat-table cdk-table mat-sort mb-5']"));
            }
        }

        private IWebElement ButtonCreateDomainHTML
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() = ' Create Domain HTML ']"));
            }
        }

        private IWebElement ButtonOptions
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() = ' Options ']"));
            }
        }

        private IWebElement LinkDelete
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-icon[text() = 'delete']"));
            }
        }

        private IWebElement TextboxSearch
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@placeholder = 'Search']"));
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

        private void ClickTemplateTab()
        {
            ClickWhenClickable(TabTemplate);
        }

        private void ClickSelectFromTemplatesRadioButton()
        {
            ClickWhenClickable(RadioButtonSelectFromTemplate);
        }

        private IWebElement GetTemplateTable()
        {
            return TableTemplate;
        }

        private void ClickCreateDomainHTMLButton()
        {
            ClickWhenClickable(ButtonCreateDomainHTML);
        }

        private void ClickOptionsButton()
        {
            ClickWhenClickable(ButtonOptions);
        }

        private void ClickOptionsDelete()
        {
            ClickWhenClickable(LinkDelete);
        }

        private void SetSearchBox(String searchStr)
        {
            TextboxSearch.SendKeys(searchStr);
        }

        //Aggregate Methods


        public void SetAddNewDomainURL(String URL)
        {
            TextboxAddNewDomainsDomainURL.SendKeys(URL);
        }

        public IList<IWebElement> GetDomainsTableRows()
        {
            WaitUntilElementIsClickable(table.GetCommonTable(), 15);
            return table.GetCommonTableRows();
        }


        public bool FindDomainByName(String name)
        {
            bool found = false;
            WaitUntilElementIsNotVisible(By.XPath(".//span[text()= 'Close']"));
            RefreshPage();
            WaitUntilElementIsNotVisible(By.XPath("//mat-spinner"));
            IWebElement theTable = table.GetCommonTable();
            if (CheckIfElementExists(theTable, 10))
            {

                IList<IWebElement> rows = GetDomainsTableRows();
                Console.WriteLine("Found the table and rows are " + rows.Count);
                for (var i = 0; i < rows.Count; i++)
                {
                    Console.WriteLine("Row is : " + rows[i].Text);
                    if (rows[i].Text.Contains(name))
                    {
                        found = true;
                        break;
                    }
                }             
            }
            else
            {
                Console.WriteLine("didn't find the table");
                throw new ElementNotVisibleException("The Domains table is not showing");
            }
            return found;
        }

        public void AddNewDomain(String URL)
        {
            ClickAddNewDomainsButton();
            SetAddNewDomainURL(URL);
            ClickAddNewDomainsSubmitButton();
            ClickCloseFromPopup();
            WaitUntilElementIsClickable(table.GetCommonTable(), 60);
            WaitUntilElementIsNotVisible(By.XPath("//mat-spinner"));
        }

        public void ClickDomainsTableRowByName(String name)
        {
            table.GetCommonTable().FindElement(By.XPath(".//mat-row/mat-cell[text() = '" + name + "']")).Click();
        }

        public void ClickSelectButtonInTableByTemplateName(String name)
        {
            IWebElement templateTable = GetTemplateTable();
            templateTable.FindElement(By.XPath(".//mat-row/mat-cell[text()='" + name + "']/following-sibling::mat-cell[2]/button/span[text()=' Select ']")).Click();
        }

        public void SelectTemplate(String template)
        {
            ClickTemplateTab();
            ClickSelectFromTemplatesRadioButton();

            ClickSelectButtonInTableByTemplateName(template);
            ClickCreateDomainHTMLButton();
            WaitUntilElementIsVisible(By.XPath("//div[text() = 'A demo of the domain as it will be seen directly']"));
        }

        public void DeleteDomain(String domainName)
        {
            ClickDomainsTableRowByName(domainName);
            ClickOptionsButton();
            ClickOptionsDelete();
            ClickConfirmFromPopup();
            WaitUntilElementIsNotVisible(By.XPath("//mat-spinner"));
            
        }

        public void SearchDomain(String searchString)
        {
            SetSearchBox(searchString);
            Find(By.XPath("//mat-icon[text() = 'search']")).Click();

        }

    }
}
