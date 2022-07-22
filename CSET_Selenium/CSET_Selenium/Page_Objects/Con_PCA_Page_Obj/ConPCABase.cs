using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;

namespace CSET_Selenium.Enums.Con_PCA
{
    class ConPCABase : BasePage
    {
        private readonly IWebDriver driver;

        public ConPCABase(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void ClickOKFromPopup()
        {
            WaitUntilElementIsVisible(By.XPath("//mat-dialog-container[contains(@class, 'mat-dialog-container')]//span[text() = ' OK ']")).Click();
        }


        public void ClickYesOrNoFromPopup(YesNo yesNo)
        {
            if (yesNo == YesNo.Yes)
            {
                WaitUntilElementIsVisible(By.XPath("//span[text()=' Yes ']")).Click();
            }
            else
            {
                WaitUntilElementIsVisible(By.XPath("//span[text()=' No ']")).Click();
            }
        }
    }


}
