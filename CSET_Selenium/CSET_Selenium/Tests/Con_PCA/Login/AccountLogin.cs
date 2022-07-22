using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using CSET_Selenium.DriverConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.ConPCA_Repository.Login_Page;

namespace CSET_Selenium.Tests.Con_PCA
{
    [TestFixture]
    public class AccountLogin : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void Login()
        {
            BaseConfiguration cf = new BaseConfiguration("https://pca.dev.inltesting.xyz/login");
            driver = driver = BuildDriver(cf);

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA("jessica.qu", "Abc123$$");
        }
    }
}
