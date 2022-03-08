using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Security_Assurance_Level
{
    class SecurityAssuranceLevel : BasePage
    {
        private readonly IWebDriver driver;
        private Actions actions;
        public SecurityAssuranceLevel(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            actions = new Actions(driver);
        }

        
        //Element Locators

        private IWebElement TextHeaderSimple
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[5]/label[1]"));
            }
        }

        private IWebElement TextHeaderGeneralRiskBased
        {
            get
            {
                return this.driver.FindElement(By.XPath("//label[contains(text(),'General Risk Based')]"));
            }
        }

        private IWebElement TextHeaderNist
        {
            get
            {
                return this.driver.FindElement(By.XPath("//label[contains(text(),'NIST-60 / FIPS-199')]"));
            }
        }


        private IWebElement TextHeaderOverallSalLow
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Overall SAL')]/..//label[contains(text(),'Low')]"));
            }
        }

        private IWebElement TextHeaderOverallSalModerate
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Overall SAL')]/..//label[contains(text(),'Moderate')]"));
            }
        }
        private IWebElement TextHeaderOverallSalHigh
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Overall SAL')]/..//label[not(contains(text(), 'Very')) and contains(text(),'High')]"));
            }
        }
        private IWebElement TextHeaderOverallSalVeryHigh
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Overall SAL')]/..//label[contains(text(),'Very High')]"));
            }
        }

        //confidentiality
        private IWebElement TextHeaderConfidentialityLow
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Confidentiality')]/..//label[contains(text(),'Low')]"));
            }
        }

        private IWebElement TextHeaderConfidentialityModerate
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Confidentiality')]/..//label[contains(text(),'Moderate')]"));
            }
        }
        private IWebElement TextHeaderConfidentialityHigh
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Confidentiality')]/..//label[not(contains(text(), 'Very')) and contains(text(),'High')]"));
            }
        }
        private IWebElement TextHeaderConfidentialityVeryHigh
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Confidentiality')]/..//label[contains(text(),'Very High')]"));
            }
        }
        //integrity
        private IWebElement TextHeaderIntegrityLow
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Integrity')]/..//label[contains(text(),'Low')]"));
            }
        }

        private IWebElement TextHeaderIntegrityModerate
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Integrity')]/..//label[contains(text(),'Moderate')]"));
            }
        }
        private IWebElement TextHeaderIntegrityHigh
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Integrity')]/..//label[not(contains(text(), 'Very')) and contains(text(),'High')]"));
            }
        }
        private IWebElement TextHeaderIntegrityVeryHigh
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Integrity')]/..//label[contains(text(),'Very High')]"));
            }
        }

        //availability
        private IWebElement TextHeaderAvailabilityLow
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Availability')]/..//label[contains(text(),'Low')]"));
            }
        }

        private IWebElement TextHeaderAvailabilityModerate
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Availability')]/..//label[contains(text(),'Moderate')]"));
            }
        }
        private IWebElement TextHeaderAvailabilityHigh
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Availability')]/..//label[not(contains(text(), 'Very')) and contains(text(),'High')]"));
            }
        }
        private IWebElement TextHeaderAvailabilityVeryHigh
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'Availability')]/..//label[contains(text(),'Very High')]"));
            }
        }

        //General Risk Based Injuries On Site Slider
        private IWebElement SliderGeneralRiskBasedInjuriesOnSiteNone
        {
            get
            {
                return this.driver.FindElement(By.XPath("/html/body/app-root/layout-main/div/div[1]/div/div/app-assessment/div/div[2]/mat-sidenav-container/mat-sidenav-content/div/app-prepare/app-sals/div/div/div[6]/div/app-sal-gen/div[3]/div/div/ngx-slider[1]/span[12]/span[1]/ngx-slider-tooltip-wrapper/div"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOnSite1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-gen/div[3]/div/div/ngx-slider[1]/span[12]/span[2]/ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOnSite11
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'11-50')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOnSite51
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '7')) and contains(text(),'51-100')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOnSite101
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'101')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOnSite251
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'251')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOnSite501
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'501')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOnSite751
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'751')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOnSite1000
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'> 1000')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        //General Risk Based Injuries Offsite Slider
        private IWebElement SliderGeneralRiskBasedInjuriesOffSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOffSite1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '5')) and contains(text(),'1-10')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOffSite11
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'11-50')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOffSite51
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '7')) and contains(text(),'51-100')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOffSite101
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'101')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOffSite251
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'251')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOffSite501
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'501')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOffSite751
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'751')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedInjuriesOffSite1000
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Injuries')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'> 1000')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        //General Risk Based On Site Hospitalizations Slider
        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSite1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '5')) and contains(text(),'1-10')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSite11
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'11-50')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSite51
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '7')) and contains(text(),'51-100')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSite101
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'101')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSite251
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'251')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSite501
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'501')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSite751
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'751')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOnSite1000
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'> 1000')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        //General Risk Based  Off Site Hospitalizations Slider
        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSite1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '5')) and contains(text(),'1-10')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSite11
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'11-50')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSite51
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '7')) and contains(text(),'51-100')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSite101
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'101')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSite251
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'251')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSite501
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'501')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSite751
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'751')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedHospitalizationsOffSite1000
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Hospitalizations')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'> 1000')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        //General Risk Based On Site Deaths Slider
        private IWebElement SliderGeneralRiskBasedDeathsOnSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOnSite1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '5')) and contains(text(),'1-10')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOnSite11
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'11-50')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOnSite51
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '7')) and contains(text(),'51-100')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOnSite101
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'101')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOnSite251
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'251')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOnSite501
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'501')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOnSite751
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'751')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOnSite1000
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'> 1000')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        //General Risk Based Off Site Deaths Slider
        private IWebElement SliderGeneralRiskBasedDeathsOffSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOffSite1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '5')) and contains(text(),'1-10')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOffSite11
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'11-50')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOffSite51
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '7')) and contains(text(),'51-100')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOffSite101
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'101')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOffSite251
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'251')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOffSite501
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'501')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOffSite751
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'751')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedDeathsOffSite1000
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Deaths')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'> 1000')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        //General Risk Based Capital Loss On Site Slider
        private IWebElement SliderGeneralRiskBasedCapitalLossOnSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOnSite100k
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'M')) and contains(text(),'K')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOnSite1M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOnSite10M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'10M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOnSite100M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'B')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOnSite1B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '10M')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOnSite10B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '>')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOnSite10BGreater
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '-')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }


        //General Risk Based Capital Loss Off Site Slider
        private IWebElement SliderGeneralRiskBasedCapitalLossOffSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOffSite100k
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'M')) and contains(text(),'K')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOffSite1M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOffSite10M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'10M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOffSite100M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'B')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOffSite1B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '10M')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOffSite10B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '>')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedCapitalLossOffSite10BGreater
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Capital Loss')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '-')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }
        //General Risk Based Economic Impact On Site Slider
        private IWebElement SliderGeneralRiskBasedEconomicImpactOnSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOnSite100k
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'M')) and contains(text(),'K')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOnSite1M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOnSite10M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'10M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOnSite100M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'B')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOnSite1B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '10M')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOnSite10B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '>')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOnSite10BGreater
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '-')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }
        //General Risk Based Economic Impact Off Site Slider
        private IWebElement SliderGeneralRiskBasedEconomicImpactOffSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOffSite100k
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'M')) and contains(text(),'K')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOffSite1M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOffSite10M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'10M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOffSite100M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'B')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOffSite1B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '10M')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOffSite10B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '>')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEconomicImpactOffSite10BGreater
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Economic Impact')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '-')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }
        //General Risk Based Environmental On Site Slider
        private IWebElement SliderGeneralRiskBasedEnvironmentalOnSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOnSite100k
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'M')) and contains(text(),'K')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOnSite1M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOnSite10M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'10M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOnSite100M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'B')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOnSite1B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '10M')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOnSite10B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '>')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOnSite10BGreater
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'On Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '-')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }
        //General Risk Based Environmental Off Site Slider
        private IWebElement SliderGeneralRiskBasedEnvironmentalOffSiteNone
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[contains(text(),'None')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOffSite100k
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'M')) and contains(text(),'K')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOffSite1M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOffSite10M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '00')) and contains(text(),'10M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOffSite100M
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), 'B')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOffSite1B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '10M')) and contains(text(),'100M')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOffSite10B
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '>')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement SliderGeneralRiskBasedEnvironmentalOffSite10BGreater
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h5[contains(text(),'Environmental')]/..//div[contains(text(),'Off Site  None ')]/following-sibling::ngx-slider[1]/.//span[not(contains(text(), '-')) and contains(text(),'10B')]/preceding-sibling::ngx-slider-tooltip-wrapper"));
            }
        }

        private IWebElement CheckboxNistAirTransportation
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Air Transportation']"));
            }
        }
        private IWebElement CheckboxNistAssetLiabilityManagement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Asset and Liability Management']"));
            }
        }

        private IWebElement CheckboxNistBudgetExecution
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Budget Execution']"));
            }
        }

        private IWebElement CheckboxNistBudgetFormulation
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Budget Formulation']"));
            }
        }

        private IWebElement CheckboxNistBudgetingPerformanceInt
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Budgeting & Performance Integration']"));
            }
        }
        private IWebElement CheckboxNistCapitalPlan
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Capital Planning']"));
            }
        }
        private IWebElement CheckboxNistCollectReceive
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Collections & Receivables']"));
            }
        }
        private IWebElement CheckboxNistContingencyPlan
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Contingency Planning']"));
            }
        }
        private IWebElement CheckboxNistContinuityOfOps
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Continuity of Operations']"));
            }
        }
        private IWebElement CheckboxNistCostAccount
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Cost Accounting/Performance Measurement']"));
            }
        }
        private IWebElement CheckboxNistCustomerServices
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Customer Services']"));
            }
        }
        private IWebElement CheckboxNistDisasterPrep
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Disaster Preparedness & Planning']"));
            }
        }
        private IWebElement CheckboxNistEmergencyResponse
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Emergency Response']"));
            }
        }
        private IWebElement CheckboxNistEnergyConservation
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Energy Conservation & Preparedness']"));
            }
        }
        private IWebElement CheckboxNistEnergyProduction
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Energy Production']"));
            }
        }
        private IWebElement CheckboxNistEnergyResourceManagement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Energy Resource Management']"));
            }
        }
        private IWebElement CheckboxNistEnergySupply
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Energy Supply']"));
            }
        }
        private IWebElement CheckboxNistEnterpriseArch
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Enterprise Architecture']"));
            }
        }
        private IWebElement CheckboxNistGeneralPurpose
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Environmental Monitoring & Forecasting']"));
            }
        }
        private IWebElement CheckboxNistEnvMonitor
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Environmental Remediation']"));
            }
        }
        private IWebElement CheckboxNistEnvRemediation
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Facilities Fleet & Equipment Management']"));
            }
        }
        private IWebElement CheckboxNistFacilitiesFleet
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='General Purpose Data & Statistics']"));
            }
        }

        private IWebElement CheckboxNistGoodsAcquisition
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Goods Acquisition']"));
            }
        }
        private IWebElement CheckboxNistGroundTransport
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Ground Transportation']"));
            }
        }
        private IWebElement CheckboxNistHelpDesk
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Help Desk Services']"));
            }
        }
        private IWebElement CheckboxNistInfoInfraManagement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Information Infrastructure Management']"));
            }
        }
        private IWebElement CheckboxNistInfoManagement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Information Management']"));
            }
        }
        private IWebElement CheckboxNistInfoSec
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Information Security']"));
            }
        }
        private IWebElement CheckboxNistInfoShare
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Information Sharing']"));
            }
        }
        private IWebElement CheckboxNistIntellectualProperty
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Intellectual Property Protection']"));
            }
        }
        private IWebElement CheckboxNistInventoryControl
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Inventory Control']"));
            }
        }
        private IWebElement CheckboxNistKeyAsset
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Key Asset & Critical Infrastructure Protection']"));
            }
        }
        private IWebElement CheckboxNistLaborRights
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Labor Rights Management']"));
            }
        }
        private IWebElement CheckboxNistLifecycleChange
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Lifecycle/Change Management']"));
            }
        }
        private IWebElement CheckboxNistLogisticsManagement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Logistics Management']"));
            }
        }
        private IWebElement CheckboxNistManagementImprovement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Management Improvement']"));
            }
        }
        private IWebElement CheckboxNistManufacturing
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Manufacturing']"));
            }
        }
        private IWebElement CheckboxNistOtherFinancial
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Other Financial']"));
            }
        }
        private IWebElement CheckboxNistOtherInfoManagement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Other Information Management']"));
            }
        }
        private IWebElement CheckboxNistOtherManagement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Other Management']"));
            }
        }
        private IWebElement CheckboxNistOtherOps
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Other Operations']"));
            }
        }
        private IWebElement CheckboxNistOtherRAndD
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Other Research & Development']"));
            }
        }
        private IWebElement CheckboxNistOtherSecurity
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Other Security']"));
            }
        }
        private IWebElement CheckboxNistOtherSupportFunc
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Other Support Functions']"));
            }
        }
        private IWebElement CheckboxNistPayments
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Payments']"));
            }
        }
        private IWebElement CheckboxNistPercentageInraMaint
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Percentage Infrastructure Maintenance']"));
            }
        }
        private IWebElement CheckboxNistPermitsAndLicensing
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Permits & Licensing']"));
            }
        }
        private IWebElement CheckboxNistPollutionPrevention
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Pollution Prevention & Control']"));
            }
        }
        private IWebElement CheckboxNistProductOutreach
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Product Outreach']"));
            }
        }
        private IWebElement CheckboxNistPropertyProtection
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Property Protection']"));
            }
        }
        private IWebElement CheckboxNistPR
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Public Relations']"));
            }
        }
        private IWebElement CheckboxNistRecordsRetention
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Records Retention']"));
            }
        }
        private IWebElement CheckboxNistReportingInfo
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Reporting Information']"));
            }
        }
        private IWebElement CheckboxNistRAndD
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Research & Development']"));
            }
        }
        private IWebElement CheckboxNistScientificAndTech
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Scientific & Technological Research & Innovation']"));
            }
        }
        private IWebElement CheckboxNistSecManagement
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Security Management']"));
            }
        }
        private IWebElement CheckboxNistServiceRecovery
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Service Recovery']"));
            }
        }
        private IWebElement CheckboxNistServicesAcquisition
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Services Acquisition']"));
            }
        }
        private IWebElement CheckboxNistSystemAndNetMonitoring
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='System & Networking Monitoring']"));
            }
        }
        private IWebElement CheckboxNistSystemDev
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='System Development']"));
            }
        }
        private IWebElement CheckboxNistSystemMaintenance
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='System Maintenance']"));
            }
        }
        private IWebElement CheckboxNistTrainingAndEmployment
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Training & Employment']"));
            }
        }
        private IWebElement CheckboxNistWaterResource
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Water Resource Management']"));
            }
        }
        private IWebElement CheckboxNistWaterTransport
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Water Transportation']"));
            }
        }
        private IWebElement CheckboxNistWorkForcePlanning
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Work-Force Planning']"));
            }
        }
        private IWebElement CheckboxNistWorkerSafety
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Worker Safety']"));
            }
        }
        private IWebElement CheckboxNistWorkplacePolicyDev
        {
            get
            {
                return this.driver.FindElement(By.XPath("//h4[contains(text(),'CIA Values Based on Selected Information Types')]/..//input[@value='Workplace Policy Development & Management']"));
            }
        }

        private IWebElement NistTableLinkC2
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[2]/td[3]/a"));
            }
        }

        private IWebElement NistTableLinkC13
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[13]/td[3]/a"));
            }
        }

        private IWebElement NistTableLinkC14
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[14]/td[3]/a"));
            }
        }

        private IWebElement NistTableLinkC15
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[15]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC16
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[16]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC18
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[18]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC20
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[20]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC22
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[22]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC23
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[23]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC25
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[25]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC33
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[33]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC51
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[51]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC60
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[60]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkC65
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[65]/td[3]/a"));
            }
        }
        private IWebElement NistTableLinkI2
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[2]/td[4]/a"));
            }
        }

        private IWebElement NistTableLinkI13
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[13]/td[4]/a"));
            }
        }

        private IWebElement NistTableLinkI14
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[14]/td[4]/a"));
            }
        }

        private IWebElement NistTableLinkI15
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[15]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI16
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[16]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI18
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[18]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI20
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[20]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI22
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[22]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI23
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[23]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI25
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[25]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI33
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[33]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI51
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[51]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI60
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[60]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkI65
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[65]/td[4]/a"));
            }
        }
        private IWebElement NistTableLinkA2
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[2]/td[5]/a"));
            }
        }

        private IWebElement NistTableLinkA13
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[13]/td[5]/a"));
            }
        }

        private IWebElement NistTableLinkA14
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[14]/td[5]/a"));
            }
        }

        private IWebElement NistTableLinkA15
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[15]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA16
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[16]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA18
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[18]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA20
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[20]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA22
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[22]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA23
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[23]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA25
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[25]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA33
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[33]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA51
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[51]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA60
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[60]/td[5]/a"));
            }
        }
        private IWebElement NistTableLinkA65
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[1]/table/tr[65]/td[5]/a"));
            }
        }

        private IWebElement NistPleaseConfirmYesButton
        {
            get
            {
                return WaitUntilElementIsClickable(By.XPath("/html/body/div[1]//div[2]//mat-dialog-container//div//mat-dialog-actions//button[1]"));
            }
        }

        private IWebElement NistAnswerQuestions1Yes
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[1]/td[2]/div/label[1]"));
            }
        }

        private IWebElement NistAnswerQuestions1No
        { 
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[1]/td[2]/div/label[2]"));
            }
        }
        private IWebElement NistAnswerQuestions2Yes
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[2]/td[2]/div/label[1]"));
            }
        }
        private IWebElement NistAnswerQuestions2No
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[2]/td[2]/div/label[2]"));
            }
        }
        private IWebElement NistAnswerQuestions3Yes
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[3]/td[2]/div/label[1]"));
            }
        }
        private IWebElement NistAnswerQuestions3No
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[3]/td[2]/div/label[2]"));
            }
        }
        private IWebElement NistAnswerQuestions4Yes
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[4]/td[2]/div/label[1]"));
            }
        }
        private IWebElement NistAnswerQuestions4No
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[4]/td[2]/div/label[2]"));
            }
        }
        private IWebElement NistAnswerQuestions5Yes
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[5]/td[2]/div/label[1]"));
            }
        }
        private IWebElement NistAnswerQuestions5No
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[5]/td[2]/div/label[2]"));
            }
        }
        private IWebElement NistAnswerQuestions6Yes
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[6]/td[2]/div/label[1]"));
            }
        }
        private IWebElement NistAnswerQuestions6No
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[6]/td[2]/div/label[2]"));
            }
        }
        private IWebElement NistAnswerQuestions7Yes
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[7]/td[2]/div/label[1]"));
            }
        }
        private IWebElement NistAnswerQuestions7No
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[7]/td[2]/div/label[2]"));
            }
        }
        private IWebElement NistAnswerQuestions8Yes
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[8]/td[2]/div/label[1]"));
            }
        }
        private IWebElement NistAnswerQuestions8No
        {
            get
            {
                return this.driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[8]/td[2]/div/label[2]"));
            }
        }
        //Interaction Methods

        private void ClickHeaderSimple()
        {
            TextHeaderSimple.Click();
        }

        private void ClickHeaderGeneralRiskBased()
        {
            TextHeaderGeneralRiskBased.Click();
        }
        private void ClickHeaderNist()
        {
            TextHeaderNist.Click();
        }

        private void ClickHeaderOverallSalLow()
        {
            TextHeaderOverallSalLow.Click();
        }

        private void ClickHeaderOverallSalModerate()
        {
            TextHeaderOverallSalModerate.Click();
        }

        private void ClickHeaderOverallSalHigh()
        {
            TextHeaderOverallSalHigh.Click();
        }

        private void ClickHeaderOverallSalVeryHigh()
        {
            TextHeaderOverallSalVeryHigh.Click();
        }

        private void ClickHeaderConfidentialityLow()
        {
            TextHeaderConfidentialityLow.Click();
        }

        private void ClickHeaderConfidentialityModerate()
        {
            TextHeaderConfidentialityModerate.Click();
        }

        private void ClickHeaderConfidentialityHigh()
        {
            TextHeaderConfidentialityHigh.Click();
        }

        private void ClickHeaderConfidentialityVeryHigh()
        {
            TextHeaderConfidentialityVeryHigh.Click();
        }

        private void ClickHeaderIntegrityLow()
        {
            TextHeaderIntegrityLow.Click();
        }

        private void ClickHeaderIntegrityModerate()
        {
            TextHeaderIntegrityModerate.Click();
        }

        private void ClickHeaderIntegrityHigh()
        {
            TextHeaderIntegrityHigh.Click();
        }

        private void ClickHeaderIntegrityVeryHigh()
        {
            TextHeaderIntegrityVeryHigh.Click();
        }

        private void ClickHeaderAvailabilityLow()
        {
            TextHeaderAvailabilityLow.Click();
        }

        private void ClickHeaderAvailabilityModerate()
        {
            TextHeaderAvailabilityModerate.Click();
        }

        private void ClickHeaderAvailabilityHigh()
        {
            TextHeaderAvailabilityHigh.Click();
        }

        private void ClickHeaderAvailabilityVeryHigh()
        {
            TextHeaderAvailabilityVeryHigh.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOnSiteNone()
        {
            SliderGeneralRiskBasedInjuriesOnSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOnSite1()
        {
            SliderGeneralRiskBasedInjuriesOnSite1.Click();
        }
        private void ClickSliderGeneralRiskBasedInjuriesOnSite11()
        {
          SliderGeneralRiskBasedInjuriesOnSite11.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOnSite51()
        {
            SliderGeneralRiskBasedInjuriesOnSite51.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOnSite101()
        {
            SliderGeneralRiskBasedInjuriesOnSite101.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOnSite251()
        {
            SliderGeneralRiskBasedInjuriesOnSite251.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOnSite501()
        {
            SliderGeneralRiskBasedInjuriesOnSite501.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOnSite751()
        {
            SliderGeneralRiskBasedInjuriesOnSite751.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOnSite1000()
        {
            SliderGeneralRiskBasedInjuriesOnSite1000.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOffSiteNone()
        {
            SliderGeneralRiskBasedInjuriesOffSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOffSite1()
        {
            SliderGeneralRiskBasedInjuriesOffSite1.Click();
        }
        private void ClickSliderGeneralRiskBasedInjuriesOffSite11()
        {
            SliderGeneralRiskBasedInjuriesOffSite11.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOffSite51()
        {
            SliderGeneralRiskBasedInjuriesOffSite51.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOffSite101()
        {
            SliderGeneralRiskBasedInjuriesOffSite101.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOffSite251()
        {
            SliderGeneralRiskBasedInjuriesOffSite251.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOffSite501()
        {
            SliderGeneralRiskBasedInjuriesOffSite501.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOffSite751()
        {
            SliderGeneralRiskBasedInjuriesOffSite751.Click();
        }

        private void ClickSliderGeneralRiskBasedInjuriesOffSite1000()
        {
            SliderGeneralRiskBasedInjuriesOffSite1000.Click();
        }
        //
        private void ClickSliderGeneralRiskBasedHospitalizationsOnSiteNone()
        {
            SliderGeneralRiskBasedHospitalizationsOnSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOnSite1()
        {
            SliderGeneralRiskBasedHospitalizationsOnSite1.Click();
        }
        private void ClickSliderGeneralRiskBasedHospitalizationsOnSite11()
        {
            SliderGeneralRiskBasedHospitalizationsOnSite11.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOnSite51()
        {
            SliderGeneralRiskBasedHospitalizationsOnSite51.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOnSite101()
        {
            SliderGeneralRiskBasedHospitalizationsOnSite101.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOnSite251()
        {
            SliderGeneralRiskBasedHospitalizationsOnSite251.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOnSite501()
        {
            SliderGeneralRiskBasedHospitalizationsOnSite501.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOnSite751()
        {
            SliderGeneralRiskBasedHospitalizationsOnSite751.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOnSite1000()
        {
            SliderGeneralRiskBasedHospitalizationsOnSite1000.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOffSiteNone()
        {
            SliderGeneralRiskBasedHospitalizationsOffSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOffSite1()
        {
            SliderGeneralRiskBasedHospitalizationsOffSite1.Click();
        }
        private void ClickSliderGeneralRiskBasedHospitalizationsOffSite11()
        {
            SliderGeneralRiskBasedHospitalizationsOffSite11.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOffSite51()
        {
            SliderGeneralRiskBasedHospitalizationsOffSite51.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOffSite101()
        {
            SliderGeneralRiskBasedHospitalizationsOffSite101.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOffSite251()
        {
            SliderGeneralRiskBasedHospitalizationsOffSite251.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOffSite501()
        {
            SliderGeneralRiskBasedHospitalizationsOffSite501.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOffSite751()
        {
            SliderGeneralRiskBasedHospitalizationsOffSite751.Click();
        }

        private void ClickSliderGeneralRiskBasedHospitalizationsOffSite1000()
        {
            SliderGeneralRiskBasedHospitalizationsOffSite1000.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOnSiteNone()
        {
            SliderGeneralRiskBasedDeathsOnSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOnSite1()
        {
            SliderGeneralRiskBasedDeathsOnSite1.Click();
        }
        private void ClickSliderGeneralRiskBasedDeathsOnSite11()
        {
            SliderGeneralRiskBasedDeathsOnSite11.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOnSite51()
        {
            SliderGeneralRiskBasedDeathsOnSite51.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOnSite101()
        {
            SliderGeneralRiskBasedDeathsOnSite101.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOnSite251()
        {
            SliderGeneralRiskBasedDeathsOnSite251.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOnSite501()
        {
            SliderGeneralRiskBasedDeathsOnSite501.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOnSite751()
        {
            SliderGeneralRiskBasedDeathsOnSite751.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOnSite1000()
        {
            SliderGeneralRiskBasedDeathsOnSite1000.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOffSiteNone()
        {
            SliderGeneralRiskBasedDeathsOffSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOffSite1()
        {
            SliderGeneralRiskBasedDeathsOffSite1.Click();
        }
        private void ClickSliderGeneralRiskBasedDeathsOffSite11()
        {
            SliderGeneralRiskBasedDeathsOffSite11.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOffSite51()
        {
            SliderGeneralRiskBasedDeathsOffSite51.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOffSite101()
        {
            SliderGeneralRiskBasedDeathsOffSite101.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOffSite251()
        {
            SliderGeneralRiskBasedDeathsOffSite251.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOffSite501()
        {
            SliderGeneralRiskBasedDeathsOffSite501.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOffSite751()
        {
            SliderGeneralRiskBasedDeathsOffSite751.Click();
        }

        private void ClickSliderGeneralRiskBasedDeathsOffSite1000()
        {
            SliderGeneralRiskBasedDeathsOffSite1000.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOnSiteNone()
        {
            SliderGeneralRiskBasedCapitalLossOnSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOnSite100k()
        {
            SliderGeneralRiskBasedCapitalLossOnSite100k.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOnSite1M()
        {
            SliderGeneralRiskBasedCapitalLossOnSite1M.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOnSite10M()
        {
            SliderGeneralRiskBasedCapitalLossOnSite10M.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOnSite100M()
        {
            SliderGeneralRiskBasedCapitalLossOnSite100M.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOnSite1B()
        {
            SliderGeneralRiskBasedCapitalLossOnSite1B.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOnSite10B()
        {
            SliderGeneralRiskBasedCapitalLossOnSite10B.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOnSite10BGreater()
        {
            SliderGeneralRiskBasedCapitalLossOnSite10BGreater.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOffSiteNone()
        {
            SliderGeneralRiskBasedCapitalLossOffSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOffSite100k()
        {
            SliderGeneralRiskBasedCapitalLossOffSite100k.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOffSite1M()
        {
            SliderGeneralRiskBasedCapitalLossOffSite1M.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOffSite10M()
        {
            SliderGeneralRiskBasedCapitalLossOffSite10M.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOffSite100M()
        {
            SliderGeneralRiskBasedCapitalLossOffSite100M.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOffSite1B()
        {
            SliderGeneralRiskBasedCapitalLossOffSite1B.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOffSite10B()
        {
            SliderGeneralRiskBasedCapitalLossOffSite10B.Click();
        }

        private void ClickSliderGeneralRiskBasedCapitalLossOffSite10BGreater()
        {
            SliderGeneralRiskBasedCapitalLossOffSite10BGreater.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOnSiteNone()
        {
            SliderGeneralRiskBasedEconomicImpactOnSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOnSite100k()
        {
            SliderGeneralRiskBasedEconomicImpactOnSite100k.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOnSite1M()
        {
            SliderGeneralRiskBasedEconomicImpactOnSite1M.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOnSite10M()
        {
            SliderGeneralRiskBasedEconomicImpactOnSite10M.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOnSite100M()
        {
            SliderGeneralRiskBasedEconomicImpactOnSite100M.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOnSite1B()
        {
            SliderGeneralRiskBasedEconomicImpactOnSite1B.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOnSite10B()
        {
            SliderGeneralRiskBasedEconomicImpactOnSite10B.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOnSite10BGreater()
        {
            SliderGeneralRiskBasedEconomicImpactOnSite10BGreater.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOffSiteNone()
        {
            SliderGeneralRiskBasedEconomicImpactOffSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOffSite100k()
        {
            SliderGeneralRiskBasedEconomicImpactOffSite100k.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOffSite1M()
        {
            SliderGeneralRiskBasedEconomicImpactOffSite1M.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOffSite10M()
        {
            SliderGeneralRiskBasedEconomicImpactOffSite10M.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOffSite100M()
        {
            SliderGeneralRiskBasedEconomicImpactOffSite100M.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOffSite1B()
        {
            SliderGeneralRiskBasedEconomicImpactOffSite1B.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOffSite10B()
        {
            SliderGeneralRiskBasedEconomicImpactOffSite10B.Click();
        }

        private void ClickSliderGeneralRiskBasedEconomicImpactOffSite10BGreater()
        {
            SliderGeneralRiskBasedEconomicImpactOffSite10BGreater.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOnSiteNone()
        {
            SliderGeneralRiskBasedEnvironmentalOnSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOnSite100k()
        {
            SliderGeneralRiskBasedEnvironmentalOnSite100k.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOnSite1M()
        {
            SliderGeneralRiskBasedEnvironmentalOnSite1M.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOnSite10M()
        {
            SliderGeneralRiskBasedEnvironmentalOnSite10M.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOnSite100M()
        {
            SliderGeneralRiskBasedEnvironmentalOnSite100M.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOnSite1B()
        {
            SliderGeneralRiskBasedEnvironmentalOnSite1B.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOnSite10B()
        {
            SliderGeneralRiskBasedEnvironmentalOnSite10B.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOnSite10BGreater()
        {
            SliderGeneralRiskBasedEnvironmentalOnSite10BGreater.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOffSiteNone()
        {
            SliderGeneralRiskBasedEnvironmentalOffSiteNone.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOffSite100k()
        {
            SliderGeneralRiskBasedEnvironmentalOffSite100k.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOffSite1M()
        {
            SliderGeneralRiskBasedEnvironmentalOffSite1M.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOffSite10M()
        {
            SliderGeneralRiskBasedEnvironmentalOffSite10M.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOffSite100M()
        {
            SliderGeneralRiskBasedEnvironmentalOffSite100M.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOffSite1B()
        {
            SliderGeneralRiskBasedEnvironmentalOffSite1B.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOffSite10B()
        {
            SliderGeneralRiskBasedEnvironmentalOffSite10B.Click();
        }

        private void ClickSliderGeneralRiskBasedEnvironmentalOffSite10BGreater()
        {
            SliderGeneralRiskBasedEnvironmentalOffSite10BGreater.Click();
        }

        private void ClickNistCheckAirTransportation()
        {
            CheckboxNistAirTransportation.Click();
        }

        private void ClickNistCheckAssetLM()
        {
            CheckboxNistAssetLiabilityManagement.Click();
        }

        private void ClickNistCheckBE()
        {
            CheckboxNistBudgetExecution.Click();
        }

        private void ClickNistCheckBF()
        {
            CheckboxNistBudgetFormulation.Click();
        }
        private void ClickNistCheckBPI()
        {
            CheckboxNistBudgetingPerformanceInt.Click();
        }
        private void ClickNistCheckCP()
        {
            CheckboxNistCapitalPlan.Click();
        }
        private void ClickNistCheckCR()
        {
            CheckboxNistCollectReceive.Click();
        }
        private void ClickNistCheckContingencyP()
        {
            CheckboxNistContingencyPlan.Click();
        }
        private void ClickNistCheckCOps()
        {
            CheckboxNistContinuityOfOps.Click();
        }
        private void ClickNistCheckCAPM()
        {
            CheckboxNistCostAccount.Click();
        }
        private void ClickNistCheckCS()
        {
            CheckboxNistCustomerServices.Click();
        }
        private void ClickNistCheckDPP()
        {
            CheckboxNistDisasterPrep.Click();
        }
        private void ClickNistCheckER()
        {
            CheckboxNistEmergencyResponse.Click();
        }
        private void ClickNistCheckECP()
        {
            CheckboxNistEnergyConservation.Click(); 
        }
        private void ClickNistCheckEP()
        {
            CheckboxNistEnergyProduction.Click();
        }
        private void ClickNistCheckERM()
        {
            CheckboxNistEnergyResourceManagement.Click();
        }
        private void ClickNistCheckESSSS()
        {
            CheckboxNistEnergySupply.Click();
        }
        private void ClickNistCheckEArch()
        {
            CheckboxNistEnterpriseArch.Click();
        }
        private void ClickNistCheckEnvMF()
        {
            CheckboxNistEnvMonitor.Click();
        }
        private void ClickNistCheckEnvR()
        {
            CheckboxNistEnvRemediation.Click(); 
        }
        private void ClickNistCheckFFEM()
        {
            CheckboxNistFacilitiesFleet.Click();
        }
        private void ClickNistCheckGPDS()
        {
            CheckboxNistGeneralPurpose.Click();
        }
        private void ClickNistCheckGoodsAcq()
        {
            CheckboxNistGoodsAcquisition.Click();
        }
        private void ClickNistCheckGroundTrans()
        {
            CheckboxNistGroundTransport.Click();
        }
        private void ClickNistCheckHDS()
        {
            CheckboxNistHelpDesk.Click();
        }
        private void ClickNistCheckIIM()
        {
            CheckboxNistInfoInfraManagement.Click();
        }
        private void ClickNistCheckInfoM()
        {
            CheckboxNistInfoManagement.Click();
        }
        private void ClickNistCheckInfoSec()
        {
            CheckboxNistInfoSec.Click();
        }
        private void ClickNistCheckInfoShare()
        {
            CheckboxNistInfoShare.Click();
        }
        private void ClickNistCheckIPP()
        {
            CheckboxNistIntellectualProperty.Click();
        }
        private void ClickNistCheckIC()
        {
            CheckboxNistInventoryControl.Click();
        }
        private void ClickNistCheckKACIP()
        {
            CheckboxNistKeyAsset.Click();
        }
        private void ClickNistCheckLRM()
        {
            CheckboxNistLaborRights.Click();
        }
        private void ClickNistCheckLCM()
        {
            CheckboxNistLifecycleChange.Click();
        }
        private void ClickNistCheckLogM()
        {
            CheckboxNistLogisticsManagement.Click();
        }
        private void ClickNistCheckMI()
        {
            CheckboxNistManagementImprovement.Click();
        }
        private void ClickNistCheckManufacturing()
        {
            CheckboxNistManufacturing.Click();
        }
        private void ClickNistCheckOtherFin()
        {
            CheckboxNistOtherFinancial.Click();
        }
        private void ClickNistCheckOtherInfoM()
        {
            CheckboxNistOtherInfoManagement.Click();
        }
        private void ClickNistCheckOtherM()
        {
            CheckboxNistOtherManagement.Click();
        }
        private void ClickNistCheckOtherOps()
        {
            CheckboxNistOtherOps.Click();
        }
        private void ClickNistCheckOtherRD()
        {
            CheckboxNistOtherRAndD.Click();
        }
        private void ClickNistCheckOtherSec()
        {
            CheckboxNistOtherSecurity.Click();
        }
        private void ClickNistCheckOtherSuppF()
        {
            CheckboxNistOtherSupportFunc.Click();
        }
        private void ClickNistCheckPayments()
        {
            CheckboxNistPayments.Click();
        }
        private void ClickNistCheckPIM()
        {
            CheckboxNistPercentageInraMaint.Click();
        }
        private void ClickNistCheckPL()
        {
            CheckboxNistPermitsAndLicensing.Click();
        }
        private void ClickNistCheckPPC()
        {
            CheckboxNistPollutionPrevention.Click();
        }
        private void ClickNistCheckPO()
        {
            CheckboxNistProductOutreach.Click();
        }
        private void ClickNistCheckPP()
        {
            CheckboxNistPropertyProtection.Click();
        }
        private void ClickNistCheckPR()
        {
            CheckboxNistPR.Click();
        }
        private void ClickNistCheckRR()
        {
            CheckboxNistRecordsRetention.Click();
        }
        private void ClickNistCheckRI()
        {
            CheckboxNistReportingInfo.Click();
        }
        private void ClickNistCheckRD()
        {
            CheckboxNistRAndD.Click();
        }
        private void ClickNistCheckSTRI()
        {
            CheckboxNistScientificAndTech.Click();
        }
        private void ClickNistCheckSM()
        {
            CheckboxNistSecManagement.Click();
        }
        private void ClickNistCheckSR()
        {
            CheckboxNistServiceRecovery.Click();
        }
        private void ClickNistCheckSAcq()
        {
            CheckboxNistServicesAcquisition.Click();
        }
        private void ClickNistCheckSNM()
        {
            CheckboxNistSystemAndNetMonitoring.Click();
        }
        private void ClickNistCheckSD()
        {
            CheckboxNistSystemDev.Click();
        }
        private void ClickNistCheckSysM()
        {
            CheckboxNistSystemMaintenance.Click();
        }
        private void ClickNistCheckTE()
        {
            CheckboxNistTrainingAndEmployment.Click();
        }
        private void ClickNistCheckWRM()
        {
            CheckboxNistWaterResource.Click();
        }
        private void ClickNistCheckWTrans()
        {
            CheckboxNistWaterTransport.Click();
        }
        private void ClickNistCheckWFP()
        {
            CheckboxNistWorkForcePlanning.Click();
        }
        private void ClickNistCheckWS()
        {
            CheckboxNistWorkerSafety.Click();
        }
        private void ClickNistCheckWPDM()
        {
            CheckboxNistWorkplacePolicyDev.Click();
        }
        private void ClickNistA2()
        {
            NistTableLinkA2.Click();
        }
        private void ClickNistA13()
        {
            NistTableLinkA13.Click();
        }
        private void ClickNistA14()
        {
            NistTableLinkA14.Click();
        }
        private void ClickNistA15()
        {
            NistTableLinkA15.Click();
        }
        private void ClickNistA16()
        {
            NistTableLinkA16.Click();
        }
        private void ClickNistA18()
        {
            NistTableLinkA18.Click();
        }
        private void ClickNistA20()
        {
            NistTableLinkA20.Click();
        }
        private void ClickNistA22()
        {
            NistTableLinkA22.Click();
        }
        private void ClickNistA23()
        {
            NistTableLinkA23.Click();
        }
        private void ClickNistA25()
        {
            NistTableLinkA25.Click();
        }
        private void ClickNistA33()
        {
            NistTableLinkA33.Click();
        }
        private void ClickNistA51()
        {
            NistTableLinkA51.Click();
        }
        private void ClickNistA60()
        {
            NistTableLinkA60.Click();
        }
        private void ClickNistA65()
        {
            NistTableLinkA65.Click();
        }
        private void ClickNistC2()
        {
            NistTableLinkC2.Click();
        }
        private void ClickNistC13()
        {
            NistTableLinkC13.Click();
        }
        private void ClickNistC14()
        {
            NistTableLinkC14.Click();
        }
        private void ClickNistC15()
        {
            NistTableLinkC15.Click();
        }
        private void ClickNistC16()
        {
            NistTableLinkC16.Click();
        }
        private void ClickNistC18()
        {
            NistTableLinkC18.Click();
        }
        private void ClickNistC20()
        {
            NistTableLinkC20.Click();
        }
        private void ClickNistC22()
        {
            NistTableLinkC22.Click();
        }
        private void ClickNistC23()
        {
            NistTableLinkC23.Click();
        }
        private void ClickNistC25()
        {
            NistTableLinkC25.Click();
        }
        private void ClickNistC33()
        {
            NistTableLinkC33.Click();
        }
        private void ClickNistC51()
        {
            NistTableLinkC51.Click();
        }
        private void ClickNistC60()
        {
            NistTableLinkC60.Click();
        }
        private void ClickNistC65()
        {
            NistTableLinkC65.Click();
        }
        private void ClickNistI2()
        {
            NistTableLinkI2.Click();
        }
        private void ClickNistI13()
        {
            NistTableLinkI13.Click();
        }
        private void ClickNistI14()
        {
            NistTableLinkI14.Click();
        }
        private void ClickNistI15()
        {
            NistTableLinkI15.Click();
        }
        private void ClickNistI16()
        {
            NistTableLinkI16.Click();
        }
        private void ClickNistI18()
        {
            NistTableLinkI18.Click();
        }
        private void ClickNistI20()
        {
            NistTableLinkI20.Click();
        }
        private void ClickNistI22()
        {
            NistTableLinkI22.Click();
        }
        private void ClickNistI23()
        {
            NistTableLinkI23.Click();
        }
        private void ClickNistI25()
        {
            NistTableLinkI25.Click();
        }
        private void ClickNistI33()
        {
            NistTableLinkI33.Click();
        }
        private void ClickNistI51()
        {
            NistTableLinkI51.Click();
        }
        private void ClickNistI60()
        {
            NistTableLinkI60.Click();
        }
        private void ClickNistI65()
        {
            NistTableLinkI65.Click();
        }
        private void ClickNistPleaseConfirmYes()
        {
            NistPleaseConfirmYesButton.Click();
        }
        private void ClickNistAnswerQ1No()
        {
            NistAnswerQuestions1No.Click();
        }
        private void ClickNistAnswerQ1Yes()
        {
            NistAnswerQuestions1Yes.Click();
        }
        private void ClickNistAnswerQ2No()
        {
            NistAnswerQuestions2No.Click();
        }
        private void ClickNistAnswerQ2Yes()
        {
            NistAnswerQuestions2Yes.Click();
        }
        private void ClickNistAnswerQ3No()
        {
            NistAnswerQuestions3No.Click();
        }
        private void ClickNistAnswerQ3Yes()
        {
            NistAnswerQuestions3Yes.Click();
        }
        private void ClickNistAnswerQ4No()
        {
            NistAnswerQuestions4No.Click();
        }
        private void ClickNistAnswerQ4Yes()
        {
            NistAnswerQuestions4Yes.Click();
        }
        private void ClickNistAnswerQ5No()
        {
            NistAnswerQuestions5No.Click();
        }
        private void ClickNistAnswerQ5Yes()
        {
            NistAnswerQuestions5Yes.Click();
        }
        private void ClickNistAnswerQ6No()
        {
            NistAnswerQuestions6No.Click();
        }
        private void ClickNistAnswerQ6Yes()
        {
            NistAnswerQuestions6Yes.Click();
        }
        private void ClickNistAnswerQ7No()
        {
            NistAnswerQuestions7No.Click();
        }
        private void ClickNistAnswerQ7Yes()
        {
            NistAnswerQuestions7Yes.Click();
        }
        private void ClickNistAnswerQ8No()
        {
            NistAnswerQuestions8No.Click();
        }
        private void ClickNistAnswerQ8Yes()
        {
            NistAnswerQuestions8Yes.Click();
        }

        //Aggregate Methods
        //public Boolean retryButtonClick(By by)
        //{
        //    Boolean result = false;
        //    int attempts = 0;
        //    while (attempts < 2)
        //    {
        //        try
        //        {
        //            this.driver.FindElement(by).Click();
        //            result = true;
        //            break;
        //        }
        //        catch (StaleElementReferenceException e)
        //        {
        //        }
        //        attempts++;
        //    }
        //    return result;
        //}
        //public Boolean retryButtonScroll(By by)
        //{
        //    Boolean result = false;
        //    int attempts = 0;
        //    while (attempts < 2)
        //    {
        //        try
        //        {
        //            this.actions.MoveToElement(driver.FindElement(by)).Perform();
        //            result = true;
        //            break;
        //        }
        //        catch (StaleElementReferenceException e)
        //        {
        //        }
        //        attempts++;
        //    }
        //    return result;
        //}
        public void SelectHeaderSimple()
        {

            retryButtonScroll(TextHeaderSimple, actions);
            retryButtonClick(TextHeaderSimple);
            //ClickHeaderSimple();
            retryButtonClick(TextHeaderOverallSalLow);
            retryButtonClick(TextHeaderOverallSalModerate);
            retryButtonClick(TextHeaderOverallSalHigh);
            retryButtonClick(TextHeaderOverallSalVeryHigh);
            retryButtonClick(TextHeaderConfidentialityLow);
            retryButtonClick(TextHeaderConfidentialityModerate);
            retryButtonClick(TextHeaderConfidentialityHigh);
            retryButtonClick(TextHeaderConfidentialityVeryHigh);
            retryButtonClick(TextHeaderIntegrityLow);
            retryButtonClick(TextHeaderIntegrityModerate);
            retryButtonClick(TextHeaderIntegrityHigh);
            retryButtonClick(TextHeaderIntegrityVeryHigh);
            retryButtonClick(TextHeaderAvailabilityLow);
            retryButtonClick(TextHeaderAvailabilityModerate);
            retryButtonClick(TextHeaderAvailabilityHigh);
            retryButtonClick(TextHeaderAvailabilityVeryHigh);
            ClickNext();
        }

        public void SelectHeaderGeneralRiskBased()
        {
            this.actions.MoveToElement(driver.FindElement(By.XPath("//label[contains(text(),'General Risk Based')]")));
            actions.Perform();
            retryButtonClick(TextHeaderGeneralRiskBased);

            this.actions.MoveToElement(SliderGeneralRiskBasedInjuriesOnSite1);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSite1);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSiteNone);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSite11);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSite51);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSite101);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSite251);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSite501);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSite751);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOnSite1000);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSite1);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSiteNone);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSite11);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSite51);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSite101);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSite251);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSite501);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSite751);
            retryButtonClick(SliderGeneralRiskBasedInjuriesOffSite1000);
            //
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSite1);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSiteNone);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSite11);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSite51);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSite101);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSite251);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSite501);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSite751);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOnSite1000);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSite1);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSiteNone);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSite11);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSite51);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSite101);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSite251);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSite501);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSite751);
            retryButtonClick(SliderGeneralRiskBasedHospitalizationsOffSite1000);
            //
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSite1);
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSiteNone);
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSite11);
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSite51);
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSite101);
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSite251);
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSite501);
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSite751);
            retryButtonClick(SliderGeneralRiskBasedDeathsOnSite1000);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSite1);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSiteNone);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSite11);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSite51);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSite101);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSite251);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSite501);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSite751);
            retryButtonClick(SliderGeneralRiskBasedDeathsOffSite1000);
            //
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOnSite100k);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOnSiteNone);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOnSite1M);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOnSite10M);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOnSite100M);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOnSite1B);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOnSite10B);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOnSite10BGreater);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOffSite100k);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOffSiteNone);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOffSite1M);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOffSite10M);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOffSite100M);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOffSite1B);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOffSite10B);
            retryButtonClick(SliderGeneralRiskBasedCapitalLossOffSite10BGreater);
            
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOnSite100k);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOnSiteNone);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOnSite1M);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOnSite10M);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOnSite100M);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOnSite1B);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOnSite10B);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOnSite10BGreater);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOffSite100k);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOffSiteNone);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOffSite1M);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOffSite10M);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOffSite100M);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOffSite1B);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOffSite10B);
            retryButtonClick(SliderGeneralRiskBasedEconomicImpactOffSite10BGreater);
            
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOnSite100k);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOnSiteNone);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOnSite1M);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOnSite10M);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOnSite100M);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOnSite1B);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOnSite10B);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOnSite10BGreater);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOffSite100k);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOffSiteNone);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOffSite1M);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOffSite10M);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOffSite100M);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOffSite1B);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOffSite10B);
            retryButtonClick(SliderGeneralRiskBasedEnvironmentalOffSite10BGreater);
            
            
        }

        public void SelectHeaderNist()
        {
            this.actions.MoveToElement(driver.FindElement(By.XPath("//label[contains(text(),'NIST-60 / FIPS-199')]")));
            actions.Perform();
            ClickHeaderNist();
            retryButtonClick(TextHeaderOverallSalLow);
            retryButtonClick(TextHeaderOverallSalModerate);
            retryButtonClick(TextHeaderOverallSalHigh);
            retryButtonClick(TextHeaderOverallSalVeryHigh);
            retryButtonClick(TextHeaderConfidentialityLow);
            retryButtonClick(TextHeaderConfidentialityModerate);
            retryButtonClick(TextHeaderConfidentialityHigh);
            retryButtonClick(TextHeaderConfidentialityVeryHigh);
            retryButtonClick(TextHeaderIntegrityLow);
            retryButtonClick(TextHeaderIntegrityModerate);
            retryButtonClick(TextHeaderIntegrityHigh);
            retryButtonClick(TextHeaderIntegrityVeryHigh);
            retryButtonClick(TextHeaderAvailabilityLow);
            retryButtonClick(TextHeaderAvailabilityModerate);
            retryButtonClick(TextHeaderAvailabilityHigh);
            retryButtonClick(TextHeaderAvailabilityVeryHigh);
            retryButtonClick(CheckboxNistAirTransportation);
            retryButtonClick(CheckboxNistAssetLiabilityManagement);
            retryButtonClick(CheckboxNistBudgetExecution);
            retryButtonClick(CheckboxNistBudgetFormulation);
            retryButtonClick(CheckboxNistBudgetingPerformanceInt);
            retryButtonClick(CheckboxNistCapitalPlan);
            retryButtonClick(NistTableLinkC2);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA2);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI2);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(CheckboxNistContingencyPlan);
            retryButtonClick(CheckboxNistContinuityOfOps);
            retryButtonClick(CheckboxNistCostAccount);
            retryButtonClick(CheckboxNistCollectReceive);
            retryButtonClick(CheckboxNistCustomerServices);
            retryButtonClick(CheckboxNistDisasterPrep);
            retryButtonClick(CheckboxNistEnterpriseArch);
            retryButtonClick(CheckboxNistEnergyConservation);
            retryButtonClick(CheckboxNistEnvMonitor);
            retryButtonClick(CheckboxNistEnvRemediation);
            retryButtonClick(CheckboxNistEnergyProduction);
            retryButtonClick(CheckboxNistEmergencyResponse);
            retryButtonClick(CheckboxNistEnergyResourceManagement);
            retryButtonClick(CheckboxNistEnergySupply);
            retryButtonClick(CheckboxNistFacilitiesFleet);
            retryButtonClick(CheckboxNistGoodsAcquisition);
            retryButtonClick(CheckboxNistGeneralPurpose);
            retryButtonClick(CheckboxNistGroundTransport);
            retryButtonClick(CheckboxNistHelpDesk);
            retryButtonClick(NistTableLinkC13);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC14);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC15);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC16);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC18);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC20);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC22);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC23);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC25);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA13);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA14);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA15);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA16);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA18);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA20);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA22);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA23);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA25);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI13);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI14);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI15);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI16);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI18);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI20);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI22);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI23);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI25);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(CheckboxNistInventoryControl);
            retryButtonClick(CheckboxNistInfoInfraManagement);
            retryButtonClick(CheckboxNistInfoManagement);
            retryButtonClick(CheckboxNistInfoSec);
            retryButtonClick(CheckboxNistInfoShare);
            retryButtonClick(CheckboxNistIntellectualProperty);
            retryButtonClick(CheckboxNistKeyAsset);
            retryButtonClick(NistTableLinkC33);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA33);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI33);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(CheckboxNistLifecycleChange);
            retryButtonClick(CheckboxNistLogisticsManagement);
            retryButtonClick(CheckboxNistLaborRights);
            retryButtonClick(CheckboxNistManufacturing);
            retryButtonClick(CheckboxNistManagementImprovement);
            retryButtonClick(CheckboxNistOtherFinancial);
            retryButtonClick(CheckboxNistOtherInfoManagement);
            retryButtonClick(CheckboxNistOtherManagement);
            retryButtonClick(CheckboxNistOtherOps);
            retryButtonClick(CheckboxNistOtherRAndD);
            retryButtonClick(CheckboxNistOtherSecurity);
            retryButtonClick(CheckboxNistOtherSupportFunc);
            retryButtonClick(CheckboxNistPayments);
            retryButtonClick(CheckboxNistPercentageInraMaint);
            retryButtonClick(CheckboxNistPermitsAndLicensing);
            retryButtonClick(CheckboxNistProductOutreach);
            retryButtonClick(CheckboxNistPropertyProtection);
            retryButtonClick(CheckboxNistPollutionPrevention);
            retryButtonClick(CheckboxNistPR);
            retryButtonClick(NistTableLinkC51);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA51);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI51);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(CheckboxNistRAndD);
            retryButtonClick(CheckboxNistReportingInfo);
            retryButtonClick(CheckboxNistRecordsRetention);
            retryButtonClick(CheckboxNistServicesAcquisition);
            retryButtonClick(CheckboxNistSystemDev);
            retryButtonClick(CheckboxNistSecManagement);
            retryButtonClick(CheckboxNistSystemAndNetMonitoring);
            retryButtonClick(CheckboxNistServiceRecovery);
            retryButtonClick(CheckboxNistScientificAndTech);
            retryButtonClick(CheckboxNistSystemMaintenance);
            retryButtonClick(CheckboxNistTrainingAndEmployment);
            retryButtonClick(CheckboxNistWorkForcePlanning);
            retryButtonClick(CheckboxNistWaterResource);
            retryButtonClick(CheckboxNistWorkerSafety);
            retryButtonClick(CheckboxNistWaterTransport);
            retryButtonClick(CheckboxNistWorkplacePolicyDev);
            retryButtonClick(NistTableLinkC60);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkC65);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA60);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkA65);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI60);
            retryButtonClick(NistPleaseConfirmYesButton);
            retryButtonClick(NistTableLinkI65);
            retryButtonClick(NistPleaseConfirmYesButton);

            this.actions.MoveToElement(driver.FindElement(By.XPath("//*[@id='sidenav-content']/app-prepare/app-sals/div/div/div[6]/div/app-sal-nist/div[2]/div[2]/table/tr[8]/td[2]/div/label[1]")));
            actions.Perform();
            retryButtonClick(NistAnswerQuestions1No);
            retryButtonClick(NistAnswerQuestions1Yes);
            retryButtonClick(NistAnswerQuestions2Yes);
            retryButtonClick(NistAnswerQuestions3Yes);
            retryButtonClick(NistAnswerQuestions4Yes);
            retryButtonClick(NistAnswerQuestions5Yes);
            retryButtonClick(NistAnswerQuestions6Yes);
            retryButtonClick(NistAnswerQuestions7Yes);
            retryButtonClick(NistAnswerQuestions8Yes);

            retryButtonClick(NistAnswerQuestions2No);
            retryButtonClick(NistAnswerQuestions3No);
            retryButtonClick(NistAnswerQuestions4No);
            retryButtonClick(NistAnswerQuestions5No);
            retryButtonClick(NistAnswerQuestions6No);
            retryButtonClick(NistAnswerQuestions7No);
            retryButtonClick(NistAnswerQuestions8No);
        }

        public void SelectHeaderOverallSalLow()
        {
            ClickHeaderOverallSalLow();
        }

        public void SelectHeaderOverallSalModerate()
        {
            ClickHeaderOverallSalModerate();
        }
        public void SelectHeaderOverallSalHigh()
        {
            ClickHeaderOverallSalHigh();
        }
        public void SelectHeaderOverallSalVeryHigh()
        {
            ClickHeaderOverallSalVeryHigh();
        }

        public void SelectHeaderConfidentialityLow()
        {
            ClickHeaderConfidentialityLow();
        }

        public void SelectHeaderConfidentialityModerate()
        {
            ClickHeaderConfidentialityModerate();
        }

        public void SelectHeaderConfidentialityHigh()
        {
            ClickHeaderConfidentialityHigh();
        }

        public void SelectHeaderConfidentialityVeryHigh()
        {
            ClickHeaderConfidentialityVeryHigh();
        }

        public void SelectHeaderIntegrityLow()
        {
            ClickHeaderIntegrityLow();
        }

        public void SelectHeaderIntegrityModerate()
        {
            ClickHeaderIntegrityModerate();
        }

        public void SelectHeaderIntegrityHigh()
        {
            ClickHeaderIntegrityHigh();
        }

        public void SelectHeaderIntegrityVeryHigh()
        {
            ClickHeaderIntegrityVeryHigh();
        }

        public void SelectHeaderAvailabilityLow()
        {
            ClickHeaderAvailabilityLow();
        }

        public void SelectHeaderAvailabilityModerate()
        {
            ClickHeaderAvailabilityModerate();
        }

        public void SelectHeaderAvailabilityHigh()
        {
            ClickHeaderAvailabilityHigh();
        }

        public void SelectHeaderAvailabilityVeryHigh()
        {
            ClickHeaderAvailabilityVeryHigh();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOnSiteNone()
        {
            ClickSliderGeneralRiskBasedInjuriesOnSiteNone();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOnSite1()
        {
            
            ClickSliderGeneralRiskBasedInjuriesOnSite1();
        }
        public void SelectSliderGeneralRiskBasedInjuriesOnSite11()
        {
            ClickSliderGeneralRiskBasedInjuriesOnSite11();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOnSite51()
        {
            ClickSliderGeneralRiskBasedInjuriesOnSite51();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOnSite101()
        {
            ClickSliderGeneralRiskBasedInjuriesOnSite101();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOnSite251()
        {
            ClickSliderGeneralRiskBasedInjuriesOnSite251();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOnSite501()
        {
            ClickSliderGeneralRiskBasedInjuriesOnSite501();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOnSite751()
        {
            ClickSliderGeneralRiskBasedInjuriesOnSite751();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOnSite1000()
        {
            ClickSliderGeneralRiskBasedInjuriesOnSite1000();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOffSiteNone()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSiteNone();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOffSite1()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSite1();
        }
        public void SelectSliderGeneralRiskBasedInjuriesOffSite11()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSite11();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOffSite51()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSite51();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOffSite101()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSite101();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOffSite251()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSite251();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOffSite501()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSite501();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOffSite751()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSite751();
        }

        public void SelectSliderGeneralRiskBasedInjuriesOffSite1000()
        {
            ClickSliderGeneralRiskBasedInjuriesOffSite1000();
        }
        //
        public void SelectSliderGeneralRiskBasedHospitalizationsOnSiteNone()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSiteNone();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOnSite1()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSite1();
        }
        public void SelectSliderGeneralRiskBasedHospitalizationsOnSite11()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSite11();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOnSite51()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSite51();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOnSite101()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSite101();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOnSite251()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSite251();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOnSite501()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSite501();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOnSite751()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSite751();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOnSite1000()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOnSite1000();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOffSiteNone()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSiteNone();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOffSite1()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSite1();
        }
        public void SelectSliderGeneralRiskBasedHospitalizationsOffSite11()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSite11();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOffSite51()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSite51();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOffSite101()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSite101();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOffSite251()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSite251();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOffSite501()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSite501();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOffSite751()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSite751();
        }

        public void SelectSliderGeneralRiskBasedHospitalizationsOffSite1000()
        {
            ClickSliderGeneralRiskBasedHospitalizationsOffSite1000();
        }

        public void SelectSliderGeneralRiskBasedDeathsOnSiteNone()
        {
            ClickSliderGeneralRiskBasedDeathsOnSiteNone();
        }

        public void SelectSliderGeneralRiskBasedDeathsOnSite1()
        {
            ClickSliderGeneralRiskBasedDeathsOnSite1();
        }
        public void SelectSliderGeneralRiskBasedDeathsOnSite11()
        {
            ClickSliderGeneralRiskBasedDeathsOnSite11();
        }

        public void SelectSliderGeneralRiskBasedDeathsOnSite51()
        {
            ClickSliderGeneralRiskBasedDeathsOnSite51();
        }

        public void SelectSliderGeneralRiskBasedDeathsOnSite101()
        {
            ClickSliderGeneralRiskBasedDeathsOnSite101();
        }

        public void SelectSliderGeneralRiskBasedDeathsOnSite251()
        {
            ClickSliderGeneralRiskBasedDeathsOnSite251();
        }

        public void SelectSliderGeneralRiskBasedDeathsOnSite501()
        {
            ClickSliderGeneralRiskBasedDeathsOnSite501();
        }

        public void SelectSliderGeneralRiskBasedDeathsOnSite751()
        {
            ClickSliderGeneralRiskBasedDeathsOnSite751();
        }

        public void SelectSliderGeneralRiskBasedDeathsOnSite1000()
        {
            ClickSliderGeneralRiskBasedDeathsOnSite1000();
        }

        public void SelectSliderGeneralRiskBasedDeathsOffSiteNone()
        {
            ClickSliderGeneralRiskBasedDeathsOffSiteNone();
        }

        public void SelectSliderGeneralRiskBasedDeathsOffSite1()
        {
            ClickSliderGeneralRiskBasedDeathsOffSite1();
        }
        public void SelectSliderGeneralRiskBasedDeathsOffSite11()
        {
            ClickSliderGeneralRiskBasedDeathsOffSite11();
        }

        public void SelectSliderGeneralRiskBasedDeathsOffSite51()
        {
            ClickSliderGeneralRiskBasedDeathsOffSite51();
        }

        public void SelectSliderGeneralRiskBasedDeathsOffSite101()
        {
            ClickSliderGeneralRiskBasedDeathsOffSite101();
        }

        public void SelectSliderGeneralRiskBasedDeathsOffSite251()
        {
            ClickSliderGeneralRiskBasedDeathsOffSite251();
        }

        public void SelectSliderGeneralRiskBasedDeathsOffSite501()
        {
            ClickSliderGeneralRiskBasedDeathsOffSite501();
        }

        public void SelectSliderGeneralRiskBasedDeathsOffSite751()
        {
            ClickSliderGeneralRiskBasedDeathsOffSite751();
        }

        public void SelectSliderGeneralRiskBasedDeathsOffSite1000()
        {
            ClickSliderGeneralRiskBasedDeathsOffSite1000();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOnSiteNone()
        {
            ClickSliderGeneralRiskBasedCapitalLossOnSiteNone();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOnSite100k()
        {
            ClickSliderGeneralRiskBasedCapitalLossOnSite100k();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOnSite1M()
        {
            ClickSliderGeneralRiskBasedCapitalLossOnSite1M();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOnSite10M()
        {
            ClickSliderGeneralRiskBasedCapitalLossOnSite10M();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOnSite100M()
        {
            ClickSliderGeneralRiskBasedCapitalLossOnSite100M();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOnSite1B()
        {
            ClickSliderGeneralRiskBasedCapitalLossOnSite1B();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOnSite10B()
        {
            ClickSliderGeneralRiskBasedCapitalLossOnSite10B();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOnSite10BGreater()
        {
            ClickSliderGeneralRiskBasedCapitalLossOnSite10BGreater();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOffSiteNone()
        {
            ClickSliderGeneralRiskBasedCapitalLossOffSiteNone();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOffSite100k()
        {
            ClickSliderGeneralRiskBasedCapitalLossOffSite100k();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOffSite1M()
        {
            ClickSliderGeneralRiskBasedCapitalLossOffSite1M();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOffSite10M()
        {
            ClickSliderGeneralRiskBasedCapitalLossOffSite10M();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOffSite100M()
        {
            ClickSliderGeneralRiskBasedCapitalLossOffSite100M();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOffSite1B()
        {
            ClickSliderGeneralRiskBasedCapitalLossOffSite1B();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOffSite10B()
        {
            ClickSliderGeneralRiskBasedCapitalLossOffSite10B();
        }

        public void SelectSliderGeneralRiskBasedCapitalLossOffSite10BGreater()
        {
            ClickSliderGeneralRiskBasedCapitalLossOffSite10BGreater();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOnSiteNone()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOnSiteNone();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOnSite100k()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOnSite100k();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOnSite1M()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOnSite1M();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOnSite10M()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOnSite10M();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOnSite100M()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOnSite100M();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOnSite1B()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOnSite1B();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOnSite10B()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOnSite10B();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOnSite10BGreater()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOnSite10BGreater();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOffSiteNone()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOffSiteNone();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOffSite100k()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOffSite100k();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOffSite1M()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOffSite1M();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOffSite10M()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOffSite10M();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOffSite100M()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOffSite100M();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOffSite1B()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOffSite1B();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOffSite10B()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOffSite10B();
        }

        public void SelectSliderGeneralRiskBasedEconomicImpactOffSite10BGreater()
        {
            ClickSliderGeneralRiskBasedEconomicImpactOffSite10BGreater();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOnSiteNone()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOnSiteNone();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOnSite100k()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOnSite100k();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOnSite1M()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOnSite1M();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOnSite10M()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOnSite10M();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOnSite100M()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOnSite100M();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOnSite1B()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOnSite1B();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOnSite10B()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOnSite10B();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOnSite10BGreater()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOnSite10BGreater();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOffSiteNone()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOffSiteNone();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOffSite100k()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOffSite100k();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOffSite1M()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOffSite1M();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOffSite10M()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOffSite10M();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOffSite100M()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOffSite100M();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOffSite1B()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOffSite1B();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOffSite10B()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOffSite10B();
        }

        public void SelectSliderGeneralRiskBasedEnvironmentalOffSite10BGreater()
        {
            ClickSliderGeneralRiskBasedEnvironmentalOffSite10BGreater();
        }

        //nist
        public void SelectNistCheckAirTransportation()
        {
            ClickNistCheckAirTransportation();
        }

        public void SelectNistCheckAssetLM()
        {
            ClickNistCheckAssetLM();
        }

        public void SelectNistCheckBE()
        {
            ClickNistCheckBE();
        }

        public void SelectNistCheckBF()
        {
            ClickNistCheckBF();
        }
        public void SelectNistCheckBPI()
        {
            ClickNistCheckBPI();
        }
        public void SelectNistCheckCP()
        {
            ClickNistCheckCP();
        }
        public void SelectNistCheckCR()
        {
            ClickNistCheckCR();
        }
        public void SelectNistCheckContingencyP()
        {
            ClickNistCheckContingencyP();
        }
        public void SelectNistCheckCOps()
        {
            ClickNistCheckCOps();
        }
        public void SelectNistCheckCAPM()
        {
            ClickNistCheckCAPM();
        }
        public void SelectNistCheckCS()
        {
            ClickNistCheckCS();
        }
        public void SelectNistCheckDPP()
        {
            ClickNistCheckDPP();
        }
        public void SelectNistCheckER()
        {
            ClickNistCheckER();
        }
        public void SelectNistCheckECP()
        {
            ClickNistCheckECP();
        }
        public void SelectNistCheckEP()
        {
            ClickNistCheckEP();
        }
        public void SelectNistCheckERM()
        {
            ClickNistCheckERM();
        }
        public void SelectNistCheckESSSS()
        {
            ClickNistCheckESSSS();
        }
        public void SelectNistCheckEArch()
        {
            ClickNistCheckEArch();
        }
        public void SelectNistCheckEnvMF()
        {
            ClickNistCheckEnvMF();
        }
        public void SelectNistCheckEnvR()
        {
            ClickNistCheckEnvR();
        }
        public void SelectNistCheckFFEM()
        {
            ClickNistCheckFFEM();
        }
        public void SelectNistCheckGPDS()
        {
            ClickNistCheckGPDS();
        }
        public void SelectNistCheckGoodsAcq()
        {
            ClickNistCheckGoodsAcq();
        }
        public void SelectNistCheckGroundTrans()
        {
            ClickNistCheckGroundTrans();
        }
        public void SelectNistCheckHDS()
        {
            ClickNistCheckHDS();
        }
        public void SelectNistCheckIIM()
        {
            ClickNistCheckIIM();
        }
        public void SelectNistCheckInfoM()
        {
            ClickNistCheckInfoM();
        }
        public void SelectNistCheckInfoSec()
        {
            ClickNistCheckInfoSec();
        }
        public void SelectNistCheckInfoShare()
        {
            ClickNistCheckInfoShare();
        }
        public void SelectNistCheckIPP()
        {
            ClickNistCheckIPP();
        }
        public void SelectNistCheckIC()
        {
            ClickNistCheckIC();
        }
        public void SelectNistCheckKACIP()
        {
            ClickNistCheckKACIP();
        }
        public void SelectNistCheckLRM()
        {
            ClickNistCheckLRM();
        }
        public void SelectNistCheckLCM()
        {
            ClickNistCheckLCM();
        }
        public void SelectNistCheckLogM()
        {
            ClickNistCheckLogM();
        }
        public void SelectNistCheckMI()
        {
            ClickNistCheckMI();
        }
        public void SelectNistCheckManufacturing()
        {
            ClickNistCheckManufacturing();
        }
        public void SelectNistCheckOtherFin()
        {
            ClickNistCheckOtherFin();
        }
        public void SelectNistCheckOtherInfoM()
        {
            ClickNistCheckOtherInfoM();
        }
        public void SelectNistCheckOtherM()
        {
            ClickNistCheckOtherM();
        }
        public void SelectNistCheckOtherOps()
        {
            ClickNistCheckOtherOps();
        }
        public void SelectNistCheckOtherRD()
        {
            ClickNistCheckOtherRD();
        }
        public void SelectNistCheckOtherSec()
        {
            ClickNistCheckOtherSec();
        }
        public void SelectNistCheckOtherSuppF()
        {
            ClickNistCheckOtherSuppF();
        }
        public void SelectNistCheckPayments()
        {
            ClickNistCheckPayments();
        }
        public void SelectNistCheckPIM()
        {
            ClickNistCheckPIM();
        }
        public void SelectNistCheckPL()
        {
            ClickNistCheckPL();
        }
        public void SelectNistCheckPPC()
        {
            ClickNistCheckPPC();
        }
        public void SelectNistCheckPO()
        {
            ClickNistCheckPO();
        }
        public void SelectNistCheckPP()
        {
            ClickNistCheckPP();
        }
        public void SelectNistCheckPR()
        {
            ClickNistCheckPR();
        }
        public void SelectNistCheckRR()
        {
            ClickNistCheckRR();
        }
        public void SelectNistCheckRI()
        {
            ClickNistCheckRI();
        }
        public void SelectNistCheckRD()
        {
            ClickNistCheckRD();
        }
        public void SelectNistCheckSTRI()
        {
            ClickNistCheckSTRI();
        }
        public void SelectNistCheckSM()
        {
            ClickNistCheckSM();
        }
        public void SelectNistCheckSR()
        {
            ClickNistCheckSR();
        }
        public void SelectNistCheckSAcq()
        {
            ClickNistCheckSAcq();
        }
        public void SelectNistCheckSNM()
        {
            ClickNistCheckSNM();
        }
        public void SelectNistCheckSD()
        {
            ClickNistCheckSD();
        }
        public void SelectNistCheckSysM()
        {
            ClickNistCheckSysM();
        }
        public void SelectNistCheckTE()
        {
            ClickNistCheckTE();
        }
        public void SelectNistCheckWRM()
        {
            ClickNistCheckWRM();
        }
        public void SelectNistCheckWTrans()
        {
            ClickNistCheckWTrans();
        }
        public void SelectNistCheckWFP()
        {
            ClickNistCheckWFP();
        }
        public void SelectNistCheckWS()
        {
            ClickNistCheckWS();
        }
        public void SelectNistCheckWPDM()
        {
            ClickNistCheckWPDM();
        }
        public void SelectNistA2()
        {
            ClickNistA2();
        }
        public void SelectNistA13()
        {
            ClickNistA13();
        }
        public void SelectNistA14()
        {
            ClickNistA14();
        }
        public void SelectNistA15()
        {
            ClickNistA15();
        }
        public void SelectNistA16()
        {
            ClickNistA16();
        }
        public void SelectNistA18()
        {
            ClickNistA18();
        }
        public void SelectNistA20()
        {
            ClickNistA20();
        }
        public void SelectNistA22()
        {
            ClickNistA22();
        }
        public void SelectNistA23()
        {
            ClickNistA23();
        }
        public void SelectNistA25()
        {
            ClickNistA25();
        }
        public void SelectNistA33()
        {
            ClickNistA33();
        }
        public void SelectNistA51()
        {
            ClickNistA51();
        }
        public void SelectNistA60()
        {
            ClickNistA60();
        }
        public void SelectNistA65()
        {
            ClickNistA65();
        }
        public void SelectNistC2()
        {
            ClickNistC2();
        }
        public void SelectNistC13()
        {
            ClickNistC13();
        }
        public void SelectNistC14()
        {
            ClickNistC14();
        }
        public void SelectNistC15()
        {
            ClickNistC15();
        }
        public void SelectNistC16()
        {
            ClickNistC16();
        }
        public void SelectNistC18()
        {
            ClickNistC18();
        }
        public void SelectNistC20()
        {
            ClickNistC20();
        }
        public void SelectNistC22()
        {
            ClickNistC22();
        }
        public void SelectNistC23()
        {
            ClickNistC23();
        }
        public void SelectNistC25()
        {
            ClickNistC25();
        }
        public void SelectNistC33()
        {
            ClickNistC33();
        }
        public void SelectNistC51()
        {
            ClickNistC51();
        }
        public void SelectNistC60()
        {
            ClickNistC60();
        }
        public void SelectNistC65()
        {
            ClickNistC65();
        }
        public void SelectNistI2()
        {
            ClickNistI2();
        }
        public void SelectNistI13()
        {
            ClickNistI13();
        }
        public void SelectNistI14()
        {
            ClickNistI14();
        }
        public void SelectNistI15()
        {
            ClickNistI15();
        }
        public void SelectNistI16()
        {
            ClickNistI16();
        }
        public void SelectNistI18()
        {
            ClickNistI18();
        }
        public void SelectNistI20()
        {
            ClickNistI20();
        }
        public void SelectNistI22()
        {
            ClickNistI22();
        }
        public void SelectNistI23()
        {
            ClickNistI23();
        }
        public void SelectNistI25()
        {
            ClickNistI25();
        }
        public void SelectNistI33()
        {
            ClickNistI33();
        }
        public void SelectNistI51()
        {
            ClickNistI51();
        }
        public void SelectNistI60()
        {
            ClickNistI60();
        }
        public void SelectNistI65()
        {
            ClickNistI65();
        }
        public void SelectNistPleaseConfirmYes()
        {
            ClickNistPleaseConfirmYes();
        }
        public void SelectNistAnswerQ1No()
        {
            ClickNistAnswerQ1No();
        }
        public void SelectNistAnswerQ1Yes()
        {
            ClickNistAnswerQ1Yes();
        }
        public void SelectNistAnswerQ2No()
        {
            ClickNistAnswerQ2No();
        }
        public void SelectNistAnswerQ2Yes()
        {
            ClickNistAnswerQ2Yes();
        }
        public void SelectNistAnswerQ3No()
        {
            ClickNistAnswerQ3No();
        }
        public void SelectNistAnswerQ3Yes()
        {
            ClickNistAnswerQ3Yes();
        }
        public void SelectNistAnswerQ4No()
        {
            ClickNistAnswerQ4No();
        }
        public void SelectNistAnswerQ4Yes()
        {
            ClickNistAnswerQ4Yes();
        }
        public void SelectNistAnswerQ5No()
        {
            ClickNistAnswerQ5No();
        }
        public void SelectNistAnswerQ5Yes()
        {
            ClickNistAnswerQ5Yes();
        }
        public void SelectNistAnswerQ6No()
        {
            ClickNistAnswerQ6No();
        }
        public void SelectNistAnswerQ6Yes()
        {
            ClickNistAnswerQ6Yes();
        }
        public void SelectNistAnswerQ7No()
        {
            ClickNistAnswerQ7No();
        }
        public void SelectNistAnswerQ7Yes()
        {
            ClickNistAnswerQ7Yes();
        }
        public void SelectNistAnswerQ8No()
        {
            ClickNistAnswerQ8No();
        }
        public void SelectNistAnswerQ8Yes()
        {
            ClickNistAnswerQ8Yes();
        }
    }
}
