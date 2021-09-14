using CSET_Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSET_Selenium.DriverConfiguration
{
    class BasePage : WaitUtils
    {
        private readonly IWebDriver driver;

        public BasePage(IWebDriver webDriver) : base(webDriver)
        {
            this.driver = webDriver;
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public void Visit(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public String GetCurrentUrl()
        {
            return this.driver.Url;
        }

        public void ConsoleOut(String outputMessage)
        {
            Console.WriteLine(outputMessage);
        }

        public void RefreshPage()
        {
            this.driver.Navigate().Refresh();
        }

        public IWebElement Find(By locator)
        {
            return this.driver.FindElement(locator);
        }

        public IReadOnlyCollection<IWebElement> Finds(By locator)
        {
            return driver.FindElements(locator);
        }

        public String GetTextOrValueFromElement(IWebElement ele)
        {
            WaitUntilElementIsVisible(ele);
            if (StringsUtils.EqualsIgnoreCase(ele.TagName, "div"))
            {
                return ele.Text;
            }
            else
            {
                return ele.GetAttribute("value");
            }
        }

        public String GetTextOrValueFromElement(By locator)
        {
            if (StringsUtils.EqualsIgnoreCase(Find(locator).TagName, "div"))
            {
                return Find(locator).Text;
            }
            else
            {
                return Find(locator).GetAttribute("value");
            }
        }

        public bool ClickIfAvailable(IWebElement ele)
        {
            if (CheckIfElementExists(ele, 5))
            {
                if (isElementDisabled(ele))
                {
                    return false;
                }
                else
                {
                    clickWhenClickable(ele);
                    return true;
                }
            }
            return false;
        }

        public void ClickWhenClickable(IWebElement ele)
        {
            WaitUntilElementIsClickable(ele).Click();
            WaitForPostBack();
        }

        public void ClickWhenClickable(By locator)
        {
            WaitUntilElementIsClickable(locator).Click();
            WaitForPostBack();
        }

        public void ClickWhenClickable(IWebElement ele, int wait)
        {
            WaitUntilElementIsClickable(ele, wait).Click();
            WaitForPostBack();
        }

        public void ClickWhenClickable(By locator, int wait)
        {
            WaitUntilElementIsClickable(locator, wait).Click();
            WaitForPostBack();
        }


        public void SetText(IWebElement textBox, String text)
        {
            WaitUntilElementIsClickable(textBox);
            textBox.Clear();
            textBox.SendKeys(text);
            ClickProductLogo();
            WaitForPostBack();
        }

        public void SetTextHitEnter(IWebElement textBox, String text)
        {
            WaitUntilElementIsClickable(textBox);
            textBox.Clear();
            textBox.SendKeys(text);
            textBox.SendKeys(Keys.Enter);
            WaitForPostBack();
        }

        public void ClickWhenVisible(IWebElement elementToClick)
        {
            elementToClick = this.WaitUntilElementIsVisible(elementToClick);
            elementToClick.Click();
            WaitForPostBack();
        }

        public void ClickWhenVisible(IWebElement elementToClick, int wait)
        {
            elementToClick = this.WaitUntilElementIsVisible(elementToClick, wait);
            elementToClick.Click();
            WaitForPostBack();
        }

        public void ClickWhenVisible(By locator)
        {
            this.WaitUntilElementIsVisible(locator).Click();
            WaitForPostBack();
        }

        public void ClickWhenVisible(By locator, int wait)
        {
            this.WaitUntilElementIsVisible(locator, wait).Click();
            WaitForPostBack();
        }


        public void Sleep(int timeInMilliseconds)
        {
            int normalizedTime = TimeFixer(timeInMilliseconds);
            try
            {
                Thread.Sleep(normalizedTime); 
            }
            catch (Exception e)
            {
                ConsoleOut(e.Message);
            }
        }

        /**
         * This method will check to see if an element is useable or not on a page. This is useful for elements that are displayed on a page,
         * but that are grayed-out, for instance. A normal check to see if an element exists will always return true in this instance,
         * even though the element is not actually useable.
         *
         * @param element WebElement to check
         * @return boolean disabled or not.
         */
        public bool IsElementDisabled(IWebElement element)
        {
            return element.GetAttribute("class").Contains("x-item-disabled") || element.GetAttribute("class").Contains("x-disabled") || element.GetAttribute("class").Contains("x-btn-disabled");
        }

        // wait for element to be clickable
        // visible etc.

        /**
         * This method checks to see if an alert (pop-up) message is present on the page, indicating the need for some user interaction.
         *
         * @return boolean Alert present or not.
         */
        public bool IsAlertPresent()
        {
            try
            {
                Find(By.XPath("//div[contains(@id, 'messagebox-1001_header-body')]/parent::div/parent::div/preceding-sibling::div[contains(@style, 'display: block')]"));
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        public String GetPopupTextContents()
        {
            String popUpTextContents = "";
            popUpTextContents = Find(By.XPath("//div[contains(@id, 'messagebox-1001-displayfield-inputEl')]")).Text;
            return popUpTextContents;
        }

        public String SelectOKOrCancelFromPopup(Enums.OkCancel okOrCancel)
        {
            String popUpTextContents = "";
            popUpTextContents = Find(By.XPath("//div[contains(@id, 'messagebox-1001-displayfield-inputEl')]")).Text;
            IWebElement okButton = Find(By.XPath("//div[contains(@id,'messagebox-1001')]//div//a[contains(.,'OK')]"));
            IWebElement cancelButton = Find(By.XPath("//div[contains(@id,'messagebox-1001')]//div//a[contains(.,'Cancel')]"));

            switch (okOrCancel)
            {
                case Enums.OkCancel.OK:
                    ClickWhenClickable(okButton);
                    WaitForPostBack();
                    break;
                case Enums.OkCancel.Cancel:
                    ClickWhenClickable(cancelButton);
                    WaitForPostBack();
                    break;
            }
            return popUpTextContents;
        }

        public void SendArbitraryKeys(Keys keysToSend)
        {
            Keys[] = new Keys[] { Keys.Alt, Keys.Control, Keys.Shift, Keys.LeftAlt, Keys.LeftControl, Keys.LeftShift, Keys.Meta };
            List<Keys> modifierKeys = new List<Keys> { (Keys.Alt, Keys.Control, Keys.Shift, Keys.LeftAlt, Keys.LeftControl, Keys.LeftShift, Keys.Meta};
            if (modifierKeys.Contains(keysToSend))
            {
                new Actions(driver).KeyDown(keysToSend).KeyUp(keysToSend);
            }
            else
            {
                new Actions(driver).SendKeys(keysToSend).Perform();
            }
            WaitForPostBack();
        }

        public void SendArbitraryKeys(String keysToSend)
        {
            new Actions(driver).sendKeys(keysToSend).perform();
            waitForPostBack();
        }

        public void ClickElementByCordinates(WebElement ele, int x, int y)
        {
            waitUntilElementIsClickable(ele);
            Actions builder = new Actions(driver);
            builder.moveToElement(ele, x, y).click().perform();
            waitForPostBack();
        }

        public void UploadOrSaveFile(String filePath) throws AWTException
        {
            Path path = Paths.get(filePath).getParent();
    	    try {
			    Files.createDirectories(path);
		    } catch (IOException e) {
			    e.printStackTrace();
		    }
            StringSelection ss = new StringSelection(filePath);
            Toolkit.getDefaultToolkit().getSystemClipboard().setContents(ss, null);

            Robot robot = new Robot();
            if (((RemoteWebDriver)getDriver()).getCapabilities().getPlatform().is (Platform.LINUX))
            {
                robot.keyPress(KeyEvent.VK_CONTROL);
                robot.keyPress(KeyEvent.VK_L);
                robot.keyRelease(KeyEvent.VK_L);
                robot.keyRelease(KeyEvent.VK_CONTROL);
            }
            robot.keyPress(KeyEvent.VK_CONTROL);
            robot.keyPress(KeyEvent.VK_V);
            robot.keyRelease(KeyEvent.VK_V);
            robot.keyRelease(KeyEvent.VK_CONTROL);
            sleep(2); //Used to ensure that paste function has time to fully enter in the pop-up dialogue.
            robot.keyPress(KeyEvent.VK_ENTER);
            robot.keyRelease(KeyEvent.VK_ENTER);
            sleep(1); //Used to ensure that the pop-up dialogue closes fully or asks for override confirmation before continuing.
            robot.keyPress(KeyEvent.VK_ALT);
            robot.keyPress(KeyEvent.VK_Y);
            robot.keyRelease(KeyEvent.VK_Y);
            robot.keyRelease(KeyEvent.VK_ALT);
            sleep(5); //Used to ensure that the download finishes before continuing, otherwise an incomplete download will happen.
            waitForPostBack();
        }

        public void DragAndDrop(WebElement elementToDrag, int xOffset, int yOffset)
        {
            Actions builder = new Actions(driver);
            Action dragAndDrop = builder.clickAndHold(elementToDrag)
                    .moveByOffset(xOffset, yOffset)
                    .release(elementToDrag)
                    .build();
            dragAndDrop.perform();
            waitForPostBack();
        }

        public void HoverOverAndClick(WebElement element)
        {
            //    	waitUntilElementIsClickable(element);
            element = Find(By.XPath(getXpathFromElement(element)));
            Actions mouse = new Actions(this.driver);
            mouse.moveToElement(element);
            mouse.click();
            mouse.perform();
            waitForPostBack();
        }

        public void HoverOver(WebElement element)
        {
            element = waitUntilElementIsVisible(element);
            Actions mouse = new Actions(this.driver);
            mouse.moveToElement(element);
            mouse.perform();
            waitForPostBack();
        }

        /**
         * Hovers over the first element to click the second. Use this if the second element doesn't exist until the first one is hovered over.
         * 
         * @param first The first element to hover over.
         * @param secondXPath The xPath of the second.
         * @return Whether this method succeeded in clicking the second element.
         */
        public bool HoverOverFirstToClickSecond(WebElement first, String secondXPath)
        {
            if (hoverOverFirstToShowSecond(first, secondXPath))
            {
                WebElement second = find(By.xpath(secondXPath));
                clickWhenClickable(second);
                return true;
            }
            return false;
        }

        /**
         * Hovers over the first element until the second shows up. Use this if the second element doesn't exist until the first one is hovered over.
         * 
         * @param first The first element to hover over.
         * @param secondXPath The xPath of the second.
         * @return Whether this method succeeded in under 25 tries.
         */
        public boolean HoverOverFirstToShowSecond(WebElement first, String secondXPath)
        {
            WebElement second;
            int index = 0;
            boolean passed = false;
            do
            {
                index++;
                hoverOver(first);
                try
                {
                    second = find(By.xpath(secondXPath));
                    hoverOver(second);
                    passed = true;
                }
                catch (Exception e)
                {
                }
            } while (!passed && index < 25);
            return passed;
        }

        /**
         * @author bhiltbrand
         * @Description - This is meant to refocus the window and fire off postbacks.
         * @DATE - Sep 14, 2021
         */
        public void ClickProductLogo()
        {
            clickWhenClickable(By.xpath("//img[contains(@class,'product-logo')]"));
            waitForPostBack();
        }

        public bool CheckIfElementExists(IWebElement element, int checktimeInMilliseconds)
        {
            try
            {
                WaitUntilElementIsVisible(element, checktimeInMilliseconds);
                return true;
            }
            catch (Exception var4)
            {
                return false;
            }
        }

        public bool CheckIfElementExists(String xpath, int checktimeInMilliseconds)
        {
            int normalizedTime = timeFixer(checktimeInMilliseconds);
            boolean found = finds(By.xpath(xpath)).size() > 0;

            for (int i = 0; !found && i < normalizedTime; ++i)
            {
                this.sleep(1);
                found = finds(By.xpath(xpath)).size() > 0;
            }
            return found;
        }

        public String GetXpathFromElement(WebElement element)
        {
            String[] xpathSplit = element.toString().split("-> xpath: ");
            String xPath = "";
            if (xpathSplit.length == 1)
            {
                xpathSplit = element.toString().split("By.xpath: ");
                if (xpathSplit.length == 1)
                {
                    systemOut("The Element passed in is a proxy WebElement. As such, the original xPath cannot be extracted.");
                }
            }

            for (int i = 1; i < xpathSplit.length; ++i)
            {
                String sanitizedXPath = xpathSplit[i];
                if (sanitizedXPath.startsWith("."))
                {
                    sanitizedXPath = sanitizedXPath.substring(1, sanitizedXPath.length());
                }

                if (i == xpathSplit.length - 1)
                {
                    xPath = xPath + sanitizedXPath.substring(0, sanitizedXPath.length() - 1);
                }
                else
                {
                    xPath = xPath + sanitizedXPath.substring(0, sanitizedXPath.length() - 3);
                }
            }

            return xPath;
        }

        public void DoubleClickMouse(int x, int y) throws Exception
        {
            int windowX = this.driver.manage().window().getPosition().getX();
            int offsetBecauseIWant = 10;

            Robot r = new Robot();
            r.mouseMove(windowX + offsetBecauseIWant + x, y);
            r.mousePress(InputEvent.BUTTON1_DOWN_MASK);
            r.mouseRelease(InputEvent.BUTTON1_DOWN_MASK);
            Thread.sleep(50);//Used to ensure 2 individual button clicks.
            r.mousePress(InputEvent.BUTTON1_DOWN_MASK);
            r.mouseRelease(InputEvent.BUTTON1_DOWN_MASK);
            waitForPostBack();
        }

        public void ScrollToElement(WebElement element)
        {
            ((JavascriptExecutor)driver).executeScript("arguments[0].scrollIntoView(true);", element);
        }

        public void ClickAndHoldAndRelease(WebElement elementToClick)
        {
            Actions action = new Actions(this.driver);
            action.clickAndHold(elementToClick).release().build().perform();
            waitForPostBack();
        }

        public void ClickOK()
        {
            clickWhenClickable(By.xpath("//span[contains(text(), 'OK')]/parent::span"));
            waitForPostBack();
        }

        public void ClickNext()
        {
            clickWhenClickable(By.xpath("//span[contains(@id, ':Next-btnEl') or contains(@id, ':Next-btnInnerEl') or contains(@id, ':nextButton') or contains(@id, 'NewPolicyChange-btnInnerEl')]"));
            waitForPostBack();
        }

        public void ClickBack()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, ':Prev') or contains(@id, 'SubmissionWizard:Prev')]"));
        }

        public void ClickDone()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, ':Done')]"));
        }

        public void ClickComplete()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, 'Complete')]"));
            if (checkIfElementExists("//div[contains(@id, 'messagebox-1001-displayfield-inputEl')]", 3))
            {
                selectOKOrCancelFromPopup(OkCancel.OK);
            }
        }

        public void ClickCompleteWithoutPopup()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, 'Complete')]"));
        }

        public void ClickDiscardUnsavedChangesLink()
        {
            if (checkIfElementExists("//div[contains(@id, ':_msgs')]/div/a[contains(., 'Discard Unsaved Change')]", 1000))
            {
                clickWhenClickable(By.xpath("//div[contains(@id, ':_msgs')]/div/a[contains(., 'Discard Unsaved Change')]"));
            }
        }

        public void ClickClose()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, ':Close') or (contains(@id, 'NewDocumentFromTemplateScreen:ToolbarButton'))]"));
        }

        public void ClickAdd()
        {
            clickWhenClickable(By.xpath("//span[contains(@id, ':Add-btnEl') or (contains(@id, ':AddEmptyPayments-btnInnerEl'))]"));
        }

        public void ClickRemove()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, ':Remove')]"));
        }

        public void ClickUpdate()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, 'Update')] | //span[contains(@id, ':FinishPCR-btnEl')]"));
        }

        public void ClickFinish()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, ':Finish')]"));
        }
        public void ClickCancel()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, 'LocationDetailPanelSet:fred:ToolbarButton') or contains (@id, 'LocationDetailPanelSet:fred:LocationToolbarButtonSet:ToolbarButton') or contains(@id, ':Cancel') or contains(@id, 'BOPSingleBuildingDetailScreen:ToolbarButton') or contains(@id, 'CancelButton')] | //span[contains(@id, ':Cancel-btnInnerEl')] | //span[contains(@id, 'HOBuilding_FBMPopup:ToolbarButton')]"));
        }

        public void ClickEdit()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, ':EditLink') or contains(@id, ':Edit') or contains(@id, ':editbutton') or contains(@id, 'viewEdit_LinkAsBtn')]"));
            waitForPostBack();
        }

        public void ClickReset()
        {
            clickWhenClickable(By.xpath("//a[contains(@id, ':Reset')]"));
        }

        public void ClickSearch()
        {
            clickWhenClickable(By.xpath("//a[(contains(@id, ':SearchLinksInputSet:Search')) or contains (@id, ':SearchLinksDocumentsInputSet:Search') or (contains(@id, ':SearchLinksNotesInputSet:Search')) or (contains(@id, 'AdditionalInterestLV_tb:ToolbarButton')) or (contains(@id, 'AddlInterestContactSearchPopup:LienholderSearchPanelSet:Search')) or (contains(@id, ':ABContactSearchScreen:ContactSearchDV:Search')) or (contains(@id, 'SimpleABContactSearch:SimpleSearchScreen:Search')) or (contains(@id, 'RecentlyViewedSearch:Search')) or (contains(@id, 'MenuItem_Search')) or (contains(@id, ':PhoneSearchDV:Search'))] |  //a[(contains(@id, ':InterestAddRemoveToolbarButtonSet:ToolbarButton'))]//span[(contains(text(), 'Search'))] | //*[contains(@id,':AddressSearchScreen:AddressSearchDV:Search')] | //a[contains(@id, 'SearchDV:Search')] | //a[contains(@id, ':LienholderSearchPanelSet:Search')]"));
        }

        public void ClickOverride()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':Update')]"));
        }
}
