using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using Shared = CSET_Selenium.Repositories.Shared;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.Security_Assurance_Level;
using CSET_Selenium.Enums.SAL;
using System.Threading;


namespace CSET_Selenium.Helpers
{
    static internal class AssessmentCommonFunctions
    {
        private static Random r = new Random();
        private static Dictionary<string, string> statMap = new Dictionary<string, string>();

        internal static SecurityAssuranceLevel InitilizeAssessment(IWebDriver driver, Shared.AssessmentRepository sharedRepo)
        {
            SecurityAssuranceLevel SALPage = null;
            LandingPage landingPage = AssessmentCommonFunctions.LogInToLandingPage(driver, sharedRepo);

            if (landingPage != null)
            {
                AssessmentConfiguration configurationPage = AssessmentCommonFunctions.InitializeAssessmentConfiguationPage(driver, sharedRepo);

                if (configurationPage != null)
                {
                    AssessmentInfo info = AssessmentCommonFunctions.InitializeAssessmentInformationPage(driver, sharedRepo);

                    if (info != null)
                    {
                        // optionally allocate an instance of this object to set propertiesd
                        Shared.SecurityAssuranceLevel salData = new Shared.SecurityAssuranceLevel();

                        SALPage = AssessmentCommonFunctions.InitializeAssessmentSALPage(driver, sharedRepo, salData);
                    }
                }
            }

            return SALPage;
        }

        internal static LandingPage LogInToLandingPage(IWebDriver driver, Shared.AssessmentRepository sharedRepo)
        {
            LandingPage landingPage = null;
            LoginPage loginPage = AssessmentCommonFunctions.LogInToCSET(driver, sharedRepo);

            if (loginPage != null)
            {
                landingPage = AssessmentCommonFunctions.GoToCSETLandingPage(driver, sharedRepo);
            }

            return landingPage;
        }
        internal static LoginPage LogInToCSET(IWebDriver driver, Shared.AssessmentRepository sharedRepo)
        {
            Dictionary<string, string> userCredentials = sharedRepo.UserCredentials;
            string userName = userCredentials["UserName"];
            string passWord = userCredentials["PassWord"];

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToCSET(userName, passWord);

            return loginPage;
        }

        internal static LandingPage GoToCSETLandingPage(IWebDriver driver, Shared.AssessmentRepository sharedRepo)
        {
            LandingPage nercRev6Assessment = new LandingPage(driver);
            nercRev6Assessment.OpenNewAssessment();
            nercRev6Assessment.NERCRev6CreateAssessment();

            return nercRev6Assessment;
        }

        internal static AssessmentConfiguration InitializeAssessmentConfiguationPage(IWebDriver driver, Shared.AssessmentRepository sharedRepo)
        {
            // access shared repository to set assessment configuation
            AssessmentConfiguration configurationPage = new AssessmentConfiguration(driver);
            configurationPage.CreateNERCRev6Assessment(sharedRepo.AssessmentConfig);

            return configurationPage;
        }

        internal static AssessmentInfo InitializeAssessmentInformationPage(IWebDriver driver, Shared.AssessmentRepository sharedRepo)
        {
            AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
            assessmentInfo.SetAssessmentInformation(sharedRepo.AssessmentInfo);

            return assessmentInfo;
        }

        internal static SecurityAssuranceLevel InitializeAssessmentSALPage(
            IWebDriver driver, 
            Shared.AssessmentRepository sharedRepo, 
            Shared.SecurityAssuranceLevel sal = null)
        {
            SecurityAssuranceLevel securityPage = new SecurityAssuranceLevel(driver);

            int generalRiskNum = r.Next(9);
            securityPage.SelectHeaderGeneralRiskBased();
            securityPage.SetRandomGeneralRisk(generalRiskNum);
            securityPage.SelectHeaderNist();
            Thread.Sleep(3000);
            for (int i = 0; i < 5; i++)
            {
                securityPage.SetRandomNistCheck();
            }
            securityPage.GetStandardMap().ToList().ForEach(x => statMap.Add(x.Key, x.Value));
            securityPage.SetRandomNistQuestion();
            securityPage.ClickNext();

            sal = (sal == null) ? sharedRepo.SecurityAssuranceLevel() : sal;

            SetSalMethdology(securityPage, sal.Methodology);

            SetSalConfidentiality(securityPage, sal.Confidentiality);

            SetSalOverall(securityPage, sal.Overall);

            SetSalIntegrity(securityPage, sal.Integrity);

            SetSalAvailability(securityPage, sal.Avaiability);

            return securityPage;
        }

        private static void SetSalOverall(SecurityAssuranceLevel securityPage, SAL_Overall overall)
        {
            switch (overall)
            {
                case SAL_Overall.Moderate:
                    {
                        securityPage.SelectHeaderOverallSalModerate();

                        break;
                    }
                case SAL_Overall.High:
                    {
                        securityPage.SelectHeaderOverallSalHigh();

                        break;
                    }
                case SAL_Overall.VeryHigh:
                    {
                        securityPage.SelectHeaderOverallSalVeryHigh();

                        break;
                    }
                default:
                    {
                        securityPage.SelectHeaderOverallSalLow();

                        break;
                    }
            }
        }

        private static void SetSalMethdology(SecurityAssuranceLevel securityPage, SAL_Methodology methodology)
        {
            switch (methodology)
            {
                case SAL_Methodology.GeneralRiskBased:
                    {
                        securityPage.SelectHeaderGeneralRiskBased();

                        break;
                    }
                case SAL_Methodology.NIST60_FIPS199:
                    {
                        securityPage.SelectHeaderNist();

                        break;
                    }
                default:
                    {
                        securityPage.SelectHeaderSimple();

                        break;
                    }
            }
        }

        private static void SetSalConfidentiality(SecurityAssuranceLevel securityPage, SAL_Confidentiality confideentiality)
        {
            if (confideentiality == SAL_Confidentiality.Low)
            {

            }
        }

        private static void SetSalIntegrity(SecurityAssuranceLevel securityPage, SAL_Integrity integrity)
        {
            if (integrity == SAL_Integrity.Low)
            {

            }
        }

        private static void SetSalAvailability (SecurityAssuranceLevel securityPage, SAL_Availability availability)
        {
            if (availability == SAL_Availability.Low)
            {

            }
        }
    }
}
