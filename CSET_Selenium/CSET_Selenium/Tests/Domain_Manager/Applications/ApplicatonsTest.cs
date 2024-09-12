using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Helpers.Con_PCA;
using CSET_Selenium.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using CSET_Selenium.Domain_Manager_Page_Obj.Login_Page;
using CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.SideMenu;
using CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.Applications;
using CSET_Selenium.Enums.Domain_Manager;

namespace CSET_Selenium.Tests.Domain_Manager.ApplicationsCRUD
{
    [TestFixture]
    public class ApplicationCRUDTest : BaseTest
    {
        private IWebDriver driver;
        private String template = "computer-repair";

        [Test]
        public void ApplicationsTest()
        {
            BaseConfiguration cf = new BaseConfiguration("https://dm.dev.inltesting.xyz/login");
            driver = BuildDriver(cf);
            TableUtils table = new TableUtils(driver);
            String appName = StringsUtils.GenerateRandomString(6, true);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToDomainManager(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());
            SideMenu sideMenu = new SideMenu(driver);
            //Create a new Application
            sideMenu.SelectApplications();
            Applications app = new Applications(driver);
            app.CreateNewApplication(appName);
            Assert.That(app.FindApplicationByName(appName), "Didn't find the new application "+appName);

            //Edit an Application
            app.ClickApplicationsTableRowByName(appName);
            app.ClickEditButton();
            app.SetProgramLeadName(Contact.General_Name.GetValue());
            app.SetProgramLeadEmail(Contact.Email.GetValue());
            app.SetProgramLeadPhone(Contact.Phone.GetValue());
            app.ClickSaveButton();
            String leadName = app.GetApplicationSummaryValue("Program Lead Name");
            String leadEmail = app.GetApplicationSummaryValue("Program Lead Email");
            String leadPhone = app.GetApplicationSummaryValue("Program Lead Phone");
            Assert.That(leadName.Contains(Contact.General_Name.GetValue()) && leadEmail.Contains(Contact.Email.GetValue()) && leadPhone.Contains(Contact.Phone.GetValue()), "Edit Application has some issues");

            //delete the application
            sideMenu.SelectApplications();
            app.WaitUntilSpinnerNotShowing();
            app.DeleteApplication(appName);
            Assert.That(app.FindApplicationByName(appName), Is.False, "Application is not deleted as expected.");
        }
    }
}
