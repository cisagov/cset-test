using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.Domain_Manager_Page_Obj.SideMenu
{
    class SideMenu : BasePage
    {
        private readonly IWebDriver driver;

        public SideMenu(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement Domains
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Domains']"));
            }
        }

        private IWebElement Templates
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Templates']"));
            }
        }

        private IWebElement Applications
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Application']"));
            }
        }

        private IWebElement Categorization
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Categorization']"));
            }
        }

        private IWebElement Users
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Users']"));
            }
        }

        //Interaction Methods

        private void ClickDomains()
        {
            Domains.Click();
            WaitUntilElementIsVisible(By.XPath("//h1[text() = 'Domains']"), 3);
        }

        private void ClickApplications()
        {
            Applications.Click();
        }

        private void ClickTemplates()
        {
            Templates.Click();
        }

        private void ClickCategorization()
        {
            Categorization.Click();
        }

        private void ClickUsers()
        {
            Users.Click();
        }

       
        //Aggregate Methods

        public void SelectDomains()
        {
            ClickDomains();
        }

        public void SelectTemplates()
        {
            ClickTemplates();
        }

        public void SelectApplications()
        {
            ClickApplications();
        }

        public void SelectCategorization()
        {
            ClickCategorization();
        }

        public void SelectUsers()
        {
            ClickUsers();
        }
 
    }
}
