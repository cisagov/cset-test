using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Navbar
{
    class navbar : BasePage
    {
        private readonly IWebDriver driver;

        public navbar(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement buttonLandingPage
        {
            get
            {
                return this.driver.FindElement(By.XPath("//span[contains(text(),'New Assessment')]"));
            }
        }

    }
}
