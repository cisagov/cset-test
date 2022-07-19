using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Repository.Login_Page;
using CSET_Selenium.Repository.Landing_Page;
using NUnit.Framework;
using OpenQA.Selenium;


namespace CSET_Selenium.Tests.Create_Assessment
{
    class BasicModuleCreation
    {
        [TestFixture]
        public class CreateAssessment : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void CreateBasicModule()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.NavigateToModuleBuilder();
                ModuleBuilder newModule = new ModuleBuilder(driver);
                newModule.CreateNewModule();
            }
        }
    }
}
