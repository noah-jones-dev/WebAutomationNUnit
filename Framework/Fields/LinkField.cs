using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Framework.Verifications;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Framework.Fields
{
    public class LinkField : BaseField<LinkField>
    {
        private const string UniversalLinkLocatorFormat = "//div[@id='{0}']//li/a[contains(text(), '{1}')] | //div[@id='{0}']//a[contains(@href, '{1}')]";
        public VerifyLink Verify { get; }
        private static string GetMenuType(MenuTypes menuType)
        {
            return menuType.Equals(MenuTypes.Top) ? "headerPanel" : menuType.Equals(MenuTypes.MiddleLeft) 
                ? "leftPanel" : menuType.Equals(MenuTypes.MiddleRight) ? "rightPanel" : "footerPanel";
        }
        public LinkField(IWebDriver driver, IList<By> locators) : base(driver, locators)
        {
            Verify = new VerifyLink(this);
        }
        
        public LinkField(IWebDriver driver, MenuTypes panelLocation, string linkName) : this(driver, 
            new List<By>{By.XPath(string.Format(UniversalLinkLocatorFormat, 
                GetMenuType(panelLocation), linkName))})
        {
        }

        public void Click()
        {
            var element = GetElement();
            element.Click();
        }
        
    }
}
