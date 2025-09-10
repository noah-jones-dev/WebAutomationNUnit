

using NUnit.Framework;
using NUnitWebAutomationCSharp.Framework.Fields;

namespace NUnitWebAutomationCSharp.Framework.Verifications
{
    public class VerifyCheckbox : VerifyBase<CheckboxField>
    {
        public VerifyCheckbox(CheckboxField field) : base(field)
        {
        }

        private bool CheckIfEnabled()
        {
            var element = field.GetElement();
            bool result = element.Selected;
            return result;
        }

        public void IsChecked()
        {
            var result = CheckIfEnabled();
            Assert.That(result, Is.EqualTo(true), "The actual value: 'false'.");
        }
        
        public void IsUnChecked()
        {
            var result = CheckIfEnabled();
            Assert.That(result, Is.EqualTo(false), "The actual value: 'true'.");
        }
    }
}

