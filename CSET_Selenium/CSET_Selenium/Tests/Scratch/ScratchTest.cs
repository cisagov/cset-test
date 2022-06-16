
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using CSET_Selenium.DriverConfiguration;

namespace CSET_Selenium.Tests.Scratch
{
    [TestFixture]
    public class ScratchTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void MyGoogleSearch()
        {
            Console.Write("test case started ");
            //create the reference for the browser
            BaseConfiguration cf = new BaseConfiguration("https://www.google.com");
            driver = BuildDriver(cf);
            // identify the Google search text box  

            IWebElement ele = driver.FindElement(By.Name("q"));
            //enter the value in the google search text box  
            ele.SendKeys("Selenium C#");
            //identify the google search button  
            IWebElement ele1 = driver.FindElement(By.Name("btnK"));
            // click on the Google search button  
            /*new BasePage(driver).ClickWhenClickable(ele1);
            driver.Close();
            Console.Write("test case ended ");*/
        }
    }
}
