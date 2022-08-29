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
            Assert.IsTrue(overview.IsPageLoaded(waitForSeconds), "Aggregate Statistics Page is not loaded in limited time.");
           
            Dictionary<string, string> overviewCategoryAndValueMap = overview.GetAggregateStatisticsOverviewItemsAndValues();
            VerifyAggregateStatisticsMap(overviewCategoryAndValueMap);

            Dictionary<string, string> customerTotalByCategoryFederal = overview.GetAggregateStatisticsOCustomerTotalsByCategory(CustomerTypes.Federal);
            VerifyAggregateStatisticsMap(customerTotalByCategoryFederal);

            Dictionary<string, string> customerTotalByCategoryState = overview.GetAggregateStatisticsOCustomerTotalsByCategory(CustomerTypes.State);
            VerifyAggregateStatisticsMap(customerTotalByCategoryState);

            Dictionary<string, string> customerTotalByCategoryLocal = overview.GetAggregateStatisticsOCustomerTotalsByCategory(CustomerTypes.Local);
            VerifyAggregateStatisticsMap(customerTotalByCategoryLocal);

            Dictionary<string, string> customerTotalByCategoryTribal = overview.GetAggregateStatisticsOCustomerTotalsByCategory(CustomerTypes.Tribal);
            VerifyAggregateStatisticsMap(customerTotalByCategoryTribal);

            Dictionary<string, string> customerTotalByCategoryPrivate = overview.GetAggregateStatisticsOCustomerTotalsByCategory(CustomerTypes.Private);
            VerifyAggregateStatisticsMap(customerTotalByCategoryPrivate);

            /* Subscription Status Tab*/
            overview.ClickSubscriptionStatusTab();
            Assert.IsTrue(overview.IsPageLoaded(waitForSeconds), "Subscription Status Page is not loaded in limited time.");

            Assert.IsTrue(overview.CheckIfElementExists(overview.GetSubscriptionStatusEndingSoonTable(), 3), "Subscription Ending Soon table is not loaded.");
            Assert.IsTrue(overview.CheckIfElementExists(overview.GetSubscriptionStatusInProgressTable(), 3), "Subscription In Progress table is not loaded.");
            Assert.IsTrue(overview.CheckIfElementExists(overview.GetSubscriptionStatusStoppedTable(), 3), "Subscription Stopped table is not loaded.");

            /* Logging Errors Tab*/
            overview.ClickLoggingErrorsTab();
            Assert.IsTrue(overview.IsPageLoaded(waitForSeconds), "Logging Errors Page is not loaded in limited time.");

            Assert.IsTrue(overview.CheckIfElementExists(overview.GetLoggingErrorsTable(), 3), "Logging Errors table is not loaded.");

            /* Failed Email Tab*/
            overview.ClickFailedEmailsTab();
            Assert.IsTrue(overview.IsPageLoaded(waitForSeconds), "Failed Email Page is not loaded in limited time.");

            Assert.IsTrue(overview.CheckIfElementExists(overview.GetFailedEmailsTable(), 3), "Failed Emails table is not loaded.");
        }

        private void VerifyAggregateStatisticsMap(Dictionary<string, string> theMap)
        {
            bool foundError = false;

            foreach (var pair in theMap)
            {
                if (pair.Value.Equals("") || pair.Value == null)
                {
                    Console.WriteLine("The value for " + pair.Key + " is not correct.");
                    foundError = true;
                }
            }
            Assert.IsFalse(foundError, "Found error in map, please see console output for the error.");
        }
    }
}
