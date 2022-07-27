using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Enums;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Customers
{
    class Customers : BasePage
    {
        private readonly IWebDriver driver;

        public Customers(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element   Locators

        private IWebElement ButtonNewCustomer
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' New Customer ']"));
            }
        }

        private IWebElement ButtonAddContact
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Add Contact ']"));
            }
        }

        private IWebElement TextboxCustomerName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='customerName']"));
            }
        }

        private IWebElement TextboxCustomerDomain
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='domain']"));
            }
        }

        private IWebElement TextboxCustomerType
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-select[@formcontrolname='customerType']"));
            }
        }

        private IWebElement TextboxCustomerIdentifier
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='customerIdentifier']"));
            }
        }

        private IWebElement TextboxCustomerAddress1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='address1']"));
            }
        }

        private IWebElement TextboxCustomerCity
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='city']"));
            }
        }

        private IWebElement TextboxCustomerState
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='state']"));
            }
        }

        private IWebElement TextboxCustomerZIP
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='zip']"));
            }
        }

        private IWebElement TextboxCustomerFirstName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='firstName']"));
            }
        }

        private IWebElement TextboxCustomerLastName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='lastName']"));
            }
        }

        private IWebElement TextboxCustomerEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='email']"));
            }
        }

        private IWebElement ButtonNewCustomerOrgContactsAdd
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Add ']"));
            }
        }

        private IWebElement ButtonSaveCustomer
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Save Customer ']"));
            }
        }

        private IWebElement CustomersTable
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-table[@class ='mat-table cdk-table mat-sort']"));
            }
        }

        private IWebElement CustomerOrgContactsTable
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//table[@class ='mat-table cdk-table mat-elevation-z1 flex-grow-1 ng-star-inserted']"));
            }
        }

        private IWebElement SaveButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() =' Save ']"));
            }
        }

        private IWebElement DeleteCustomerButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() =' Delete Customer ']"));
            }
        }

        private IWebElement ConfirmDeleteYesButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() =' Yes ']"));
            }
        }

        private IWebElement OKButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() =' OK ']"));
            }
        }
        //Interaction Methods

        private void ClickNewCustomerButton()
        {
            ButtonNewCustomer.Click();
        }

        private void ClickAddContactButton()
        {
            ButtonAddContact.Click();
        }

        private void ClickCustomerOrgContactsAddButton()
        {
            ButtonNewCustomerOrgContactsAdd.Click();
        }

        private void ClickSaveCustomerButton()
        {
            ButtonSaveCustomer.Click();
        }

        private void SetCustomerName(String customerName)
        {
            ClickWhenClickable(TextboxCustomerName);
            TextboxCustomerName.SendKeys(customerName);
        }

        private void SelectCustomerType(String customerType)
        {
            ClickWhenClickable(TextboxCustomerType);
            driver.FindElement(By.XPath("//span[text()='" + customerType + "']")).Click();
        }

        private void SetCustomerDomain(String customerDomain)
        {
            ClickWhenClickable(TextboxCustomerDomain);
            TextboxCustomerDomain.SendKeys(customerDomain);
        }

        private void SetCustomerIdentifier(String customerID)
        {
            ClickWhenClickable(TextboxCustomerIdentifier);
            TextboxCustomerIdentifier.SendKeys(Keys.Control + "a");
            TextboxCustomerIdentifier.SendKeys(Keys.Delete);
            TextboxCustomerIdentifier.SendKeys(customerID);
        }

        private void SetCustomerAddress1(String customerAddress1)
        {
            ClickWhenClickable(TextboxCustomerAddress1);
            TextboxCustomerAddress1.SendKeys(customerAddress1);
        }

        private void SetCustomerCity(String customerCity)
        {
            ClickWhenClickable(TextboxCustomerCity);
            TextboxCustomerCity.SendKeys(customerCity);
        }

        private void SetCustomerState(String state)
        {
            ClickWhenClickable(TextboxCustomerState);
            TextboxCustomerState.SendKeys(state);
        }

        private void SetCustomerZIP(String zip)
        {
            ClickWhenClickable(TextboxCustomerZIP);
            TextboxCustomerZIP.SendKeys(zip);
        }

        private void SetCustomerFirstName(String firstName)
        {
            ClickWhenClickable(TextboxCustomerFirstName);
            TextboxCustomerFirstName.SendKeys(firstName);
        }

        private void SetCustomerLastName(String lastName)
        {
            ClickWhenClickable(TextboxCustomerLastName);
            TextboxCustomerLastName.SendKeys(lastName);
        }

        private void SetCustomerEmail(String email)
        {
            ClickWhenClickable(TextboxCustomerEmail);
            TextboxCustomerEmail.SendKeys(email);
        }

        private void ClickSaveButton()
        {
            ClickWhenClickable(SaveButton);
        }

        private void ClickDeleteCustomerButton()
        {
            ClickWhenClickable(DeleteCustomerButton);
        }

        private void ClickConfirmDeleteYesButton()
        {
            ClickWhenClickable(ConfirmDeleteYesButton);
        }

        private void ClickOKButton()
        {
            ClickWhenClickable(OKButton);
        }

        //Aggregate Methods
        public void EditCustomerIdentifier(String id)
        {
            SetCustomerIdentifier(id);
            ClickSaveCustomerButton();
            ClickSaveButton();
        }
        public void CreateNewCustomer(CustomerTypes customerType)
        {
            ClickNewCustomerButton();
            SelectCustomerType(customerType.GetValue());
            SetCustomerName(Customer.Customer_Name.GetValue());
            SetCustomerDomain(Customer.Customer_Domain.GetValue());
            SetCustomerIdentifier(Customer.Customer_Identifier.GetValue());
            SetCustomerAddress1(Customer.Address1.GetValue());
            SetCustomerCity(Customer.City.GetValue());
            SetCustomerState(Customer.State.GetValue());
            SetCustomerZIP(Customer.ZIP.GetValue());
            ClickAddContactButton();
            SetCustomerFirstName(Customer.First_Name.GetValue());
            SetCustomerLastName(Customer.Last_Name.GetValue());
            SetCustomerEmail(Customer.Customer_Email.GetValue());
            ClickCustomerOrgContactsAddButton();
            ClickSaveCustomerButton();
        }

        public IWebElement GetCustomerTable()
        {
            return CustomersTable;
        }

        public IWebElement GetCustomerOrgContactsTable()
        {
            return CustomerOrgContactsTable;
        }

        public IList<IWebElement> GetCustomerTableRows()
        {
            IList<IWebElement> rows;           
            rows =   GetCustomerTable().FindElements(By.TagName("mat-row"));
            return rows;
        }

        public String GetCustomerNameByRowNumber(int rowNum)
        {
            IList<IWebElement> rows = GetCustomerTableRows();
            return rows[rowNum - 1].Text.Split('\r')[0];                    
        }

        public void ClickCustomersTableEditByIdentifier(String id)
        {           
            IList<IWebElement> rows = GetCustomerTableRows();           
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].FindElement(By.XPath(".//mat-cell[2]")).Text.Equals(id))
                {   
                    rows[i].FindElement(By.XPath(".//mat-cell[8]/button")).Click();
                }
            }
        }

        
        public void DeleteContactByRowNumber(int rowNumber)
        {
            GetCustomerOrgContactsTable().FindElement(By.XPath(".//tbody/tr[" + rowNumber + "]/td[6]/button[2]/span/mat-icon[text() = 'delete']")).Click();
        }


        public void DeleteCustomersByIdentifier(String id)
        {
            IList<IWebElement> rows = GetCustomerTableRows();
            for (var i = 0; i < rows.Count; i++)
            {
                var tmp = rows[i].FindElement(By.XPath(".//mat-cell[2]")).Text;
                var tmprow = rows[i].Text;
                if (rows[i].FindElement(By.XPath(".//mat-cell[2]")).Text.Equals(id))
                {
                    rows[i].FindElement(By.XPath(".//mat-cell[8]/button")).Click();
                    DeleteContactByRowNumber(1);
                    ClickDeleteCustomerButton();
                    ClickConfirmDeleteYesButton();
                    ClickSaveButton();
                    ClickOKButton();
                }
            }
        }
    }
}
