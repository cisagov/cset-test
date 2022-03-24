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

        private IWebElement ButtonCreateNetworkDiagram
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(),'Create a Network Diagram')]"));
            }
        }

        private IWebElement ButtonDCS
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='DCS']"));
            }
        }

        private IWebElement ButtonPCS
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='PCS']"));
            }
        }

        private IWebElement ButtonSCADA
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='SCADA']"));
            }
        }

        private IWebElement ButtonElectricUtility
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Electric']"));
            }
        }

        private IWebElement ButtonHydroelectricSystem
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Hydro']"));
            }
        }

        private IWebElement ButtonNuclearPlant
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Nuclear']"));
            }
        }
        private IWebElement ButtonOilAndGas1
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Oil & Gas 1']"));
            }
        }
        private IWebElement ButtonOilAndGas2
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Oil & Gas 2']"));
            }
        }
        private IWebElement ButtonTrafficControl
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Traffic Control']"));
            }
        }
        private IWebElement ButtonWasteWaterTreatementPlant
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Waste Water Treatment Plant']"));
            }
        }
        private IWebElement ButtonWaterPlantSystem
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Water Plant System']"));
            }
        }
        private IWebElement ButtonHVAC
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='HVAC']"));
            }
        }
        private IWebElement ButtonBuildingAccessControl
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Building Access Control']"));
            }
        }
        private IWebElement ButtonMedical
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Medical']"));
            }
        }
        private IWebElement ButtonRadio
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Radio']"));
            }
        }
        private IWebElement ButtonWindEnergy
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Wind Energy']"));
            }
        }
        private IWebElement ButtonEmergencyComm
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[@title='Emergency Management']"));
            }
        }

        private IWebElement ButtonCreate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//button[contains(text(), 'Create')]"));
            }
        }

        private IWebElement ButtonEdit
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(), 'Edit')]"));

            }
        }

        private IWebElement DropdownFile 
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(), 'File')]"));          
            }
        }

        private IWebElement DropdownNewFromTemplate
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//td[contains(text(), 'New From Template')]"));
            }
        }

        private IWebElement ButtonReturnToCset
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//a[contains(text(), 'Return to CSET')]"));
            }
        }






        //Interaction Methods

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


        public void SelectButtonCreateNetworkDiagram()
        {
            ClickButtonCreateNetworkDiagram();
        }

        public void SelectButtonDCS()
        {
            ClickButtonDCS();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }

        public void SelectButtonPCS()
        {
            ClickButtonPCS();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }

        public void SelectButtonSCADA()
        {
            ClickButtonSCADA();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }

        public void SelectButtonElectricUtility()
        {
            ClickButtonElectricUtility();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }

        public void SelectButtonHydroelectricSystem()
        {
            ClickButtonHydroelectricSystem();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }

        public void SelectButtonNuclearPlant()
        {
            ClickButtonNuclearPlant();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonOilAndGas1()
        {
            ClickButtonOilAndGas1();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonOilAndGas2()
        {
            ClickButtonOilAndGas2();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonTrafficControl()
        {
            ClickButtonTrafficControl();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonWasteWaterTreatementPlant()
        {
            ClickButtonWasteWaterTreatementPlant();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonWaterPlantSystem()
        {
            ClickButtonWaterPlantSystem();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonHVAC()
        {
            ClickButtonHVAC();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonBuildingAccessControl()
        {
            ClickButtonBuildingAccessControl();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonMedical()
        {
            ClickButtonMedical();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonRadio()
        {
            ClickButtonRadio();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectButtonWindEnergy()
        {
            ClickButtonWindEnergy();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
        }
        public void SelectClickButtonEmergencyComm()
        {
            ClickButtonEmergencyComm();
            SelectClickButtonCreate();
            SelectButtonEdit();
            SelectDropdownFile();
            SelectDropdownNewFromTemplate();
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
            ClickNext();
        }
    }
}
