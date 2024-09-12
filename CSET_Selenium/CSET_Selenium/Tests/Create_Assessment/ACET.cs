using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Page_Objects.Maturity_Models;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CSET_Selenium.Tests.Create_Assessment
{
    class AcetBuildAssessment
    {
        [TestFixture]
        public class CreateAcetBuildAssessment : BaseTest
        {
            private IWebDriver driver;



            [Test]
            public void ACET()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777/");
                driver = BuildDriver(cf);
<<<<<<< HEAD
              //  Assert.That(driver.Title.Contains("ACET"));
=======
                Assert.That(driver.Title.Contains("ACET"));
>>>>>>> 69ac795 (Fixes to testing, automation currently working)

                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "\"K!q;va&%G],(0!mE:G+%ba~z><T/v4AELXZUFz;Tav|y}'mbx");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.ACETCreateNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateAcetBuildAssessment("ACET(ACET Build)", "New-New-York", "New York", "2525", "100000");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

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


            }

        }
    }
}
