using CSET_Selenium.Repository.Login_Page;
using CSET_Selenium.DriverConfiguration;
using CSET_Selenium.Page_Objects.Assessment_Configuration;
using CSET_Selenium.Page_Objects.AssessmentInfo;
using CSET_Selenium.Page_Objects.Cybersecurity_Standards_Selection;
using CSET_Selenium.Page_Objects.Sidebar;
using CSET_Selenium.Repository.Landing_Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CSET_Selenium.Tests.Create_Assessment
{
    class ModuleBuilderTest
    {
        [TestFixture]
        public class Module_Builder : BaseTest
        {
            private IWebDriver driver;
            Random r = new Random();

            private Boolean DoesModBuilderInputExist(List<String> els, int index, String tag)
            {
                List<IWebElement> elementList = new List<IWebElement>();
                Console.WriteLine("//" + tag + "[contains(text(), '" + els[index] + "')]");
                elementList.AddRange(driver.FindElements(By.XPath("//" + tag + "[contains(text(), '" + els[index] + "')]")));
                return elementList.Count > 0;
            }

            [Test]
            public void ModuleBuilderTest()
            {

                //Create a base configuration
                BaseConfiguration cf = new BaseConfiguration("http://csetac:5777");
                driver = BuildDriver(cf);
                Assert.That(driver.Title.Contains("CSET"));

                //Login and navigate to module builder
                LoginPage loginPage = new LoginPage(driver);
                loginPage.LoginToCSET("william.martin@inl.gov", "\"K!q;va&%G],(0!mE:G+%ba~z><T/v4AELXZUFz;Tav|y}'mbx");

                LandingPage createNewAssessment = new LandingPage(driver);
                createNewAssessment.NavigateToModuleBuilder();

                //Create a new module
                ModuleBuilder newModule = new ModuleBuilder(driver);
                newModule.CreateNewModule();

                //Set module details using the Chemical Oil, and Natural Gas category
                newModule.SetModuleDetails();

                //Add 2 random requirements to the module and 2 questions to the module
                newModule.GoToRequirements();
                newModule.AddRequirement("Random requirement 1", "Requirement 1", "Requirement 1 Supplemental Info", "Is this test working 1?");
                newModule.AddRequirement("Random requirement 2", "Requirement 2", "Requirement 2 Supplemental Info", "Is this test working 2?");

                //Navigate back to CSET home and create a new assessment
                newModule.GoHome();
                createNewAssessment.OpenNewAssessment();

                AssessmentConfiguration assessmentConfiguration = new AssessmentConfiguration(driver);
                assessmentConfiguration.CreateStandardAssessment("Standard Assessment NERC2 Rev6", "Wayne Tech", "Gotham City", "New Jersey");

                AssessmentInfo assessmentInfo = new AssessmentInfo(driver);
                assessmentInfo.SetAssessmentInformation();

                //Select Cybersecurity Standards Selection from the sidebar, and checkmark the module that corresponds to the above ("Chem Oil and Gas Test")
                Sidebar sidebar = new Sidebar(driver);
                sidebar.SelectCybersecurityStandardsSelection();

                newModule.CybersecStandardCheckbox();

                CybersecurityStandardsSelection css = new CybersecurityStandardsSelection(driver);
                css.ClickNext();
                Thread.Sleep(2000);

                //Assert that the module was created correctly

                var els = newModule.GetModuleInputs();
                var i = 1;
                foreach (var el in els)
                {
                    Console.WriteLine("This is element " + i + " at index " + (i - 1) + ": " + el);
                    i++;
                }

                driver.FindElement(By.XPath("//button[contains(text(), 'Expand All')]")).Click();
                var buttons = driver.FindElements(By.XPath("//app-question-block//div//div//div//div//button[1]"));
                foreach(var el in buttons)
                {
                    el.Click();
                }
                Thread.Sleep(5000);

                Assert.That(DoesModBuilderInputExist(els, 23, "span"));
                Assert.That(DoesModBuilderInputExist(els, 13, "span"));
                Assert.That(DoesModBuilderInputExist(els, 10, "div"));
                Assert.That(DoesModBuilderInputExist(els, 20, "div"));
                Assert.That(DoesModBuilderInputExist(els, 5, "span"));
                Assert.That(DoesModBuilderInputExist(els, 15, "span"));
                Assert.That(DoesModBuilderInputExist(els, 4, "div"));
                Assert.That(DoesModBuilderInputExist(els, 14, "div"));


                buttons = driver.FindElements(By.XPath("//app-question-block//div//div//div//div//button[2]"));
                foreach (var el in buttons)
                {
                    el.Click();
                }
                Thread.Sleep(2000);

                Assert.That(DoesModBuilderInputExist(els, 5, "div"));
                Assert.That(DoesModBuilderInputExist(els, 15, "div"));

                driver.FindElement(By.XPath("//label[contains(text(),'Requirements')]")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//button[@class='btn btn-primary m-0 br-0']")).Click();
                Thread.Sleep(3000);
                var buttons2 = driver.FindElements(By.XPath("//app-question-extras/div/div[1]/button[1]"));
                foreach (var el in buttons2)
                {
                    el.Click();
                }

                Thread.Sleep(2000);
                Assert.That(DoesModBuilderInputExist(els, 17, "div"));
                Assert.That(DoesModBuilderInputExist(els, 7, "div"));
                Assert.That(DoesModBuilderInputExist(els, 10, "div"));
                Assert.That(DoesModBuilderInputExist(els, 20, "div"));
                Assert.That(DoesModBuilderInputExist(els, 5, "div"));
                Assert.That(DoesModBuilderInputExist(els, 15, "div"));
                Assert.That(DoesModBuilderInputExist(els, 4, "div"));
                Assert.That(DoesModBuilderInputExist(els, 14, "div"));

                buttons = driver.FindElements(By.XPath("//app-question-block//div//div//div//div//button[2]"));
                foreach (var el in buttons)
                {
                    el.Click();
                }
                Thread.Sleep(2000);

                Assert.That(DoesModBuilderInputExist(els, 6, "div"));
                Assert.That(DoesModBuilderInputExist(els, 16, "div"));
                Thread.Sleep(4000);

                createNewAssessment.NavigateToModuleBuilder();
                newModule.DeleteModule();
            }
        }
    }
}

