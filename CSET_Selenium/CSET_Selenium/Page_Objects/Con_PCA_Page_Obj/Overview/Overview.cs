using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.ConPCA_Repository.Con_PCA;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Overview
{
    class Overview : ConPCABase
    {
        private readonly IWebDriver driver;

        public Overview(IWebDriver driver) : base(driver)
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
            GetCustomerTable().FindElement(By.XPath(".//mat-row/mat-cell[text() = ' " + name + " ']")).Click();
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
    }
}
