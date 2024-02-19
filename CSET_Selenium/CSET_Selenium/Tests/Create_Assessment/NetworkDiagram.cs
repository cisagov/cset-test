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
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "\"K!q;va&%G],(0!mE:G+%ba~z><T/v4AELXZUFz;Tav|y}'mbx");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.OpenNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateNetworkDiagramAssessment("Network Diagram Assessment", "Lex Corp", "Metropolis  ", "New York");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //SAL Page
                assessmentInfo.SetAssessmentInformation();

                //Network Diagram Page
                Page_Objects.Cybersecurity_Standards_Selection.NetDiagramObjects netDiagram = new Page_Objects.Cybersecurity_Standards_Selection.NetDiagramObjects(driver);
                netDiagram.SelectButtonCreateNetworkDiagram();
                netDiagram.SelectButtonDCS();
                netDiagram.SelectButtonPCS();                
                netDiagram.SelectButtonSCADA();           
                netDiagram.SelectButtonElectricUtility();
                netDiagram.SelectButtonHydroelectricSystem();
                netDiagram.SelectButtonNuclearPlant();
                netDiagram.SelectButtonOilAndGas1();
                netDiagram.SelectButtonOilAndGas2();
                netDiagram.SelectButtonTrafficControl();
                netDiagram.SelectButtonWasteWaterTreatementPlant();
                netDiagram.SelectButtonWaterPlantSystem();
                netDiagram.SelectButtonHVAC();
                netDiagram.SelectButtonBuildingAccessControl();
                netDiagram.SelectButtonMedical();
                netDiagram.SelectButtonRadio();
                netDiagram.SelectButtonWindEnergy();
                netDiagram.SelectClickButtonEmergencyComm();
                netDiagram.SelectClickButtonCreate();
                netDiagram.SelectClickButtonReturnToCset();
                
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
