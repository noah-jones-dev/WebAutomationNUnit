using NUnitWebAutomationCSharp.Framework.Verifications;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Framework.Fields
{
    public class CheckboxField : BaseField<CheckboxField>
    {
        public VerifyCheckbox Verify { get; }
        
        public CheckboxField(IWebDriver driver, IList<By> locators) : base(driver, locators)
        {
            Verify = new VerifyCheckbox(this);
        }

        private bool CheckIfEnabled(out IWebElement element)
        {
            element = GetElement();
            bool result = element.Selected;
            return result;
        }

        public void Check()
        {
            IWebElement element;
            var result = CheckIfEnabled(out element);
            if (result.Equals(false))
            {
                element.Click();
            }
        }

        public void Uncheck()
        {
            IWebElement element;
            var result = CheckIfEnabled(out element);
            if (result.Equals(true))
            {
                element.Click();
            }
        }
    }
}

