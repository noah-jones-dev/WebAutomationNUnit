using NUnitWebAutomationCSharp.Framework.Verifications;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Framework.Fields
{
    public class TextField : BaseField<TextField>
    {
        public VerifyText Verify { get; }

        public TextField(IWebDriver driver, IList<By> locators) : base(driver, locators)
        {
            Verify = new VerifyText(this);
        }

        public void Enter(string text)
        {
            var element = GetElement();
            element.SendKeys(text);
        }

    }
}

