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
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "\"K!q;va&%G],(0!mE:G+%ba~z><T/v4AELXZUFz;Tav|y}'mbx");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.NavigateToModuleBuilder();
                ModuleBuilder newModule = new ModuleBuilder(driver);
                newModule.CreateNewModule();
            }
        }
    }
}
