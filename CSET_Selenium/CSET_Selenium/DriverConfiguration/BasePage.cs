using CSET_Selenium.Enums;
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
        private IWebDriver driver;

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
                if (IsElementDisabled(ele))
                {
                    return false;
                }
                else
                {
                    ClickWhenClickable(ele);
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
            //ClickProductLogo();
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
         * @param element IWebElement to check
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

        /*public void SendArbitraryKeys(Keys keysToSend)
        {
            List<Keys> modifierKeys = new List<Keys> { Keys.Alt, Keys.Control, Keys.Shift, Keys.LeftAlt, Keys.LeftControl, Keys.LeftShift, Keys.Meta };
            if (modifierKeys.Contains(keysToSend))
            {
                new Actions(driver).KeyDown(keysToSend).KeyUp(keysToSend);
            }
            else
            {
                new Actions(driver).SendKeys(keysToSend).Perform();
            }
            WaitForPostBack();
        }*/

        public void SendArbitraryKeys(String keysToSend)
        {
            new Actions(driver).SendKeys(keysToSend).Perform();
            WaitForPostBack();
        }

        public void ClickElementByCordinates(IWebElement ele, int x, int y)
        {
            WaitUntilElementIsClickable(ele);
            Actions builder = new Actions(driver);
            builder.MoveToElement(ele, x, y).Click().Perform();
            WaitForPostBack();
        }

        /*public void UploadOrSaveFile(String filePath) throws AWTException
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
            WaitForPostBack();
        }*/

        public void DragAndDrop(IWebElement elementToDrag, int xOffset, int yOffset)
        {
            Actions builder = new Actions(this.driver);
            IAction dragAndDrop = builder.ClickAndHold(elementToDrag)
                    .MoveByOffset(xOffset, yOffset)
                    .Release(elementToDrag)
                    .Build();
            dragAndDrop.Perform();
            WaitForPostBack();
        }

        public void HoverOverAndClick(IWebElement element)
        {
            //    	WaitUntilElementIsClickable(element);
            element = Find(By.XPath(GetXpathFromElement(element)));
            Actions mouse = new Actions(this.driver);
            mouse.MoveToElement(element);
            mouse.Click();
            mouse.Perform();
            WaitForPostBack();
        }

        public void HoverOver(IWebElement element)
        {
            element = WaitUntilElementIsVisible(element);
            Actions mouse = new Actions(this.driver);
            mouse.MoveToElement(element);
            mouse.Perform();
            WaitForPostBack();
        }

        /**
         * Hovers over the first element to click the second. Use this if the second element doesn't exist until the first one is hovered over.
         * 
         * @param first The first element to hover over.
         * @param secondXPath The xPath of the second.
         * @return Whether this method succeeded in clicking the second element.
         */
        public bool HoverOverFirstToClickSecond(IWebElement first, String secondXPath)
        {
            if (HoverOverFirstToShowSecond(first, secondXPath))
            {
                IWebElement second = Find(By.XPath(secondXPath));
                ClickWhenClickable(second);
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
        public bool HoverOverFirstToShowSecond(IWebElement first, String secondXPath)
        {
            IWebElement second;
            int index = 0;
            bool passed = false;
            do
            {
                index++;
                HoverOver(first);
                try
                {
                    second = Find(By.XPath(secondXPath));
                    HoverOver(second);
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
            ClickWhenClickable(By.XPath("//img[contains(@class,'product-logo')]"));
            WaitForPostBack();
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
            int normalizedTime = TimeFixer(checktimeInMilliseconds);
            bool found = Finds(By.XPath(xpath)).Count > 0;

            for (int i = 0; !found && i < normalizedTime; ++i)
            {
                this.Sleep(1000);
                found = Finds(By.XPath(xpath)).Count > 0;
            }
            return found;
        }

        public String GetXpathFromElement(IWebElement element)
        {
            String[] xpathSplit = StringsUtils.SplitStringByString(element.ToString(), "-> xpath: ");
            String xPath = "";
            if (xpathSplit.Length == 1)
            {
                xpathSplit = StringsUtils.SplitStringByString(element.ToString(), "-> xpath: ");
                if (xpathSplit.Length == 1)
                {
                    Console.WriteLine("The Element passed in is a proxy IWebElement. As such, the original xPath cannot be extracted.");
                }
            }

            for (int i = 1; i < xpathSplit.Length; ++i)
            {
                String sanitizedXPath = xpathSplit[i];
                if (sanitizedXPath.StartsWith("."))
                {
                    sanitizedXPath = sanitizedXPath.Substring(1, sanitizedXPath.Length);
                }

                if (i == xpathSplit.Length - 1)
                {
                    xPath = xPath + sanitizedXPath.Substring(0, sanitizedXPath.Length - 1);
                }
                else
                {
                    xPath = xPath + sanitizedXPath.Substring(0, sanitizedXPath.Length - 3);
                }
            }

            return xPath;
        }

        /*public void DoubleClickMouse(int x, int y) throws Exception
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
            WaitForPostBack();
        }*/

        public void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void ClickAndHoldAndRelease(IWebElement elementToClick)
        {
            Actions action = new Actions(this.driver);
            action.ClickAndHold(elementToClick).Release().Build().Perform();
            WaitForPostBack();
        }

        public void ClickOK()
        {
            ClickWhenClickable(By.XPath("//span[contains(text(), 'OK')]/parent::span"));
            WaitForPostBack();
        }

        public void ClickNext()
        {
            ClickWhenClickable(By.XPath("//button[contains(text(), 'Next')]"));
            WaitForPostBack();
        }

        public void ClickBack()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':Prev') or contains(@id, 'SubmissionWizard:Prev')]"));
        }

        public void ClickDone()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':Done')]"));
        }

        public void ClickComplete()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, 'Complete')]"));
            if (CheckIfElementExists("//div[contains(@id, 'messagebox-1001-displayfield-inputEl')]", 3))
            {
                SelectOKOrCancelFromPopup(OkCancel.OK);
            }
        }

        public void ClickCompleteWithoutPopup()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, 'Complete')]"));
        }

        public void ClickDiscardUnsavedChangesLink()
        {
            if (CheckIfElementExists("//div[contains(@id, ':_msgs')]/div/a[contains(., 'Discard Unsaved Change')]", 1000))
            {
                ClickWhenClickable(By.XPath("//div[contains(@id, ':_msgs')]/div/a[contains(., 'Discard Unsaved Change')]"));
            }
        }

        public void ClickClose()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':Close') or (contains(@id, 'NewDocumentFromTemplateScreen:ToolbarButton'))]"));
        }

        public void ClickAdd()
        {
            ClickWhenClickable(By.XPath("//span[contains(@id, ':Add-btnEl') or (contains(@id, ':AddEmptyPayments-btnInnerEl'))]"));
        }

        public void ClickRemove()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':Remove')]"));
        }

        public void ClickUpdate()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, 'Update')] | //span[contains(@id, ':FinishPCR-btnEl')]"));
        }

        public void ClickFinish()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':Finish')]"));
        }
        public void ClickCancel()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, 'LocationDetailPanelSet:fred:ToolbarButton') or contains (@id, 'LocationDetailPanelSet:fred:LocationToolbarButtonSet:ToolbarButton') or contains(@id, ':Cancel') or contains(@id, 'BOPSingleBuildingDetailScreen:ToolbarButton') or contains(@id, 'CancelButton')] | //span[contains(@id, ':Cancel-btnInnerEl')] | //span[contains(@id, 'HOBuilding_FBMPopup:ToolbarButton')]"));
        }

        public void ClickEdit()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':EditLink') or contains(@id, ':Edit') or contains(@id, ':editbutton') or contains(@id, 'viewEdit_LinkAsBtn')]"));
            WaitForPostBack();
        }

        public void ClickReset()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':Reset')]"));
        }

        public void ClickSearch()
        {
            ClickWhenClickable(By.XPath("//a[(contains(@id, ':SearchLinksInputSet:Search')) or contains (@id, ':SearchLinksDocumentsInputSet:Search') or (contains(@id, ':SearchLinksNotesInputSet:Search')) or (contains(@id, 'AdditionalInterestLV_tb:ToolbarButton')) or (contains(@id, 'AddlInterestContactSearchPopup:LienholderSearchPanelSet:Search')) or (contains(@id, ':ABContactSearchScreen:ContactSearchDV:Search')) or (contains(@id, 'SimpleABContactSearch:SimpleSearchScreen:Search')) or (contains(@id, 'RecentlyViewedSearch:Search')) or (contains(@id, 'MenuItem_Search')) or (contains(@id, ':PhoneSearchDV:Search'))] |  //a[(contains(@id, ':InterestAddRemoveToolbarButtonSet:ToolbarButton'))]//span[(contains(text(), 'Search'))] | //*[contains(@id,':AddressSearchScreen:AddressSearchDV:Search')] | //a[contains(@id, 'SearchDV:Search')] | //a[contains(@id, ':LienholderSearchPanelSet:Search')]"));
        }

        public void ClickOverride()
        {
            ClickWhenClickable(By.XPath("//a[contains(@id, ':Update')]"));
        }

        public void SetTextAlternateClear(IWebElement textBox, String text)
        {
            WaitUntilElementIsClickable(textBox);
            textBox.SendKeys(Keys.Control + "a");
            textBox.SendKeys(text);
            textBox.SendKeys(Keys.Tab);
        }

        //Not Yet Implemented
        /** This method will perform a screen capture of the entire screen that has focus in that moment.
         * @param screenCapName - String screen capture file name to save.
         * @return - String file path to the screen capture file.
         */
        /*public String CaptureScreen(String screenCapName)
        {
            String filePath = "C:\\tmp\\screencaps\\";
            File tempScreenCapsFolder = new File(filePath);
            if (!tempScreenCapsFolder.exists())
            {
                tempScreenCapsFolder.mkdir();
            }

            String saveFilePath = filePath + screenCapName + ".png";
            Rectangle screenRect = new Rectangle(Toolkit.getDefaultToolkit().getScreenSize());
            BufferedImage capture = null;
            try
            {
                capture = new Robot().createScreenCapture(screenRect);
            }
            catch (AWTException e)
            {
                e.printStackTrace();

                return null;
            }

            try
            {
                ImageIO.write(capture, "png", new File(saveFilePath));
            }
            catch (IOException e)
            {
                e.printStackTrace();
            }

            return saveFilePath;
        }*/
    }
}
