using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Repository.Login_Page;
using CSET_Selenium.Repository.Navbar;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Tests.Check_User_Guides
{
    class UserGuides
    {
        [TestFixture]
        public class CheckUserGuides : BaseTest
        {
            private IWebDriver driver;



            [Test]
            public void CSETUserGuide()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                Navbar navbar = new Navbar(driver);
                navbar.OpenCSETUserGuide();
                List<IWebElement> csetVersion = new List<IWebElement>();
                csetVersion.AddRange(driver.FindElements(By.XPath("//div[contains(text()[2],'Version 11.0.0')]")));
                if (csetVersion.Count > 0)
                {
                    Console.WriteLine("ACET has correct version");
                } else
                {
                    Console.WriteLine("**** ACET User Guide's version number is wrong ****");
                }
            }
        }
    }
}
