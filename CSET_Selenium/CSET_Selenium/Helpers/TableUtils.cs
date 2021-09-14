using CSET_Selenium.DriverConfiguration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Helpers
{
    class TableUtils : BasePage
    {
        private readonly IWebDriver driver;

        public TableUtils(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        /**
         * This method returns the count of rows in the table passed in. This will return a 1-based int (As the user sees it).
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @return <b>rowCount</b>
         * This is the number of rows that exist in the <b>BODY</b> of the table (exclusive of headers or footers). 1-based index.
         * <br>Note: The .size method is a 1-based index.</br>
         */
        public int getRowCount(WebElement tableDivElement)
        {
            waitUntilElementIsVisible(tableDivElement);
            int rowCount = 0;
            if (getXpathFromElement(tableDivElement).contains("/div/table"))
            {
                try
                {
                    rowCount = tableDivElement.findElements(By.xpath(".//tbody/tr")).size();
                }
                catch (StaleElementReferenceException staleElementException)
                {
                    rowCount = tableDivElement.findElements(By.xpath(".//tbody/tr")).size();
                }
            }
            else
            {
                try
                {
                    rowCount = tableDivElement.findElements(By.xpath(".//div[contains(@id,'-body')]//tbody/tr")).size();
                }
                catch (StaleElementReferenceException staleElementException)
                {
                    rowCount = tableDivElement.findElements(By.xpath(".//div[contains(@id,'-body')]//tbody/tr")).size();
                }
            }
            return rowCount;
        }

        /**
         * This method will randomly choose a row out the the table passed in and return the rowNumber for that row.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @return <b>randomRow</b>
         * This is the integer value of the random row selected.
         */
        public int getRandomRowFromTable(WebElement tableDivElement)
        {
            int randomRow = NumberUtils.generateRandomNumberInt(1, getRowCount(tableDivElement));
            return randomRow;
        }

        //Table Paging Methods

        public int getCurrentTablePageNumber(WebElement tableDivElement)
        {
            String pageNumber = tableDivElement.findElement(By.xpath(".//div[contains(@id, 'gpaging')]/descendant::input[contains(@id, ':_ListPaging-inputEl')]")).getAttribute("value");
            return Integer.valueOf(pageNumber);
        }

        public void setTablePageNumber(WebElement tableDivElement, int pageNum)
        {
            WebElement pagingBox = tableDivElement.findElement(By.xpath(".//div[contains(@id, 'gpaging')]/descendant::input[contains(@id, ':_ListPaging-inputEl')]"));
            clickWhenClickable(pagingBox);
            pagingBox.sendKeys(Keys.CONTROL + "a");
            pagingBox.sendKeys(String.valueOf(pageNum));
            pagingBox.sendKeys(Keys.ENTER);
            waitForPostBack();
        }

        public boolean incrementTablePageNumber(WebElement tableDivElement)
        {
            int maxPage = getNumberOfTablePages(tableDivElement);
            int currentPage = 1;
            if (maxPage > 1)
            {
                currentPage = getCurrentTablePageNumber(tableDivElement);
            }
            if (currentPage < maxPage)
            {
                clickNextPageButton(tableDivElement);
                return true;
            }
            return false;
        }

        public boolean hasMultiplePages(WebElement tableDivElement)
        {
            //jlarsen 1/25/2017 we found that suddenly the editBox_CommonPageBox always exists not on the page. so I had to change it to look to see if the Table is displayed.
            //if if doesn't find the table with display: none, then it checks to see if that table exists at all without display: none to try to prevent false positives
            List<WebElement> multiplePages = tableDivElement.findElements(By.xpath(".//table[contains(@id, ':_ListPaging') and contains(@style, 'display: none')]"));

            if (multiplePages.isEmpty())
            {
                return !tableDivElement.findElements(By.xpath(".//table[contains(@id, ':_ListPaging') and not(contains(@style, 'display: none'))]")).isEmpty();
            }
            else
            {
                return false;
            }
        }

        public int getNumberOfTablePages(WebElement tableDivElement)
        {
            if (!hasMultiplePages(tableDivElement))
            {
                return 1;
            }
            else
            {
                List<WebElement> ofNumDiv = tableDivElement.findElements(By.xpath(".//descendant::div[contains(@id, 'tbtext') and contains(text(), 'of ')]"));
                String allText = ofNumDiv.get(0).getText();

                int toReturn = Integer.valueOf(allText.replace("of ", ""));
                return toReturn;
            }
        }

        public int clickFirstPageButton(WebElement tableDivElement)
        {
            if (hasMultiplePages(tableDivElement))
            {
                clickWhenClickable(tableDivElement.findElement(By.xpath(".//div[contains(@id, 'gpaging')]/descendant::a[@data-qtip='First Page']")));
            }
            else
            {
                Assert.fail("The table that you tried to interact with did not have a paging section available. Page navigation buttons will not work.");
            }
            return getCurrentTablePageNumber(tableDivElement);
        }

        public int clickPreviousPageButton(WebElement tableDivElement)
        {
            if (hasMultiplePages(tableDivElement))
            {
                clickWhenClickable(tableDivElement.findElement(By.xpath(".//div[contains(@id, 'gpaging')]/descendant::a[@data-qtip='Previous Page']")));
            }
            else
            {
                Assert.fail("The table that you tried to interact with did not have a paging section available. Page navigation buttons will not work.");
            }
            return getCurrentTablePageNumber(tableDivElement);
        }

        public int clickNextPageButton(WebElement tableDivElement)
        {
            if (hasMultiplePages(tableDivElement))
            {
                clickWhenClickable(tableDivElement.findElement(By.xpath(".//div[contains(@id, 'gpaging')]/descendant::a[@data-qtip='Next Page']")));
            }
            else
            {
                Assert.fail("The table that you tried to interact with did not have a paging section available. Page navigation buttons will not work.");
            }
            return getCurrentTablePageNumber(tableDivElement);
        }

        public int clickLastPageButton(WebElement tableDivElement)
        {
            if (hasMultiplePages(tableDivElement))
            {
                clickWhenClickable(tableDivElement.findElement(By.xpath(".//div[contains(@id, 'gpaging')]/descendant::a[@data-qtip='Last Page']")));
            }
            else
            {
                Assert.fail("The table that you tried to interact with did not have a paging section available. Page navigation buttons will not work.");
            }
            return getCurrentTablePageNumber(tableDivElement);
        }
        //End Table Paging Methods

        public List<WebElement> getAllTableRows(WebElement tableDivElement)
        {
            List<WebElement> rowsInTable = null;

            if (getXpathFromElement(tableDivElement).contains("/div/table"))
            {
                try
                {
                    rowsInTable = tableDivElement.findElements(By.xpath(".//tbody/tr"));
                }
                catch (StaleElementReferenceException staleElementException)
                {
                    rowsInTable = tableDivElement.findElements(By.xpath(".//tbody/tr"));
                }
            }
            else
            {
                try
                {
                    rowsInTable = tableDivElement.findElements(By.xpath(".//div[contains(@id,'-body')]//tbody/tr"));
                }
                catch (StaleElementReferenceException staleElementException)
                {
                    rowsInTable = tableDivElement.findElements(By.xpath(".//div[contains(@id,'-body')]//tbody/tr"));
                }
            }
            return rowsInTable;
        }

        public ArrayList<String> getAllCellTextFromSpecificColumn(WebElement tableDivElement, String columnName)
        {
            List<WebElement> allRows = getAllTableRows(tableDivElement);
            String gridColId = getGridColumnFromTable(tableDivElement, columnName);

            ArrayList<String> toReturn = new ArrayList<String>();

            for (WebElement row : allRows)
            {
                toReturn.add(row.findElement(By.xpath(".//td[contains(@class, '" + gridColId + "')]/div")).getText());
            }

            return toReturn;
        }

        /**
         * This method is used for sorting tables. It simply clicks on the header in the table you specify. It only clicks once, so if you want to
         * sort the column a different way than default, simply call this method twice.
         *
         * @param tableDivElement  This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                         but can also include a div for buttons or dropdowns, and a footer div.
         *                         <img src="../../../javadoc_images/TableXpath.png" />
         * @param headerColumnName This is the text of the Header for the column you are trying to sort.
         */
        public void sortByHeaderColumn(WebElement tableDivElement, String headerColumnName)
        {
            String tableHeaderGridColumnID = getGridColumnFromTable(tableDivElement, headerColumnName);
            WebElement tableHeader = tableDivElement.findElement(By.xpath(".//div[contains(@id,'" + tableHeaderGridColumnID + "')]"));
            clickWhenClickable(tableHeader);
        }

        /**
         * This method is used for getting the corresponding GridColumnID from a table. You pass in the table and the text displayed
         * on the column header of the column you want the GridColumnID returned from.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param headerColumn    This is the text of the Header for the column you are trying to get.
         * @return <b>gridColumnID</b>
         * This is the gridColumnID of the the column you want to work with, represented as a String.
         */
        public String getGridColumnFromTable(WebElement tableDivElement, String headerColumn)
        {
            WebElement newElement = waitUntilElementIsClickable(tableDivElement);
            WebElement contextContainer = null;
            if (headerColumn != null)
            {
                String headerXPath = ".//child::div[contains(@id,'headercontainer')]/child::div/child::div/child::div/child::div/span[.='" + headerColumn + "']";
                WebElement headerGridColumn = newElement.findElement(By.xpath(headerXPath));
                waitUntilElementIsClickable(headerGridColumn);
                String contextContainerXpath = ".//parent::div/parent::div";
                contextContainer = headerGridColumn.findElement(By.xpath(contextContainerXpath));
            }
            else
            {
                String headerXPath = ".//child::div[contains(@id,'headercontainer')]//div[contains(@class,'header-inner-empty')]";
                WebElement headerGridColumn = newElement.findElement(By.xpath(headerXPath));
                waitUntilElementIsClickable(headerGridColumn);
                String contextContainerXpath = ".//parent::div";
                contextContainer = headerGridColumn.findElement(By.xpath(contextContainerXpath));
            }
            String gridColumnID = contextContainer.getAttribute("id");
            waitForPostBack();
            return gridColumnID;
        }

        /**
         * This method will return the row number of the highlighted row, or the row that has focus, on the table.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @return <b>rowNumber</b>
         * This is the row number of the row that is currently highlighted in the table, as the user sees it (1-based index).
         * <br>Note: data-recordindex is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public int getHighlightedRowNumber(WebElement tableDivElement)
        {
            return Integer.valueOf(tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@class, 'x-grid-row-focused')] | .//tbody/descendant::td[contains(@class, 'x-grid-cell-selected')]/parent::tr")).getAttribute("data-recordindex")) + 1;
        }

        /**
         * This method will return the row number of the table row passed in as a WebElement.
         *
         * @param webElementRow This is the WebElement from a search on a table, returning the row. The returned row is a WebElement, so we have to extract out the int rowNumber.
         * @return <b>rowNumber</b>
         * This is the row number of the row in the table that was passed in as a WebElement, as the user sees it (1-based index).
         * <br>Note: data-recordindex is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public int getRowNumberFromWebElementRow(WebElement webElementRow)
        {
            int rowNumber = Integer.valueOf(webElementRow.findElement(By.xpath(".//parent::td/parent::tr")).getAttribute("data-recordindex")) + 1;
            return rowNumber;
        }

        /**
         * This method will click and highlight the first row in a table.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         */
        public void clickFirstRowInTable(WebElement tableDivElement)
        {
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '0')]")));
        }

        /**
         * This method will get the first link (as a webelement) in the table row that is specified.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber       This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public WebElement getLinkInSpecficRowInTable(WebElement tableDivElement, int rowNumber)
        {
            WebElement linkWebElement = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]//a"));
            checkIfElementExists(linkWebElement, 500);
            return linkWebElement;
        }

        /**
         * This method will click the first link in the table row that is specified.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber       This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void clickLinkInSpecficRowInTable(WebElement tableDivElement, int rowNumber)
        {
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]//a")));
        }

        /**
         * This method will click the Actions drop down link in the table row that is specified.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber       This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void clickActionsLinkInSpecficRowInTable(WebElement tableDivElement, int rowNumber)
        {
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]//a[contains(@id,'" + (rowNumber - 1) + ":ActionButton')]")));
        }

        /**
         * This method will click the Actions drop down link in the table row that is specified. Once clicked, it will click
         * the action link corresponding to the actionText passed in.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber       This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         * @param actionText      This is the String Text of the action link you would like to click.
         */
        public void clickActionsLinkInSpecficRowInTable(WebElement tableDivElement, int rowNumber, String actionText)
        {
            clickActionsLinkInSpecficRowInTable(tableDivElement, rowNumber);
            clickWhenClickable(find(By.xpath(".//div[contains(@id, '" + (rowNumber - 1) + ":ActionButton-fieldMenu')]//span[contains(text(),'" + actionText + "')]/parent::a")));
        }

        /**
         * This method will click the first link in the table row that is specified.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber       This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void clickLinkInTableByRowAndColumnName(WebElement tableDivElement, int rowNumber, String headerColumn)
        {
            String tableGridColumnId = getGridColumnFromTable(tableDivElement, headerColumn);
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]/td[contains(@class, '" + tableGridColumnId + "')]//a")));
        }

        /**
         * This method will click the button in the table cell specified by the row and column.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber       This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         * @param headerColumn    This is the text of the Header for the column you are constraining the search to.
         * @param buttonText      This is the text of the button contained in the cell you would like to click.
         */
        public void clickButtonInTableByRowAndColumnName(WebElement tableDivElement, int rowNumber, String headerColumn, String buttonText)
        {
            String tableGridColumnId = getGridColumnFromTable(tableDivElement, headerColumn);
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]/td[contains(@class, '" + tableGridColumnId + "')]//a[contains(text(), '" + buttonText + "')]")));
        }

        public void clickCellInTableByRowAndColumnName(WebElement tableDivElement, int rowNumber, String headerColumn)
        {
            String tableGridColumnId = getGridColumnFromTable(tableDivElement, headerColumn);
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]/td[contains(@class, '" + tableGridColumnId + "')]//div")));
        }

        public String getCellTextInTableByRowAndColumnName(WebElement tableDivElement, int rowNumber, String headerColumn)
        {
            WebElement newElement = waitUntilElementIsClickable(tableDivElement);
            String tableGridColumnId = getGridColumnFromTable(newElement, headerColumn);
            return newElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]/td[contains(@class, '" + tableGridColumnId + "')]//div")).getText();
        }

        /**
         * This method is like the getCellTextInTableByRowAndColumnName method, but is used for tables with gridCells
         * It will allow you to drill down and get just the piece of information out of a gridCell that you want.
         *
         * @param tableDivElement          This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                                 but can also include a div for buttons or dropdowns, and a footer div.
         *                                 <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber                This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                                 <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         * @param headerColumn             This is the text of the Header for the column you are constraining the search to.
         * @param divIDValueAfterLastColon This is the final ID value after the last colon for the div you want to work with.
         *                                 <img src="../../../javadoc_images/GridCellValueInTable.png" />
         * @return The String value of the text in the GridCell.
         */
        public String getGridCellTextInTableByRowAndColumnName(WebElement tableDivElement, int rowNumber, String headerColumn, String divIDValueAfterLastColon)
        {
            WebElement newElement = waitUntilElementIsClickable(tableDivElement);
            String tableGridColumnId = getGridColumnFromTable(newElement, headerColumn);
            return newElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]/td[contains(@class, '" + tableGridColumnId + "')]//div/descendant::td[contains (@id, '" + divIDValueAfterLastColon + "')]")).getText();
        }

        public WebElement getCellWebElementInTableByRowAndColumnName(WebElement tableDivElement, int rowNumber, String headerColumn)
        {
            String tableGridColumnId = getGridColumnFromTable(tableDivElement, headerColumn);
            return tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]/td[contains(@class, '" + tableGridColumnId + "')]//div"));
        }

        public WebElement getCellWebElementInTableByRowAndColumnName(WebElement tableDivElement, WebElement rowWebElement, String headerColumn)
        {
            String tableGridColumnId = getGridColumnFromTable(tableDivElement, headerColumn);
            //If this method fails in the future, look at ensuring that the lookup for the webelement is constrained to the tableRow.
            return rowWebElement.findElement(By.xpath(".//td[contains(@class, '" + tableGridColumnId + "')]//div"));
        }

        public String getCellTextInTableByRowAndColumnName(WebElement tableDivElement, WebElement rowWebElement, String headerColumn)
        {
            String cellValue;
            String tableGridColumnId = getGridColumnFromTable(tableDivElement, headerColumn);
            try
            {
                cellValue = rowWebElement.findElement(By.xpath(".//td[contains(@class, '" + tableGridColumnId + "')]//div")).getText();
            }
            catch (Exception e)
            {
                //e.printStackTrace();
                System.out.println("Failed to find the cell value for the row specified. Attempting a fallback.");
                cellValue = rowWebElement.findElement(By.xpath(".//parent::tr/td[contains(@class, '" + tableGridColumnId + "')]//div")).getText();
            }
            return cellValue;
        }

        public WebElement getCheckboxWebElementByTextInTable(WebElement tableDivElement, String textInTable)
        {
            WebElement tableCheckBoxElement = null;
            try
            {
                if (checkIfElementExists(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../preceding-sibling::td/div[contains(@class, '-inner-checkcolumn')]", 1000))
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../preceding-sibling::td/div[contains(@class, '-inner-checkcolumn')]"));
                }
                else
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../following-sibling::td/div[contains(@class, '-inner-checkcolumn')]"));
                }
            }
            catch (Exception e)
            {
                tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::a[contains(text(), '" + textInTable + "')]/../../../preceding-sibling::td/div[contains(@class, '-inner-checkcolumn')]"));
            }
            return tableCheckBoxElement;
        }

        /**
         * This method will find the row in the table corresponding to the text passed in and then click that row.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param textInTable     This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         */
        public void clickRowInTableByText(WebElement tableDivElement, String textInTable)
        {
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/descendant::div[text()='" + textInTable + "']/ancestor::tr[1] | .//tbody/descendant::a[text()='" + textInTable + "']/ancestor::tr[1]")));
        }

        /**
         * This method will click the row in the table corresponding to the row number passed in.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber       This is the row number that you want to click on. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void clickRowInTableByRowNumber(WebElement tableDivElement, int rowNumber)
        {
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]")));
        }

        /**
         * This method will find the corresponding row to the text that is passed in.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param textInTable     This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         * @return <b>rowNumber</b>
         * This is the row number of the row corresponding to the text searched. This is a 1-based index (As the user sees it). Returns the first instance... returns 0 if not found
         * <br>Note: The .indexOf method is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public int getRowNumberInTableByText(WebElement tableDivElement, String textInTable)
        {
            WebElement tableRowToFind = null;
            try
            {
                tableRowToFind = tableDivElement.findElement(By.xpath(".//tbody/descendant::*[contains(text(), '" + textInTable + "')]/ancestor::tr[1]"));
                waitForPostBack();
            }
            catch (Exception e)
            {
                System.out.println("The table row searched was not found. Most likely, the xpath used did not match up exactly with your scenario. Please verify and tweak this xPath if necessary.");
            }

            int rowNumber = 0;
            if (tableRowToFind != null)
            {
                rowNumber = getRowNumberFromWebElementRow(tableRowToFind);
                waitForPostBack();
            }

            return rowNumber;
        }

        /**
         * This method will find the corresponding row to a single column name and row value that is passed in and return true if found and false if not.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnName      This is a single String value that contains the Title of the columns.
         * @param columnRowValue  This is a single String value that contains the value corresponding to the Title of the column to search.
         * @return <b>found</b>
         * This is the true / false value indicating whether or not the specified row was found in the table.
         */
        public boolean verifyRowExistsInTableByColumnsAndValues(WebElement tableDivElement, String columnName, String columnRowValue)
        {
            boolean found = false;
            String tableGridColumnID = getGridColumnFromTable(tableDivElement, columnName);
            List<WebElement> rowsResults = tableDivElement.findElements(By.xpath(".//tr/td[contains(@class,'" + tableGridColumnID + "') and contains(.,'" + columnRowValue + "')]/ancestor::tr[1]"));
            if (rowsResults.size() > 0)
            {
                found = true;
            }

            return found;
        }

        /**
         * This method will find the corresponding row to a HashMap of column names and row values that are passed in and return true if found and false if not.
         *
         * @param tableDivElement        This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                               but can also include a div for buttons or dropdowns, and a footer div.
         *                               <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnRowKeyValuePairs This is a HashMap of Strings that contain the Titles of the columns and the row values corresponding to those columns.
         * @return <b>found</b>
         * This is the true / false value indicating whether or not the specified row was found in the table.
         */
        public boolean verifyRowExistsInTableByColumnsAndValues(WebElement tableDivElement, HashMap<String, String> columnRowKeyValuePairs)
        {
            boolean found = false;
            StringBuilder xpathBuilder = new StringBuilder();
            WebElement newElement = waitUntilElementIsClickable(tableDivElement);

            for (Map.Entry<String, String> entry : columnRowKeyValuePairs.entrySet())
            {

                String tableGridColumnID = getGridColumnFromTable(newElement, entry.getKey());
                if (entry.getValue().startsWith("/div"))
                {
                    xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "')]" + entry.getValue());
                }
                else
                {
                    if (entry.getValue().contains("$"))
                    {
                        xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "') and (.='" + entry.getValue() + "')]");
                    }
                    else
                    {
                        xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "') and contains(.,'" + entry.getValue() + "')]");
                    }
                }
            }

            xpathBuilder.append("/ancestor::tr[1]");
            xpathBuilder.replace(0, 9, ".//");
            List<WebElement> rowsResults = tableDivElement.findElements(By.xpath(xpathBuilder.toString()));

            if (rowsResults.size() > 0)
            {
                found = true;
            }

            return found;
        }

        /**
         * This method will find the corresponding row to a single column name and row value that is passed in.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnName      This is a single String value that contains the Title of the columns.
         * @param columnRowValue  This is a single String value that contains the value corresponding to the Title of the column to search.
         * @return <b>rowNumber</b>
         * This is the row number of the row corresponding to the text searched. This is a 1-based index (As the user sees it). Returns the first instance... returns 0 if not found
         * <br>Note: The .indexOf method is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public WebElement getRowInTableByColumnNameAndValue(WebElement tableDivElement, String columnName, String columnRowValue)
        {
            String tableGridColumnID = getGridColumnFromTable(tableDivElement, columnName);
            List<WebElement> tableRows = tableDivElement.findElements(By.xpath(".//tr/td[contains(@class,'" + tableGridColumnID + "') and contains(.,'" + columnRowValue + "')]/ancestor::tr[1]"));
            if (tableRows.isEmpty())
            {
                return null;
                //        	Assert.fail("UNABLE TO FIND ROW IN TABLE FOR THE XPATH: .//tr/td[contains(@class,'" + tableGridColumnID + "') and contains(.,'" + columnRowValue + "')]/ancestor::tr[1]");
            }
            WebElement tableRow = tableDivElement.findElement(By.xpath(".//tr/td[contains(@class,'" + tableGridColumnID + "')  and contains(.,'" + columnRowValue + "')]/ancestor::tr[1]"));

            return tableRow;
        }



        /**
         * This method will find the corresponding row to a single column name and row value that is passed in.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnName      This is a single String value that contains the Title of the columns.
         * @param columnRowValue  This is a single String value that equals the value corresponding to the Title of the column to search.
         * @return <b>rowNumber</b>
         * This is the row number of the row corresponding to the text searched. This is a 1-based index (As the user sees it). Returns the first instance... returns 0 if not found
         * <br>Note: The .indexOf method is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public WebElement getRowInTableByColumnNameAndExactValue(WebElement tableDivElement, String columnName, String columnRowValue)
        {
            String tableGridColumnID = getGridColumnFromTable(tableDivElement, columnName);
            List<WebElement> tableRows = tableDivElement.findElements(By.xpath(".//tr/td[contains(@class,'" + tableGridColumnID + "') and contains(.,'" + columnRowValue + "')]/ancestor::tr[1]"));
            if (tableRows.isEmpty())
            {
                Assert.fail("UNABLE TO FIND ROW IN TABLE FOR THE XPATH: .//tr/td[contains(@class,'" + tableGridColumnID + "') and contains(.,'" + columnRowValue + "')]/ancestor::tr[1]");
            }
            WebElement tableRow = tableDivElement.findElement(By.xpath(".//tr/td[contains(@class,'" + tableGridColumnID + "')  and (. = '" + columnRowValue + "')]/ancestor::tr[1]"));

            return tableRow;
        }

        /**
         * This method will find the corresponding row to a single column name and row value that is passed in. It differs from the like-named method in that
         * it uses an equals comparator instead of a contains.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnName      This is a single String value that contains the Title of the columns.
         * @param columnRowValue  This is a single String value that contains the value corresponding to the Title of the column to search.
         * @return <b>rowNumber</b>
         * This is the row number of the row corresponding to the text searched. This is a 1-based index (As the user sees it). Returns the first instance... returns 0 if not found
         * <br>Note: The .indexOf method is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public WebElement getRowInTableByColumnNameAndValueEquals(WebElement tableDivElement, String columnName, String columnRowValue)
        {
            String tableGridColumnID = getGridColumnFromTable(tableDivElement, columnName);
            WebElement tableRow = tableDivElement.findElement(By.xpath(".//tr/td[contains(@class,'" + tableGridColumnID + "') and (. = '" + columnRowValue + "')]/ancestor::tr[1]"));

            return tableRow;
        }

        /**
         * This method will find the corresponding row to the text that is passed in.
         *
         * @param tableDivElement        This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                               but can also include a div for buttons or dropdowns, and a footer div.
         *                               <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnRowKeyValuePairs This is a HashMap of Strings that contain the Titles of the columns and the row values corresponding to those columns.
         * @return <b>rowNumber</b>
         * This is the row number of the row corresponding to the text searched. This is a 1-based index (As the user sees it). Returns the first instance... returns 0 if not found
         * <br>Note: The .indexOf method is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public WebElement getRowInTableByColumnsAndValues(WebElement tableDivElement, HashMap<String, String> columnRowKeyValuePairs)
        {
            StringBuilder xpathBuilder = new StringBuilder();
            WebElement newElement = waitUntilElementIsClickable(tableDivElement);

            for (Map.Entry<String, String> entry : columnRowKeyValuePairs.entrySet())
            {

                String tableGridColumnID = getGridColumnFromTable(newElement, entry.getKey());
                if (entry.getValue().startsWith("/div"))
                {
                    xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "')]" + entry.getValue());
                }
                else
                {
                    if (entry.getValue().contains("$"))
                    {
                        xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "') and (.='" + entry.getValue() + "')]");
                    }
                    else
                    {
                        xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "') and contains(.,'" + entry.getValue() + "')]");
                    }
                }
            }

            xpathBuilder.append("/ancestor::tr[1]");
            xpathBuilder.replace(0, 9, ".//");
            System.out.println(xpathBuilder.toString());
            WebElement tableRow = newElement.findElement(By.xpath(xpathBuilder.toString()));
            return tableRow;
        }

        /**
         * This method will find the corresponding row to the text that is passed in. It differs from the like-named method in that
         * it uses an equals comparator instead of a contains.
         *
         * @param tableDivElement        This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                               but can also include a div for buttons or dropdowns, and a footer div.
         *                               <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnRowKeyValuePairs This is a HashMap of Strings that contain the Titles of the columns and the row values corresponding to those columns.
         * @return <b>rowNumber</b>
         * This is the row number of the row corresponding to the text searched. This is a 1-based index (As the user sees it). Returns the first instance... returns 0 if not found
         * <br>Note: The .indexOf method is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public WebElement getRowInTableByColumnsAndValuesEquals(WebElement tableDivElement, HashMap<String, String> columnRowKeyValuePairs)
        {
            StringBuilder xpathBuilder = new StringBuilder();
            WebElement newElement = waitUntilElementIsClickable(tableDivElement);

            for (Map.Entry<String, String> entry : columnRowKeyValuePairs.entrySet())
            {

                String tableGridColumnID = getGridColumnFromTable(newElement, entry.getKey());
                if (entry.getValue().startsWith("/div"))
                {
                    xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "')]" + entry.getValue());
                }
                else
                {
                    xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "') and (.=,'" + entry.getValue() + "')]");
                }
            }

            xpathBuilder.append("/ancestor::tr[1]");
            xpathBuilder.replace(0, 9, ".//");
            System.out.println(xpathBuilder.toString());
            WebElement tableRow = newElement.findElement(By.xpath(xpathBuilder.toString()));
            return tableRow;
        }

        /**
         * This method will find the corresponding rows to the text that is passed in.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnName      This is a single String value that contains the Title of the columns.
         * @param columnRowValue  This is a single String value that contains the value corresponding to the Title of the column to search.
         * @return <b>tableRows</b>
         * This is a list of table row WebElements corresponding to the text searched. This is a 1-based index (As the user sees it). Returns the first instance... returns 0 if not found
         * <br>Note: The .indexOf method is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public List<WebElement> getRowsInTableByColumnNameAndValue(WebElement tableDivElement, String columnName, String columnRowValue)
        {
            String tableGridColumnID = getGridColumnFromTable(tableDivElement, columnName);
            List<WebElement> tableRows = tableDivElement.findElements(By.xpath(".//tr/td[contains(@class,'" + tableGridColumnID + "') and (. = '" + columnRowValue + "')]/ancestor::tr[1]"));

            return tableRows;
        }

        /**
         * This method will find the corresponding rows to the text that is passed in.
         *
         * @param tableDivElement        This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                               but can also include a div for buttons or dropdowns, and a footer div.
         *                               <img src="../../../javadoc_images/TableXpath.png" />
         * @param columnRowKeyValuePairs This is a HashMap of Strings that contain the Titles of the columns and the row values corresponding to those columns.
         * @return <b>tableRows</b>
         * This is a list of table row WebElements corresponding to the text searched. This is a 1-based index (As the user sees it). Returns the first instance... returns 0 if not found
         * <br>Note: The .indexOf method is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public List<WebElement> getRowsInTableByColumnsAndValues(WebElement tableDivElement, HashMap<String, String> columnRowKeyValuePairs)
        {
            StringBuilder xpathBuilder = new StringBuilder();
            WebElement newElement = waitUntilElementIsClickable(tableDivElement);

            for (Map.Entry<String, String> entry : columnRowKeyValuePairs.entrySet())
            {

                String tableGridColumnID = getGridColumnFromTable(newElement, entry.getKey());
                if (entry.getValue().startsWith("/div"))
                {
                    xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "')]" + entry.getValue());
                }
                else
                {
                    if (entry.getValue().contains("$"))
                    {
                        xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "') and (.='" + entry.getValue() + "')]");
                        //This else if will allow you to use the keyword 'not ' (notice the space at the end) to tell the method to do a not contains
                    }
                    else if (entry.getValue().startsWith("not "))
                    {
                        String[] stringSplit = entry.getValue().split(" ", 2);
                        xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "') and not (contains(.,'" + stringSplit[1] + "'))]");
                    }
                    else
                    {
                        xpathBuilder.append("/parent::tr/td[contains(@class,'" + tableGridColumnID + "') and contains(.,'" + entry.getValue() + "')]");
                    }
                }
            }

            xpathBuilder.append("/ancestor::tr[1]");
            xpathBuilder.replace(0, 9, ".//");
            List<WebElement> tableRows = tableDivElement.findElements(By.xpath(xpathBuilder.toString()));
            return tableRows;
        }

        /**
         * This method will iterate through a table and return the first instance of a row found to <b>NOT</b> contain anything in the
         * first required column of the table passed in.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @return <b>newestRow</b>
         * This is the first instance of an empty row in the table. This is a 1-based index (As the user sees it).
         * <br>Note: data-recordindex is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public int getNextAvailableLineInTable(WebElement tableDivElement)
        {
            waitForPostBack();
            int rowCount = getRowCount(tableDivElement);
            int newestRow = 0;
            for (int i = 0; i <= rowCount; i++)
            {
                String firstRequiredColumnGridColumnID = tableDivElement.findElement(By.xpath(".//div[contains(@class, 'requiredcolumnindicator')]")).getAttribute("id");
                WebElement editBox_TableEditBox = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex,'" + i + "')]/td[contains(@class,'" + firstRequiredColumnGridColumnID + "')]/div"));
                if ((editBox_TableEditBox.getText().equalsIgnoreCase(" ")) || (editBox_TableEditBox.getText().equalsIgnoreCase("<none>")))
                {
                    newestRow = i + 1;
                    break;
                }
            }
            return newestRow;
        }

        /**
         * This method will iterate through a table and return the first instance of a row found to <b>NOT</b> contain anything in the
         * column specified of the table passed in.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param headerColumn    This is the text of the Header for the column you are trying to get.
         * @return <b>newestRow</b>
         * This is the first instance of an empty row in the table. This is a 1-based index (As the user sees it).
         * <br>Note: data-recordindex is a 0-based index. We add 1 to it to make it 1-based.</br>
         */
        public int getNextAvailableLineInTable(WebElement tableDivElement, String headerColumn)
        {
            waitForPostBack();
            int rowCount = getRowCount(tableDivElement);
            int newestRow = 0;
            for (int i = 0; i <= rowCount - 1; i++)
            {
                String requiredGridColumnID = getGridColumnFromTable(tableDivElement, headerColumn);
                WebElement editBox_TableEditBox = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex,'" + i + "')]/td[contains(@class,'" + requiredGridColumnID + "')]/div"));
                if (editBox_TableEditBox.getText().equalsIgnoreCase(" ") || (editBox_TableEditBox.getText().equalsIgnoreCase("<none>")) || (editBox_TableEditBox.getText().equalsIgnoreCase("<none selected>")))
                {
                    newestRow = i + 1;
                    break;
                }
            }
            return newestRow;
        }

        /**
         * This method will select the cell corresponding to the information provided. It will then click that cell
         * and navigate to the resulting Guidewire8Select. Once there, it will fill out the dropdown with the specified value.
         *
         * @param tableDivElement  This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                         but can also include a div for buttons or dropdowns, and a footer div.
         *                         <img src="../../../javadoc_images/TableXpath.png" />
         * @param tableRowNumber   This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         * @param headerColumnText This is the text of the Header for the column you are trying to get.
         * @param valueToSelect    This is the value you would like to enter in the dropdown.
         *                         <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public boolean selectValueForSelectInTable(WebElement tableDivElement, int tableRowNumber, String headerColumnText, String valueToSelect)
        {
            String gridColumnID = getGridColumnFromTable(tableDivElement, headerColumnText);
            WebElement tableCell = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex,'" + (tableRowNumber - 1) + "')]/td[contains(@class,'" + gridColumnID + "')]/div"));
            clickProductLogo();
            clickWhenClickable(tableCell);//We need to click the cell to make the Select Element available.
            Guidewire8Select mySelect = new Guidewire8Select(driver, "(//table[contains(@id,'simplecombo') and contains(@id,'triggerWrap')])[last()]");
            boolean found = mySelect.selectByVisibleTextPartialWithNoFail(valueToSelect);
            clickProductLogo();
            return found;
        }

        /**
         * This method will select the cell corresponding to the information provided. It will then click that cell
         * and navigate to the resulting Guidewire8Select. Once there, it will fill out the dropdown with the specified value.
         *
         * @param tableDivElement  This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                         but can also include a div for buttons or dropdowns, and a footer div.
         *                         <img src="../../../javadoc_images/TableXpath.png" />
         * @param tableRowNumber   This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         * @param headerColumnText This is the text of the Header for the column you are trying to get.
         * @param valueToSelect    This is the value you would like to enter in the dropdown.
         *                         <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public boolean selectValueForSelectInTableDoubleClick(WebElement tableDivElement, int tableRowNumber, String headerColumnText, String valueToSelect)
        {
            String gridColumnID = getGridColumnFromTable(tableDivElement, headerColumnText);
            clickRowInTableByRowNumber(tableDivElement, tableRowNumber);
            WebElement tableCell = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex,'" + (tableRowNumber - 1) + "')]/td[contains(@class,'" + gridColumnID + "')]/div"));
            Point tableCellCoordinates = tableCell.getLocation();
            try
            {
                doubleClickMouse(tableCellCoordinates.getX(), (tableCellCoordinates.getY() + 80));
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }
            waitForPostBack();
            Guidewire8Select mySelect = new Guidewire8Select(driver, "(//table[contains(@id,'simplecombo') and contains(@id,'triggerWrap')])[last()]");
            boolean found = mySelect.selectByVisibleTextPartialWithNoFail(valueToSelect);
            clickProductLogo();
            return found;
        }

        /**
         * This method will select the cell corresponding to the information provided. It will then click that cell
         * and navigate to the resulting Guidewire8Select. Once there, it will fill out the dropdown with a random value.
         *
         * @param tableDivElement  This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                         but can also include a div for buttons or dropdowns, and a footer div.
         *                         <img src="../../../javadoc_images/TableXpath.png" />
         * @param tableRowNumber   This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         * @param headerColumnText This is the text of the Header for the column you are trying to get.
         *                         <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void selectRandomValueForSelectInTable(WebElement tableDivElement, int tableRowNumber, String headerColumnText)
        {
            String gridColumnID = getGridColumnFromTable(tableDivElement, headerColumnText);
            WebElement tableCell = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex,'" + (tableRowNumber - 1) + "')]/td[contains(@class,'" + gridColumnID + "')]/div"));
            clickWhenClickable(tableCell);//We need to click the cell to make the Select Element available.
            Guidewire8Select mySelect = new Guidewire8Select(driver, "(//table[contains(@id,'simplecombo') and contains(@id,'triggerWrap')])[last()]");
            mySelect.selectByVisibleTextRandom();
            clickProductLogo();
        }

        /**
         * This method will fill out a pre-selected, pre-clicked cell in the table with the value supplied. This method <b>DOES NOT</b> click
         * cell beforehand. If you need that functionality, please see the other methods that follow.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param cellInputName   This is the name of the input resulting in the DOM tree from clicking on the cell. See screenshot to be able to find this element.
         *                        <img src="../../../javadoc_images/CellValueInTable.png" />
         * @param valueToSet      This is the value you want to use to put in the cell.
         */
        public void setValueForCellInsideTable(WebElement tableDivElement, String cellInputName, String valueToSet)
        {
            waitForPostBack();
            WebElement editBox_tableEditBox = tableDivElement.findElement(By.xpath(".//input[contains(@name,'" + cellInputName + "')] | .//textarea[contains(@name,'" + cellInputName + "')]"));
            setText(editBox_tableEditBox, valueToSet); // @editor ecoleman 7/16/18
        }

        /**
         * This method clicks the cell in the table resulting from a search based on the tableRow and tableHeaderName supplied. Once clicked,
         * it fills out the resulting cell input with the input value supplied.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param tableRowNumber  This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         * @param tableHeaderName This is the text of the Header for the column you are trying to get.
         * @param cellInputName   This is the name of the input resulting in the DOM tree from clicking on the cell. See screenshot to be able to find this element.
         *                        <img src="../../../javadoc_images/CellValueInTable.png" />
         * @param valueToSet      This is the value you want to use to put in the cell.
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void setValueForCellInsideTable(WebElement tableDivElement, int tableRowNumber, String tableHeaderName, String cellInputName, String valueToSet)
        {
            String gridColumnID = getGridColumnFromTable(tableDivElement, tableHeaderName);
            waitForPostBack();
            WebElement tableCell = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex,'" + (tableRowNumber - 1) + "')]/td[contains(@class,'" + gridColumnID + "')]/div"));
            clickWhenClickable(tableCell);
            waitForPostBack();
            waitForPostBack();
            WebElement cellTextBox = tableDivElement.findElement(By.xpath(".//input[contains(@name,'" + cellInputName + "') and not (contains(@style, 'display: none'))] | .//textarea[contains(@name,'" + cellInputName + "') and not (contains(@style, 'display: none'))]"));
            cellTextBox.sendKeys(Keys.chord(Keys.CONTROL + "a"));
            waitForPostBack();
            cellTextBox.sendKeys(valueToSet);
            waitForPostBack();
            clickProductLogo();
            waitForPostBack();
        }

        /**
         * This method clicks the cell in the table corresponding to the WebElement cell declaration. Once clicked,
         * it fills out the resulting cell input with the input value supplied.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param cellElement     This is the WebElement that contains the xpath for finding the specific cell in the table.
         * @param cellInputName   This is the name of the input resulting in the DOM tree from clicking on the cell. See screenshot to be able to find this element.
         *                        <img src="../../../javadoc_images/CellValueInTable.png" />
         * @param valueToSet      This is the value you want to use to put in the cell.
         */
        public void setValueForCellInsideTable(WebElement tableDivElement, WebElement cellElement, String cellInputName, String valueToSet)
        {
            clickWhenClickable(cellElement);
            WebElement cellTextBox = null;
            try
            {
                cellTextBox = tableDivElement.findElement(By.xpath(".//input[contains(@name,'" + cellInputName + "')] | .//textarea[contains(@name,'" + cellInputName + "')]"));
            }
            catch (StaleElementReferenceException e)
            {
                System.out.println("The Cell Text Box Element reference was stale when Selenium tried to interact with it. Re-getting the element and trying again...");
                tableDivElement = find(By.xpath(getXpathFromElement(tableDivElement)));
                clickProductLogo();
                clickWhenClickable(cellElement);
                cellTextBox = tableDivElement.findElement(By.xpath(".//input[contains(@name,'" + cellInputName + "')] | .//textarea[contains(@name,'" + cellInputName + "')]"));
            }
            cellTextBox.sendKeys(Keys.chord(Keys.CONTROL + "a"));
            cellTextBox.sendKeys(valueToSet);
            clickProductLogo();
        }

        /**
         * This method gets the "select" link WebElement in the table, based on row number.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param tableRowNumber  This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         * @return 
         */
        public WebElement getSelectLinkInTable(WebElement tableDivElement, int tableRowNumber)
        {
            return tableDivElement.findElement(By.xpath(".//a[contains(@id,':" + (tableRowNumber - 1) + ":selectCell') or contains(@id, ':" + (tableRowNumber - 1) + ":_Select') or contains(@id, ':" + (tableRowNumber - 1) + ":Select')]"));
        }

        /**
         * This method clicks the "select" link in the table, based on row number.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param tableRowNumber  This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void clickSelectLinkInTable(WebElement tableDivElement, int tableRowNumber)
        {
            WebElement selectLink = tableDivElement.findElement(By.xpath(".//a[contains(@id,':" + (tableRowNumber - 1) + ":selectCell') or contains(@id, ':" + (tableRowNumber - 1) + ":_Select') or contains(@id, ':" + (tableRowNumber - 1) + ":Select')]"));
            clickWhenClickable(selectLink);
        }

        /**
         * This method checks to see if the checkbox you are interacting with has been checked already.
         *
         * @param tableCheckBoxElement This is the WebElement of the checkbox you are wanting to work with.
         * @return <b>trueFalse</b>
         * This is the true or false value stating whether or not the box is checked (true), or not (false).
         */
        public boolean isTableCheckboxChecked(WebElement tableCheckBoxElement)
        {
            List<WebElement> possibleCheckboxMatches = tableCheckBoxElement.findElements(By.xpath(".//div[contains(@class,'grid-checkcolumn-checked')] | .//div/img[contains(@class,'grid-checkcolumn-checked')] | .//img[contains(@class,'grid-checkcolumn-checked')]"));
            return possibleCheckboxMatches.size() > 0;
        }

        /**
         * This method will click the checkbox in the header of the table, effectively performing a "select All" function.
         *
         * @param tableDivElement      This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                             but can also include a div for buttons or dropdowns, and a footer div.
         *                             <img src="../../../javadoc_images/TableXpath.png" />
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         */
        public void setTableTitleCheckAllCheckbox(WebElement tableDivElement, boolean setCheckboxTrueFalse)
        {
            WebElement tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//../../preceding-sibling::div[contains(@id,'headercontainer')]/descendant::span[contains(@id, 'rowcheckcolumn')]/div"));
            if (setCheckboxTrueFalse == true)
            {
                if (isTableCheckboxChecked(tableCheckBoxElement))
                {
                    //Do Nothing
                }
                else
                {
                    clickWhenClickable(tableCheckBoxElement);
                }
            }
            else
            {
                if (isTableCheckboxChecked(tableCheckBoxElement))
                {
                    clickWhenClickable(tableCheckBoxElement);
                }
                else
                {
                    //Do Nothing
                }
            }
        }

        public boolean checkIfCellExistsInTableByText(WebElement table, String cellText)
        {
            return checkIfElementExists(table.findElement(By.xpath(".//div[text()='" + cellText + "']")), 2000);
        }

        /**
         * This method will click the hyperlink in a table, based on the text of that hyperlink.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param linkTextInTable This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         */
        public void clickLinkInTable(WebElement tableDivElement, String linkTextInTable)
        {
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/descendant::div/a[text() = '" + linkTextInTable + "' or contains(text(), '" + linkTextInTable + "')]")));
        }

        public boolean checkIfLinkExistsInTable(WebElement tableDivElement, String linkTextInTable)
        {
            return checkIfElementExists(".//tbody/descendant::div/a[text() = '" + linkTextInTable + "']", 2000);
        }

        /**
         * This method will click the hyperlink in a table, based on the text of that hyperlink.
         *
         * @param tableDivElement             This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                                    but can also include a div for buttons or dropdowns, and a footer div.
         *                                    <img src="../../../javadoc_images/TableXpath.png" />
         * @param linkTextArrayOfSearchValues This is an ArrayList of text values that you want to search for in the row of the table. It can be anywhere in that row.
         *                                    This is particularly useful for searching for sections of a string, while leaving out other sections.
         *                                    (Ex. - You want to search for a string containing "FirstName" and also containing "LastName" in the entire
         *                                    String "FirstName MiddleInitial LastName")
         */
        public void clickLinkInTable(WebElement tableDivElement, ArrayList<String> linkTextArrayOfSearchValues)
        {
            StringBuilder xPathBuilder = new StringBuilder();
            for (String linkTextValue : linkTextArrayOfSearchValues)
            {
                xPathBuilder.append(" and contains(text(), '" + linkTextValue + "')");
            }
            xPathBuilder.replace(0, 5, "");
            clickWhenClickable(tableDivElement.findElement(By.xpath(".//tbody/descendant::div/a[" + xPathBuilder.toString() + "]")));
        }

        /**
         * This method finds the cell in the table resulting from a search based on the tableRow and tableHeaderName supplied. Once found,
         * it clicks the radio button corresponding to the boolean value supplied.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param tableRowNumber  This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         * @param tableHeaderName This is the text of the Header for the column you are trying to get.
         * @param yesNo           This is the boolean value that you want to set for the radio button.
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void setRadioValueForCellInsideTable(WebElement tableDivElement, int tableRowNumber, String tableHeaderName, boolean yesNo)
        {
            String gridColumnID = getGridColumnFromTable(tableDivElement, tableHeaderName);
            WebElement radioGroup = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex,'" + (tableRowNumber - 1) + "')]/td[contains(@class,'" + gridColumnID + "')]/div/table[contains(@class,'gw-radio-group-cell')]"));
            Guidewire8RadioButton radioButton = new Guidewire8RadioButton(getDriver(), radioGroup);
            radioButton.select(yesNo);
        }

        /**
         * ****This method handles radiobuttons in a tablecell that are inside a div tag instead of a table.****
         *
         * This method finds the cell in the table resulting from a search based on the tableRow and tableHeaderName supplied. Once found,
         * it clicks the radio button corresponding to the boolean value supplied.
         *
         * @param tableDivElement This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                        but can also include a div for buttons or dropdowns, and a footer div.
         *                        <img src="../../../javadoc_images/TableXpath.png" />
         * @param tableRowNumber  This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         * @param tableHeaderName This is the text of the Header for the column you are trying to get.
         * @param yesNo           This is the boolean value that you want to set for the radio button.
         *                        <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void setRadioValueForCell(WebElement tableDivElement, int tableRowNumber, String tableHeaderName)
        {
            String gridColumnID = getGridColumnFromTable(tableDivElement, tableHeaderName);
            WebElement radioButton = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex,'" + (tableRowNumber - 1) + "')]/td[contains(@class,'" + gridColumnID + "')]/div/div[contains(@class,'" + gridColumnID + "')]"));
            if (!radioButton.getAttribute("class").contains("radio-col-on"))
            {
                radioButton.click();
            }
        }


        /**
         * This method finds the cell in the table resulting from a search based on text in any cell in the table. Once found,
         * it clicks the radio button corresponding to the boolean value supplied.
         *
         * @param tableDivElement         This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                                but can also include a div for buttons or dropdowns, and a footer div.
         *                                <img src="../../../javadoc_images/TableXpath.png" />
         * @param constrainingTextInTable This is the text that you want to search the table to find THAT WILL CONSTRAIN THE LOOKUP OF THE NEXT TEXT SET TO WHAT IMMEDIATELY FOLLOWS THIS TEXT. This is most useful for dependent question sets, and can be left null.
         * @param textInTable             This is the text that you want to search the table to find. This is most useful for question sets.
         * @param yesNo                   This is the boolean value that you want to set for the radio button.
         *                                <br>Note: data-recordindex is a 0-based index. We subtract 1 from the 1-based rowNumber passed in to make it 0-based.</br>
         */
        public void setRadioValueForCellInsideTable(WebElement tableDivElement, String constrainingTextInTable, String textInTable, boolean yesNo)
        {
            WebElement radioGroup;
            if (constrainingTextInTable != null)
            {
                radioGroup = tableDivElement.findElement(By.xpath(".//descendant::tbody/descendant::div[contains(text(), " + StringsUtils.xPathSpecialCharacterEscape(constrainingTextInTable) + ")]/ancestor::tr/following-sibling::tr/descendant::div[contains(text(), " + StringsUtils.xPathSpecialCharacterEscape(textInTable) + ")]/parent::td/following-sibling::td/descendant::table[@class='gw-radio-group-cell']"));
            }
            else
            {
                radioGroup = tableDivElement.findElement(By.xpath(".//descendant::tbody/descendant::div[contains(text(), " + StringsUtils.xPathSpecialCharacterEscape(textInTable) + ")]/parent::td/following-sibling::td/descendant::table[@class='gw-radio-group-cell']"));
            }
            Guidewire8RadioButton radioButton = new Guidewire8RadioButton(getDriver(), radioGroup);
            radioButton.select(yesNo);
        }


        /**
         * @param textToSearch the text next to the radio group.
         * @param radioValue   True check yes, False check no.
         * @description This function replaces the old selector function from Generic Helpers.
         * @warning This WILL NOT WORK if there are multiple table with the same text.
         */

        public void setRadioByText(String textToSearch, Boolean radioValue)
        {
            By radioGroupSelector = By.xpath("//div[contains(text(),'" + textToSearch + "')]/ancestor::tr[contains(@class, 'x-grid-row')]/descendant::table[@class='gw-radio-group-cell']");
            Guidewire8RadioButton radioButton = new Guidewire8RadioButton(getDriver(), find(radioGroupSelector));
            radioButton.select(radioValue);
        }

        /**
         * ATTENTION: THIS METHOD WILL NOT VERIFY THAT THE CHECKBOX HAS BEEN SET CORRECTLY. PLEASE PLAN ACCORDINGLY.
         * This is the private method used by all checkbox methods that DON'T VERIFY THAT THE BOX HAS BEEN SET CORRECTLY.
         * It is responsible for the actual setting of the checkbox.
         *
         * @param checkboxWebElement   The already collected and resolved WebElement for the checkbox that you want to set.
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         */
        private void setCheckboxInTablePrivateMethodNoVerify(WebElement checkboxWebElement, boolean setCheckboxTrueFalse)
        {
            // If you want to check a check box
            if (setCheckboxTrueFalse)
            {
                // If the element isn't checked and you wanted it to be.
                if (!checkboxWebElement.getAttribute("class").contains("-checkcolumn-checked"))
                {
                    // Try the original method for clicking checkboxes. This works most of the time.
                    clickWhenClickable(checkboxWebElement);
                    if (!find(By.xpath(getXpathFromElement(checkboxWebElement))).getAttribute("class").contains("-checkcolumn-checked"))
                    {
                        // Try the new method. This works for the more "difficult" checkboxes.
                        checkboxWebElement = find(By.xpath(getXpathFromElement(checkboxWebElement)));
                        clickAndHoldAndRelease(checkboxWebElement);
                    }// Else: Do Nothing. The checkbox is already checked and set as desired (true in this instance).
                }
            }
            // You want to uncheck a checkbox
            else
            {
                // element is currently checked and reverse logic on boolean setCheckbox
                if (checkboxWebElement.getAttribute("class").contains("-checkcolumn-checked"))
                {
                    // Try the original method for clicking checkboxes. This works most of the time.
                    clickWhenClickable(checkboxWebElement);
                    if (find(By.xpath(getXpathFromElement(checkboxWebElement))).getAttribute("class").contains("-checkcolumn-checked"))
                    {
                        // Try the new method. This works for the more "difficult" checkboxes.
                        checkboxWebElement = find(By.xpath(getXpathFromElement(checkboxWebElement)));
                        clickAndHoldAndRelease(checkboxWebElement);
                    }//Else: Do Nothing. The checkbox is already unchecked and set as desired (false in this instance).
                }
            }
        }

        /**
         * This is the private method used by all setCheckBoxInTable methods below. It is responsible for the actual setting of the checkbox.
         *
         * @param checkboxWebElement   The already collected and resolved WebElement for the checkbox that you want to set.
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         * @return setCorrectly
         * This is the boolean value that indicates whether or not the checkbox was set as required.
         */
        private boolean setCheckboxInTablePrivateMethod(WebElement checkboxWebElement, boolean setCheckboxTrueFalse)
        {
            boolean setCorrectly = false;
            //check for and save off Header Text of Table for possible later use if needed
            String orginalXPathLocatorForElement = getXpathFromElement(checkboxWebElement);
            String originalTableHeaderText = "";
            String originalGridColumnID = "";
            String[] originalXPathStringSplit = new String[1];
            int originalRowNumber = 0;
            if (orginalXPathLocatorForElement.contains("gridcolumn"))
            {
                originalXPathStringSplit = orginalXPathLocatorForElement.split("//");
                int beginningIndex = orginalXPathLocatorForElement.indexOf("gridcolumn-");
                int endingIndex = orginalXPathLocatorForElement.indexOf("'", beginningIndex);
                originalGridColumnID = orginalXPathLocatorForElement.substring(beginningIndex, endingIndex);
                originalTableHeaderText = find(By.xpath("//" + originalXPathStringSplit[1] + "//div[contains(@id,'headercontainer')]/descendant::div[contains(@id, '" + originalGridColumnID + "')]/descendant::span")).getText();
                int rowNumberBeginningIndex = originalXPathStringSplit[2].indexOf("data-recordindex");
                originalRowNumber = Integer.valueOf(originalXPathStringSplit[2].substring((rowNumberBeginningIndex + 19), (rowNumberBeginningIndex + 20))) + 1;
            }
            // If you want to check a check box
            if (setCheckboxTrueFalse)
            {
                // If the element isn't checked and you wanted it to be.
                if (!checkboxWebElement.getAttribute("class").contains("-checkcolumn-checked"))
                {
                    // Try the original method for clicking checkboxes. This works most of the time.
                    clickWhenClickable(checkboxWebElement);
                    if (find(By.xpath(getXpathFromElement(checkboxWebElement))).getAttribute("class").contains("-checkcolumn-checked"))
                    {
                        setCorrectly = true;
                    }
                    else
                    {
                        // Try the new method. This works for the more "difficult" checkboxes.
                        checkboxWebElement = find(By.xpath(getXpathFromElement(checkboxWebElement)));
                        clickAndHoldAndRelease(checkboxWebElement);
                        if (orginalXPathLocatorForElement.contains("gridcolumn"))
                        {
                            String newGridColumnID = getGridColumnFromTable(find(By.xpath("//" + originalXPathStringSplit[1])), originalTableHeaderText);
                            String newXPathToCheck = orginalXPathLocatorForElement.replace(originalGridColumnID, newGridColumnID);
                            try
                            {
                                checkboxWebElement = find(By.xpath(newXPathToCheck));
                            }
                            catch (NoSuchElementException e)
                            {
                                System.out.println("The verification for the checkbox failed. This can happen if the element is no longer a checkbox. Checking to verify that this is the case...");
                                try
                                {
                                    //Add more cases here as necessary if other strange checkboxes don't behave as they should.
                                    if (originalTableHeaderText.equals("Add Due"))
                                    {
                                        if (getCellTextInTableByRowAndColumnName(find(By.xpath("//" + originalXPathStringSplit[1])), originalRowNumber, originalTableHeaderText).equals("Yes"))
                                        {
                                            setCorrectly = true;
                                        }
                                    }
                                }
                                catch (NoSuchElementException e2)
                                {
                                    Assert.fail("The checkbox element could not be found, and the attempt to look for possible logic changes failed as well. Please investigate.");
                                }
                            }
                        }
                        //This is a gate-keeper to keep this method from attempting to evaluate the xpath below if the logic above determined that the checkbox changed to another element.
                        if (!setCorrectly)
                        {
                            if (find(By.xpath(getXpathFromElement(checkboxWebElement))).getAttribute("class").contains("-checkcolumn-checked"))
                            {
                                setCorrectly = true;
                            }
                        }
                    }
                    // The checkbox is already checked and set as desired (true in this instance). Flip the setCorrectly flag.
                }
                else
                {
                    setCorrectly = true;
                }
            }
            // You want to uncheck a checkbox
            else
            {
                // element is currently checked and reverse logic on boolean setCheckbox
                if (checkboxWebElement.getAttribute("class").contains("-checkcolumn-checked"))
                {
                    // Try the original method for clicking checkboxes. This works most of the time.
                    clickWhenClickable(checkboxWebElement);
                    if (!find(By.xpath(getXpathFromElement(checkboxWebElement))).getAttribute("class").contains("-checkcolumn-checked"))
                    {
                        setCorrectly = true;
                    }
                    else
                    {
                        // Try the new method. This works for the more "difficult" checkboxes.
                        checkboxWebElement = find(By.xpath(getXpathFromElement(checkboxWebElement)));
                        clickAndHoldAndRelease(checkboxWebElement);
                        if (orginalXPathLocatorForElement.contains("gridcolumn"))
                        {
                            String newGridColumnID = getGridColumnFromTable(find(By.xpath("//" + originalXPathStringSplit[1])), originalTableHeaderText);
                            String newXPathToCheck = orginalXPathLocatorForElement.replace(originalGridColumnID, newGridColumnID);
                            try
                            {
                                checkboxWebElement = find(By.xpath(newXPathToCheck));
                            }
                            catch (NoSuchElementException e)
                            {
                                System.out.println("The verification for the checkbox failed. This can happen if the element is no longer a checkbox. Checking to verify that this is the case...");
                                try
                                {
                                    //Add more cases here as necessary if other strange checkboxes don't behave as they should.
                                    if (originalTableHeaderText.equals("Add Due"))
                                    {
                                        if (getCellTextInTableByRowAndColumnName(find(By.xpath("//" + originalXPathStringSplit[1])), originalRowNumber, originalTableHeaderText).equals("No"))
                                        {
                                            setCorrectly = true;
                                        }
                                    }
                                }
                                catch (NoSuchElementException e2)
                                {
                                    Assert.fail("The checkbox element could not be found, and the attempt to look for possible logic changes failed as well. Please investigate.");
                                }
                            }
                        }
                        //This is a gate-keeper to keep this method from attempting to evaluate the xpath below if the logic above determined that the checkbox changed to another element.
                        if (!setCorrectly)
                        {
                            if (!find(By.xpath(getXpathFromElement(checkboxWebElement))).getAttribute("class").contains("-checkcolumn-checked"))
                            {
                                setCorrectly = true;
                            }
                        }
                    }
                    // The checkbox is already unchecked and set as desired (false in this instance). Flip the setCorrectly flag.
                }
                else
                {
                    setCorrectly = true;
                }
            }
            clickProductLogo();
            return setCorrectly;
        }

        /**
         * This method will click a checkbox corresponding to the text of a hyperlink found anywhere in the table that you pass in.
         *
         * @param tableDivElement      This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                             but can also include a div for buttons or dropdowns, and a footer div.
         *                             <img src="../../../javadoc_images/TableXpath.png" />
         * @param linkTextInTable      This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         */
        public void setCheckboxInTableByLinkText(WebElement tableDivElement, String linkTextInTable, boolean setCheckboxTrueFalse)
        {
            WebElement tableCheckBoxElement = null;
            boolean setCorrectly = false;
            int i = 0;
            while (!setCorrectly && i < 10)
            {
                try
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div/a[text()='" + linkTextInTable + "']/../../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                }
                catch (Exception e)
                {
                    try
                    {
                        tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[text()='" + linkTextInTable + "']/../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                    }
                    catch (Exception foo)
                    {
                        Assert.fail("The CheckBox WebElement was not found in the table. Please verify your xPath.");
                    }
                }
                setCorrectly = setCheckboxInTablePrivateMethod(tableCheckBoxElement, setCheckboxTrueFalse);
                i++;
            }

            if (!setCorrectly)
            {
                Assert.fail("Unable to Check the Checkbox after 10 attempts.");
            }
        }

        /**
         * This method will click the checkbox in the row of the table you specify.
         *
         * @param tableDivElement      This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                             but can also include a div for buttons or dropdowns, and a footer div.
         *                             <img src="../../../javadoc_images/TableXpath.png" />
         * @param rowNumber            This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         *                             <br>Note: tr[] is a 1-based index. We leave the rowNumber passed in alone so that it matches up with the correct table row.</br>
         */
        public void setCheckboxInTable(WebElement tableDivElement, int rowNumber, boolean setCheckboxTrueFalse)
        {
            WebElement tableCheckBoxElement = null;
            boolean setCorrectly = false;
            int i = 0;
            while (!setCorrectly && i < 10)
            {
                try
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/tr[" + (rowNumber) + "]/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                }
                catch (Exception e)
                {
                    Assert.fail("The CheckBox WebElement was not found in the table. Please verify your xPath.");
                }
                setCorrectly = setCheckboxInTablePrivateMethod(tableCheckBoxElement, setCheckboxTrueFalse);
                i++;
            }
            clickProductLogo();

            if (!setCorrectly)
            {
                Assert.fail("Unable to Check the Checkbox after 10 attempts.");
            }
        }

        /**
         * This method will click the checkbox in the row of the table you specify, constrained to the column header name you specify.
         *
         * @param tableDivElement      This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                             but can also include a div for buttons or dropdowns, and a footer div.
         *                             <img src="../../../javadoc_images/TableXpath.png" />
         * @param headerColumnName     This is the text of the Header for the column you are trying to use to constrain your search.
         * @param rowNumber            This is the row number in the table that you would like to use for interaction. This will be the 1-based index row number (As the user sees it).
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         *                             <br>Note: tr[] is a 1-based index. We leave the rowNumber passed in alone so that it matches up with the correct table row.</br>
         */
        public void setCheckboxInTable(WebElement tableDivElement, int rowNumber, String headerColumnName, boolean setCheckboxTrueFalse)
        {
            WebElement tableCheckBoxElement = null;
            boolean setCorrectly = false;
            int i = 0;
            while (!setCorrectly && i < 10)
            {
                try
                {
                    String tableGridColumnId = getGridColumnFromTable(tableDivElement, headerColumnName);
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/tr[contains(@data-recordindex, '" + (rowNumber - 1) + "')]/td[contains(@class, '" + tableGridColumnId + "')]//descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                }
                catch (Exception e)
                {
                    Assert.fail("The CheckBox WebElement was not found in the table. Please verify your xPath.");
                }
                setCorrectly = setCheckboxInTablePrivateMethod(tableCheckBoxElement, setCheckboxTrueFalse);
                i++;
            }

            if (!setCorrectly)
            {
                Assert.fail("Unable to Check the Checkbox after 10 attempts.");
            }
        }

        /**
         * ATTENTION: THIS METHOD WILL NOT VERIFY THAT THE CHECKBOX HAS BEEN SET CORRECTLY. PLEASE PLAN ACCORDINGLY.
         * This method will click a checkbox corresponding to the text found anywhere in the table that you pass in.
         *
         * @param tableDivElement      This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                             but can also include a div for buttons or dropdowns, and a footer div.
         *                             <img src="../../../javadoc_images/TableXpath.png" />
         * @param textInTable          This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         */
        public void setCheckboxInTableByTextNoVerify(WebElement tableDivElement, String textInTable, boolean setCheckboxTrueFalse)
        {
            WebElement tableCheckBoxElement = null;
            try
            {
                if (checkIfElementExists(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]", 1000))
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                }
                else
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../following-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                }
            }
            catch (Exception e)
            {
                tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::a[contains(text(), '" + textInTable + "')]/../../../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
            }
            setCheckboxInTablePrivateMethodNoVerify(tableCheckBoxElement, setCheckboxTrueFalse);
        }

        /**
         * This method will click a checkbox corresponding to the text found anywhere in the table that you pass in.
         *
         * @param tableDivElement      This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                             but can also include a div for buttons or dropdowns, and a footer div.
         *                             <img src="../../../javadoc_images/TableXpath.png" />
         * @param textInTable          This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         */
        public void setCheckboxInTableByText(WebElement tableDivElement, String textInTable, boolean setCheckboxTrueFalse)
        {
            WebElement tableCheckBoxElement = null;
            boolean setCorrectly = false;
            int i = 0;
            while (!setCorrectly && i < 10)
            {
                try
                {
                    if (checkIfElementExists(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]", 1000))
                    {
                        tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                    }
                    else
                    {
                        tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[contains(text(), '" + textInTable + "')]/../following-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                    }
                }
                catch (Exception e)
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::a[contains(text(), '" + textInTable + "')]/../../../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                }
                setCorrectly = setCheckboxInTablePrivateMethod(tableCheckBoxElement, setCheckboxTrueFalse);
                i++;
            }

            if (!setCorrectly)
            {
                Assert.fail("Unable to Check the Checkbox after 10 attempts.");
            }
        }

        /**
         * This method will click a checkbox corresponding to the text found anywhere in the table that you pass in. This method can accept multiple text arguments.
         *
         * @param tableDivElement      This is the WebElement that contains all elements of the table. It usually wraps a header div and body div,
         *                             but can also include a div for buttons or dropdowns, and a footer div.
         *                             <img src="../../../javadoc_images/TableXpath.png" />
         * @param text1                This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         * @param text2                This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         * @param text3                This is the text that you want to search for in the row of the table. It can be anywhere in that row.
         * @param setCheckboxTrueFalse This is the true or false value you want to use when setting the checkbox value. Use true to set it, or false to clear it.
         */
        public void setCheckboxInTableByMultiText(WebElement tableDivElement, String text1, String text2, String text3, boolean setCheckboxTrueFalse)
        {
            WebElement tableCheckBoxElement = null;
            boolean setCorrectly = false;
            int i = 0;
            while (!setCorrectly && i < 10)
            {
                if (checkIfElementExists(".//tbody/descendant::div[contains(text(), '" + text1 + "')]/ancestor::tr/descendant::div[contains(text(), '" + text2 + "')]/ancestor::tr/descendant::div[contains(text(), '" + text3 + "')]/../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]", 1000))
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[contains(text(), '" + text1 + "')]/ancestor::tr/descendant::div[contains(text(), '" + text2 + "')]/ancestor::tr/descendant::div[contains(text(), '" + text3 + "')]/../preceding-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                }
                else
                {
                    tableCheckBoxElement = tableDivElement.findElement(By.xpath(".//tbody/descendant::div[contains(text(), '" + text1 + "')]/ancestor::tr/descendant::div[contains(text(), '" + text2 + "')]/ancestor::tr/descendant::div[contains(text(), '" + text3 + "')]/../following-sibling::td/descendant::img[contains(@class, 'x-grid-checkcolumn')]"));
                }
                setCorrectly = setCheckboxInTablePrivateMethod(tableCheckBoxElement, setCheckboxTrueFalse);
                i++;
            }

            if (!setCorrectly)
            {
                Assert.fail("Unable to Check the Checkbox after 10 attempts.");
            }
        }

        /**
         * it will search all the pages of table to find the row and column
         * @param tableWebElement
         * @param rowName
         * @param column
         * @return
         */
        public String getColumnByRow(WebElement tableWebElement, String rowName, String column)
        {
            int row = getRowNumberInTableByText(tableWebElement, rowName);
            if (row == 0 && hasMultiplePages(tableWebElement))
            {
                boolean nextButtonExists = checkIfElementExists("//div[contains(@id, 'gpaging')]/a[contains(@data-qtip, 'Next Page') and contains(@style,'right: auto;')]", 1000);
                if (nextButtonExists)
                {
                    clickNextPageButton(tableWebElement);
                    int numPages = getNumberOfTablePages(tableWebElement);
                    for (int page = 2; page <= numPages; page++)
                    {
                        row = getRowNumberInTableByText(tableWebElement, rowName);
                        if (row > 0)
                        {
                            break;
                        }
                    }
                }

            }
            if (row == 0)
            {
                Assert.fail("Given row not found.");
            }

            return getCellTextInTableByRowAndColumnName(tableWebElement, row, column);
        }
    }
}
