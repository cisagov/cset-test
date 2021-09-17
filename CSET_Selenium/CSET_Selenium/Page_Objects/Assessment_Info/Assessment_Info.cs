using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Assessment_Info
{
    class Assessment_Info : BasePage
    {
        public Assessment_Info(IWebDriver driver) : base(driver)
        {
            SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'sector')]")]
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
        private readonly IWebElement buttonNext;
    }
}
