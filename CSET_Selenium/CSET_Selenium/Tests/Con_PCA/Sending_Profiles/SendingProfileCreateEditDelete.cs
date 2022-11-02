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
    public class ProfileCreateEditDeleteTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void SendingProfileTest()
        {
            BaseConfiguration cf = new BaseConfiguration(Env.Dev.GetValue());
            driver = BuildDriver(cf);
            String profileDomain = StringsUtils.GenerateRandomString(6, true)+".xyz";
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());

            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectSendingProfiles();
            //Create a new profile
            SendingProfiles profile = new SendingProfiles(driver);
            profile.CreateNewProfile(profileDomain);
            bool foundNewProfile = profile.FindProfileByName(profileDomain);
            Assert.IsTrue(foundNewProfile, "Didn't find the new Profile.");

            //Edit profile and verify
            profile.UpdateInterfaceType(profileDomain, ProfileInterfaceType.Mailgun);
            String newType = profile.GetCellValueInProfilesTableRow(profile.GetProfilesTableRowByName(profileDomain), 2);
            String typeShouldBe = ProfileInterfaceType.Mailgun.GetValue();           
            Assert.IsTrue(String.Equals(newType, typeShouldBe, StringComparison.OrdinalIgnoreCase), "Failed editing Profile.");

            //delete a profile and verify
            profile.DeleteProfile(profileDomain);
            sideMenu.SelectCustomers();
            sideMenu.SelectSendingProfiles();

            foundNewProfile = profile.FindProfileByName(profileDomain);
            Assert.IsFalse(foundNewProfile, "Profile is not deleted successfully");
        }
    }
}
