using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu
{
    class SideMenu : BasePage
    {
        private readonly IWebDriver driver;

        public SideMenu(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement Subscriptions
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Subscriptions']"));
            }
        }

        private IWebElement Templates
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Templates']"));
            }
        }

        private IWebElement Customers
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Customers']"));
            }
        }

        private IWebElement SendingProfiles
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Sending Profiles']"));
            }
        }

        private IWebElement SimulatedURLs
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Simulated URLs']"));
            }
        }

        private IWebElement LandingPages
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Landing Pages']"));
            }
        }

        private IWebElement Recommendations
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Recommendations']"));
            }
        }

        private IWebElement Tags
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Tags']"));
            }
        }

        private IWebElement Users
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Users']"));
            }
        }

        private IWebElement Configuration
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text(),'Configuration']"));
            }
        }

        private IWebElement Overview
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Overview']"));
            }
        }

        //Interaction Methods

        private void ClickSubscription()
        {
            Subscriptions.Click();
        }

        private void ClickConfiguration()
        {
            Configuration.Click();
        }

        private void ClickTemplates()
        {
            Templates.Click();
        }

        private void ClickCustomers()
        {
            Customers.Click();
        }

        private void ClickSendingProfiles()
        {
            SendingProfiles.Click();
        }

        private void ClickSimulatedURLs()
        {
            SimulatedURLs.Click();
        }

        private void ClickLandingPages()
        {
            LandingPages.Click();
        }

        private void ClickRecommendations()
        {
            Recommendations.Click();
        }

        private void ClickTags()
        {
            Tags.Click();
        }

        private void ClickUsers()
        {
            Users.Click();
        }

        private void ClickOverview()
        {
            Overview.Click();
        }

        //Aggregate Methods

        public void SelectSubscriptions()
        {
            ClickSubscription();
        }

        public void SelectTemplates()
        {
            ClickTemplates();
        }

        public void SelectCustomers()
        {
            ClickCustomers();
        }

        public void SelectSendingProfiles()
        {
            ClickSendingProfiles();
        }

        public void SelectSimulatedURLs()
        {
            ClickSimulatedURLs();
        }

        public void SelectLandingPages()
        {
            ClickLandingPages();
        }

        public void SelectRecommendation()
        {
            ClickRecommendations();
        }

        public void SelectTags()
        {
            ClickTags();
        }

        public void SelectUsers()
        {
            ClickUsers();
        }

        public void SelectConfiguration()
        {
            ClickConfiguration();
        }

        public void SelectOverview()
        {
            ClickOverview();
        }
    }
}
