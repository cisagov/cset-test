using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Helpers.Con_PCA;
using CSET_Selenium.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Domain_Manager_Page_Obj.Login_Page;
using CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.SideMenu;
using CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.Templates;

namespace CSET_Selenium.Tests.Domain_Manager.TemplatesTest
{
    [TestFixture]
    public class TemplateCRUDTest : BaseTest
    {
        private IWebDriver driver;
        private String template = "computer-repair";

        [Test]
        public void TemplatesTest()
        {
            BaseConfiguration cf = new BaseConfiguration("https://dm.dev.inltesting.xyz/login");
            driver = BuildDriver(cf);
           
            //String templateName = "TemplateTest";

            
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToDomainManager(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());
            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectTemplates();
            Templates template = new Templates(driver);
            //template.WaitUntilSpinnerNotShowing();
            template.WaitForPageLoad();
            TableUtils table = new TableUtils(driver);

            List<String> tempateList = table.GetColumnCellsListByLabelName("Template Name");
            IList<String> domainsUsingList;
            foreach(String eachName in tempateList)
            {
                Console.WriteLine("Checking " + eachName);
                template.ClickTemplatesTableRowByName(eachName);
                template.ClickTab("Domains Using");
                domainsUsingList = template.GetDomainsUsingTabDomainNameList();
                
                sideMenu.SelectTemplates();
                //template.WaitUntilSpinnerNotShowing();
                template.WaitUntilElementIsVisible(table.GetCommonTable(), 5);
            }

        }
    }
}
        
