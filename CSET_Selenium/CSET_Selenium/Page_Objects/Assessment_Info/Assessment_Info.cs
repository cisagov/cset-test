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

        private IWebElement editBox_AssessmentName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='name']"));
            }
        }

        private IWebElement editBox_AssessmentDate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='date']"));
            }
        }


        private IWebElement editBox_FacilityName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='facility']"));
            }
        }

        private IWebElement editBox_CityOrSiteName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='citySite']"));
            }
        }

        private IWebElement editBox_StateProvinceRegion
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='stateProvRegion']"));
            }
        }

        private IWebElement button_AddContact
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()='Add Contact']/ancestor::button"));
            }
        }

        private IWebElement editBox_ContactFirstName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='fName']"));
            }
        }

        private IWebElement editBox_ContactLastName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='lName']"));
            }
        }

        private IWebElement editBox_ContactEmail
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='email']"));
            }
        }

        private IWebElement radioGroup_Role
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@name='contactRoles']"));
            }
        }

        private IWebElement button_ContactSave
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@type='submit' and text()=' Save ']"));
            }
        }

        private IWebElement button_ContactCancel
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@type='button' and text()=' Cancel ']"));
            }
        }

        private IWebElement select_Sector
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[@id='sector']"));
            }
        }

        private IWebElement select_Industry
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[@id='industry']"));
            }
        }

        private IWebElement select_AssetValue
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[@id='assetValue']"));
            }
        }

        private IWebElement select_ExpectedEffort
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[@id='size']"));
            }
        }

        private IWebElement button_Next
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[text()='Next']"));
            }
        }


        /*[FindsBy(How = How.XPath, Using = "//select[contains(@id,'sector')]")]
        private readonly IWebElement selectSector;

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'industry')]")]
        private readonly IWebElement selectIndustry;

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'assetValue')]")]
        private readonly IWebElement selectAssetValue;

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'size')]")]
        private readonly IWebElement selectSize;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'OrganizationName')]")]
        private readonly IWebElement textboxOrgName;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'Agency')]")]
        private readonly IWebElement textboxAgency;

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'OrganizationType')]")]
        private readonly IWebElement selectOrgType;

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'Facilitator')]")]
        private readonly IWebElement selectFacilitator;

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'PointOfContact')]")]
        private readonly IWebElement selectPointOfContact;

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'IsScoped')]")]
        private readonly IWebElement checkboxIsScoped;
        
        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Back')]")]
        private readonly IWebElement buttonBack;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(), 'Next')]")]
        private readonly IWebElement buttonNext;*/

        //Interaction Methods
        private void setAssessmentName(String assessmentName)
        {
            ClickWhenClickable(editBox_AssessmentName);
            editBox_AssessmentName.SendKeys(assessmentName);
        }

        private void setAssessmentDate(DateTime assessmentDate)
        {
            ClickWhenClickable(editBox_AssessmentDate);
            editBox_AssessmentDate.SendKeys(assessmentDate.ToString());

        }


        //Aggregate Methods
        public void SetAssessmentInformation()
        {

            ClickNext();
        }

    }
}
