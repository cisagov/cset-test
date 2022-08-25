using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Overview;
using CSET_Selenium.Enums.Con_PCA;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace CSET_Selenium.Tests.Con_PCA.OverviewTest
{
    [TestFixture]
    public class OverviewTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void OverviewAllTabsTest()
        {
            BaseConfiguration cf = new BaseConfiguration(Env.Dev.GetValue());
            driver = driver = BuildDriver(cf);
            int waitForSeconds = 30;
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());
            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectOverview();
            Overview overview = new Overview(driver);
            /*test Aggregate Statistics tab*/
            overview.ClickAggregateStatisticsTab();
            Assert.IsTrue(overview.IsPageLoaded(waitForSeconds), "Page is not loaded in limited time.");

            String t1 = overview.GetAggregateStatisticsOverviewValue("Total status reports sent out");
            String t2 = overview.GetAggregateStatisticsValueByCustomerCategory(CustomerTypes.Private, "Emails Sent");

            bool foundError = false;
            Dictionary<string, string> overviewCategoryAndValue = overview.GetAggregateStatisticsOverviewItemsAndValues();
            foreach (var pair in overviewCategoryAndValue)
            {
                if (pair.Value.Equals("")) { 
                    Console.WriteLine("The value for "+pair.Key+" is not correct.");
                    foundError = true;
                }
            }
            Assert.IsFalse(foundError, "Please see console output for the error.");

            Dictionary<string, string> customerTotalByCategory = overview.GetAggregateStatisticsOCustomerTotalsByCategory(CustomerTypes.Federal);
            string tmp = "";

        }
    }
}
