using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using CSET_Selenium.Repository.Login_Page;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using CSET_Selenium.DriverConfiguration;
using System.Threading;

namespace CSET_Selenium.Tests.Refresh
{
    [TestFixture]
    public class RefreshPage : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void RefreshCSET()
        {
            BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
            driver = BuildDriver(cf);
            Assert.That(driver.Title.Contains("CSET"), "****CSET did not load correctly****");

            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            Assert.That(driver.Title.Contains("CSET"), "****CSET did not refresh proplerly****");
        }

        [Test]
        public void RefreshACET()
        {
            BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
            driver = BuildDriver(cf);
            Assert.That(driver.Title.Contains("ACET"), "****ACET did not load correctly****");

            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            Assert.That(driver.Title.Contains("ACET"), "****ACET did not refresh proplerly****");
        }

        [Test]
        public void RefreshTSA()
        {
            BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
            driver = BuildDriver(cf);
            Assert.That(driver.Title.Contains("CSET-TSA"), "****CSET-TSA did not load correctly****");

            driver.Navigate().Refresh();
            Thread.Sleep(2000);
            Assert.That(driver.Title.Contains("CSET-TSA"), "****CSET-TSA did not refresh proplerly****");
        }
    }
}
