using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CSET_Selenium.Tests.Create_Assessment
{
    class NetworkDiagram
    {
        [TestFixture]
        public class CreateNetworkDiagramAssessment : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void Blank()
            {
                BaseConfiguration cf = new BaseConfiguration("http://cset-tst.inl.gov");
                driver = BuildDriver(cf);
                Assert.True(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "Password123");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateNetworkDiagramAssessment("Network Diagram Assessment", "Lex Corp", "Metropolis  ", "New York");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //SAL Page
                assessmentInfo.SetAssessmentInformation();

                //Network Diagram Page
                Page_Objects.Cybersecurity_Standards_Selection.NetDiagramObjects netDiagram = new Page_Objects.Cybersecurity_Standards_Selection.NetDiagramObjects(driver);
                netDiagram.SelectButtonNetworkDiagram();
                netDiagram.SelectButtonCreateNetworkDiagram();
                netDiagram.SelectButtonDCS();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();            
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonPCS();                
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonSCADA();           
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonElectricUtility();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonHydroelectricSystem();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonNuclearPlant();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonOilAndGas1();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonOilAndGas2();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonTrafficControl();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonWasteWaterTreatementPlant();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonWaterPlantSystem();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonHVAC();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonBuildingAccessControl();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonMedical();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonRadio();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectButtonWindEnergy();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectButtonEdit();
                netDiagram.SelectDropdownFile();
                netDiagram.SelectDropdownNewFromTemplate();
                netDiagram.SelectClickButtonEmergencyComm();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectClickButtonReturnToCset();
                netDiagram.ClickNext();
                
                //Standards Questions Page
                assessmentInfo.SetAssessmentInformation();

                //Components Summary Page
                assessmentInfo.SetAssessmentInformation();

                //Ranked Components By Category Page
                assessmentInfo.SetAssessmentInformation();

                //Component Results By Category Page
                assessmentInfo.SetAssessmentInformation();

                //Components By Component Type Page
                assessmentInfo.SetAssessmentInformation();

                //Network Warning Page
                assessmentInfo.SetAssessmentInformation();

                //High-Level Assessment Description, Executive Summary & Comments Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page
                
            }
        }
    }
}
