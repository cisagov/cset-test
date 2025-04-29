using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    /// <summary>
    /// 
    /// </summary>
    class StandardQuestionsPage : BasePage
    {
        private StandardQuestions standardQuestions;

        // page objects
        private AccountManagementPage AccountManagementPage;
        private ConfigurationManagementPage ConfigurationManagementPage;
        private IncidentResponsePage IncidentResponsePage;
        private PhysicalSecurityPage PhysicalSecurityPage;
        private PoliciesPage PoliciesPage;
        private RecoveryPage RecoveryPage;
        private RiskAssessmentPage RiskAssessmentPage;
        private SystemProtectionPage SystemProtectionPage;
        private VulerabilityAssementAndManagementPage VulerabilityAssementAndManagementPage;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        public StandardQuestionsPage(IWebDriver driver, StandardQuestions standardQuestions) : base(driver)
        {
            this.ExpandAllQuestions();

            this.standardQuestions = standardQuestions;

            // initialize page controls to backing object value
            this.AccountManagementPage = new AccountManagementPage(driver, standardQuestions.AccountManagement);
            this.ConfigurationManagementPage = new ConfigurationManagementPage(driver, standardQuestions.ConfigurationManagement);
            this.IncidentResponsePage = new IncidentResponsePage(driver, standardQuestions.IncidentResponse);
            this.PhysicalSecurityPage = new PhysicalSecurityPage(driver, standardQuestions.PhysicalSecurity);
            this.PoliciesPage = new PoliciesPage(driver, standardQuestions.Policies);
            this.RecoveryPage = new RecoveryPage(driver, standardQuestions.Recovery);
            this.RiskAssessmentPage = new RiskAssessmentPage(driver, standardQuestions.RiskAssessment);
            this.SystemProtectionPage = new SystemProtectionPage(driver, standardQuestions.SystemProtection);
            this.VulerabilityAssementAndManagementPage = new VulerabilityAssementAndManagementPage(driver, standardQuestions.VulnerabilityAssementAndManagement);
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetQuestionsMode()
        {
            this.QuestionsMode.Click();
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetRequirementsMode()
        {
            this.RequirementsMode.Click();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ExpandAllQuestions()
        {
            this.ExpandAll.Click();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CompressAllQuestions()
        {
            this.CompressAll.Click();
        }

        //Element Locators

        private IWebElement RequirementsMode
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Requirements Mode')]"));
            }
        }

        private IWebElement QuestionsMode
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Questions Mode')]"));
            }
        }

        private IWebElement ExpandAll
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[2]/div[2]/div[2]/div[1]/button[2]"));
            }
        }

        private IWebElement CompressAll
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id=\"sidenav-content\"]/app-questions/div/div[2]/div[2]/div[2]/div[1]/button[1]"));
            }
        }
    }
}
