using NUnitWebAutomationCSharp.Framework.Verifications;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Framework.Fields
{
    public class ButtonField :  BaseField<ButtonField>
    {
        private const string UniversalButtonLocatorFormat =
            "//button[contains(@class,'button') and contains(normalize-space(.),'{0}')] " +
            "| //input[contains(@class,'button') and contains(@value,'{0}')] " +
            "| //ul[contains(@class,'button')]//a[contains(normalize-space(.),'{0}')]";
        public VerifyButton Verify { get; }
        
        public ButtonField(IWebDriver driver, string buttonName) : this(driver, 
            new List<By>{By.XPath(string.Format(UniversalButtonLocatorFormat, buttonName))})
        {
        }
        
        public ButtonField(IWebDriver driver, IList<By> locators) : base(driver, locators)
        {
            Verify = new VerifyButton(this);
        }
        
        public void Click()
        {
            var element = GetElement();
            element.Click();
        }
    }
}

