using System;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Templates;
using CSET_Selenium.Helpers;

namespace CSET_Selenium.Tests.Con_PCA.Template
{
    [TestFixture]
    public class TemplateCreationEditRetireDelete : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void TemplateTest()
        {
            BaseConfiguration cf = new BaseConfiguration("https://pca.dev.inltesting.xyz/login");
            driver = BuildDriver(cf);
            String templateName = StringsUtils.GenerateRandomString(6);
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA("jessica.qu", "Abc123$$");
            //Create a new template
            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectTemplates();
            Templates template = new Templates(driver);
            if (!template.NewTemplateButtonPresent())
            {
                sideMenu.SelectSubscriptions();
                sideMenu.SelectTemplates();
            }

            template.CreateNewTemplate(templateName, "whatever");
            
            Assert.IsTrue(template.FindTemplateByName(templateName));

            //Edit a template 
            String newTemplateName = StringsUtils.GenerateRandomString(6);
            template.EditTemplateName(templateName, newTemplateName);
            sideMenu.SelectTemplates();
           
            Assert.IsTrue(template.FindTemplateByName(newTemplateName));

            //retire a template
            template.RetireTemplate(newTemplateName, "Retire");
            template.ShowRetired();
            
            Assert.IsTrue(template.FindTemplateByName(newTemplateName));

            //delete a template
            template.ShowRetired();
            template.DeleteTemplate(newTemplateName);
            sideMenu.SelectTemplates();
            template.ShowRetired();
            
            Assert.IsFalse(template.FindTemplateByName(newTemplateName));//assert false -- the template should not be found after delete
        }
    }
}
