using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
//using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CSET_Selenium.Tests.Import_Export
{
    internal class Import
    {
        [TestFixture]
        public class ImportTests : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void ImportAll()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");

                driver = driver = BuildDriver(cf);
               // Assert.True(driver.Title.Contains("CSET-TSA"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("matthew.winston@inl.gov", "Asdfghjkl12#$");

                LandingPage landingPage = new LandingPage(driver);
                landingPage.WaitForPageLoad();

                WaitUtils waitUtils = new WaitUtils(driver);
                Actions actions = new Actions(driver);

                By importInput = By.XPath("//input[@id='importFile']");
                By importLabel = By.XPath("//label[@for='importFile']");

                List<string> filesInDownload = Directory.GetFiles("C:\\Users\\" + Environment.UserName
                                                                                + "\\Downloads").ToList();
                string fileListForSendKeys = "";

                for (int i = 0; i < filesInDownload.Count; i++)
                {
                    if (filesInDownload[i].Trim(' ').EndsWith(".csetw") || filesInDownload[i].Trim(' ').EndsWith(".acet"))
                    {
                        if (fileListForSendKeys.Length == 0)
                        {
                            fileListForSendKeys = filesInDownload[i];
                        }
                        else
                        {
                            fileListForSendKeys += " \n " + filesInDownload[i];

                        }
                    }
                }

                By uploadProgressPopup = By.XPath("//mat-dialog-container/child::app-upload-export");

                waitUtils.WaitUntilElementIsVisible(importLabel);
                driver.FindElement(importInput).SendKeys(fileListForSendKeys);
                Thread.Sleep(1000);

                waitUtils.WaitUntilElementIsNotVisible(uploadProgressPopup, 50000);
                waitUtils.WaitForPageLoad();
            }

            [Test]
            public void ImportAllLocal()
            {
                BaseConfiguration cf = new BaseConfiguration("http://localhost:4200/");

                driver = driver = BuildDriver(cf);

                LandingPage landingPage = new LandingPage(driver);
                landingPage.WaitForPageLoad();

                WaitUtils waitUtils = new WaitUtils(driver);
                Actions actions = new Actions(driver);

                By importInput = By.XPath("//input[@id='importFile']");
                By importLabel = By.XPath("//label[@for='importFile']");

                List<string> filesInDownload = Directory.GetFiles("C:\\Users\\" + Environment.UserName 
                                                                                + "\\Downloads").ToList();
                string fileListForSendKeys = "";

                for (int i = 0; i < filesInDownload.Count; i++)
                {
                    if (filesInDownload[i].Trim(' ').EndsWith(".csetw") || filesInDownload[i].Trim(' ').EndsWith(".acet"))
                    {
                        if (fileListForSendKeys.Length == 0)
                        {
                            fileListForSendKeys = filesInDownload[i];
                        }
                        else
                        {
                            fileListForSendKeys += " \n " + filesInDownload[i];

                        }
                    }
                }

                By uploadProgressPopup = By.XPath("//mat-dialog-container/child::app-upload-export");

                waitUtils.WaitUntilElementIsVisible(importLabel);
                driver.FindElement(importInput).SendKeys(fileListForSendKeys);
                Thread.Sleep(1000);

                waitUtils.WaitUntilElementIsNotVisible(uploadProgressPopup, 50000);
                waitUtils.WaitForPageLoad();
            }
        }
    }
}
