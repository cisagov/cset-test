using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Enums.Con_PCA;
using OpenQA.Selenium;

namespace CSET_Selenium.ConPCA_Repository.Con_PCA
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

        public void ClickCloseFromPopup()
        {
            WaitUntilElementIsVisible(By.XPath("//mat-dialog-container[contains(@class, 'mat-dialog-container')]//span[text() = ' Close ']")).Click();
        }

        public void ClickConfirmFromPopup()
        {
            WaitUntilElementIsVisible(By.XPath("//mat-dialog-actions[contains(@class, 'mat-dialog-actions')]//span[text() = 'Confirm']")).Click();
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

        public void WaitUntilSpinnerNotShowing()
        {
            //if(CheckIfElementExists(Find(By.XPath("//mat-spinner")), 1)){
            try
            {
                WaitUntilElementIsNotVisible(By.XPath("//mat-spinner"));
            }catch(Exception e)
            {

            }
            //}
        }
    }


}
