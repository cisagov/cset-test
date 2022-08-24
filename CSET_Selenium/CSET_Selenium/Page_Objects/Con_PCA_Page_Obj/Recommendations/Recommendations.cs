using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.ConPCA_Repository.Con_PCA;
using CSET_Selenium.Enums.Con_PCA;
using OpenQA.Selenium;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Recommendations
{
    class Recommendations : ConPCABase
    {
        private readonly IWebDriver driver;

        public Recommendations(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        

        //Element Locators

        private IWebElement ButtonNewRecommendation
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' New Recommendation ']"));
            }
        }

        private IWebElement ButtonSaveRecommendation
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[text()=' Save Recommendation ']"));
            }
        }

        private IWebElement TextboxTitle
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@formcontrolname='title']"));
            }
        }

        private IWebElement MatSelectType
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-select[@formcontrolname='type']"));
            }
        }

        private IWebElement TableRecommendations
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//mat-table[@class='mat-table cdk-table mat-sort']"));
            }
        }

        private IWebElement TextareaDescription
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@formcontrolname='description']"));
            }
        }

        //Interaction Methods
        private void ClickNewRecommendationButton()
        {
            ClickWhenClickable(ButtonNewRecommendation);
        }
        //private void SetTitleTextbox()
        //{
        //    TextboxTitle.Click();
        //}
        private void ClickSaveRecommendationButton()
        {
            ClickWhenClickable(ButtonSaveRecommendation);
        }



        private void SelectTypeFromDropdown(RecommendationType type)
        {
            ClickWhenClickable(MatSelectType);
            Find(By.XPath(".//mat-option[span[text() = '" + type.GetValue() + "']]")).Click();
        }

        private IWebElement GetRecommendationsTable()
        {
            return TableRecommendations;
        }

        //Aggregate Methods
        public void SetRecommendationTitle(String title)
        {
            int i = 0;
            do
            {
                TextboxTitle.SendKeys(Keys.Control + "a");
                TextboxTitle.SendKeys(Keys.Delete);
                i++;
            } while ((!TextboxTitle.Text.Equals("")) && i < 3);
            TextboxTitle.SendKeys(title);
        }

        public IList<IWebElement> GetRecommendationsTableRows()
        {
            IList<IWebElement> rows;
            rows = GetRecommendationsTable().FindElements(By.TagName("mat-row"));
            return rows;
        }

        public void SetDescription(String text)
        {
            TextareaDescription.Clear();
            TextareaDescription.SendKeys(text);
        }


        public bool FindRecommendationByTitle(String name)
        {
            IList<IWebElement> rows = GetRecommendationsTableRows();
            bool foundRecommendation = false;
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(name))
                {
                    foundRecommendation = true;
                    break;
                }
            }
            return foundRecommendation;
        }

        public IWebElement GetRecommendationsTableRowByTitle(String name)
        {
            IList<IWebElement> rows = GetRecommendationsTableRows();
            //bool foundRecommendation = false;
           
            for (var i = 0; i < rows.Count; i++)
            {
                if (rows[i].Text.Contains(name))
                {
                    return rows[i];
                }
            }
            return null;
        }

        public String GetCellValueInRecommendationTableRow(IWebElement row, int cellNumber)
        {
            return row.FindElement(By.XPath(".//mat-cell["+cellNumber+"]")).Text;
        }

        public void CreateNewRecommendation(String recommTitle, RecommendationType type, String desciption)
        {
            ClickNewRecommendationButton();
            SetRecommendationTitle(recommTitle);
            SetDescription(desciption);
            SelectTypeFromDropdown(type);
            ClickSaveRecommendationButton();
        }

        public void ClickEditButtonByRecommendationTitle(String title)
        {
            IList<IWebElement> rows = GetRecommendationsTableRows();
            for (var i = 0; i < rows.Count; i++)
            {
                //String oneRow = rows[i].FindElement(By.XPath(".//mat-cell[1]")).Text;
                if (rows[i].FindElement(By.XPath(".//mat-cell[1]")).Text.Equals(title))
                {
                    rows[i].FindElement(By.XPath(".//mat-cell[4]/button/span/mat-icon[text() = 'edit']")).Click();
                    break;
                }
            }
        }

        public void ClickDeleteButtonByRecommendationTitle(String title)
        {
            IList<IWebElement> rows = GetRecommendationsTableRows();
            for (var i = 0; i < rows.Count; i++)
            {
                //String oneRow = rows[i].FindElement(By.XPath(".//mat-cell[1]")).Text;
                if (rows[i].FindElement(By.XPath(".//mat-cell[1]")).Text.Equals(title))
                {
                    rows[i].FindElement(By.XPath(".//mat-cell[4]/button/span/mat-icon[text() = 'delete']")).Click();
                    break;
                }
            }
        }

        public void EditRecommendationType(String recommendationTitle, RecommendationType newType)
        {
            ClickEditButtonByRecommendationTitle(recommendationTitle);
            SelectTypeFromDropdown(newType);
            ClickSaveRecommendationButton();
        }

        public void DeleteRecommendationByTitle(String recommendationTitle)
        {
            ClickDeleteButtonByRecommendationTitle(recommendationTitle);
            ClickYesOrNoFromPopup(YesNo.Yes);
            RefreshPage();
        }
    }
}
