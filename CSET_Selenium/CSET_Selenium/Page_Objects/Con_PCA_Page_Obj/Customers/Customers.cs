using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Customers
{
    class Customers : BasePage
    {
        private readonly IWebDriver driver;

        public Customers(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

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


        //Interaction Methods

        private void ClickNewCustomerButton()
        {
            ButtonNewCustomer.Click();
        }

        private void ClickAddContactButton()
        {
            ButtonAddContact.Click();
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
            //SelectElement select = new SelectElement(TextboxCustomerType);
            //select.SelectByText(customerType);
        }

        //Aggregate Methods
        public void CreateNewCustomer(String customerType)
        {
            ClickNewCustomerButton();
            SelectCustomerType(customerType);


        }
    }
}
