using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using Shared = CSET_Selenium.Repositories.Shared;

namespace CSET_Selenium.Helpers
{
    public static class ExtensionMethodHelpers
    {
        static LandingPage LogInToLandingPage(this IWebDriver driver, Shared.AssessmentRepository sharedRepo)
        {
            Dictionary<string, string> userCredentials = sharedRepo.UserCredentials;
            string userName = userCredentials["UserName"];
            string passWord = userCredentials["PassWord"];

            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToCSET(userName, passWord);

            LandingPage nercRev6Assessment = new LandingPage(driver);
            nercRev6Assessment.OpenNewAssessment();
            nercRev6Assessment.NERCRev6CreateAssessment();

            return nercRev6Assessment;
        }
    }
}
