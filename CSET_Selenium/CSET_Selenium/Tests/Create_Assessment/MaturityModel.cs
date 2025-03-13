using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Page_Objects.Maturity_Models;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CSET_Selenium.Tests.Create_Assessment
{
    class MaturityModel
    {
        [TestFixture]
        public class CreateMaturityModelAssessment : BaseTest
        {
            private IWebDriver driver;



            [Test]
            public void ACET()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.OpenNewAssessment();
                createNewAssessment.ACETCreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("ACET(CSET Build)", "S.T.A.R. Labs", "Star City", "Washington");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                // may need to delete the next 2 lines
                //Maturity Models Page
                //MaturityModelsPage maturityModelsPage = new MaturityModelsPage(driver);
                //maturityModelsPage.SelectACET();

                //Inherent Risk Profiles
                assessmentInfo.SetAssessmentInformation();

                //Inherent Risk Profile Summary
                assessmentInfo.SetAssessmentInformation();

                //Statements Page
                assessmentInfo.SetAssessmentInformation();

                //ACET Maturity Results Page
                assessmentInfo.SetAssessmentInformation();

                //ACET Dashboard Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page

            }

            [Test]
            public void CMMCVer1()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.OpenNewAssessment();
                createNewAssessment.CMMC1CreateNewAssessment();

                //CMMC Tutorial Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
//                assessmentInfo.SetAssessmentInformation();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);

                //Assessment Configuration Page => Assessment INformation Page
                assessmentConfiguration.CreateMaturityModelAssessment("CMMC Ver 2", "Planet Express", "New New York", "New York");

                //Assessment Information Page = Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page => Reports Page
                assessmentInfo.SetAssessmentInformation();

                // Reports => Feedback Page
                assessmentInfo.SetAssessmentInformation();
            }

            [Test]
            public void CMMCVer2()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.OpenNewAssessment();
                createNewAssessment.CMMC2CreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("CMMC Ver 2", "Planet Express", "New New York", "New York");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //Maturity Models Page
                //MaturityModelsPage maturityModelsPage = new MaturityModelsPage(driver);
                //maturityModelsPage.SelectCMMC2();

                //CMMC Tutorial Page
                assessmentInfo.SetAssessmentInformation();

                //CMMC Target Level Selection Page
                assessmentInfo.SetAssessmentInformation();
            }

            [Test]
            public void CRR()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.OpenNewAssessment();
                createNewAssessment.CRRCreateNewAssessment();

                //CRR Tutorial Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                //assessmentConfiguration.CreateMaturityModelAssessment("CRR", "S.T.A.R. Labs", "Star City", "Washington");

                // Assessment Information Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Summary Page
                assessmentInfo.SetAssessmentInformation();

                //Assesst Management Page
                assessmentInfo.SetAssessmentInformation();

                //Controls Management Page
                assessmentInfo.SetAssessmentInformation();

                //Configuration and Change Management Page
                assessmentInfo.SetAssessmentInformation();

                //Vulnerability Management Page
                assessmentInfo.SetAssessmentInformation();

                //Incident Management Page
                assessmentInfo.SetAssessmentInformation();

                //Service Continuity Management Page
                assessmentInfo.SetAssessmentInformation();

                //Risk Management Page
                assessmentInfo.SetAssessmentInformation();

                //External Dependencies Management Page
                assessmentInfo.SetAssessmentInformation();

                //Training and Awareness Page
                assessmentInfo.SetAssessmentInformation();

                //Situatinal Awareness Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page
                assessmentInfo.SetAssessmentInformation();
            }


            [Test]
            public void EDM()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.OpenNewAssessment();
                createNewAssessment.EDMCreateNewAssessment();

                //EDM Tutorial Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("EDM", "S.T.A.R. Labs", "Star City", "Washington");

                //Assessment Information Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Summary Results Page
                assessmentInfo.SetAssessmentInformation();

                //Relationship Formation Page
                assessmentInfo.SetAssessmentInformation();

                //Relationship Management and Governance Page
                assessmentInfo.SetAssessmentInformation();

                //Service Protection and Sustainment Page
                assessmentInfo.SetAssessmentInformation();

                //Maturity Indicator Levels Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();
            }

            [Test]
            public void RRA()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.OpenNewAssessment();
                createNewAssessment.RRACreateNewAssessment();

                //Ransomeware Readiness Tutorial Page
                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateMaturityModelAssessment("RRA", "Curtis Farms", "Shady Sands", "New California");

                // Assessment Information Page
                assessmentInfo.SetAssessmentInformation();

                //Practices Page
                assessmentInfo.SetAssessmentInformation();

                //Goal Performance Page
                assessmentInfo.SetAssessmentInformation();

                //Assessment Tiers Page
                assessmentInfo.SetAssessmentInformation();

                //Performance Summary Page
                assessmentInfo.SetAssessmentInformation();

                //Reports Page
                assessmentInfo.SetAssessmentInformation();

                //Feedback Page

            }
        }
    }
}
