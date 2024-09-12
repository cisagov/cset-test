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
            BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
            driver = driver = BuildDriver(cf);
            Assert.That(driver.Title.Contains("CSET"));
            
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToCSET("william.martin@inl.gov", "Password123");
        }
    }
}
