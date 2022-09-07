using CSET_Selenium.Enums.Con_PCA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace CSET_Selenium.Helpers.Con_PCA
{
    class TableUtils
    {
        private readonly IWebDriver driver;
 
        public TableUtils(IWebDriver driver)
        {
            this.driver = driver;
        }

        /*All side menu main function pages have the same table class*/
        public IWebElement GetCommonTable()
        {
            return driver.FindElement(By.XPath("//mat-table[@class='mat-table cdk-table mat-sort']"));
        }

        public IList<IWebElement> GetCommonTableRows()
        {
            return GetCommonTable().FindElements(By.XPath(".//mat-row"));
        }

        public IList<IWebElement> GetTableRows(IWebElement table)
        {
            return table.FindElements(By.XPath(".//mat-row"));
        }

        public void ClickCommonTableRowByName(String name)
        {
            GetCommonTable().FindElement(By.XPath(".//mat-row/mat-cell[text() = ' " + name + " ']")).Click();
        }

        public List<String> GetColumnCellsListByLabelName(String name)
        {
            String classAttributeString = GetCommonTable().FindElement(By.XPath(".//div[text() = '" + name + "']/ancestor::mat-header-cell")).GetAttribute("class");
            String commonClassText = classAttributeString.Substring(classAttributeString.IndexOf("cdk-column-")); ;
            IList<IWebElement> rows = GetCommonTableRows();
            List<String> columnCellsList = new List<String>();
            for (var i = 0; i < rows.Count; i++)
            {
                columnCellsList.Add(rows[i].FindElement(By.XPath(".//mat-cell[contains(@class, '" + commonClassText + "')]")).Text.Trim());
            }
            return columnCellsList;
        }

        public void SortColumn(String columnName, Sort sort)
        {
            //IWebElement columnTitle = GetCommonTable().FindElement(By.XPath(".//div[text() = '" + columnName + "']"));
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            w.Until
            (ExpectedConditions.ElementIsVisible(By.XPath(".//div[text() = '" + columnName + "']")));
            IWebElement columnTitle = GetCommonTable().FindElement(By.XPath(".//div[text() = '" + columnName + "']"));
            columnTitle.Click();
            String ariaSort = columnTitle.FindElement(By.XPath("../..")).GetAttribute("aria-sort");
            do
            {
                columnTitle.Click();
            } while (!(columnTitle.FindElement(By.XPath("../..")).GetAttribute("aria-sort").Equals(sort.ToString())));
            driver.FindElement(By.XPath("//span[@class = 'loggin-user']")).Click();
        }
    }
}
