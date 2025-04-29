using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums;
using CSET_Selenium.Repositories.NERC_Rev_6.Data_Types;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.AssessmentQuesitons.NERCRev6
{
    /// <summary>
    /// 
    /// </summary>
    internal class AccountManagementPage : BasePage
    {
        private AccountManagement _accountManagement;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="accountManagement"></param>
        public AccountManagementPage(IWebDriver driver, AccountManagement accountManagement) : base(driver)
        {
            this._accountManagement = accountManagement;

            // initialize page controls to backing object value
            this.PersonnelAndTraining = accountManagement.PersonnelAndTraining;
        }

        /// <summary>
        /// 
        /// </summary>
        public QuestionAnswers PersonnelAndTraining
        {
            get { return this._accountManagement.PersonnelAndTraining; }
            set 
            {
                switch (value)
                {
                    case QuestionAnswers.YES:
                        {
                            this.PersonnelAndTrainingYesButton.Click();

                            break;
                        }
                    case QuestionAnswers.NO:
                        {
                            this.PersonnelAndTrainingNoButton.Click();

                            break;
                        }
                    case QuestionAnswers.NA:
                        {
                            this.PersonnelAndTrainingNAButton.Click();

                            break;
                        }
                    case QuestionAnswers.ALT:
                        {
                            this.PersonnelAndTrainingAltButton.Click();

                            break;
                        }
                }
            }
        }

        private IWebElement PersonnelAndTrainingYesButton
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id='qq14499']/div[1]/div[2]/div/label[1]")); }
        }

        private IWebElement PersonnelAndTrainingNoButton
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id='qq14499']/div[1]/div[2]/div/label[2]")); }
        }

        private IWebElement PersonnelAndTrainingNAButton
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id='qq14499']/div[1]/div[2]/div/label[3]")); }
        }

        private IWebElement PersonnelAndTrainingAltButton
        {
            get { return WaitUntilElementIsVisible(By.XPath("//*[@id='qq14499']/div[1]/div[2]/div/label[4]")); }
        }
    }
}
