using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.DriverConfiguration;
using System.Collections.Generic;
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
            BaseConfiguration cf = new BaseConfiguration(Env.Dev.GetValue());
            driver = BuildDriver(cf);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());

            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectCustomers();

            /*create a new customer and validate */
            Customers customer = new Customers(driver);
            customer.CreateNewCustomer(Enums.Con_PCA.CustomerTypes.Federal);          
            bool foundCustomer = customer.FindCustomerByID(Customer.Customer_Identifier.GetValue());
            Assert.IsTrue(foundCustomer, "Didn't find the new customer");

            /*edit the customer*/
            var newID = StringsUtils.GenerateRandomString(10);
            customer.ClickCustomersTableEditByIdentifier(Customer.Customer_Identifier.GetValue());
            customer.EditCustomerIdentifier(newID);          
            foundCustomer = customer.FindCustomerByID(newID);
            Assert.IsTrue(foundCustomer, "Didn't find the new customer with the edited ID");

            //delete the new customer and verify           
            customer.DeleteCustomersByIdentifier(newID);
            foundCustomer = customer.FindCustomerByID(newID);
            Assert.IsFalse(foundCustomer, "The customer was not successfully deleted.");
        }
    }
}
