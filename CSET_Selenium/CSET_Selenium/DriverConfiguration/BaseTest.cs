using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace CSET_Selenium.DriverConfiguration
{
    [TestFixture]
    public abstract class BaseTest
    {
        private IWebDriver baseTestDriverForListener;
        //private String testID = null; //This value can be set using the setTestID method to be able to use a custom test identifier.
        //protected bool waitForMe = true;

        public IWebDriver GetBaseTestDriverForListener()
        {
            return baseTestDriverForListener;
        }

        public void SetBaseTestDriverForListener(IWebDriver baseTestDriverForListener)
        {
            this.baseTestDriverForListener = baseTestDriverForListener;
        }

        /**
         * @param cf
         * @return The IWebDriver!!!!!
         * @throws Exception
         * 
         */
        public IWebDriver BuildDriver(Object cf)
        {
            BaseConfiguration baseCF = (BaseConfiguration) cf;
            if (baseCF.GetHost().Equals("grid")) {

            } else {
        	    //sets variable to not wait for X seconds if running on local
                //waitForMe = false;
            }
            this.baseTestDriverForListener = new BaseDriverBuilder().BuildWebDriver(cf);
            return GetBaseTestDriverForListener();
        }

        [SetUp]
        public void TestSetUp()
        {
            /*LoggingHelper.startTestLogging(getTestId());
            if (!waitForMe)
            {
                Random rand = new Random(Environment.TickCount);

                // nextInt is normally exclusive of the top value,
                // so add 1 to make it inclusive
                int random = rand.Next(15);
                try
                {
                    Thread.Sleep(random * 1000);
                }
                catch (Exception e)
                {

                }
            }*/
        }

        [TearDown]
        public void TearDownDriver()
        {
            if (this.baseTestDriverForListener != null)
            {
                this.baseTestDriverForListener.Quit();
                //qaLogger.debug("Driver quit successfully");
            }
            else
            {
                //qaLogger.debug("Driver instance was null.");
            }
        }

        //Not yet implemented. Need to implement logging framework first.
        /*@AfterClass(alwaysRun = true)
            public void TestShutDown()
        {
            //Stop test logging to test specific file
            LoggingHelper.stopTestLogging();
        }

        public void setTestId(String testID)
        {
            this.testID = testID;
        }*/
    }
}
