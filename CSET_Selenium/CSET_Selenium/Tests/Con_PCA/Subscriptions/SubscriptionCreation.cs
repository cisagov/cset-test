using System;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using CSET_Selenium.Enums.Con_PCA;
using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Customers;
using System.Collections.Generic;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Subscriptions;
using CSET_Selenium.Helpers;

namespace CSET_Selenium.Tests.Con_PCA.SubscriptionTest
{
    [TestFixture]
    public class SubscriptionCreation : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void SubscriptionTest()
        {
            BaseConfiguration cf = new BaseConfiguration(Env.Dev.GetValue());
            driver = driver = BuildDriver(cf);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());
            //find a customer to assign 
            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectCustomers();
            Customers customer = new Customers(driver);
            String customerName = customer.GetCustomerNameByRowNumber(1);
            //create subscription
            sideMenu.SelectSubscriptions();
            Subscriptions subscription = new Subscriptions(driver);
            subscription.CreateNewSubscription();
            subscription.AssignCustomer();
            subscription.ClickCustomerTableRowByName(customerName);
            subscription.SelectPrimaryContactByIndex(1);
            subscription.SelectAdminEmailByIndex(1);
            subscription.SelectSendingProfileByIndex(1);
            subscription.SetStartDate(DateUtils.DateFormatAsString(DateTime.Now, "MM/dd/yyyy"));
            subscription.SetStartTime("11:00");
            subscription.SetTargetEmailDomain("@inl.gov");
            subscription.SetTargetRecipients("test@inl.gov");
            String newSubscriptionName = subscription.Submit();

            IList<IWebElement> rows = subscription.GetSubscriptionsTableRows();
            bool foundSubscription = false;
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(newSubscriptionName))
                {
                    foundSubscription = true;
                    break;
                }
            }
            Assert.That(foundSubscription);

            //Assert.That(foundCustomer);

            Console.Write("test case ended ");
        }
    }
}