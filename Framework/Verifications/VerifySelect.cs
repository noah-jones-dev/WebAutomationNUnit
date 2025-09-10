

using NUnit.Framework;
using NUnitWebAutomationCSharp.Framework.Fields;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitWebAutomationCSharp.Framework.Verifications
{
    public class VerifySelect : VerifyBase<SelectField>
    {
        public VerifySelect(SelectField field) : base(field)
        {
        }

        private SelectElement GetSelectElement()
        {
            IWebElement element = field.GetElement();
            SelectElement selectElement = new SelectElement(element);
            return selectElement;
        }

        public void OptionIs(string expectedOption)
        {
            var select = GetSelectElement();
            var actualOption = select.SelectedOption.Text;
            Assert.That(actualOption, Is.EqualTo(expectedOption), 
                $"The expected value '{expectedOption}' did not match the actual value '{actualOption}'.");
        }

        public void OptionsAre(string[] expectedOptions)
        {
            var select = GetSelectElement();
            var actualOptions = select.Options.Select(option => option.Text).ToArray();
            Assert.That(expectedOptions, Is.EquivalentTo(actualOptions), 
                $"Expected options did not match the actual options.");
        }
    }
}

