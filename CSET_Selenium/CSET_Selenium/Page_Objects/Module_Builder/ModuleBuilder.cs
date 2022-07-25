using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CSET_Selenium.Repository.Landing_Page
{
    class ModuleBuilder : BasePage
    {
        private readonly IWebDriver driver;
        private Random r = new Random();
        private List<String> moduleInputs = new List<String>();
        private String fullName;
        private String shortName;
        private String description;
        private String category;
        private List<String> categoryList = new List<String>
        {
            "Chemical, Oil, and Natural Gas",
            "Custom",
            "Defense Infrastructure",
            "DoDI and CNSSI",
            "Electrical",
            "Financial",
            "General",
            "Health Care",
            "Information Technology",
            "NIST Cybersecurity Framework",
            "Nuclear",
            "Process Control and SCADA",
            "Questions Only",
            "Supply Chain",
            "Transportation"
        };

        public ModuleBuilder(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement CreateModuleButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[@class='cset-icons-plus fs-base mr-2']"));
            }
        }

        private IWebElement ModuleNameInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='fullname']"));
            }
        }

        private IWebElement ShortNameInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='shortname']"));
            }
        }

        private IWebElement DescriptionInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@id='description']"));
            }
        }

        private IWebElement ChemOilGasCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='1']"));
            }
        }

        private IWebElement CustomCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='12']"));
            }
        }

        private IWebElement DefenseInfrastructureCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='15']"));
            }
        }
        private IWebElement DoDIandCNSSICategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='9']"));
            }
        }

        private IWebElement ElectricalCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='2']"));
            }
        }

        private IWebElement FinancialCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='14']"));
            }
        }

        private IWebElement GeneralCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='10']"));
            }
        }

        private IWebElement HealthcareCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='7']"));
            }
        }

        private IWebElement InformationTechCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='4']"));
            }
        }

        private IWebElement NISTCyberFrameworkCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='13']"));
            }
        }

        private IWebElement NuclearCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='8']"));
            }
        }

        private IWebElement ProcessControlAndSCADACategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='5']"));
            }
        }

        private IWebElement QuestionsOnlyCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='11']"));
            }
        }

        private IWebElement SupplyChainCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='6']"));
            }
        }

        private IWebElement TransportationCategoryInput
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//option[@value='3']"));
            }
        }

        private IWebElement RequirementsButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[@class='cset-icons-books-stack-2']"));
            }
        }

        private IWebElement QuestionsButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[@class='cset - icons - question - mark']"));
            }
        }

        private IWebElement ManageDocumentsButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@id='documents']"));
            }
        }

        private IWebElement CloneFromExistingModulesButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@id='addsets']"));
            }
        }

        private IWebElement CreateRequirementButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[@class='cset-icons-plus fs-base mr-2']"));
            }
        }

        private IWebElement GetCatInput
        {

            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='category']"));
            }
        }

        private IWebElement GetSubCatInput
        {

            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='subcategory']"));
            }
        }

        private IWebElement getQuestionElement
        {
            get
            {
                int random = r.Next(1, 77);
                return WaitUntilElementIsVisible(By.XPath("//select[@id='groupheading']//option[" + random + "]"));
            }
        }

        private IWebElement TitleId
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='title']"));
            }
        }
        private IWebElement RequirementText
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//textarea[@id='requirementText']"));
            }
        }

        private IWebElement Create
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@class='btn btn-primary']"));
            }
        }

        private IWebElement ReqLowSAL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='SAL - L - 1000922']"));
            }
        }
        private IWebElement ReqModerateSAL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[2]"));
            }
        }
        private IWebElement ReqHighSAL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[3]"));
            }
        }
        private IWebElement ReqVeryHighSAL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[4]"));
            }
        }

        private IWebElement QLowSAL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Low')]"));
            }
        }
        private IWebElement QModerateSAL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Moderate')]"));
            }
        }
        private IWebElement QHighSAL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'High')]"));
            }
        }
        private IWebElement QVeryHighSAL
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Very High')]"));
            }
        }

        private IWebElement SupplementalInfo
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@contenteditable='true']"));
            }
        }

        private IWebElement ManageReqDocs
        {
            get
            {
                return WaitUntilElementIsVisible(By.Id("documents"));
            }
        }

        private IWebElement SourceDocDropdown
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[@id='newSourceDoc']//option[2]"));
            }
        }

        private IWebElement HelpDocDropdown
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//select[@id='newResourceDoc']//option[2]"));
            }
        }

        private IWebElement AddButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[@class='cset-icons-plus fs-base-2 mr-2']"));
            }
        }

        private List<IWebElement> RandomDocumentation
        {
            get
            {
                WaitUntilElementIsVisible(By.XPath("//tr[652]"));
                return new List<IWebElement>(driver.FindElements(By.XPath("//input")));
            }
        }

        private IWebElement StandardDocBackButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@class='btn btn-link']"));
            }
        }

        private IWebElement AddReqQuestionButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.Id("addQuestion"));
            }
        }

        private IWebElement NewQuestion
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='txtCustomQuestionEntry']"));
            }
        }

        private IWebElement QuestionGroupHeading
        {
            get
            {
                int random = r.Next(1, 78);
                return WaitUntilElementIsVisible(By.XPath("//select[@id='category']//option[" + random + "]"));
            }
        }

        private IWebElement QuestionSubCategory
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//input[@id='subcategory']"));
            }
        }

        private IWebElement AddNewQuestionButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@class='btn btn-primary']"));
            }
        }

        private IWebElement CreateQuestionButton
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//span[@class='cset - icons - plus fs - base mr - 2'"));
            }
        }

        private IWebElement BackToRequirement
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(), 'Back to Requirement')]"));
            }
        }

        private IWebElement BackToRequirementListing
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[@class='btn btn-link']"));
            }
        }

        private IWebElement BackToModuleDetail
        {
            get
            {
                return WaitUntilElementIsVisible(By.Id("btnBack"));
            }
        }

        private IWebElement CSET
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//app-logo-cset"));
            }
        }

        private IWebElement ChemOilGasCheckbox
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//label[contains(text(), 'Chem Oil and Gas Test')]"));
            }
        }
        //Interaction Methods

        private void ClickCreateModuleButton()
        {
            CreateModuleButton.Click();
        }

        private void SetModuleName(String name)
        {
            ClickWhenClickable(ModuleNameInput);
            ModuleNameInput.SendKeys(name);
        }

        private void SetShortName(String name)
        {
            ClickWhenClickable(ShortNameInput);
            ShortNameInput.SendKeys(name);
        }

        private void SetDescription(String description)
        {
            ClickWhenClickable(DescriptionInput);
            DescriptionInput.SendKeys(description);
        }

        private void ClickChemOilGasCategoryInput()
        {
            ChemOilGasCategoryInput.Click();
        }

        private void ClickCustomCategoryInput()
        {
            CustomCategoryInput.Click();
        }

        private void ClickDefenseInfrastructureCategoryInput()
        {
            DefenseInfrastructureCategoryInput.Click();
        }

        private void ClickDoDIandCNSSICategoryInput()
        {
            DoDIandCNSSICategoryInput.Click();
        }

        private void ClickElectricalCategoryInput()
        {
            ElectricalCategoryInput.Click();
        }
        private void ClickFinancialCategoryInput()
        {
            FinancialCategoryInput.Click();
        }
        private void ClickGeneralCategoryInput()
        {
            GeneralCategoryInput.Click();
        }
        private void ClickHealthcareCategoryInput()
        {
            HealthcareCategoryInput.Click();
        }
        private void ClickInformationTechnologyCategoryInput()
        {
            InformationTechCategoryInput.Click();
        }
        private void ClickNistCyberFrameworkCategoryInput()
        {
            NISTCyberFrameworkCategoryInput.Click();
        }
        private void ClickNuclearCategoryInput()
        {
            NuclearCategoryInput.Click();
        }
        private void ClickProcessControlAndSCADACategoryInput()
        {
            ProcessControlAndSCADACategoryInput.Click();
        }
        private void ClickQuestionsOnlyCategoryInput()
        {
            QuestionsOnlyCategoryInput.Click();
        }
        private void ClickSupplyChainCategoryInput()
        {
            SupplyChainCategoryInput.Click();
        }
        private void ClickTransportationCategoryInput()
        {
            TransportationCategoryInput.Click();
        }

        private void ClickRequirementsButton()
        {
            RequirementsButton.Click();
        }

        private void ClickQuestionsButton()
        {
            QuestionsButton.Click();
        }

        private void ClickManageDocumentsButton()
        {
            ManageDocumentsButton.Click();
        }

        private void ClickCloneFromExistingModulesButton()
        {
            CloneFromExistingModulesButton.Click();
        }

        private void ClickCreateRequirementButton()
        {
            CreateRequirementButton.Click();
        }

        private void GetCatOption()
        {
            var catoptions = driver.FindElements(By.XPath("//datalist[@id='catoptions']//option"));
            var input = GetCatInput;
            int random = r.Next(1, 92);
            driver.FindElement(By.XPath("//input[@id='category']"));
            moduleInputs.Add(driver.FindElement(By.XPath("//datalist[@id='catoptions']//option[" + random + "]")).GetAttribute("value"));
            Console.WriteLine("Getting option " + random + " from " + catoptions.Count() + " total options\nThe option is " + driver.FindElement(By.XPath("//option[" + random + "]")).GetAttribute("value"));
            input.SendKeys(driver.FindElement(By.XPath("//option[" + random + "]")).GetAttribute("value"));
        }

        private void GetSubCatOption()
        {
            var subcatoptions = driver.FindElements(By.XPath("//datalist[@id='subcatoptions']//option"));
            var input = GetSubCatInput;
            int random = r.Next(1, 1311);
            moduleInputs.Add(driver.FindElement(By.XPath("//option[" + random + "]")).GetAttribute("value"));
            Console.WriteLine("Getting option " + random + " from " + subcatoptions.Count() + " total options\nThe option is " + driver.FindElement(By.XPath("//option[" + random + "]")).GetAttribute("value"));
            input.SendKeys(driver.FindElement(By.XPath("//option[" + random + "]")).GetAttribute("value"));
        }

        private void GetQuestionOption()
        {
            moduleInputs.Add(getQuestionElement.GetAttribute("value"));
            getQuestionElement.Click();
        }

        private void ClickCreateQuestionButton()
        {
            CreateQuestionButton.Click();
        }

        private void SetTitleId(String title)
        {
            TitleId.Click();
            TitleId.SendKeys(title);
        }

        private void SetRequirementText(String text)
        {
            RequirementText.Click();
            RequirementText.SendKeys(text);
        }

        private void ClickCreate()
        {
            Create.Click();
        }

        private void ClickReqLowSAL()
        {
            ReqLowSAL.Click();
        }

        private void ClickReqModerateSAL()
        {
            ReqModerateSAL.Click();
        }

        private void ClickReqHighSAL()
        {
            ReqHighSAL.Click();
        }

        private void ClickReqVeryHighSAL()
        {
            ReqVeryHighSAL.Click();
        }

        private void SetSupplementalInfo(String info)
        {
            SupplementalInfo.Click();
            SupplementalInfo.SendKeys(info);
        }

        private void ClickManageReqDocs()
        {
            ManageReqDocs.Click();
        }

        private void ClickSourceDocDropdown()
        {
            SourceDocDropdown.Click();
        }

        private void ClickHelpDocDropdown()
        {
            HelpDocDropdown.Click();
        }

        private void ClickAddButton()
        {
            AddButton.Click();
        }

        private void ClickRandomDocumentation()
        {
            int random = r.Next(4, 656);
            Console.WriteLine("Reading index " + random + " of " + RandomDocumentation.Count() + " total items");
            moduleInputs.Add(RandomDocumentation[random].GetAttribute("value"));
            RandomDocumentation[random].Click();
        }

        private void ClickStandardDocsBack()
        {
            StandardDocBackButton.Click();
        }

        private void ClickAddReqQuestion()
        {
            AddReqQuestionButton.Click();
        }

        private void SetNewQuestion(String questionText)
        {
            NewQuestion.Click();
            NewQuestion.SendKeys(questionText);
        }

        private void SetRandomQuestionGroupHeading()
        {
            moduleInputs.Add(QuestionGroupHeading.GetAttribute("value"));
            QuestionGroupHeading.Click();
        }

        private void ClickQLowSAL()
        {
            QLowSAL.Click();
        }

        private void ClickQModerateSAL()
        {
            QModerateSAL.Click();
        }

        private void ClickQHighSAL()
        {
            QHighSAL.Click();
        }

        private void ClickQVeryHighSAL()
        {
            QVeryHighSAL.Click();
        }

        private void ClickAddNewQuestion()
        {
            AddNewQuestionButton.Click();
        }

        private void ClickBackToRequirement()
        {
            BackToRequirement.Click();
        }

        private void ClickBackToRequirementListing()
        {
            BackToRequirementListing.Click();
        }

        private void ClickBackToModuleDetail()
        {
            BackToModuleDetail.Click();
        }

        private void ClickCSET()
        {
            CSET.Click();
        }

        private void ClickCheckbox(String cat)
        {
            var el = WaitUntilElementIsVisible(By.XPath("//label[contains(text(), '" + cat + " Test')]"));
            el.Click();
        }

        //Aggregate Methods
        public void CybersecStandardCheckbox()
        {
            ClickCheckbox(category);
        }

        public void GoHome()
        {
            ClickCSET();
        }

        public void CreateNewModule()
        {
            ClickCreateModuleButton();
        }

        public void GoToRequirements()
        {
            ClickRequirementsButton();
        }

        public void AddRequirement(String title, String text, String info, String questionText)
        {
            moduleInputs.Add(title);
            moduleInputs.Add(text);
            moduleInputs.Add(info);
            moduleInputs.Add(questionText);
            ClickCreateRequirementButton();
            Thread.Sleep(3000);
            GetCatOption();
            GetQuestionOption();
            GetSubCatOption();
            SetTitleId(title);
            SetRequirementText(text);
            ClickCreate();
            ClickReqModerateSAL();
            ClickReqHighSAL();
            ClickReqVeryHighSAL();
            SetSupplementalInfo(info);
            ClickManageReqDocs();
            ClickRandomDocumentation();
            ClickStandardDocsBack();
            ClickSourceDocDropdown();
            ClickAddButton();
            ClickAddReqQuestion();
            SetNewQuestion(questionText);
            SetRandomQuestionGroupHeading();
            GetSubCatOption();
            ClickQLowSAL();
            ClickQModerateSAL();
            ClickQHighSAL();
            ClickQVeryHighSAL();
            ClickAddNewQuestion();
            driver.Navigate().Back();
            driver.Navigate().Back();
            driver.Navigate().Back();
            driver.Navigate().Back();
        }

        public List<String> GetModuleInputs()
        {
            return moduleInputs;
        }

        public void AddQuestion()
        {
            ClickQuestionsButton();
        }

        public void AddDocument()
        {
            ClickManageDocumentsButton();
        }

        public void CloneExistingModule()
        {
            ClickCloneFromExistingModulesButton();
        }

        public void SetModuleDetails()
        {
            var rand = r.Next(0, 15);
            fullName = categoryList[rand] + " Test" ;
            shortName = "Test1";
            description = categoryList[rand] + " category test module";
            category = categoryList[rand];
            moduleInputs.Add(fullName);
            moduleInputs.Add(shortName);
            moduleInputs.Add(description);
            moduleInputs.Add(category);
            SetModuleName(fullName);
            SetShortName(shortName);
            SetDescription(description);

            Thread.Sleep(2000);

            if(category.Equals("Chemical, Oil, and Natural Gas", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickChemOilGasCategoryInput();
            }
            else if(category.Equals("Custom", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickCustomCategoryInput();
            }
            else if (category.Equals("Defense Infrastructure", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickDefenseInfrastructureCategoryInput();
            }
            else if (category.Equals("DoDI and CNSSI", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickDoDIandCNSSICategoryInput();
            }
            else if (category.Equals("Electrical", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickElectricalCategoryInput();
            }
            else if (category.Equals("Financial", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickFinancialCategoryInput();
            }
            else if (category.Equals("General", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickGeneralCategoryInput();
            }
            else if (category.Equals("Health Care", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickHealthcareCategoryInput();
            }
            else if (category.Equals("Information Technology", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickInformationTechnologyCategoryInput();
            }
            else if (category.Equals("NIST Cybersecurity Framework", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickNistCyberFrameworkCategoryInput();
            }
            else if (category.Equals("Nuclear", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickNuclearCategoryInput();
            }
            else if (category.Equals("Process Control and SCADA", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickProcessControlAndSCADACategoryInput();
            }
            else if (category.Equals("Questions Only", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickQuestionsOnlyCategoryInput();
            }
            else if (category.Equals("Supply Chain", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickSupplyChainCategoryInput();
            }
            else if (category.Equals("Transportation", StringComparison.InvariantCultureIgnoreCase))
            {
                ClickTransportationCategoryInput();
            }
            else
            {
                Console.Error.WriteLine("Please specify a correct category.");
            }
        }
    }
}