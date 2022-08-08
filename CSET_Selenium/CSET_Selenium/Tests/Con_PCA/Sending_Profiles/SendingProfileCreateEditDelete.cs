using System;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Helpers;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SendingProfiles;

namespace CSET_Selenium.Tests.Con_PCA.Sending_Profiles
{
    [TestFixture]
    public class LandingPageCreateEditDeleteTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void SendingProfileTest()
        {
            BaseConfiguration cf = new BaseConfiguration(Env.Dev.GetValue());
            driver = BuildDriver(cf);
            String landingPageName = StringsUtils.GenerateRandomString(6)+".xyz";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());

            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectSendingProfiles();
            //Create a new profile
            SendingProfiles profile = new SendingProfiles(driver);

            Console.WriteLine("");

        }
    }
}
