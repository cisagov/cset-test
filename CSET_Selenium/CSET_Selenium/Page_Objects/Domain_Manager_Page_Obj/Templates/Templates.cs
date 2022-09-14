using CSET_Selenium.ConPCA_Repository.Con_PCA;
using CSET_Selenium.Helpers.Con_PCA;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.Templates
{
    class Templates : ConPCABase
    {
        private readonly IWebDriver driver;
        private TableUtils table;

        public Templates(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            //private TableUtils table = new TableUtils(driver);
            table = new TableUtils(driver);
        }

        //Element Locators

        private IWebElement ButtonUploadTemplates
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Upload Template ']"));
            }
        }


        private IWebElement ButtonSelectFiles
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() = ' Select Files ']"));
            }
        }

        

        //Interaction Methods
        private void ClickUploadTemplateButton()
        {
            ButtonUploadTemplates.Click();
        }

        private void ClickSelectFilesButton()
        {
            ButtonSelectFiles.Click();
        }

        //Aggregate Methods


        public IList<IWebElement> GetTemplatesTableTemplateList()
        {
            WaitUntilElementIsClickable(table.GetCommonTable(), 15);

            return table.GetCommonTableRows();
        }

        public void ClickTemplatesTableRowByName(String name)
        {
            table.GetCommonTable().FindElement(By.XPath(".//mat-row/mat-cell[text() = '" + name + "']")).Click();
        }

        public void ClickTab(String tabName)
        {
            Find(By.XPath(".//div[@role = 'tab']/div[contains(text(), '"+tabName+"')]")).Click();
        }

        public List<String> GetDomainsUsingTabDomainNameList()
        {
            List<String> domainNamesList = new List<String>();
            IList<IWebElement> allRows = driver.FindElements(By.XPath("//div[text() = ' A list of all domains that are currently using this template ']/following-sibling::div/mat-table/mat-row"));
            if (allRows.Count != 0)
            {
                foreach (IWebElement ele in allRows)
                {
                    String tmp = ele.FindElement(By.XPath(".//mat-cell[1]")).Text;
                    Console.WriteLine("Domain Name is " + tmp);
                    //domainNamesList.Add(ele.FindElement(By.XPath(".//mat-cell[1]")).Text);
                    domainNamesList.Add(tmp);
                }
            }
            return domainNamesList;
        }


    }
}
