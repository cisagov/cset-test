using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using CSET_Selenium.DriverConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Customers;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Helpers;

namespace CSET_Selenium.Tests.Con_PCA.CustomerTest
{
    [TestFixture]
    public class CreateEditDeleteCustomer : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void CustomerTest()
        {
            BaseConfiguration cf = new BaseConfiguration("https://pca.dev.inltesting.xyz/login");
            driver = driver = BuildDriver(cf);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA("jessica.qu", "Abc123$$");

            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectCustomers();
            /*create a new customer and validate */
            Customers customer = new Customers(driver);
            customer.CreateNewCustomer(Enums.Con_PCA.CustomerTypes.Federal);
            IList<IWebElement> rows = customer.GetCustomerTableRows();
            bool foundCustomer = false;
            for (var i= 0; i< rows.Count;i++)
            {
                if (rows[i].Text.Contains(Customer.Customer_Identifier.GetValue()))
                {
                    foundCustomer = true;
                    break;
                }
            }

            Assert.IsTrue(foundCustomer);

            /*edit the customer*/

            var newID = StringsUtils.GenerateRandomString(10);

            customer.ClickCustomersTableEditByIdentifier(Customer.Customer_Identifier.GetValue());
            customer.EditCustomerIdentifier(newID);
            rows = customer.GetCustomerTableRows();
            foundCustomer = false;
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(newID))
                {
                    foundCustomer = true;
                    break;
                }
            }

            Assert.IsTrue(foundCustomer);

            //delete the new customer and verify
            
            customer.DeleteCustomersByIdentifier(newID);
            rows = customer.GetCustomerTableRows();
            foundCustomer = false;
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(newID))
                {
                    foundCustomer = true;
                    break;
                }
            }
            Assert.IsFalse(foundCustomer);
        }
    }
}
