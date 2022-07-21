using CSET_Selenium.Repository.Login_Page;
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
    class ProcessControlSCADAModule
    {
        [TestFixture]
        public class Module_Builder : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void ProcessControlSCADAModule()
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

                //Set module details using the Process Control and SCADA category
                newModule.SetModuleDetails("Process Control and SCADA Test", "Test2", "'Process Control and SCADA' category module test", "Process Control and SCADA");
                Thread.Sleep(4000);
            }
        }
    }
}