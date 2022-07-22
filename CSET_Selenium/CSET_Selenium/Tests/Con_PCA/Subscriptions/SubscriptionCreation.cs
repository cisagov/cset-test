using System;
using System.Collections.Generic;
using System.Linq;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using CSET_Selenium.Enums.Con_PCA;
using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Subscriptions;
using System.Collections.ObjectModel;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Customers;

namespace CSET_Selenium.Tests.Con_PCA.Subscription
{
    [TestFixture]
    public class SubscriptionCreation : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void SubscriptionTest()
        {
            BaseConfiguration cf = new BaseConfiguration("https://pca.dev.inltesting.xyz/login");
            driver = driver = BuildDriver(cf);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA("jessica.qu", "Abc123$$");
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
            subscription.SetTargetEmailDomain("@inl.gov");
            subscription.SetTargetRecipients("test@inl.gov");
            String newSubscriptionName = subscription.Submit();

            ReadOnlyCollection<IWebElement> rows = subscription.GetSubscriptionsTableRows();
            bool foundSubscription = false;
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(newSubscriptionName))
                {
                    foundSubscription = true;
                    break;
                }
            }
            Assert.IsTrue(foundSubscription);

            //Assert.IsTrue(foundCustomer);

            Console.Write("test case ended ");
        }
    }
}