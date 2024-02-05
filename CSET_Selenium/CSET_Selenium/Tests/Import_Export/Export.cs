using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Helpers;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Repository.Landing_Page;
using CSET_Selenium.Repository.Login_Page;
using CSET_Selenium.Tests.Import_Export;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;

namespace CSET_Selenium.Tests.Import_Export
{
    internal class Export
    {
        [TestFixture]
        public class ExportTests : BaseTest
        {
            private IWebDriver driver;

            [Test]
            public void ExportAll ()
            {
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5500/");

                driver = driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET-TSA"));
                
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("matthew.winston@inl.gov", "Asdfghjkl12#$");

                LandingPage landingPage = new LandingPage(driver);
                landingPage.WaitForPageLoad();

                WaitUtils waitUtils = new WaitUtils(driver);
                Actions actions = new Actions(driver);

                // first run of exporting (before the while loop)
                By exportButton = By.XPath("//button[@id='assess-0-export']");

                int i = 0;

                IWebElement footer = driver.FindElement(By.XPath("//div[@id='footerPanel-header']"));
                driver.ExecuteJavaScript("arguments[0].setAttribute('style','display:none')", footer);

                // this workaround is so the mat tooltip doesn't cover the next Export button
                waitUtils.WaitUntilElementIsVisible(exportButton);
                actions.Click(driver.FindElement(exportButton)).Perform();
                //

                waitUtils.WaitForPageLoad();

                i++;
                exportButton = By.XPath("//button[@id='assess-" + i + "-export']");
                string exportButtonString = "//button[@id='assess-" + i + "-export']";

                while (landingPage.CheckIfElementExists(exportButtonString, 0))
                {
                    // this workaround is so the mat tooltip doesn't cover the next Export button
                    waitUtils.WaitUntilElementIsVisible(exportButton);
                    actions.Click(driver.FindElement(exportButton)).Perform();
                    //

                    i++;
                    exportButton = By.XPath("//button[@id='assess-" + i + "-export']");
                    exportButtonString = "//button[@id='assess-" + i + "-export']"; 
                }
            }

            [Test]
            public void ExportAllLocal()
            {
                BaseConfiguration cf = new BaseConfiguration("http://localhost:4200/");

                string conString = "data source=(localdb)\\mssqllocaldb;initial catalog=CSETWeb;persist security info=True;Integrated Security=SSPI;MultipleActiveResultSets=True";

                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand command = new SqlCommand();

                // this command lets the current user have access to everything in the database
                command.CommandText =
                    "INSERT INTO [CSETWeb].[dbo].[ASSESSMENT_CONTACTS]\r\n" +
                    "           ([Assessment_Id]\r\n" +
                    "\t\t    ,[PrimaryEmail]\r\n" +
                    "            ,[FirstName]\r\n" +
                    "            ,[LastName]\r\n" +
                    "            ,[Invited]\r\n" +
                    "            ,[AssessmentRoleId]\r\n" +
                    "            ,[UserId])\r\n" +
                    "   select distinct e.* from [CSETWeb].[dbo].[ASSESSMENT_CONTACTS] d right join (\r\n" +
                    "       \tselect a.Assessment_Id,c.PrimaryEmail, c.FirstName, c.LastName, 1 as Invited, 2 as AssessmentRoleId, c.UserId from [CSETWeb].[dbo].[ASSESSMENTS] a, (\r\n" +
                    "           \t\tSELECT distinct\r\n" +
                    "               \t\t\t[PrimaryEmail]\r\n" +
                    "               \t\t\t,[FirstName]\r\n" +
                    "               \t\t\t,[LastName]\r\n\t" +
                    "               \t\t,[UserId]\r\n" +
                    "           \t\tFROM [CSETWeb].[dbo].[USERS]\r\n" +
                    "           \t\twhere PrimaryEmail = '" + Environment.UserName +"'\r\n" +
                    "    \t) c \r\n" +
                    ") e on d.assessment_id=e.Assessment_Id and d.userid = e.userid\r\n" +
                    "where d.assessment_id is null";
                command.Connection = con;

                List<int> assess_Ids = new List<int> { };
                command.ExecuteReader();

                con.Close();
                con.Dispose();

                driver = driver = BuildDriver(cf);

                LandingPage landingPage = new LandingPage(driver);
                landingPage.WaitForPageLoad();

                WaitUtils waitUtils = new WaitUtils(driver);
                Actions actions = new Actions(driver);

                // first run of exporting (before the while loop)
                By exportButton = By.XPath("//button[@id='assess-0-export']");

                int i = 0;

                IWebElement footer = driver.FindElement(By.XPath("//div[@id='footerPanel-header']"));
                driver.ExecuteJavaScript("arguments[0].setAttribute('style','display:none')", footer);

                // this workaround is so the mat tooltip doesn't cover the next Export button
                waitUtils.WaitUntilElementIsVisible(exportButton);
                actions.Click(driver.FindElement(exportButton)).Perform();
                //

                waitUtils.WaitForPageLoad();

                i++;
                exportButton = By.XPath("//button[@id='assess-" + i + "-export']");
                string exportButtonString = "//button[@id='assess-" + i + "-export']";

                while (landingPage.CheckIfElementExists(exportButtonString, 0))
                {
                    // this workaround is so the mat tooltip doesn't cover the next Export button
                    waitUtils.WaitUntilElementIsVisible(exportButton);
                    actions.Click(driver.FindElement(exportButton)).Perform();
                    //

                    i++;
                    exportButton = By.XPath("//button[@id='assess-" + i + "-export']");
                    exportButtonString = "//button[@id='assess-" + i + "-export']";
                }
            }
        }
    }
}
