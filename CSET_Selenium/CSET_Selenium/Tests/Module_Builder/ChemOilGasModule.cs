using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Repository.Landing_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSET_Selenium.Tests.Module_Builder
{
    class ChemOilGasModule
    {
        [TestFixture]
        public class Module_Builder : BaseTest
        {
            private IWebDriver driver;
            Random r = new Random();

            [Test]
            public void ChemOilGasModule()
            {
                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                //Login and navigate to module builder
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.NavigateToModuleBuilder();

                //Create a new module
                ModuleBuilder newModule = new ModuleBuilder(driver);
                newModule.CreateNewModule();

                //Set module details using the Chemical Oil, and Natural Gas category
                newModule.SetModuleDetails("Chem Oil and Gas Test", "Test1", "'Chemical, Oil, and Natural Gas' category test module", "Chemical, Oil, and Natural Gas");

                //Add 2 random requirements to the module and 2 questions to the module
                newModule.GoToRequirements();
                newModule.AddRequirement("Random requirement 1 for Chem, Oil, Gas Test", "Requirement 1", "Requirement 1 Supplemental Info", "Is this test working 1?");
                newModule.AddRequirement("Random requirement 2 for Chem, Oil, Gas Test", "Requirement 2", "Requirement 2 Supplemental Info", "Is this test working 2?");

                //Assert the above module was created correctly
                
                Thread.Sleep(4000);
            }
        }
    }
}

