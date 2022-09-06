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

namespace CSET_Selenium.Tests.Domain_Manager.DomainsTest
{
    [TestFixture]
    public class DomainsTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void DomainsCRUDTest()
        {
            BaseConfiguration cf = new BaseConfiguration("https://dm.dev.inltesting.xyz/login");
            driver = driver = BuildDriver(cf);
            String domainURL = StringsUtils.GenerateRandomString(6, true) + ".xyz";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToDomainManager(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());
            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectDomains();
            Domains domain = new Domains(driver);
            domain.AddNewDomain(domainURL);

            String tmp = "";
        }
    }
}
