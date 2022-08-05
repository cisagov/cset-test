using System;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.ConPCA_Repository.Login_Page;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.SideMenu;
using NUnit.Framework;
using OpenQA.Selenium;
using CSET_Selenium.Helpers;
using CSET_Selenium.Enums.Con_PCA;
using CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Recommendations;

namespace CSET_Selenium.Tests.Con_PCA.RecommendationsTest
{
    [TestFixture]
    public class RecommendationTest : BaseTest
    {
        private IWebDriver driver;

        [Test]
        public void RecommendationCreateEditDelete()
        {
            BaseConfiguration cf = new BaseConfiguration(Env.Dev.GetValue());
            driver = BuildDriver(cf);
            String recommendationTitle = StringsUtils.GenerateRandomString(6);
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoginToConPCA(LoginInfo.User_Name.GetValue(), LoginInfo.Password.GetValue());
            //Create a new recommendation
            SideMenu sideMenu = new SideMenu(driver);
            sideMenu.SelectRecommendation();
            Recommendations recommendation = new Recommendations(driver);
            recommendation.CreateNewRecommendation(recommendationTitle, RecommendationType.Red_Flag, "Test");
            bool foundNewRecommendation = recommendation.FindRecommendationByTitle(recommendationTitle);
            Assert.IsTrue(foundNewRecommendation, "Didn't find the new recommendation.");

            //Edit the recommendation and verify
            
            recommendation.EditRecommendationType(recommendationTitle, RecommendationType.Sophisticated);
            String newType = recommendation.GetCellValueInRecommendationTableRow(recommendation.GetRecommendationsTableRowByTitle(recommendationTitle), 2);
            String typeShouldBe = RecommendationType.Sophisticated.GetValue();
            bool tmp = String.Equals(newType, typeShouldBe, StringComparison.OrdinalIgnoreCase);

            Assert.IsTrue(String.Equals(newType, typeShouldBe, StringComparison.OrdinalIgnoreCase), "Failed editing recommendation.");
            

            //Delete a recommendation
            recommendation.DeleteRecommendationByTitle(recommendationTitle);
            Assert.IsFalse(recommendation.FindRecommendationByTitle(recommendationTitle), "The recommendation is not deleted as expected.");
        }
    }
}
