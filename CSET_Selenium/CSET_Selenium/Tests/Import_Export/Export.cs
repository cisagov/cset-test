using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSET_Selenium.Tests.Import_Export
{
    internal class Export
    {
        [TestFixture]
        public class ExportTests : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void ExportAll ()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");

                driver = driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET-TSA"));
                
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("matthew.winston@inl.gov", "Asdfghjkl12#$");

                LandingPage landingPage = new LandingPage(driver);
                landingPage.WaitForPageLoad();

                WaitUtils waitUtils = new WaitUtils(driver);
                Actions actions = new Actions(driver);

                // first run of exporting (before the while loop)
                By exportButton = By.XPath("//button[@id='assess-0-export']");

                int i = 0;

                IWebElement footer = driver.FindElement(By.XPath("//div[@id='footerPanel-header']"));
                driver.ExecuteJavaScript("arguments[0].setAttribute('style','display:none')", footer);

                // this workaround is so the mat tooltip doesn't cover the next Export button
                waitUtils.WaitUntilElementIsVisible(exportButton);
                actions.Click(driver.FindElement(exportButton)).Perform();
                //

                waitUtils.WaitForPageLoad();

                i++;
                exportButton = By.XPath("//button[@id='assess-" + i + "-export']");
                string exportButtonString = "//button[@id='assess-" + i + "-export']";

                while (landingPage.CheckIfElementExists(exportButtonString, 0))
                {
                    // this workaround is so the mat tooltip doesn't cover the next Export button
                    waitUtils.WaitUntilElementIsVisible(exportButton);
                    actions.Click(driver.FindElement(exportButton)).Perform();
                    //

                    i++;
                    exportButton = By.XPath("//button[@id='assess-" + i + "-export']");
                    exportButtonString = "//button[@id='assess-" + i + "-export']"; 
                }
            }
        }
    }
}
