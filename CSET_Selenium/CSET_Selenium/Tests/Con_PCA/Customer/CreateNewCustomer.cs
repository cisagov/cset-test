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

namespace CSET_Selenium.Tests.Con_PCA.Customer
{
    [TestFixture]
    public class CreateCustomer : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void Login()
        {
            BaseConfiguration cf = new BaseConfiguration("https://pca.dev.inltesting.xyz/login");
            driver = driver = BuildDriver(cf);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToCSET("jessica.qu", "Abc123$$");

            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectCustomers();
            Customers customer = new Customers(driver);
            customer.CreateNewCustomer("Government - Federal");

            Console.Write("test case ended ");

        }
    }
}
