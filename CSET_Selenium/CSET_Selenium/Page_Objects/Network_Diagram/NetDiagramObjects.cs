using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSET_Selenium.Page_Objects.Cybersecurity_Standards_Selection
{
    class NetDiagramObjects : BasePage
    {
        private readonly IWebDriver driver;
        private Actions actions;
        public NetDiagramObjects(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            this.actions = new Actions(driver);
        }

        //Element Locators

        private IWebElement ButtonNetDiagram
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//*[@id='sidenav']/div/mat-tree/mat-nested-tree-node[1]/ul/mat-tree-node[17]/button"));
            }
        }

        private IWebElement ButtonCreateNetworkDiagram
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//app-prepare/app-diagram/app-info/div/div[2]/button[1]"));
            }
        }

        private IWebElement ButtonDCS
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[1]"));
            }
        }

        private IWebElement ButtonPCS
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[2]"));
            }
        }

        private IWebElement ButtonSCADA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[3]"));
            }
        }

        private IWebElement ButtonElectricUtility
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[4]"));
            }
        }

        private IWebElement ButtonHydroelectricSystem
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[5]"));
            }
        }

        private IWebElement ButtonNuclearPlant
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[6]"));
            }
        }
        private IWebElement ButtonOilAndGas1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[7]"));
            }
        }
        private IWebElement ButtonOilAndGas2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[8]"));
            }
        }
        private IWebElement ButtonTrafficControl
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[9]"));
            }
        }
        private IWebElement ButtonWasteWaterTreatementPlant
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[10]"));
            }
        }
        private IWebElement ButtonWaterPlantSystem
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[11]"));
            }
        }
        private IWebElement ButtonHVAC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[12]"));
            }
        }
        private IWebElement ButtonBuildingAccessControl
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[13]"));
            }
        }
        private IWebElement ButtonMedical
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[14]"));
            }
        }
        private IWebElement ButtonRadio
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[15]"));
            }
        }
        private IWebElement ButtonWindEnergy
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[16]"));
            }
        }
        private IWebElement ButtonEmergencyComm
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[2]/div[17]"));
            }
        }

        private IWebElement ButtonCreate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[14]/div/div[3]/button[2]"));
            }
        }

        private IWebElement ButtonEdit
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[3]/div[1]/a[2]"));

            }
        }

        private IWebElement DropdownFile 
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[3]/div[1]/a[1]"));          
            }
        }

        private IWebElement DropdownNewFromTemplate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[13]/table/tbody/tr[1]/td[2]"));
            }
        }

        private IWebElement ButtonReturnToCset
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//html/body/div[3]/div[1]/a[7]"));
            }
        }






        //Interaction Methods

        private void ClickNetDiagram()
        {
            ButtonNetDiagram.Click();
        }

        private void ClickButtonCreateNetworkDiagram()
        {
            ButtonCreateNetworkDiagram.Click();
        }

        private void ClickButtonDCS()
        {
            ButtonDCS.Click();
        }

        private void ClickButtonPCS()
        {
            ButtonPCS.Click();
        }

        private void ClickButtonSCADA()
        {
            ButtonSCADA.Click();
        }

        private void ClickButtonElectricUtility()
        {
            ButtonElectricUtility.Click();
        }

        private void ClickButtonHydroelectricSystem()
        {
            ButtonHydroelectricSystem.Click();
        }

        private void ClickButtonNuclearPlant()
        {
            ButtonNuclearPlant.Click();
        }
        private void ClickButtonOilAndGas1()
        {
            ButtonOilAndGas1.Click();
        }
        private void ClickButtonOilAndGas2()
        {
            ButtonOilAndGas2.Click();
        }
        private void ClickButtonTrafficControl()
        {
            ButtonTrafficControl.Click();
        }
        private void ClickButtonWasteWaterTreatementPlant()
        {
            ButtonWasteWaterTreatementPlant.Click();
        }
        private void ClickButtonWaterPlantSystem()
        {
            ButtonWaterPlantSystem.Click();
        }
        private void ClickButtonHVAC()
        {
            ButtonHVAC.Click();
        }
        private void ClickButtonBuildingAccessControl()
        {
            ButtonBuildingAccessControl.Click();
        }
        private void ClickButtonMedical()
        {
            ButtonMedical.Click();
        }
        private void ClickButtonRadio()
        {
            ButtonRadio.Click();
        }
        private void ClickButtonWindEnergy()
        {
            ButtonWindEnergy.Click();
        }
        private void ClickButtonEmergencyComm()
        {
            ButtonEmergencyComm.Click();
        }

        private void ClickButtonCreate()
        {
            ButtonCreate.Click();
        }

        private void ClickButtonEdit()
        {
            ButtonEdit.Click();
        }

        private void ClickDropdownFile()
        {
            HoverOver(DropdownFile);
        }

        private void ClickDropdownNewFromTemplate()
        {
            retryButtonClick(DropdownNewFromTemplate);
        }

        private void ClickButtonReturnToCset()
        {
            retryButtonClick(ButtonReturnToCset);
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

        public void SelectButtonNetworkDiagram()
        {
            ClickNetDiagram();
        }

        public void SelectButtonCreateNetworkDiagram()
        {
            ClickButtonCreateNetworkDiagram();
        }

        public void SelectButtonDCS()
        {
            ClickButtonDCS();
        }

        public void SelectButtonPCS()
        {
            ClickButtonPCS();
        }

        public void SelectButtonSCADA()
        {
            ClickButtonSCADA();
        }

        public void SelectButtonElectricUtility()
        {
            ClickButtonElectricUtility();
        }

        public void SelectButtonHydroelectricSystem()
        {
            ClickButtonHydroelectricSystem();
        }

        public void SelectButtonNuclearPlant()
        {
            ClickButtonNuclearPlant();
        }
        public void SelectButtonOilAndGas1()
        {
            ClickButtonOilAndGas1();
        }
        public void SelectButtonOilAndGas2()
        {
            ClickButtonOilAndGas2();
        }
        public void SelectButtonTrafficControl()
        {
            ClickButtonTrafficControl();
        }
        public void SelectButtonWasteWaterTreatementPlant()
        {
            ClickButtonWasteWaterTreatementPlant();
        }
        public void SelectButtonWaterPlantSystem()
        {
            ClickButtonWaterPlantSystem();
        }
        public void SelectButtonHVAC()
        {
            ClickButtonHVAC();
        }
        public void SelectButtonBuildingAccessControl()
        {
            ClickButtonBuildingAccessControl();
        }
        public void SelectButtonMedical()
        {
            ClickButtonMedical();
        }
        public void SelectButtonRadio()
        {
            ClickButtonRadio();
        }
        public void SelectButtonWindEnergy()
        {
            ClickButtonWindEnergy();
        }
        public void SelectClickButtonEmergencyComm()
        {
            ClickButtonEmergencyComm();
        }

        public void SelectClickButtonCreate()
        {
            ClickButtonCreate();
        }

        public void SelectButtonEdit()
        {
            ClickButtonEdit();
        }

        public void SelectDropdownFile()
        {
            ClickDropdownFile();
        }

        public void SelectDropdownNewFromTemplate()
        {
            ClickDropdownNewFromTemplate();
        }

        public void SelectClickButtonReturnToCset()
        {
            ClickButtonReturnToCset();
        }
    }
}
