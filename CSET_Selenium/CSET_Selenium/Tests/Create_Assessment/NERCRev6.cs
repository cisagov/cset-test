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

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToCSET("william.martin@inl.gov", "+L|=!yDx(`zU8|c=E:6*)?)S!k:XynL!5Vi39|:?8kp'uMB9X'");

            LandingPage createNewAssessment = new LandingPage(driver);
            createNewAssessment.OpenNewAssessment();
            createNewAssessment.NERCRev6CreateAssessment();

            AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
            assessmentConfiguration.CreateNERCRev6Assessment("NERC CIP-002 through CIP-014 Revision 6", "S.T.A.R. Labs", "Star City", "Washington");

            AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
            assessmentInfo.SetAssessmentInformation();

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
