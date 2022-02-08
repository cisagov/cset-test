using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.User_Guides
{
    class UserGuides : BasePage
    {
        private readonly IWebDriver driver;

        public UserGuides(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        //Element Locators

        private IWebElement TextCSETVersionNumber
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text()[2],'Version 11.0.1')]"));
            }
        }

        private IWebElement TextACETVersionNumber
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Version 11.0.1')]"));
            }
        }

        private IWebElement TextCMMC2VersionNumber
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text()[2],'Version 11.0.1')]"));
            }
        }

        private IWebElement TextCRRVersionNumber
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div/h2[contains(text(),'11.0.1')]"));
            }
        }

        private IWebElement TextEDMVersionNumber
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[contains(text(),'Version 11.0.1')]"));
            }
        }

        //Interaction Methods

        /*private bool CheckACETUserGuideVersion
        {
            get
            {
                try
                {
                    assertTrue(IsElementPresent(By(TextACETVersionNumber)));
                } 
                catch (Err)
                {

                }

                //driver.FindElement((By)TextACETVersionNumber);
                
            }
        }*/

        /*private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }*/




        //Aggregate Methods
        /*    public void CreateNewAssessment()
            {
                ClickNewAssessmentButton();
            }*/

/*        if (IsElementPresent(By.Id("element name")))
            {
                //do if exists
            }
            else
            {
                //do if does not exists
            }*/

    }
}
