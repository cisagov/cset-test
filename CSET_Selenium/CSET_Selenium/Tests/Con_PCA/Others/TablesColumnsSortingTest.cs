using System;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using CSET_Selenium.Enums.Con_PCA;
using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Subscriptions;
using System.Collections.Generic;


namespace CSET_Selenium.Tests.Con_PCA.Others
{
    [TestFixture]
    public class AllTablesSortingTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void SortingTest()
        {
            BaseConfiguration cf = new BaseConfiguration(Env.Dev.GetValue());
            driver = driver = BuildDriver(cf);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA("jessica.qu", "Abc123$$");
            
            SideMenu sideMenu = new SideMenu(driver);
            
            sideMenu.SelectSubscriptions();
            Subscriptions subscription = new Subscriptions(driver);

            List<String> cl = subscription.GetColumnCellsListByLabelName("Start Date");
            cl.Sort();
            List<String> listAfterSortAsShoouldBe = cl;
            cl.Reverse();
            List<String> listAfterSortDesShouldBe = cl;

            subscription.SortColumn("Start Date", Sort.descending);
            List<String> listFromUI = subscription.GetColumnCellsListByLabelName("Start Date");

            Boolean foundDifference = false;

            for(int i=0; i< listAfterSortDesShouldBe.Count-1; i++)
            {
                if (!listAfterSortDesShouldBe[i].Equals(listFromUI[i]))
                {
                    foundDifference = true;
                    Console.WriteLine("Row " + i + " should be " + listAfterSortDesShouldBe[i] + ", while it is " + listFromUI[i]);
                }
            }
            Assert.IsFalse(foundDifference, "Table sorting failed, please see console output for details.");
        }
    }
}
