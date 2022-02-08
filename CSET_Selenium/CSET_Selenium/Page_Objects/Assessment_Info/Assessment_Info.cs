using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.AssessmentInfo
{
    class AssessmentInfo : BasePage
    {
        private readonly IWebDriver driver;

        public AssessmentInfo(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement DropdownSector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'sector')]"));
            }
        }

        private IWebElement DropdownIndustry
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'industry')]"));
            }
        }

        private IWebElement DropdownAssetValue
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'assetValue')]"));
            }
        }

        private IWebElement DropdownExpectedEffort
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'size')]"));
            }
        }

        private IWebElement TextboxOrganizationName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name, 'edmOrganizationName')]"));
            }
        }

        private IWebElement TextboxAgency
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'edmAgency')]"));
            }
        }

        private IWebElement DropdownOrganizationType
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'edmOrganizationType')]"));
            }
        }

        private IWebElement DropdownFacilitator
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name, 'edmFacilitator')]"));
            }
        }

        private IWebElement TextboxCriticalService
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[contains(@name,'criticalService')]"));
            }
        }

        private IWebElement DropdownPointOfContact
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[contains(@name,'critSvcPointOfContact')]"));
            }
        }

        private IWebElement CheckboxScoped
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[contains(@name,'edmIsScoped')]"));
            }
        }

        //Interaction Methods
        private void SetAssessmentName(String assessmentName)
        {
//            ClickWhenClickable(editBox_AssessmentName);
  //          editBox_AssessmentName.SendKeys(assessmentName);
        }

        private void SetAssessmentDate(DateTime assessmentDate)
        {
            //ClickWhenClickable(editBox_AssessmentDate);
            //editBox_AssessmentDate.SendKeys(assessmentDate.ToString());

        }


        //Aggregate Methods
        public void SetAssessmentInformation()
        {

            ClickNext();
        }

    }
}
