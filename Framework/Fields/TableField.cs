using NUnitWebAutomationCSharp.Framework.Verifications;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Framework.Fields
{
    public class TableField : BaseField<TableField>
    {
        private const string UniversalTableLocatorFormat = "//table[@id='{0}']";
        private const string UniversalRowLocatorFormat = ".//tbody/tr[{0}]";

        public TableField(IWebDriver driver, List<By> locators) : base(driver, locators)
        {
        }
        
        public TableField(IWebDriver driver, string tableID) : base(driver, 
            new List<By>{By.XPath(string.Format(UniversalTableLocatorFormat, tableID))})
        {
            
        }

        public TableRow this[int rowIndex] => new TableRow(Driver, 
            Locators.Append(By.XPath(string.Format(UniversalRowLocatorFormat, rowIndex))).ToList());
    }

    public class TableRow : BaseField<TableRow>
    {
        private const string UniversalCellLocatorFormat = ".//td[{0}]";
        public TableRow(IWebDriver driver, List<By> locators) : base(driver, locators)
        {
        }
        
        public TableCell this[int cellIndex] => new TableCell(Driver, 
            Locators.Append(By.XPath(string.Format(UniversalCellLocatorFormat, cellIndex))).ToList());
        
    }

    public class TableCell : BaseField<TableCell>
    {
        public VerifyTableCell Verify { get; }

        public TableCell(IWebDriver driver, List<By> locators) : base(driver, locators)
        {
            Verify = new VerifyTableCell(this);
        }
        
        public string Text => GetElement().Text;

        public void Click()
        {
            var element = GetElement();
            element = element.FindElement(By.XPath(".//a"));
            element.Click();
        }
    }
}

