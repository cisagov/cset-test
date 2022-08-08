using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Enums.Con_PCA;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SendingProfiles
{
    class SendingProfiles : ConPCABase
    {
        private readonly IWebDriver driver;

        public SendingProfiles(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement ButtonNewProfile
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' New Profile ']"));
            }
        }

        private IWebElement ButtonSaveProfile
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Save Profile ']"));
            }
        }


        private IWebElement TextboxDomainName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='name']"));
            }
        }

        private IWebElement MatSelectInterfaceType
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-select[@formcontrolname='interfaceType']"));
            }
        }

        private IWebElement TableProfiles
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-table[@class='mat-table cdk-table mat-sort']"));
            }
        }

        //Interaction Methods
        private void ClickNewProfileButton()
        {
            ClickWhenClickable(ButtonNewProfile);
        }
        
        private void ClickSaveProfileButton()
        {
            ClickWhenClickable(ButtonSaveProfile);
        }

        private void SelectInterfaceType(String type)
        {
            ClickWhenClickable(MatSelectInterfaceType);
            Find(By.XPath(".//mat-option[span[text() = '" + type + "']]")).Click();
        }

        private IWebElement GetProfilesTable()
        {
            return TableProfiles;
        }

        //Aggregate Methods
        public void SetDomainName(String name)
        {
            int i = 0;
            do
            {
                TextboxDomainName.SendKeys(Keys.Control + "a");
                TextboxDomainName.SendKeys(Keys.Delete);
                i++;
            } while ((!TextboxDomainName.Text.Equals("")) && i < 3);
            TextboxDomainName.SendKeys(name);
        }

        public IList<IWebElement> GetProfilesTableRows()
        {
            IList<IWebElement> rows;
            rows = GetProfilesTable().FindElements(By.TagName("mat-row"));
            return rows;
        }

        public void CreateNewProfile(String domainName, String interFaceType)
        {
            ClickNewProfileButton();
            SetDomainName(domainName);
            SelectInterfaceType(interFaceType);
            ClickSaveProfileButton();
            ClickOKFromPopup();
        }
    }
 }
