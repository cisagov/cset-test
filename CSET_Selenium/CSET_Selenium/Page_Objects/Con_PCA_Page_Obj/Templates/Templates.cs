using CSET_Selenium.Enums.Con_PCA;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Templates
{
    class Templates : ConPCABase
    {
        private readonly IWebDriver driver;

        public Templates(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement ButtonNewTemplate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' New Template ']"), 1);
            }
        }

        private IWebElement ButtonSaveTemplate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Save Template ']"));
            }
        }

        private IWebElement TextboxTemplateName
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='templateName']"));
            }
        }

        private IWebElement TextAreaHTMLView
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@class = 'angular-editor-textarea']"));
            }
        }

        private IWebElement TabTemplateAttributes
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() = 'Template Attributes ']"));
            }
        }

        private IWebElement TextboxTemplateSubject
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname = 'templateSubject']"));
            }
        }

        private IWebElement RadioGroupOrganization
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-radio-group[@formcontrolname = 'organization']"));
            }
        }

        
        private IWebElement TableTemplates
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-table[@class = 'mat-table cdk-table mat-sort']"));
            }
        }

        private IWebElement ButtonActions
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[contains(text(), 'Actions')]"));
            }
        }

        private IWebElement LinkRetire
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-icon[contains(text(), 'archive')]"));
            }
        }

        private IWebElement ButtonRetire
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() = ' Retire ']"));
            }
        }

        private IWebElement TextAreaRetireReason
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//h3[contains(text(), 'reason for retiring')]/following-sibling::mat-form-field/div/div/div[3]/textarea"));
            }
        }

        private IWebElement ButtonDeleteTemplate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text() = ' Delete Template ']"));
            }
        }

        private IWebElement TextPageTitle
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@class = 'header-title']"));
            }
        }

        //Interaction Methods

        private void ClickNewTemplateButton()
        {
            ButtonNewTemplate.Click();
        }

        private void ClickSaveTemplateButton()
        {
            ButtonSaveTemplate.Click();
        }

        private void ClickTemplateAttributesTab()
        {
            TabTemplateAttributes.Click();
        }

        
        private void SetTemplateAttributesTabSubject(String subject)
        {
            TextboxTemplateSubject.SendKeys(subject);
        }

        private void ClickActionsButton()
        {
            ButtonActions.Click();
        }

        private void ClickActionsRetire()
        {
            LinkRetire.Click();
        }

        private void ClickRetireButton()
        {
            ButtonRetire.Click();
        }

        private void SelectOrganization(YesNo yesNo)
        {
            if(yesNo == YesNo.Yes)
            {
                RadioGroupOrganization.FindElement(By.XPath(".//mat-radio-button[2]")).Click();
            }
            else
            {
                RadioGroupOrganization.FindElement(By.XPath(".//mat-radio-button")).Click();
            }
        }

        private IWebElement GetTemplatesTable()
        {
            return TableTemplates;
        }

        private void SetRetireReason(String reason)
        {
            TextAreaRetireReason.SendKeys(reason);
        }

        private void ClickDeleteTemplateButton()
        {
            WaitUntilElementIsClickable(ButtonDeleteTemplate, 2);
            ButtonDeleteTemplate.Click();
        }

        private void ClickPageTitle()
        {
            TextPageTitle.Click();
        }


        //Aggregate Methods

        public void SetHTMLView(String view)
        {
            TextAreaHTMLView.SendKeys(view);
        }

        public void SetTemplateName(String name)
        {
            int loop = 0;
            WaitUntilElementIsVisible(TextPageTitle, 2);
            do {
                TextboxTemplateName.Clear();
                TextboxTemplateName.SendKeys(Keys.Control + "a" + Keys.Delete);
                loop++;
                WaitForPostBack();
            }while(loop < 5 && TextboxTemplateName.Text.Length > 0);
            
            TextboxTemplateName.Click();
            TextboxTemplateName.SendKeys(name);
        }

        public void SetTemplateSubject(String subject)
        {
            ClickTemplateAttributesTab();
            SetTemplateAttributesTabSubject(subject);
        }

        public IList<IWebElement> GetTemplatesTableRows()
        {
            IList<IWebElement> rows;
            rows = GetTemplatesTable().FindElements(By.TagName("mat-row"));
            return rows;
        }

        public bool NewTemplateButtonPresent()
        {
            
            return CheckIfElementExists(ButtonNewTemplate, 2);

        }

        public void ClickEditButtonByTemplateName(String name)
        {
            IList<IWebElement> rows = GetTemplatesTableRows();
            for (var i = 0; i < rows.Count; i++)
            {
                String oneRow = rows[i].FindElement(By.XPath(".//mat-cell[2]")).Text;
                if (rows[i].FindElement(By.XPath(".//mat-cell[2]")).Text.Equals(name))
                {
                    rows[i].FindElement(By.XPath(".//mat-cell[6]/button")).Click();
                    break;
                }
            }
        }

        public void SelectCheckboxByTemplateName(String name)
        {
            IList<IWebElement> rows = GetTemplatesTableRows();
            for (var i = 0; i < rows.Count; i++)
            {
                String oneRow = rows[i].FindElement(By.XPath(".//mat-cell[2]")).Text;
                if (rows[i].FindElement(By.XPath(".//mat-cell[2]")).Text.Equals(name))
                {
                    rows[i].FindElement(By.XPath(".//mat-cell[1]/mat-checkbox")).Click();
                    break;
                }
            }
        }

        public void ShowRetired()
        {
            IWebElement showRetired = driver.FindElement(By.XPath("//input[@class='mat-slide-toggle-input cdk-visually-hidden']"));
            if(showRetired.GetAttribute("aria-checked").Equals("false"))
            {
                showRetired.FindElement(By.XPath(".//../following-sibling::span")).Click();
            }
        }

        public void CreateNewTemplate(String templateName, String subject)
        {
            if (!NewTemplateButtonPresent())
            {
                RefreshPage();
            }
            ClickNewTemplateButton();
            SetTemplateName(templateName);
            SetHTMLView(templateName + " "+subject);
            SetTemplateSubject(subject);
            SelectOrganization(YesNo.Yes);
            ClickSaveTemplateButton();
            ClickOKFromPopup();
        }

        public void EditTemplateName(String currentTemplateName, String newTemplateName)
        {
            ClickEditButtonByTemplateName(currentTemplateName);
            SetTemplateName(newTemplateName);
            ClickSaveTemplateButton();
            ClickOKFromPopup();
        }

        public void RetireTemplate(String templateName, String retireReason)
        {
            SelectCheckboxByTemplateName(templateName);
            ClickActionsButton();
            ClickActionsRetire();
            SetRetireReason(retireReason);
            ClickRetireButton();
        }

        public void DeleteTemplate(String templateName)
        {
            ClickEditButtonByTemplateName(templateName);
            ClickDeleteTemplateButton();
            ClickYesOrNoFromPopup(YesNo.Yes);
            ClickOKFromPopup();
        }

        public bool FindTemplateByName(String name)
        {
            IList<IWebElement>  rows = GetTemplatesTableRows();
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
    }
}
