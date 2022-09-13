using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Domain_Manager_Page_Obj.Login_Page;

using CSET_Selenium.Enums.Con_PCA;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.SideMenu;
using CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.Domains;
using CSET_Selenium.Helpers;
using CSET_Selenium.Helpers.Con_PCA;

namespace CSET_Selenium.Tests.Domain_Manager.DomainsCRUD
{
    [TestFixture]
    public class DomainsCRUDTest : BaseTest
    {
        private IWebDriver driver;
        private String template = "computer-repair";

        [Test]
        public void DomainsTest()
        {
            BaseConfiguration cf = new BaseConfiguration("https://dm.dev.inltesting.xyz/login");
            driver = BuildDriver(cf);
            TableUtils table = new TableUtils(driver);
            String domainURL = StringsUtils.GenerateRandomString(6, true) + ".xyz";

            Console.WriteLine("DomainURL is "+ domainURL);
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToDomainManager(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());
            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectDomains();
            //create a new domain and veriry
            Domains domain = new Domains(driver);
            domain.AddNewDomain(domainURL);          
            //domain.SearchDomain(domainURL);
            //int rowsCount = domain.GetDomainsTableRows().Count;
            Assert.IsTrue(domain.FindDomainByName(domainURL), "Didn't find the new domain " + domainURL);

            //update the domain
            domain.ClickDomainsTableRowByName(domainURL);
            domain.SelectTemplate(template);
            sideMenu.SelectDomains();
            IList<IWebElement> rows = domain.GetDomainsTableRows();
            bool found = false;
            for (var i = 0; i < rows.Count; i++)
            {              
                if (rows[i].Text.Contains(domainURL) && rows[i].Text.Contains(template))
                {
                    found = true;
                    break;
                }
            }
            Assert.IsTrue(found, "The updated domain was not found.");

            //delete the domain
            domain.DeleteDomain(domainURL);
            sideMenu.SelectDomains();
            found = domain.FindDomainByName(domainURL);
            Assert.IsFalse(found, "Domain " + domainURL+" is not deleted successfully");            
        }
    }
}
