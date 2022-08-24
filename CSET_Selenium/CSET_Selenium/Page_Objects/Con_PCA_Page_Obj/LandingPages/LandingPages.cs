using System;
using System.Collections.Generic;
using CSET_Selenium.ConPCA_Repository.Con_PCA;
using CSET_Selenium.Enums.Con_PCA;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.LandingPages
{
    class LandingPage : ConPCABase
    {
        private readonly IWebDriver driver;

        public LandingPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement ButtonNewLandingPage
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' New Landing Page ']"));
            }
        }

        private IWebElement ButtonSavePage
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Save Page ']"));
            }
        }

        private IWebElement ButtonDeletePage
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Delete Page ']"));
            }
        }

        private IWebElement TextboxLandingPageName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='templateName']"));
            }
        }

        private IWebElement TextAreaLandingPageEditorHTMLView
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@class = 'angular-editor-textarea']"));
            }
        }

        private IWebElement TableLandingPages
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-table[@class = 'mat-table cdk-table mat-sort']"));
            }
        }

        //Interaction Methods
        private void ClickNewLandingPageButton()
        {
            ButtonNewLandingPage.Click();
        }

        private void ClickSavePageButton()
        {
            ButtonSavePage.Click();
        }

        private void ClickDeletePageButton()
        {
            ButtonDeletePage.Click();
        }

        private IWebElement GetLandingPagesTable()
        {
            return TableLandingPages;
        }

        //Aggregate Methods
        public void SetLandingPageName(String name)
        {   
            int i = 0;
            do { TextboxLandingPageName.SendKeys(Keys.Control + "a");
                TextboxLandingPageName.SendKeys(Keys.Delete);
                i++;
            }while((!TextboxLandingPageName.Text.Equals("")) && i<3);
            TextboxLandingPageName.SendKeys(name);
        }

        public IList<IWebElement> GetLandingPagesTableRows()
        {
            IList<IWebElement> rows;
            rows = GetLandingPagesTable().FindElements(By.TagName("mat-row"));
            return rows;
        }

        public void SetHTMLView(String text)
        {
            TextAreaLandingPageEditorHTMLView.SendKeys(text);
        }


        public bool FindLandingPageByName(String name)
        {
            IList<IWebElement> rows = GetLandingPagesTableRows();
            bool foundNewTemplate = false;
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(name))
                {
                    foundNewTemplate = true;
                    break;
                }
            }
            return foundNewTemplate;
        }

        public void CreateNewLandingPage(String pageName, String htmlView)
        {
            ClickNewLandingPageButton();
            SetLandingPageName(pageName);
            SetHTMLView(htmlView);
            ClickSavePageButton();
            ClickOKFromPopup();
        }

        public void ClickEditButtonByLandingPageName(String name)
        {
            IList<IWebElement> rows = GetLandingPagesTableRows();
            for (var i = 0; i < rows.Count; i++)
            {
                //String oneRow = rows[i].FindElement(By.XPath(".//mat-cell[1]")).Text;
                if (rows[i].FindElement(By.XPath(".//mat-cell[1]")).Text.Equals(name))
                {
                    rows[i].FindElement(By.XPath(".//mat-cell[4]/button")).Click();
                    break;
                }
            }
        }

        public void EditLandingPageName(String currentPageName, String newPageName)
        {
            ClickEditButtonByLandingPageName(currentPageName);
            SetLandingPageName(newPageName);
            ClickSavePageButton();
            //ClickOKFromPopup();
        }

        public void DeleteLandingPageByName(String pageName)
        {
            ClickEditButtonByLandingPageName(pageName);
            ClickDeletePageButton();
            ClickYesOrNoFromPopup(YesNo.Yes);           
        }
    }
}
