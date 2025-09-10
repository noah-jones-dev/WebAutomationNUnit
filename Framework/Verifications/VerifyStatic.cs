

using NUnit.Framework;
using NUnitWebAutomationCSharp.Framework.Fields;

namespace NUnitWebAutomationCSharp.Framework.Verifications
{
    public class VerifyStatic : VerifyBase<StaticField>
    {
        public VerifyStatic(StaticField field) : base(field)
        {
        }
        
        public void TextIs(string expectedText)
        {
            var element = field.GetElement();
            Assert.That(element.Text, Is.EqualTo(expectedText), 
                $"The actual value: '{element.Text}' did not exactly match the expected value: '{expectedText}'");
        }
        
        public void TextContains(string expectedText)
        {
            var element = field.GetElement();
            Assert.That(element.Text, Does.Contain(expectedText), 
                $"The actual value: '{element.Text}' did not partially match the expected value: '{expectedText}'");
        }
    }
}

