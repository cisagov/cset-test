using CSET_Selenium.ConPCA_Repository.Con_PCA;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums.Con_PCA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static System.Net.Mime.MediaTypeNames;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Subscriptions
{
    class Subscriptions : ConPCABase
    {
        private readonly IWebDriver driver;

        public Subscriptions(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement ButtonNewSubscription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' New Subscription ']"));
            }
        }

        private IWebElement ButtonAssignCustomer
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Assign Customer ']"));
            }
        }

        private IWebElement ButtonCreateSubscription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@type='submit']"));
            }
        }

        private IWebElement TableCustomer
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-table[@class='mat-table cdk-table mat-sort']"));
            }
        }

        private IWebElement SelectPrimaryContact
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-select[@formcontrolname='primaryContact']"));
            }
        }

        private IWebElement SelectAdminEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-select[@formcontrolname='adminEmail']"));
            }
        }

        private IWebElement SelectSendingProfile
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-select[@formcontrolname='sendingProfile']"));
            }
        }

        private IWebElement TextboxTargetEmailDomain
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='targetDomain']"));
            }
        }

        private IWebElement TextboxTargetRecipients
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@formcontrolname='csvText']"));
            }
        }

        private IWebElement TextNewSubcriptionName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-dialog-content[@formcontrolname='csvText']"));
            }
        }

        private IWebElement TableSubcriptions
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-table[@class='mat-table cdk-table mat-sort']"));
            }
        }

        //Interaction Methods

        private void ClickNewSubscriptionButton()
        {
            ButtonNewSubscription.Click();
        }

        private void ClickAssignCustomerButton()
        {
            ButtonAssignCustomer.Click();
        }

        private void ClickCreateSubscriptionButton()
        {
            ButtonCreateSubscription.Click();
        }

        private void ClickEmailDomain()
        {
            ClickWhenClickable(TextboxTargetEmailDomain);
        }

        private void ClickTargetRecipients()
        {
            ClickWhenClickable(TextboxTargetRecipients);
        }

        //Aggregate Methods
        public void CreateNewSubscription()
        {
            ClickNewSubscriptionButton();
        }

        public void AssignCustomer()
        {
            ClickAssignCustomerButton();
        }

        public IWebElement GetCustomerTable()
        {
            return TableCustomer;
        }

        public IWebElement GetSubscriptionsTable()
        {
            return TableSubcriptions;
        }

        //public ReadOnlyCollection<IWebElement> GetSubscriptionsTableRows()
        public IList<IWebElement> GetSubscriptionsTableRows()
        {
            return GetSubscriptionsTable().FindElements(By.XPath(".//mat-row"));
        }

        public void ClickCustomerTableRowByName(String name)
        {
            //if (name.Contains("'"))
            //{
            //    name = name.Replace("'", "\'");
            //}
            //GetCustomerTable().FindElement(By.XPath("mat-row/mat-cell[text() = ' " + name + " ']")).Click();
            GetCustomerTable().FindElement(By.XPath("mat-row/mat-cell[contains(text(), \"" + name + "\")]")).Click();
        }

        public void SelectPrimaryContactByName(String contactName)
        {
            ClickWhenClickable(SelectPrimaryContact);
            driver.FindElement(By.XPath("//span[text()=' " + contactName + " ']")).Click();
        }

        public void SelectPrimaryContactByIndex(int index)
        {
            ClickWhenClickable(SelectPrimaryContact);
            driver.FindElement(By.XPath("//div/mat-option[" + (index + 1) + "]")).Click();
        }

        public void SelectAdminEmailByIndex(int index)
        {
            ClickWhenClickable(SelectAdminEmail);
            driver.FindElement(By.XPath("//div/mat-option[" + (index + 1) + "]")).Click();
        }

        public void SelectSendingProfileByIndex(int index)
        {
            ClickWhenClickable(SelectSendingProfile);
            driver.FindElement(By.XPath("//div/mat-option[" + (index + 1) + "]")).Click();
        }

        public void SetTargetEmailDomain(String emailDomain)
        {
            ClickEmailDomain();
            TextboxTargetEmailDomain.SendKeys(Keys.Control + "a");
            TextboxTargetEmailDomain.SendKeys(Keys.Delete);
            TextboxTargetEmailDomain.SendKeys(emailDomain);
        }

        public void SetTargetRecipients(String recipients)
        {
            ClickTargetRecipients();
            TextboxTargetRecipients.SendKeys(Keys.Control + "a");
            TextboxTargetRecipients.SendKeys(Keys.Delete);
            TextboxTargetRecipients.SendKeys(recipients);
        }

        public String Submit()
        {
            ClickCreateSubscriptionButton();
            //get newly created subscription name
            String xpath = ".//mat-dialog-content/div[contains(text(), 'Your subscription was created as')]";

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //IWebElement title = wait.Until<IWebElement>((d) =>
            //{
            //    return d.FindElement(By.XPath(xpath));
            //});
            WebDriverWait w = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            w.Until
            (ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            IWebElement popUpMsg = driver.FindElement(By.XPath(xpath));
            String subscriptionName = popUpMsg.Text.Split(' ')[5];
            popUpMsg.FindElement(By.XPath("../../following-sibling::div/mat-dialog-actions/button/span[text() = ' OK ']")).Click();

            return subscriptionName;
        }

        public String getTitleClassByColumnName(String name)
        {
            String tmp = GetSubscriptionsTable().FindElement(By.XPath(".//mat-header-cell[//div/div[text() = '"+name+"']]")).GetAttribute("class");
            return tmp;
        }

        public List<String> GetColumnCellsListByLabelName(String name)
        {           
            String classAttributeString = GetSubscriptionsTable().FindElement(By.XPath(".//div[text() = '" + name + "']/ancestor::mat-header-cell")).GetAttribute("class");
            String commonClassText = classAttributeString.Substring(classAttributeString.IndexOf("cdk-column-")); ;
            IList<IWebElement> rows = GetSubscriptionsTableRows();
            List<String> columnCellsList = new List<String>();
            for (var i = 0; i < rows.Count; i++)
            {
                columnCellsList.Add(rows[i].FindElement(By.XPath(".//mat-cell[contains(@class, '" + commonClassText + "')]")).Text.Trim());
            }
            return columnCellsList;
        }

        public void SortColumn(String columnName, Sort sort)
        {
            IWebElement columnTitle = GetSubscriptionsTable().FindElement(By.XPath(".//div[text() = '" + columnName + "']"));
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