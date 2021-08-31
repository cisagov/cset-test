using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repository.Navbar
{
    class navbar
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'New Assessment')]")]
        private readonly IWebElement buttonLandingPage;

    }
}
