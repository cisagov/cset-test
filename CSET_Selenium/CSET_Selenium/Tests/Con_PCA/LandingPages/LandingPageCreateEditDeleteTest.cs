using System;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Helpers;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.LandingPages;

namespace CSET_Selenium.Tests.Con_PCA.LandingPages
{
    [TestFixture]
    public class LandingPageCreateEditDeleteTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void LandingPageTest()
        {
            BaseConfiguration cf = new BaseConfiguration(Env.Dev.GetValue());
            driver = BuildDriver(cf);
            String landingPageName = StringsUtils.GenerateRandomString(6);
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());
            
            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectLandingPages();
            LandingPage page = new LandingPage(driver);
            //create a new landing page
            page.CreateNewLandingPage(landingPageName, "html view test");
            bool foundLandPage = page.FindLandingPageByName(landingPageName);
            Assert.IsTrue(foundLandPage, "Didn't find the new landing page.");

            //Edit the landing page and verify
            String newPageName = StringsUtils.GenerateRandomString(6);
            page.EditLandingPageName(landingPageName, newPageName);
            Assert.IsTrue(page.FindLandingPageByName(newPageName), "Didn't find the landing page after edit.");
            

            //Delete a landing page
            page.DeleteLandingPageByName(newPageName);
            Assert.IsFalse(page.FindLandingPageByName(newPageName), "The landing page is not deleted as expected.");
        }
    }
}
