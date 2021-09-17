using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSET_Selenium.Helpers
{
    class WaitUtils
    {
        private readonly IWebDriver driver;
        private TimeSpan defaultWait = new TimeSpan(0, 0, 15);

        //private By xmaskPresent = By.cssSelector("div[role='presentation'][class='x-mask x-mask-fixed']");

        public WaitUtils(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected WebDriverWait NewWait()
        {
            return new WebDriverWait(this.driver, this.defaultWait);
        }

        protected WebDriverWait NewWait(int waitInMilliseconds)
        {
            return new WebDriverWait(new SystemClock(), this.driver, TimeSpan.FromMilliseconds(TimeFixer(waitInMilliseconds)), TimeSpan.FromMilliseconds(100));
        }

        //Will normalize all time to milliseconds
        protected int TimeFixer(int time)
        {
            int tmp = (time > 300) ? time : time * 1000;
            return tmp;
        }

        public bool RetryUntilSuccessOrTimeout(Func<bool> task, int timeout = (120 * 1000), int pause = 100)
        {
            TimeSpan pauseTimeSpan = TimeSpan.FromMilliseconds(pause);
            if (pauseTimeSpan.TotalMilliseconds < 0)
            {
                throw new ArgumentException("pause must be >= 0 milliseconds");
            }
            var stopwatch = Stopwatch.StartNew();
            do
            {
                if (task()) { return true; }
                Thread.Sleep((int)pauseTimeSpan.TotalMilliseconds);
            }
            while (stopwatch.Elapsed < TimeSpan.FromMilliseconds(timeout));
            return false;
        }

        private bool IsElementVisible(By locator)
        {
            try
            {
                return driver.FindElement(locator).Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsElementVisible(IWebElement element)
        {
            try
            {
                return element.Displayed && element.Enabled;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public bool WaitForPageLoad()
        {
            bool jqueryLoaded = false;
            bool javaScriptLoaded = false;

            for (var i = 0; i < 100; i++)
            {
                try
                {
                    jqueryLoaded = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                    if (jqueryLoaded)
                    {
                        break;
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                } catch (Exception)
                {
                    //jQuery Does Not Exist on Page
                    jqueryLoaded = true;
                    break;
                }
            }

            for (var i = 0; i < 60; i++)
            {
                javaScriptLoaded = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return document.readyState").Equals("complete");
                if (javaScriptLoaded)
                {
                    break;
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }

            return jqueryLoaded && javaScriptLoaded;
        }

        public void WaitForPostBack(int milisecondsToWait = (120*1000))
        {
            try
            {
                Thread.Sleep(400); // initial pause to make sure postback kicks off.
            }
            catch (Exception)
            {
            }
            NewWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector("body")));
            if (driver.FindElement(By.CssSelector("body")).GetAttribute("class").Contains("x-mask"))
            {
                RetryUntilSuccessOrTimeout(new Func<bool>(() => !driver.FindElement(By.CssSelector("body")).GetAttribute("class").Contains("x-mask")), milisecondsToWait, 100);
            }
        }

        public bool WaitUntilElementNotClickable(By locator)
        {
            WaitForPageLoad();
            try
            {
                NewWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool WaitUntilElementNotClickable(By locator, int time)
        {
            WaitForPageLoad();
            try
            {
                NewWait(time).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool WaitUntilElementNotClickable(IWebElement ele)
        {
            WaitForPageLoad();
            try
            {
                NewWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ele));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool WaitUntilElementNotClickable(IWebElement ele, int time)
        {
            WaitForPageLoad();
            try
            {
                NewWait(time).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ele));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IWebElement WaitUntilElementIsClickable(By locator)
        {
            WaitForPageLoad();
            NewWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            return driver.FindElement(locator);
        }

        public IWebElement WaitUntilElementIsClickable(IWebElement ele)
        {
            WaitForPageLoad();
            NewWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ele));
            return ele;
        }

        public IWebElement WaitUntilElementIsClickable(By locator, int waitInMilliseconds)
        {
            WaitForPageLoad();
            NewWait(waitInMilliseconds).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            return driver.FindElement(locator);
        }

        public IWebElement WaitUntilElementIsClickable(IWebElement ele, int waitInMilliseconds)
        {
            WaitForPageLoad();
            NewWait(waitInMilliseconds).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(ele));
            return ele;
        }

        public IWebElement WaitUntilElementIsVisible(By locator)
        {
            WaitForPageLoad();
            NewWait().Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }

        public IWebElement WaitUntilElementIsVisible(IWebElement ele)
        {
            WaitForPageLoad();
            RetryUntilSuccessOrTimeout(new Func<bool>(() => IsElementVisible(ele)), 15000, 100);
            return ele;
        }

        public IWebElement WaitUntilElementIsVisible(By locator, int waitInMilliseconds)
        {
            WaitForPageLoad();
            NewWait(waitInMilliseconds).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            return driver.FindElement(locator);
        }

        public IWebElement WaitUntilElementIsVisible(IWebElement ele, int waitInMilliseconds)
        {
            WaitForPageLoad();
            RetryUntilSuccessOrTimeout(new Func<bool>(() => IsElementVisible(ele)), waitInMilliseconds, 100);
            return ele;
        }


        public bool WaitUntilElementIsNotVisible(By locator)
        {
            if (NewWait().Until(driver => !IsElementVisible(locator)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool WaitUntilElementIsNotVisible(IWebElement ele)
        {
            if (NewWait().Until(driver => !IsElementVisible(ele)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool WaitUntilElementIsNotVisible(By locator, int timeoutInMilliseconds)
        {
            if (NewWait(timeoutInMilliseconds).Until(driver => !IsElementVisible(locator)))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool WaitUntilElementIsNotVisible(IWebElement ele, int waitInMilliseconds)
        {
            if (NewWait(waitInMilliseconds).Until(driver => !IsElementVisible(ele)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
