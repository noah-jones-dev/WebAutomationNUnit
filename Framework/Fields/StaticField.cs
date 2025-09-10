using NUnitWebAutomationCSharp.Framework.Verifications;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Framework.Fields
{
    public class StaticField :  BaseField<StaticField>
    {
        public VerifyStatic Verify { get; }

        public StaticField(IWebDriver driver, IList<By> locators) : base(driver, locators)
        {
            Verify = new VerifyStatic(this);
        }
    }
}

