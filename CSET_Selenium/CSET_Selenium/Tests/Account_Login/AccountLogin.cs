using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Repository.Login_Page;
using CSET_Selenium.DriverConfiguration;

namespace CSET_Selenium.Tests.Account_Login
{
    [TestFixture]
    public class AccountLogin : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void Login()
        {
            BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
            driver = driver = BuildDriver(cf);
            Assert.That(driver.Title.Contains("CSET"));
            
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToCSET("william.martin@inl.gov", "\"K!q;va&%G],(0!mE:G+%ba~z><T/v4AELXZUFz;Tav|y}'mbx");
        }
    }
}
