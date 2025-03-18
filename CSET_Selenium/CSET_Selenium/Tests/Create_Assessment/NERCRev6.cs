using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Page_Objects.Maturity_Models;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using Shared = CSET_Selenium.Repositories.Shared;
using NERC6 = CSET_Selenium.Repositories.NERC_Rev_6;
using NUnit.Framework;
using OpenQA.Selenium;
using FluentAssertions;
using CSET_Selenium.Page_Objects.Security_Assurance_Level;

namespace CSET_Selenium.Tests.Create_Assessment
{
    [TestFixture]
    class NERCRev6 : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void CreateAssessmentTest()
        {
            BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
            driver = BuildDriver(cf);
            Assert.That(driver.Title.Contains("CSET"));

            using (Shared.AssessmentRepository sharedRepo = new Shared.AssessmentRepository())
            {
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");

                LandingPage nercRev6Assessment = new LandingPage(driver);
                nercRev6Assessment.OpenNewAssessment();
                nercRev6Assessment.NERCRev6CreateAssessment();

                AssessmentConfiguration configurationPage = new AssessmentConfiguration(driver);

                // access shared repository to set assessment configuation
                configurationPage.CreateNERCRev6Assessment(sharedRepo.AssessmentConfig);

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation(sharedRepo.AssessmentInfo);

                SecurityAssuranceLevel securityAssurance = new SecurityAssuranceLevel(driver);
                // securityAssurance.

                using (NERC6.NERCRev6Repository nercRepo = new NERC6.NERCRev6Repository())
                {
                    //Inherent Risk Profiles
                    assessmentInfo.SetAssessmentInformation();

                    //Inherent Risk Profile Summary
                    assessmentInfo.SetAssessmentInformation();

                    //Maturity Questions Page
                    assessmentInfo.SetAssessmentInformation();

                    //ACET Maturity Results Page
                    assessmentInfo.SetAssessmentInformation();

                    //ACET Dashboard Page
                    assessmentInfo.SetAssessmentInformation();

                    //Reports Page
                    assessmentInfo.SetAssessmentInformation();

                    //Feedback Page
                }
            }
        }
    }
}
