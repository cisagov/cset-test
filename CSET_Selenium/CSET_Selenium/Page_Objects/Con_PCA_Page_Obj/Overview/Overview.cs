using OpenQA.Selenium;
using CSET_Selenium.ConPCA_Repository.Con_PCA;
using System;
using CSET_Selenium.Enums.Con_PCA;
using System.Collections.Generic;
using System.Threading;

namespace CSET_Selenium.Page_Objects.Con_PCA_Page_Obj.Overview
{
    class Overview : ConPCABase
    {
        private readonly IWebDriver driver;

        public Overview(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Element Locators

        private IWebElement TabAggregateStatistics
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[text()='Aggregate Statistics']"));
            }
        }

        private IWebElement TabSubscriptionStatus
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[text()='Subscription Status']"));
            }
        }

        private IWebElement TabLoggingErrors
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[text()='Logging Errors']"));
            }
        }

        private IWebElement TabFailedEmails
        {
            get
            {
                return WaitUntilElementIsVisible(By.XPath("//div[text()='Failed Emails']"));
            }
        }



        //Interaction Methods



        //Aggregate Methods
        public void ClickAggregateStatisticsTab()
        {
            ClickWhenClickable(TabAggregateStatistics);
        }

        public void ClickSubscriptionStatusTab()
        {
            ClickWhenClickable(TabSubscriptionStatus);
        }

        public void ClickLoggingErrorsTab()
        {
            ClickWhenClickable(TabLoggingErrors);
        }

        public void ClickFailedEmailsTab()
        {
            ClickWhenClickable(TabFailedEmails);
        }

        public string GetAggregateStatisticsOverviewValue(string overviewCategory)
        {
            return Find(By.XPath("//h3[text() = 'Overview']/following-sibling::div/div/table/tr/td[text() = '"+overviewCategory+"']/following-sibling::td")).Text;
        }

        /*Subtype: Subscription Count/Cycle Count/Emails Sent/Email Click Ratio
         */
        public string GetAggregateStatisticsValueByCustomerCategory(CustomerTypes type, string subCategory)
        {
            return Find(By.XPath("//h3[text() = 'Customer Totals By Category']/following-sibling::table/tr/td/div[contains(text(), '" + type.ToString() + "')]/following-sibling::div/table/tr/td[text()='"+ subCategory + "']/following-sibling::td")).Text;
        }

        /*
         */
        public Dictionary<string, string> GetAggregateStatisticsOverviewItemsAndValues()
        {
            var map = new Dictionary<string, string>();
            string key, value;
            IList<IWebElement> list = driver.FindElements(By.XPath("//h3[text() = 'Overview']/following-sibling::div/div/table[1]/tr"));
            foreach(var tr in list)
            {
                key = tr.FindElement(By.XPath(".//td[1]")).Text;
                value = tr.FindElement(By.XPath(".//td[2]")).Text;
                map.Add(key, value);
            }

            return map;
        }

        public Dictionary<string, string> GetAggregateStatisticsOCustomerTotalsByCategory(CustomerTypes type)
        {
            var map = new Dictionary<string, string>();
            string key, value;
            IList<IWebElement> list = driver.FindElements(By.XPath("//div[text() = '"+type.ToString()+"']/following-sibling::div/table[1]/tr"));
            foreach (var tr in list)
            {
                key = tr.FindElement(By.XPath(".//td[1]")).Text;
                value = tr.FindElement(By.XPath(".//td[2]")).Text;
                map.Add(key, value);
            }

            return map;
        }

        public bool IsPageLoaded(int timeoutInSecondsToWait)
        {
            String spinnerXpath = "//mat-spinner[contains(@class, 'mat-progress-spinner-indeterminate-animation')]";
    
            int secondsToDelay = 2;
            bool spinnerNotShowing = WaitUntilElementIsNotVisible(By.XPath(spinnerXpath), 1000);
            while (!spinnerNotShowing && timeoutInSecondsToWait > 0)
            {

                Thread.Sleep(TimeSpan.FromSeconds(2));
                timeoutInSecondsToWait = timeoutInSecondsToWait - secondsToDelay;

                spinnerNotShowing = WaitUntilElementIsNotVisible(By.XPath(spinnerXpath), 1000);
            }
            return spinnerNotShowing;
        }
    }
}
